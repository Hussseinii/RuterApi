using Microsoft.AspNetCore.Identity;
using RuterApi.Models;

namespace RuterApi.Service
{
    public interface ITicketPriceService
    {
        int CalculatePrice(Person person,int zone);
    }
}
