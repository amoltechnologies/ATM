using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class ProcessPlan
    {

        [Key]
        public int ProcessPlanID { get; set; }


        //[ForeignKey("FinishedGoods")]
        public int FinishedGoodsID { get; set; }
        public  FinishedGoods FinishedGoods { get; set; } = null!;


        [Required]
        [MaxLength(50)]
        public string ProcessPlanName { get; set; } = null!;


        [Required]
        public string ProcessPlanDescription { get; set; } = null!;


        [Required]
        [MaxLength(50)]
        public string OutputName { get; set; } = null!;


        public bool IsFinalProcess { get; set; }


        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal ProcessOutputQuantity { get; set; }


        [Required]
        [MaxLength(50)]
        public string ProcessOutputUnit { get; set; } = null!;


        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal ProcessScrapQuantity { get; set; }

        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal ProcessOpeningQuantity { get; set; }


        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal ProcessBufferLevelQuantity { get; set; }


        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal ProcessAvailableQuantity { get; set; }

        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal ProcessStoreQuantity { get; set; }

        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal ProcessProductionQuantity { get; set; }

        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal ProcessQualityQuantity { get; set; }

        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal ProcessDispatchQuantity { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }


    }
}
