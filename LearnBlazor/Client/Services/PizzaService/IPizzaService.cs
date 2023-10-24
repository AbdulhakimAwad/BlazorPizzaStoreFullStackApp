using LearnBlazor.Shared;

namespace LearnBlazor.Client.Services.PizzaService
{
    public interface IPizzaService
    {
        List<Pizza> _pizzas { get; set; }
        Task GetPizzasAsync();
    }
}
