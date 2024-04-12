using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class TemperoryPurchaseOrder
    {

        [Key]
        public int SrNo { get; set; }


        //[ForeignKey("Material")]
        public int MaterialID { get; set; }
        public Material Material{ get; set; } = null!;


        public int MaterialTypeID { get; set; }
        public MaterialType MaterialType { get; set; } = null!;


        [MaxLength(50)]
        [Required]
        public string MaterialName { get; set; } = null!;


        [MaxLength(10)]
        [Required]
        public string Fyear { get; set; } = null!;


        [Required]
        public string Description { get; set; } = null!;


        [MaxLength(50)]
        public string HSNCode { get; set; } = null!;


        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BaseAmount { get; set; }


        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Quantity { get; set; } = 1;


        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }


        [Required]
        public string UnitName { get; set; } = null!;



        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiscountPercent { get; set; }



        [Column(TypeName = "decimal(18, 2)")]
        public decimal SGSTPercent { get; set; }



        [Column(TypeName = "decimal(18, 2)")]
        public decimal SGSTAmount { get; set; }



        [Column(TypeName = "decimal(18, 2)")]
        public decimal CGSTPercent { get; set; }


        [Column(TypeName = "decimal(18, 2)")]
        public decimal CGSTAmount { get; set; }



        [Column(TypeName = "decimal(18, 2)")]
        public decimal IGSTPercent { get; set; }



        [Column(TypeName = "decimal(18, 2)")]
        public decimal IGSTAmount { get; set; }



        [Column(TypeName = "decimal(18, 2)")]
        public decimal SubTotal { get; set; }


        [Required]
        public int UserId { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }



    }
}