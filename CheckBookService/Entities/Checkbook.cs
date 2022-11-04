using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;


namespace CheckBookService.Entities
{
    [Table("Tbl_checkbookdtls")]
    public class Checkbook
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        public DateTime RequestedDate { get; set; }
        public DateTime IssueDate { get; set; }
        [Required]
        public int Priority { get; set; }
    }
}

