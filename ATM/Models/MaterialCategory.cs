using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class MaterialCategory
    {

        [Key]
        public int MaterialCategoryID { get; set; }


        [Required]
        [MaxLength(50)]
        public string MaterialCategoryName { get; set; } = null!;


        [Required]
        public int MaterialTypeID { get; set; }
        public MaterialType MaterialType { get; set; } = null!;


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }



    }
}
