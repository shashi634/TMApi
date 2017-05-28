using System.Collections.Generic;

namespace ManagementTravel.Models
{
    public class UserType
    {
        public UserType()
        {
            AdminAccounts = new List<AdminAccount>();
        }

        public int Id { get; set; }
        public string UserType1 { get; set; }
        public bool? IsDeleted { get; set; }
        public virtual ICollection<AdminAccount> AdminAccounts { get; set; }
    }
}
