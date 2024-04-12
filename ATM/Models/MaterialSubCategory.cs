using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class MaterialSubCategory
    {

        [Key]
        public int MaterialSubCategoryID { get; set; }

        [Required]
        [MaxLength(50)]
        public string MaterialSubCategoryName { get; set; } = null!;


        [Required]
        public int MaterialCategoryID { get; set; }
        public MaterialCategory MaterialCategory { get; set; } = null!;


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }



    }
}
