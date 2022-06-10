using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("AccountType")]
    public partial class AccountType
    {
        public AccountType()
        {
            TaiKhoans = new HashSet<Account>();
        }

        [Key]
        [StringLength(2)]
        public string AccountTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountTypeName { get; set; }

        [Required]
        public string FunctionDescription { get; set; }

        public virtual ICollection<Account> TaiKhoans { get; set; }
        public AccountType(string AccountTypeID, string AccountTypeName, string FunctionDescription)
        {
            this.AccountTypeID = AccountTypeID;
            this.AccountTypeName = AccountTypeName;
            this.FunctionDescription = FunctionDescription;
        }
    }
}
