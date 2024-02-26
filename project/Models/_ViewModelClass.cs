using System.ComponentModel.DataAnnotations;

namespace kendoGridRev.Models
{
    public class _ViewModelClass
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        public string Department { get; set; }
        [Required]

        public decimal Salary { get; set; }
        [Required]
        public decimal Contact { get; set; }
        
        public int Br_Id { get; set; }
        [Required]
        public string Br_Name { get; set; }
    }
}
