using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class QualityOut
    {

        [Key]
        public int QualityOutID { get; set; }


        [Required]
        public int MaterialID { get; set; }
        public Material Material { get; set; }

        [Required]
        public int TypeID { get; set; }
        public MaterialType MaterialType { get; set; }


        [Required]
        [Column(TypeName = "decimal (18,2)")]
        public decimal OutQuantity { get; set; }


        [Required]
        public string IssuedTo { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }



    }
}
