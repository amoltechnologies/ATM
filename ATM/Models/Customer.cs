using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class Customer
    {

        [Key]
        public int CustomerID { get; set; }


        [Required]
        [MaxLength(50)]
        public string CustomerName { get; set; } = null!;


        [Required]
        public string Address { get; set; } = null!;


        [Required]
        [MaxLength(50)]
        public string City { get; set; } = null!;


        [Required]
        [MaxLength(50)]
        public string State { get; set; } = null!;


        [Required]
        [MaxLength(50)]
        public string EmailID { get; set; } = null!;



        //[Required]
        [MaxLength(10)]
        public string PINCode { get; set; } = null!;



        [Required]
        [MaxLength(50)]
        public string PrimaryContactPersonName { get; set; } = null!;



        [Required]
        [MaxLength(50)]
        public string PrimaryContactPersonContact { get; set; } = null!;



        //[Required]
        public string? GSTNo { get; set; } = null!;



        [Required]
        [MaxLength(50)]
        public string PANNo { get; set; } = null!;



        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal? OpeningBalance { get; set; } = 0; 
        
        
        [Required]
        public string VendorCode { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; } = DateTime.Now;


        public string? ModifiedBy { get; set; }

        public DateTime? ModificationTime { get; set; }

    }
}
