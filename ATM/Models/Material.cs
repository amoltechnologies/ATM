using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class Material
    {

        [Key]
        public int MaterialID { get; set; }


        //[ForeignKey("MaterialType")]
        public int MaterialTypeID { get; set; }
        public  MaterialType MaterialType { get; set; } = null!;


        //[ForeignKey("MaterialCategory")]
        public int MaterialCategoryID { get; set; }
        public  MaterialCategory MaterialCategory { get; set; } = null!;


        //[ForeignKey("MaterialSubCategory")]

        public int MaterialSubCategoryID { get; set; }
        public  MaterialSubCategory MaterialSubCategory { get; set; } = null!;


        //[ForeignKey("Unit")]
        [MaxLength(50)]
        [Required]
        public string UnitName { get; set; } = null!;
        //public virtual Unit Units { get; set; }


        [Required]
        [MaxLength(50)]
        public string MaterialName { get; set; } = null!;


        [Required]
        public string MaterialDescription { get; set; } = null!;


        [Required]
        [MaxLength(50)]
        public string MaterialHSNCode { get; set; } = null!;


        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal MaterialGSTPercent { get; set; }


        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal MaterialOpeningQuantity { get; set; }


        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal MaterialBufferLevelQuantity { get; set; }


        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal MaterialAvailableQuantity { get; set; }
        
        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal MaterialStoreQuantity { get; set; } 
        
        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal MaterialProductionQuantity { get; set; }
        
        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal MaterialQualityQuantity { get; set; }
        
        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal MaterialDispatchQuantity { get; set; }



        [Required]
        public bool IsQualityRequire { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }





    }
}
