using System.ComponentModel.DataAnnotations;

namespace TPPizza.Models
{
    public class PizzaEditDto
    {
        public PizzaEditDto()
        {

        }

        public PizzaEditDto(Pizza p)
        {
            Id = p.Id;
            Name = p.Name;
            Price = p.Price;
            ImageLink = p.ImageLink;
            IngredientsString = CreateIngredientsString(p.Ingredients);
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, Range(1, 99)]
        public double Price { get; set; }
        [Required]
        public string? IngredientsString { get; set; }
        [Required]
        public string ImageLink { get; set; } = "/images/default.jpg";

        public string? CreateIngredientsString(List<Ingredient> ingredients)
        {
            return string.Join(", ", ingredients);
        }
    }
}
