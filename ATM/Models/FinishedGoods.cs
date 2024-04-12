using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class FinishedGoods
    {

        [Key]
        public int FinishedGoodsID { get; set; }


        [MaxLength(50)]
        public string FG_Name { get; set; } = null!;


        [MaxLength(50)]
        public string InternalFG_Name { get; set; } = null!;


        [Required]
        [MaxLength(50)]
        public string HSNCode { get; set; } = null!;


        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal GSTPercent { get; set; }


        [Required]
        public string Description { get; set; } = null!;


        [Required]
        [Column(TypeName = "Decimal(18,2)")]
        public decimal PerUnitPrice { get; set; }


        [Required]
        public string InternalDrawing { get; set; } = null!;


        [Required]
        public string CustomerDrawing { get; set; } = null!;


        [MaxLength(50)]
        [Required]
        public string UnitName { get; set; } = null!;

       
        //[Column(TypeName = "Decimal(18, 2)")]
        //public decimal MaterialOpeningQuantity { get; set; }


        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal FGBufferLevelQuantity { get; set; }

        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal FGOpeningQuantity { get; set; }


       
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal FGAvailableQuantity { get; set; }

        
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal FGStoreQuantity { get; set; }

       
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal FGProductionQuantity { get; set; }

       
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal FGQualityQuantity { get; set; }

        
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal FGDispatchQuantity { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }


    }
}
