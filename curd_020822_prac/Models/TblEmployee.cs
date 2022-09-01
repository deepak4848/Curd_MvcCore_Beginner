using System.ComponentModel.DataAnnotations;

namespace curd_020822_prac.Models
{
    public class TblEmployee
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int age { get; set; }
        public string? address { get;set; }
        public string? salary { get; set;}
        public string? contact { get; set; } 
    }
}
