using Microsoft.AspNetCore.Mvc;

namespace LearnBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        [HttpGet]
        public async Task<ActionResult<ResponseService<List<Pizza>>>> GetPizzas()
        {
            var pizzas = await _pizzaService.GetPizza();
            if (pizzas is not null)
            {
                return Ok(pizzas);
            }
            return BadRequest();
        }
    }
}
