using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ATM.Models
{
    public class Temp_CustomerPlant
    {
        [Key]
        public int id { get; set; }

        public string CustomerPlantName { get; set; }

        [Required]
        public string CustomerPlantAddress { get; set; }

        [Required]
        public string VendorCode { get; set; }

        [Required]
        public string CustomerPlantCity { get; set; }
        [Required]
        public string CustomerPlantState { get; set; }

        [Required]
        [MaxLength(50)]
        public string CustomerPlantEmailID { get; set; }

        [Required]
        public string CustomerPlnatPincode { get; set; }
        [Required]
        public string CustomerPlantPANNo { get; set; }

        [Required]
        public string CustomerPlantGSTNo { get; set; }

        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal? CustomerPlantOpeningBalance { get; set; }

        [Required]
        public string CustomerPlantContactPersonName { get; set; }

        [Required]
        public string CustomerPlantContactNumber { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }


    }
}
