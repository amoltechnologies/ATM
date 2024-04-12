using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class CustomerPlant
    {

        [Key]
        public int CustomerPlantID { get; set; }


        //[ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; } = null!;


        [Required]
        [MaxLength(50)]
        public string CustomerPlantName { get; set; } = null!;


        [Required]
        public string CustomerPlantAddress { get; set; } = null!;


        [Required]
        public string VendorCode { get; set; } = null!;


        public string CreatedBy { get; set; } = null!;


        public DateTime CreationTime { get; set; } = DateTime.Now;


        public string? ModifiedBy { get; set; }

        public DateTime? ModificationTime { get; set; }




    }
}
