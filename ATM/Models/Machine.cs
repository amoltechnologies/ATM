using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class Machine
    {

        [Key]
        public int MachineID { get; set; }


        [Required]
        [MaxLength(50)]
        public string MachineName { get; set; } = null!;


        [Required]
        [MaxLength(50)]
        public string Make { get; set; } = null!;


        [Required]
        [MaxLength(50)]
        public string Company { get; set; } = null!;


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; }


        public string ModifiedBy { get; set; } = "";

        public DateTime ModificationTime { get; set; }



    }
}
