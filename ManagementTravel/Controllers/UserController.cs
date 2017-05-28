using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;
using ManagementTravel.Models;
using ManagementTravel.Models.Dto;

namespace ManagementTravel.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("~/api/GetPages")]
        public HttpResponseMessage GetPages()
        {
            var pageList = new List<GetLocationPage>();
            using (TravelErpContext dbContext = new TravelErpContext())
            {
                var cities = dbContext.LocationPages.ToList();

                pageList.AddRange(from item in cities
                    let itemPublicId = item.PublicId
                    where itemPublicId != null
                    where itemPublicId != null
                    let createdDate = item.CreatedDate
                    where createdDate != null
                    where createdDate != null
                                  select new GetLocationPage
                                  {
                                      Title = item.Title,
                                      Description = item.Description,
                                      City = item.Location.Name,
                                      Country = item.Location.CountryName,
                                      Images = item.Location.LocationImagess.Select(x => x.ImageName).ToList(),
                                      PublicId = (Guid)itemPublicId,
                                      CreatedDate = (DateTime)createdDate
                                  });
            }
            return Request.CreateResponse(HttpStatusCode.OK, pageList);
        }

        [HttpGet]
        [Route("~/api/GetPages/{countryName}")]
        public HttpResponseMessage GetPagesByCountryName(string countryName)
        {
            var pageList = new List<GetLocationPage>();
            using (TravelErpContext dbContext = new TravelErpContext())
            {
                var cities = dbContext.LocationPages.Where(x => x.Location.CountryName.Contains(countryName)).ToList();

                foreach (var item in cities)
                {
                    var page = new GetLocationPage();
                    page.Title = item.Title;
                    page.Description = item.Description;
                    page.City = item.Location.Name;
                    page.Country = item.Location.CountryName;
                    page.Images = item.Location.LocationImagess.Select(x => x.ImageName).ToList();
                    if (item.PublicId != null) page.PublicId = (Guid)item.PublicId;
                    if (item.CreatedDate != null) page.CreatedDate = (DateTime)item.CreatedDate;
                    pageList.Add(page);
                }

            }
            return Request.CreateResponse(HttpStatusCode.OK, pageList);
        }

        [HttpPost]
        [Route("~/api/GetPages")]
        public HttpResponseMessage GetPackage(PackageSearchParameter packageSearchParameter)
        {
            var packageList = new List<GetHotelPackage>();
            using (TravelErpContext dbContext = new TravelErpContext())
            {
                var allPackages = dbContext.HotelPackages.ToList();
                if (packageSearchParameter.City != null)
                {
                    allPackages = allPackages.Where(x => x.Hotel.Location.Name.Contains(packageSearchParameter.City)).ToList();
                }
                if (packageSearchParameter.Country != null)
                {
                    allPackages = allPackages.Where(x => x.Hotel.Location.CountryName.Contains(packageSearchParameter.Country)).ToList();
                }
                if (packageSearchParameter.startdate != null)
                {
                    allPackages = allPackages.Where(x => x.startdate == packageSearchParameter.startdate).ToList();
                }
                if (packageSearchParameter.enddate != null)
                {
                    allPackages = allPackages.Where(x => x.enddate == packageSearchParameter.enddate).ToList();
                }

                foreach (var item in allPackages)
                {
                    var package = new GetHotelPackage();
                    package.HotelName = item.Hotel.Name;
                    package.noofdays = item.noofdays;
                    package.noofnight = item.noofnight;
                    package.startdate = item.startdate;
                    package.enddate = item.enddate;
                    package.Country = item.Hotel.Location.CountryName;
                    package.City = item.Hotel.Location.Name;
                    package.defaultnoofmembers = item.defaultnoofmembers;
                    package.extraadultcharge = item.extraadultcharge;
                    package.extrachildcharge = item.extrachildcharge;
                    package.publicId = item.publicId;
                    package.Images = item.Hotel.Location.LocationImagess.Select(x => x.ImageName).ToList();
                    packageList.Add(package);
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK, packageList);
        }

        [HttpGet]
        [Route("~/api/GetLocation")]
        public HttpResponseMessage GetLocationPages()
        {
            var pageList = new List<LocationPages>();
            using (TravelErpContext dbContext = new TravelErpContext())
            {
                var cities = dbContext.LocationPages.ToList();

                foreach (var item in cities)
                {
                    var page = new LocationPages();
                    page.City = item.Location.Name;
                    page.Country = item.Location.CountryName;
                    page.FrontImage = "/p/images/" + item.Location.LocationImagess.Select(x => x.ImageName).FirstOrDefault();
                    page.Description = Regex.Replace(item.Description, "<.*?>", String.Empty).Substring(0, Math.Min(150, item.Description.Length));
                    if (item.PublicId != null) page.PublicId = (Guid)item.PublicId;
                    page.TotalHotel = dbContext.Hotels.Count(m => m.Location.Id == item.Location.Id);
                    page.AverageRate = item.AverageRate ?? 1000;
                    pageList.Add(page);
                }

            }
            return Request.CreateResponse(HttpStatusCode.OK, pageList);
        }

        [HttpPost]
        [Route("~/api/SearchLocation")]
        public HttpResponseMessage SearchLocation(LocationSearch searchParam)
        {
            var pageList = new List<LocationPages>();
            using (TravelErpContext dbContext = new TravelErpContext())
            {
                var cities = dbContext.LocationPages.ToList();
                if (searchParam.City != null) {
                    cities = cities.Where(m => m.Location.Name.ToLower().Contains(searchParam.City.ToLower())).ToList();
                }
                if (searchParam.Country != null)
                {
                    cities = cities.Where(m => m.Location.CountryName.ToLower().Contains(searchParam.Country.ToLower())).ToList();
                }
                foreach (var item in cities)
                {
                    var page = new LocationPages();
                    page.City = item.Location.Name;
                    page.Country = item.Location.CountryName;
                    page.FrontImage = "/p/images/" + item.Location.LocationImagess.Select(x => x.ImageName).FirstOrDefault();
                    page.Description = Regex.Replace(item.Description, "<.*?>", String.Empty).Substring(0, Math.Min(150, item.Description.Length));
                    if (item.PublicId != null) page.PublicId = (Guid)item.PublicId;
                    if (item.Location.PublicId != null) page.LocationPublicId = (Guid)item.Location.PublicId;
                    page.TotalHotel = dbContext.Hotels.Count(m => m.Location.Id == item.Location.Id);
                    page.AverageRate = item.AverageRate ?? 1000;
                    pageList.Add(page);
                }

            }
            return Request.CreateResponse(HttpStatusCode.OK, pageList);
        }

        [HttpGet]
        [Route("~/api/facilities")]
        public HttpResponseMessage GetFacilities()
        {
            var facilityList = new List<GetFacility>();
            using (TravelErpContext dbContext = new TravelErpContext())
            {
                var facilities = dbContext.Facilities.ToList();
                foreach (var item in facilities)
                {
                    var faciityObj = new GetFacility();
                    faciityObj.Id = item.Id;
                    faciityObj.Facility = item.Facility1;
                    facilityList.Add(faciityObj);
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK, facilityList);
        }

        [HttpGet]
        [Route("~/api/roomTypes")]
        public HttpResponseMessage GetRoomType()
        {
            var roomTypeList = new List<GetAllRoomType>();
            using (TravelErpContext dbContext = new TravelErpContext())
            {
                var roomTypes = dbContext.RoomTypes.Where(x => x.IsDeleted == false).ToList();
                foreach (var item in roomTypes)
                {
                    var roomTypeObj = new GetAllRoomType();
                    roomTypeObj.Id = item.Id;
                    roomTypeObj.RoomType = item.Type;
                    roomTypeList.Add(roomTypeObj);
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK, roomTypeList);
        }
        [HttpGet]
        [Route("~/api/mealTypes")]
        public HttpResponseMessage GetMealType()
        {
            var roomTypeList = new List<GetMealType>();
            using (TravelErpContext dbContext = new TravelErpContext())
            {
                var roomTypes = dbContext.MealTypes.Where(x=>x.IsDeleted==false).ToList();
                foreach (var item in roomTypes)
                {
                    var roomTypeObj = new GetMealType();
                    roomTypeObj.Id = item.Id;
                    roomTypeObj.MealType = item.Type;
                    roomTypeList.Add(roomTypeObj);
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK, roomTypeList);
        }
        [HttpGet]
        [Route("~/api/hotelTypes")]
        public HttpResponseMessage GetHotelType()
        {
            var hotelTypeList = new List<GetHotelType>();
            using (TravelErpContext dbContext = new TravelErpContext())
            {
                var hotelTypes = dbContext.HotelTypes.ToList();
                foreach (var item in hotelTypes)
                {
                    var roomTypeObj = new GetHotelType();
                    roomTypeObj.Id = item.Id;
                    roomTypeObj.HotelType = item.Type;
                    hotelTypeList.Add(roomTypeObj);
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK, hotelTypeList);
        }

        /// <summary>
        /// This is only for Home Page
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("~/api/hotels")]
        public HttpResponseMessage GetHotel()
        {
            var hotels = new List<GetHotelsHomePage>();
            using (TravelErpContext dbContext = new TravelErpContext())
            {
                var hotelTypes = dbContext.Hotels.ToList().Take(12);
                foreach (var item in hotelTypes)
                {
                    var hotel = new GetHotelsHomePage();
                    hotel.Name = item.Name;
                    hotel.City = item.Location.Name;
                    hotel.Country = item.Location.CountryName;
                    hotel.Image = "/p/images/" + item.HotelImages.Select(x => x.ImageName).FirstOrDefault();
                    if (hotel.Image == "/p/images/")
                    {
                        hotel.Image = "/img/defaultHotel.png";
                    }
                    hotel.PublicId = item.PublicId;
                    var m = dbContext.HotelRoomTypePrices.
                            Where(x => x.HotelRoomType.HotelId == item.Id).
                            Select(y => y.Rate).Average();
                    if (m != null) hotel.Rate = (int)m;
                    var n = dbContext.HotelRoomTypePrices.
                            Where(x => x.HotelRoomType.HotelId == item.Id).
                            Select(y => y.RoomNoAvailable).Sum();
                    hotel.RoonAvailable = n;
                    hotel.Rating = item.AverageRating ?? 0;
                    hotels.Add(hotel);
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK, hotels);
        }

        [HttpGet]
        [Route("~/api/hotels/{id}")]
        public HttpResponseMessage GetHotel(string id)
        {
            var hotel = new GetHotelDetails();
            using (TravelErpContext dbContext = new TravelErpContext())
             {
                Guid hotelGuid = Guid.Parse(id);
                var data = dbContext.Hotels.Where(x => x.PublicId == hotelGuid).FirstOrDefault();
                if (data != null)
                {
                    hotel.Name = data.Name;
                    hotel.Description = data.Description;
                    hotel.Country = data.Location.CountryName;
                    hotel.City = data.Location.Name;
                    hotel.HotelTypes = data.HotelType.Type;
                    // facility
                    var m = dbContext.HotelFacilities
                            .Where(x => x.HotelId == data.Id)
                            .Select(n => n.FacilityId)
                            .ToList();
                    foreach (var c in m)
                    {
                        var hotelFacl = new GetFacility();
                        if (c != null)
                        {
                            hotelFacl.Id = (int)c;
                            var facilityName = dbContext.Facilities
                                .Where(x => x.Id == c)
                                .Select(k => k.Facility1)
                                .FirstOrDefault();
                            hotelFacl.Facility = facilityName;
                        }
                        hotel.Facilities.Add(hotelFacl);
                    }
                    // meal type
                    var m1 = dbContext.HotelMealTypes
                            .Where(x => x.HotelId == data.Id)
                            .Select(n => n.MealTypeId)
                            .ToList();
                    foreach (var c in m1)
                    {
                        var hotelMeal = new GetMealType();
                        if (c != null)
                        {
                            hotelMeal.Id = (int)c;
                            var mealType = dbContext.MealTypes
                                .Where(x => x.Id == c)
                                .Select(k => k.Type)
                                .FirstOrDefault();
                            hotelMeal.MealType = mealType;
                        }
                        hotel.MealTypes.Add(hotelMeal);
                    }
                    // room type
                    var m2 = dbContext.HotelRoomTypes
                            .Where(x => x.HotelId == data.Id)
                            .Select(n => n.Id)
                            .ToList();
                    foreach (var c in m2)
                    {
                        var hotelRoom = new GetRoomType();
                        hotelRoom.Id = (int)c;
                        var roomName = dbContext.HotelRoomTypePrices
                                            .Where(x => x.HotelRoomType.Id == c)
                                            .Select(k => k.HotelRoomType.RoomType.Type)
                                            .FirstOrDefault();
                        hotelRoom.RoomType = roomName;
                        hotelRoom.Price = dbContext.HotelRoomTypePrices
                                            .Where(x => x.HotelRoomType.Id == c)
                                            .Select(k => k.Rate)
                                            .FirstOrDefault();
                        hotelRoom.Available = dbContext.HotelRoomTypePrices
                        .Where(x => x.HotelRoomType.Id == c)
                        .Select(k => k.RoomNoAvailable)
                        .FirstOrDefault();
                        hotel.RoomTypes.Add(hotelRoom);
                    }
                    hotel.Image = data.HotelImages.Select(d => d.ImageName).ToList();
                }
            }

            return Request.CreateResponse(HttpStatusCode.OK, hotel);
        }

        [HttpPost]
        [Route("~/api/hotels")]
        public HttpResponseMessage GetHotelList(SearchHotelParameters searchHotelParameters)
        {
            var hotels = new List<GetHotelsHomePage>();

            using (TravelErpContext dbContext = new TravelErpContext())
            {
                var hotelTypes = dbContext.HotelPackages.ToList();
                if (!String.IsNullOrEmpty(searchHotelParameters.City))
                {
                    hotelTypes = hotelTypes.Where(x => x.Hotel.Location.Name == searchHotelParameters.City).ToList();
                }
                if (searchHotelParameters.startdate != null)
                {
                    hotelTypes = hotelTypes.Where(x => x.startdate == searchHotelParameters.startdate).ToList();
                }
                if (searchHotelParameters.enddate != null)
                {
                    hotelTypes = hotelTypes.Where(x => x.enddate == searchHotelParameters.enddate).ToList();
                }
                foreach (var item in hotelTypes.Select(x => x.Hotel))
                {
                    var hotel = new GetHotelsHomePage();
                    hotel.Name = item.Name;
                    hotel.City = item.Location.Name;
                    hotel.Country = item.Location.CountryName;
                    hotel.Image = "/p/images/" + item.HotelImages.Select(x => x.ImageName).FirstOrDefault();
                    if (hotel.Image == "/p/images/")
                    {
                        hotel.Image = "/img/defaultHotel.png";
                    }
                    hotel.PublicId = item.PublicId;
                    var m = dbContext.HotelRoomTypePrices.
                            Where(x => x.HotelRoomType.HotelId == item.Id).
                            Select(y => y.Rate).Average();

                    if (m != null) hotel.Rate = (int)m;
                    var n = dbContext.HotelRoomTypePrices.
                            Where(x => x.HotelRoomType.HotelId == item.Id).
                            Select(y => y.RoomNoAvailable).Sum();
                    hotel.RoonAvailable = n;
                    hotel.Rating = item.AverageRating ?? 0;
                    hotels.Add(hotel);
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK, hotels);
        }

        /// <summary>
        /// Here taking Page guid not location guid
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("~/api/LocationDetails/{id}")]
        public HttpResponseMessage LocationDetails(string id)
        {
            Guid guidOutput;
            var isValid = Guid.TryParse(id, out guidOutput);
            if (!isValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid parameter.");
            }
            var page = new GetLocationPages();
            using (var dbContext = new TravelErpContext())
            {
                var item = dbContext.LocationPages.FirstOrDefault(x => x.PublicId == guidOutput);
                if (item == null) return Request.CreateResponse(HttpStatusCode.OK, page);
                {
                    page.Title = item.Title;
                    page.Description = item.Description;
                    page.City = item.Location.Name;
                    if (item.Location.PublicId != null) page.LocationPublicId = (Guid)item.Location.PublicId;
                    page.Country = item.Location.CountryName;
                    page.Images = item.Location.LocationImagess.Select(x => x.ImageName).ToList();
                    if (item.PublicId != null) page.PublicId = (Guid)item.PublicId;
                    if (item.CreatedDate != null) page.CreatedDate = (DateTime)item.CreatedDate;
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK, page);
        }
        [HttpGet]
        [Route("~/api/LocationHotels/{id}")]
        public HttpResponseMessage HotelAccordingLocation(string id)
        {
            Guid newGuid;                                                                                  
            Guid.TryParse(id, out newGuid);
            using (var con = new SqlConnection("Data Source=.;Initial Catalog=TravelErp;Integrated Security=True;MultipleActiveResultSets=True"))
            {
                using (var cmd = new SqlCommand("Select * from GPackage where locationId='" + newGuid + "'"))
                {
                    using (var sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (var dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return Request.CreateResponse(HttpStatusCode.OK, dt);
                        }
                    }
                }
            }
        }

        [HttpGet]
        [Route("~/api/Package/{id}")]
        public HttpResponseMessage PackageDetails(string id)
        {
            Guid newGuid;
            Guid.TryParse(id, out newGuid);
            using (var con = new SqlConnection("Data Source=.;Initial Catalog=TravelErp;Integrated Security=True;MultipleActiveResultSets=True"))
            {
                using (var cmd = new SqlCommand("Select * from HotelsLocationWise where packageId='" + newGuid + "'"))
                {
                    using (var sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (var dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return Request.CreateResponse(HttpStatusCode.OK, dt);
                        }
                    }
                }
            }
        }

        [HttpPost]
        [Route("~/api/CreatePackage")]
        public HttpResponseMessage AddPackage(DtoCreatePackage dtoCreatePackage)
        {
            try
            {
                using (var dbContext = new TravelErpContext())
                {
                    var dataAlreadyExists = dbContext.GeneralPackages.FirstOrDefault(x => x.HotelId == dtoCreatePackage.HotelId
                        && x.StartDate == dtoCreatePackage.StartDate
                        && x.EndDate == dtoCreatePackage.EndDate);
                    if (dataAlreadyExists != null) {
                        return Request.CreateResponse(HttpStatusCode.Conflict, "It seems same package is going to be created again. Please check entries");
                    }

                    var checkHotelExists = dbContext.Hotels.FirstOrDefault(x => x.Id == dtoCreatePackage.HotelId);
                    if (checkHotelExists == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.BadRequest, "No Such Hotel exists.");
                    }

                    var generalPackage = new GeneralPackage
                    {
                        HotelId = dtoCreatePackage.HotelId,
                        StartDate = dtoCreatePackage.StartDate,
                        EndDate = dtoCreatePackage.EndDate,
                        PublicKey = Guid.NewGuid(),
                        NoOdNights = dtoCreatePackage.NoOfNights,
                        NoOfDays = dtoCreatePackage.NoOfDays,
                        DefaultMember = dtoCreatePackage.DefaultMember,
                        Inclusion = dtoCreatePackage.Inclusion,
                        Description = dtoCreatePackage.Description,
                        CreatedDate = DateTime.UtcNow
                    };
                    var packageDetails = dtoCreatePackage.DtoPackageDetails.Select(item => new GeneralPackageDetail
                    {
                        RoomType = item.RoomType, 
                        MealType = item.MealType, 
                        RoomPriceNormal = item.RoomPriceNormal, 
                        RoomPriceNormalType = item.RoomPriceNormalType, 
                        ExtraChildPrice = item.ExtraChildPrice, 
                        ExtraChildPriceType = item.ExtraChildPriceType, 
                        ExtraAdultPrice = item.ExtraAdultPrice, 
                        ExtraAdultPriceType = item.ExtraAdultPriceType, 
                        Tac = item.Tac, 
                        TacType = item.TacType,
                        UniqueId = Guid.NewGuid()
                    }).ToList();
                    generalPackage.GeneralPackageDetails = packageDetails;
                    dbContext.GeneralPackages.Add(generalPackage);
                    dbContext.SaveChanges();
                }
                
                return Request.CreateResponse(HttpStatusCode.Created, "Created Successifully!");
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ooops..something happened wrong.");
            }
        }
    }
}
