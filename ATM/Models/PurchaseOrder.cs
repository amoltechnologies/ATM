using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ATM.Models
{
    public class PurchaseOrder
    {

        //[Key]
        //[Column(Order = 1)]
        public int PONumber { get; set; }

        //[Key]
        //[Column(Order = 2)]
        [MaxLength(10)]
        [Required]
        public string Fyear { get; set; } = null!;


        [Required]
        public int SupplierID { get; set; }


        [Required]
        public DateTime DateOfPO { get; set; }



        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalGSTAmount { get; set; }



        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalDiscountAmount { get; set; }


        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }


        //[Required]
        //[DataType(DataType.Date)]
        //public DateTime Date { get; set; }


        [Required]
        public int UserId { get; set; }


        // miscellaneous details


        [MaxLength(50)]
        public string KindAttention { get; set; } = null!;


        [MaxLength(50)]
        public string Delivery { get; set; } = null!;


        [MaxLength(50)]
        public string Payment { get; set; } = null!;


        [MaxLength(50)]
        public string PandF { get; set; } = null!;


        [MaxLength(50)]
        public string TransportationAmount { get; set; } = null!;


        [MaxLength(50)]
        public string Insurance { get; set; } = null!;


        [MaxLength(50)]
        public string DispatchedThrough { get; set; } = null!;


        [MaxLength(50)]
        public string QuotationNo { get; set; } = null!;


        public DateTime DateOfQuotation { get; set; }


        public string POStatus { get; set; } = "Open";


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; } 


    }
}
