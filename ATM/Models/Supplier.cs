using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class Supplier
    {

        [Key]
        public int SupplierID { get; set; }



        [MaxLength(50)]
        [Required]
        public string SupplierName { get; set; } 


        [Required]
        public string Address { get; set; } 


        [Required]
        [MaxLength(50)]
        public string City { get; set; } 


        [Required]
        [MaxLength(50)]
        public string State { get; set; } 


        [Required]
        [MaxLength(50)]
        public string SupplierEmailID { get; set; } 


        [MaxLength(10)]
        public string PINCode { get; set; } 



        [Required]
        [MaxLength(50)]
        public string PrimaryContactPersonName { get; set; } 


        [Required]
        [MaxLength(50)]
        public string PrimaryContactPersonContact { get; set; }


        //[Required]
        public string? GSTNo { get; set; } 


        [Required]
        [MaxLength(50)]
        public string PANNo { get; set; } 


        [Required]
        [Column(TypeName = "Decimal(18,2)")]
        public decimal OpeningBalance { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }



    }
}
