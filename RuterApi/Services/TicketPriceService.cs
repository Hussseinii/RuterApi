using RuterApi.Models;
using RuterApi.Extentions;

namespace RuterApi.Service
{
    public class TicketPriceService : ITicketPriceService
    {
       
        public decimal CalculatePrice(Person person, int zone)
        {
            if(person.IsMilitary)
            {
                return zone < 3 ? 6.4m + 9.6m * zone
                               : 7.2m + 9.6m * zone;
            }
            else if (person.IsAdult())
            {
                return 14 + 26 * zone;
            }
            else if (person.IsChild())
            {
                return zone < 3 ? 6.4m + 9.6m * zone
                               : 7.2m + 9.6m * zone;
            }
            else if (person.IsHunnor())
            {
                return zone < 3 ? 8 + 12 * zone 
                                : 9 + 12 * zone;
            }

            return -1;
        }
        
    }
}
