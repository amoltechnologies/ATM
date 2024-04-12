using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class Temp_VendorPlant
    {
        [Key]
        public int VendorPlantID { get; set; }

        [Required]
        public string VendorPlantName { get; set; }


        [Required]
        public string VendorPlantAddress { get; set; }

        [Required]
        [MaxLength(50)]
        public string VendorPlantEmailID { get; set; }

        [Required]
        public string VendorPlantCity { get; set; }

        [Required]
        public string VendorPlantState { get; set; }
        [Required]
        public string VendorPlantPincode { get; set; }
        [Required]
        public string VendorplantPANNo { get; set; }
        [Required]
        public string VendorPlantGSTNo { get; set; }
        [Required]
        public string VendorPlantContactPersonName { get; set; }
        [Required]
        public string VendorPlantContactNumber { get; set; }

        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal? VendorPlantOpeningBalance { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }


    }
}
