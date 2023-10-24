namespace LearnBlazor.Server.Services
{
    public interface IPizzaService
    {
        Task<ResponseService<List<Pizza>>> GetPizza();
    }
}
