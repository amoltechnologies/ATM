using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ATM.Models
{
    public class GRN
    {

        //[Key]
        public int GRNID { get; set; }

        /// detail po id
        /// sr no
        /// qty
        /// fyear key + grnid      

        [MaxLength(10)]
        public string Fyear { get; set; } = null!;


        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; } = null!;



        //public int DetailedPOID { get; set; }
        //public DetailedPurchaseOrder DetailedPurchaseOrder { get; set; }




        public DateTime Date { get; set; }



        public int MaterialTypeID { get; set; }
        public MaterialType MaterialType { get; set; }



        public int MaterialID { get; set; }
        public Material Material { get; set; }



        public string UnitName { get; set; } = null!;




        [Column(TypeName = "decimal(18,2)")]
        public decimal GRNQuantity { get; set; }



        public int UserID { get; set; }



        //[Column(name: "POID")]
        
        public int DetailedPOID { get; set; }
        [ForeignKey("DetailedPOID")]
        public virtual DetailedPurchaseOrder DetailedPurchaseOrder { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }


        

    }
}
