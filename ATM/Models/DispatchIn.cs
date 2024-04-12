using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class DispatchIn
    {
        [Key]
        public int DispatchInID { get; set; }


        public int TypeID { get; set; }
        public MaterialType MaterialType { get; set; } = null!;


        public int MaterialID { get; set; }
        public Material Material { get; set; } = null!;



        [Column(TypeName = "decimal(18, 2)")]
        public decimal InQuantity { get; set; }


        public string ReceivedFrom { get; set; } = null!;


        public string ReceivedTransactionID { get; set; } = null!;


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }




    }
}
