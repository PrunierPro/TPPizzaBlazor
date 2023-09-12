using System.ComponentModel.DataAnnotations;

namespace TPPizza.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, Range(1, 99)]
        public double Price { get; set; }
        [Required]
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        [Required]
        public string ImageLink { get; set; } = "/images/default.jpg";
    }
}
