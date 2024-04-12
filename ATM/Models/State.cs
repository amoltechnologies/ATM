using System.ComponentModel.DataAnnotations;

namespace ATM.Models
{
    public class State
    {

        [Key]
        public int StateID { get; set; }


        [Required(ErrorMessage = "Please Enter {0}. ")]
        
        [MaxLength(50)]
        public string StateName { get; set; } = null!;


        [Required]
        [MaxLength(2), MinLength(2)]
        public int StateGSTCode { get; set; }


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }



    }
}
