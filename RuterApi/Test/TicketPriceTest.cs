using RuterApi.Models;
using RuterApi.Service;
using Xunit;

namespace RuterApi.Test
{
    public class TicketPriceTest
    {
        private readonly ITicketPriceService _sut;
        public TicketPriceTest() { 
        
            _sut = new TicketPriceService();
        }

        [Theory]
        [InlineData(1, 40)]
        [InlineData(2, 66)]
        [InlineData(3, 92)]
        [InlineData(4, 118)]
        public void CalculatePrice_ShouldReturnCorrectPriceForEachZone_WhenPersonIsAdult(int zone, decimal expected)
        {
            var person = new Person(31);

            var result = _sut.CalculatePrice(person, zone);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 16)]
        [InlineData(2, 25.6)]
        [InlineData(3, 36)]
        [InlineData(4, 45.6)]
        public void CalculatePrice_ShouldReturnCorrectPriceForEachZone_WhenPersonIsChild(int zone, decimal expected)
        {
            var person = new Person(7);

            var result = _sut.CalculatePrice(person, zone);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 20)]
        [InlineData(2, 32)]
        [InlineData(3, 45)]
        [InlineData(4, 57)]
        public void CalculatePrice_ShouldReturnCorrectPriceForEachZone_WhenPersonIsHunnor(int zone, decimal expected)
        {
            var person = new Person(77);

            var result = _sut.CalculatePrice(person, zone);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 16)]
        [InlineData(2, 25.6)]
        [InlineData(3, 36)]
        [InlineData(4, 45.6)]
        public void CalculatePrice_ShouldReturnCorrectPrice_WhenPersonIsMilitary(int zone, decimal expected)
        {
            var person = new Person(20,true); ;

            var result = _sut.CalculatePrice(person, zone);

            Assert.Equal(expected, result);
        }

    }
}
