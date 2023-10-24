using System.ComponentModel.DataAnnotations.Schema;

namespace LearnBlazor.Shared
{
    public class Pizza
    {
        public int Id { get; set; }
        public string PizzaName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string ImgUrl { get; set; } = string.Empty;
    }
}
