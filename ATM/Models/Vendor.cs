using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class Vendor
    {

        [Key]
        public int VendorID { get; set; }



        [MaxLength(50)]
        public string VendorName { get; set; } = null!;


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
        public string VendorEmailID { get; set; } = null!;


        [MaxLength(10)]
        public string PINCode { get; set; } = null!;


        [Required]
        [MaxLength(50)]
        public string PrimaryContactPersonName { get; set; } = null!;


        [Required]
        [MaxLength(50)]
        public string PrimaryContactPersonContact { get; set; } = null!;


        //[Required]
        [MaxLength(50)]
        public string GSTNo { get; set; } = null!;


        [Required]
        [MaxLength(50)]
        public string PANNo { get; set; } = null!;


        [Required]
        [Column(TypeName = "Decimal(18,2)")]
        public decimal OpeningBalance { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }




    }
}
