using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class Temp_BOM
    {
        [Key]
        public int BOMID { get; set; }

        [Required]
        public int ProcessPlanID { get; set; }

        [Required]
        public int FinishedGoodsID { get; set; }

        [Required]
        public int MaterialID { get; set; }

        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal Quantity { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }



    }
}


