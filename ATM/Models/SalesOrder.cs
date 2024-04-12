using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class SalesOrder
    {
        //[Key]
        //[Column(Order = 1)]
        public int SalesOrderNumber { get; set; }

        //[Key]
        //[Column(Order = 2)]
        [MaxLength(10)]
        [Required]
        public string Fyear { get; set; } = null!;


        [Required]
        public int CustomerID { get; set; }


        [Required]
        public DateTime DateOfSalesOrder { get; set; }



        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalGSTAmount { get; set; }




        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }



        [Required]
        public int UserId { get; set; }


        public int CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }


        public int ModifiedBy { get; set; }

        public DateTime ModificationTime { get; set; }

    }
}
