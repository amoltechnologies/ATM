using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class BOM
    {

        [Key]
        public int BOMID { get; set; }



        //[ForeignKey("ProcessPlanID")]
        [Required]
        public int ProcessPlanID { get; set; }
        public ProcessPlan ProcessPlan { get; set; } = null!;



        //[ForeignKey("FinishedGoods")]
        [Required]
        public int FinishedGoodsID { get; set; }
        public FinishedGoods FinishedGoods { get; set; } = null!;



        //[ForeignKey("Material")]
        [Required]
        public int MaterialID { get; set; }
        public Material Material { get; set; } = null!;



        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal Quantity { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; } = DateTime.Now;


        public string? ModifiedBy { get; set; }

        public DateTime? ModificationTime { get; set; }

    }
}
