using Microsoft.EntityFrameworkCore;

namespace LearnBlazor.Server.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly AppDbCtx _context;

        public PizzaService(AppDbCtx context)
        {
            _context = context;
        }
        public async Task<ResponseService<List<Pizza>>> GetPizza()
        {
            var result = await _context.Pizza.ToListAsync();
            var response = new ResponseService<List<Pizza>>()
            {
                Data = result
            };
            return response;
        }
    }
}
