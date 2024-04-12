using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class Temp_ProcessPlan
    {
        [Key]
        public int ProcessPlanID { get; set; }

        public int FinishedGoodsID { get; set; }
        public string ProcessName { get; set; }
        public string OutputName { get; set; }


        [Required]
        [Column(TypeName = "Decimal(18, 2)")]
        public decimal OutputQuantity { get; set; }

        [Required]
        public string ProcessPlanDescription { get; set; }


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
        public bool isQualityRequired { get; set; }

        [Required]
        public bool isFinalProcess { get; set; }

        [Required]
        public string OutputUnit { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }


    }
}
