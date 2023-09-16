using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RuterApi.Models;
using RuterApi.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<ITicketPriceService,TicketPriceService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/welcome", () =>
{
    var message ="Welcome to Ruter Api!\n\nApi Endpoints\n " +
                    "/ticketprice: calculate price based on age and zone\n" +
                    " e.g.: /ticketprice?age=31&zone=1";

    return message;
});

app.MapGet("/ticketprice", (int age,bool? isMilitary, int zone, ITicketPriceService service) =>
{
    var person = new Person(age,isMilitary?? false);

    var price =  service.CalculatePrice(person, zone);

    return Results.Ok(price);
});

app.Run();