using System.ComponentModel.DataAnnotations;

namespace MyWebApp01.Models
{
    public class Timesheet
    {
        [Key]

        public int id { get; set; }
        [Required]
        public int empid { get; set; }  
        public string empname { get; set; }
        public string changedate { get; set; }
        public string task { get; set; }    
    }
}
