using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class SupplierPlant
    {

        [Key]
        public int SupplierPlantID { get; set; }


        //[ForeignKey("Supplier")]
        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }


        [Required]
        [MaxLength(50)]
        public string SupplierPlantName { get; set; }

        [Required]
        [MaxLength(50)]
        public string SupplierPlantEmailID { get; set; }

        [Required]
        public string SupplierPlantAddress { get; set; }

        [Required]
        public string SupplierPlantCity { get; set; }

        [Required]
        public string SupplierPlantState { get; set; }
        [Required]
        public string SupplierPlantPincode { get; set; }
        [Required]
        public string SupplierplantPANNo { get; set; }
        [Required]
        public string SupplierPlantGSTNo { get; set; }
        [Required]
        public string SupplierPlantContactPersonName { get; set; }
        [Required]
        public string SupplierPlantContactNumber { get; set; }
        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal? SupplierPlantOpeningBalance { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }



    }
}
