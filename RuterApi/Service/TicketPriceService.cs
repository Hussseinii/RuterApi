using RuterApi.Models;
using RuterApi.Extentions;

namespace RuterApi.Service
{
    public class TicketPriceService : ITicketPriceService
    {
       
        public int CalculatePrice(Person person, int zone)
        {
            if(person.IsMilitary)
            {
                return 20 * zone;
            }
            else if (person.IsVoksen())
            {
                return 40 * zone;
            }
            else if (person.IsBarn())
            {
                return 16 * zone;
            }
            else if (person.IsHunnor())
            {
                return 20 * zone;
            }

            return -1;
        }
        
    }
}
