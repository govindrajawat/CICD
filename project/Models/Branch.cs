using System.ComponentModel.DataAnnotations;

namespace kendoGridRev.Models
{
    public class Branch
    {
        [Key]
        public int Br_Id { get; set; }
        public string Br_Name { get; set; }
    }
}
