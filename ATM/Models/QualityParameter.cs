using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class QualityParameter
    {

        [Key]
        public int QualityParameterID { get; set; }



        [MaxLength(50)]
        [Required]
        public string QualityParameterName { get; set; } = null!;



        //[ForeignKey("ProcessPlan")]
        public int ProcessPlanID { get; set; }
        public ProcessPlan ProcessPlan { get; set; } = null!;


        [MaxLength(50)]
        [Required]
        public int UnitName { get; set; }



        [Required]
        [MaxLength(50)]
        public string OperationName { get; set; } = null!;



        [Required]
        [MaxLength(50)]
        public string Value { get; set; } = null!;


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }




    }
}
