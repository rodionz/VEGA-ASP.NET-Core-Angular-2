
using System.ComponentModel.DataAnnotations;



namespace Angular_2.Model
{
    public class Feature
    {
         public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}