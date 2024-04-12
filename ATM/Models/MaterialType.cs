using System.ComponentModel.DataAnnotations;

namespace ATM.Models
{
    public class MaterialType
    {

        [Key]
        public int MaterialTypeID { get; set; }


        [Required]
        [MaxLength(50)]
        public string MaterialTypeName { get; set; } = null!;


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }



    }
}
