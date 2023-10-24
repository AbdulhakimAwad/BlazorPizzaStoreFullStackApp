using LearnBlazor.Shared;
using System.Net.Http.Json;

namespace LearnBlazor.Client.Services.PizzaService
{
    public class PizzaService : IPizzaService
    {
        private readonly HttpClient _client;

        public PizzaService(HttpClient client)
        {
            _client = client;
        }
        public List<Pizza> _pizzas { get; set; } = new List<Pizza>();

        public async Task GetPizzasAsync()
        {
            var response = await _client.GetFromJsonAsync<ResponseService<List<Pizza>>>("api/pizza");
            if (response is not null && response.Data is not null)
            {
                _pizzas = response.Data;
            }
        }
    }
}
