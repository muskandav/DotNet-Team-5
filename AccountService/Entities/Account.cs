using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountService.Entities
{
    [Table("Tbl_Accounts")]
    public class Account
    {
        [Key]
        public int AccTypeID { get; set; }
        public string AccType { get; set; }
    }
}
