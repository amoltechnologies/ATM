using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class DetailedSalesOrder
    {

        //auto increment id
        [Key]
        public int DetailedSalesOrderID { get; set; }



        [Required]
        public int SalesOrderNumber { get; set; }


        //[Key]
        [Required]
        public int SrNo { get; set; }



        //[ForeignKey("Material")]
        [Required]
        public int FinishedGoodsID { get; set; }
        public FinishedGoods FinishedGoods { get; set; } = null!;



        [Required]
        public int MaterialTypeID { get; set; }
        public MaterialType MaterialType { get; set; } = null!;



        [MaxLength(50)]
        [Required]
        public string FG_Name { get; set; } = null!;


        [MaxLength(10)]
        [Required]
        public string Fyear { get; set; } = null!;


        [Required]
        public string Description { get; set; } = null!;



        [MaxLength(50)]
        [Required]
        public string HSNCode { get; set; } = null!;


        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BaseAmount { get; set; }



        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Quantity { get; set; }


        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal GRNQuantity { get; set; }


        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }


        [MaxLength(50)]
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



        [MaxLength(50)]
        public int UserId { get; set; }


        public int CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }


        public int ModifiedBy { get; set; }

        public DateTime ModificationTime { get; set; }

    }
}