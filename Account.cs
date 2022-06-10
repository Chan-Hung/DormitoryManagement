using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("Account")]
    public partial class Account
    {
        [Key]
        public int AccountID { get; set; }

        [StringLength(5)]
        public string EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [StringLength(2)]
        public string AccountTypeID { get; set; }

        public virtual AccountType AccountType { get; set; }

        public virtual Employee Employee { get; set; }
        public Account(string EmployeeID
            , string Username, string Password, string AccountTypeID)
        {
            this.EmployeeID = EmployeeID;
            this.Username = Username;
            this.Password = Password;
            this.AccountTypeID = AccountTypeID;
        }

        public Account()
        {

        }
    }
}
