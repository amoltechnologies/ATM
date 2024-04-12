using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ATM.Models
{
    public class Temp_QualityParameter
    {
        [Key]
        public int QualityParameterID { get; set; }

        public string QualityParameterName { get; set; }

        public int ProcessPlanID { get; set; }

        [MaxLength(50)]
        public string UnitName { get; set; } = null!;

        [Required]
        public string OperatorName { get; set; }

        [Required]
        public string Value { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }


    }
}
