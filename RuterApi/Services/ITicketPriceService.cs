using RuterApi.Models;

namespace RuterApi.Service
{
    public interface ITicketPriceService
    {
       public decimal CalculatePrice(Person person, int zone);
    }
}
