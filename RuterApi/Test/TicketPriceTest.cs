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

        [Fact]
        public void CalculatePrice_shouldReturnCorrectPriceForZoneOne_WhenPersonIsAdult()
        {
            int zone = 1;
            var person = new Person(31);

            var result = _sut.CalculatePrice(person, zone);

            Assert.Equal(40, result);
        }

        [Fact]
        public void CalculatePrice_shouldReturnCorrectPriceForZoneTo_WhenPersonIsAdult()
        {
            int zone = 2;
            var person = new Person(31);

            var result = _sut.CalculatePrice(person, zone);

            Assert.Equal(80, result);
        }

        [Fact]
        public void CalculatePrice_shouldReturnCorrectPriceForZoneOne_WhenPersonIsChild()
        {
            int zone = 1;
            var person = new Person(7);

            var result = _sut.CalculatePrice(person, zone);

            Assert.Equal(16, result);
        }

        [Fact]
        public void CalculatePrice_shouldReturnCorrectPriceForZoneTo_WhenPersonIsChild()
        {
            int zone = 2;
            var person = new Person(7);

            var result = _sut.CalculatePrice(person, zone);

            Assert.Equal(32, result);
        }

        [Fact]
        public void CalculatePrice_shouldReturnCorrectPriceForZoneOne_WhenPersonIsHunnor()
        {
            int zone = 1;
            var person = new Person(77);

            var result = _sut.CalculatePrice(person, zone);

            Assert.Equal(20, result);
        }

        [Fact]
        public void CalculatePrice_shouldReturnCorrectPriceForZoneTo_WhenPersonIsHunnor()
        {
            int zone = 2;
            var person = new Person(77);

            var result = _sut.CalculatePrice(person, zone);

            Assert.Equal(40, result);
        }

        [Fact]
        public void CalculatePrice_shouldReturnCorrectPrice_WhenPersonIsMilitary()
        {
            int zone = 1;
            var person = new Person(20,true); ;

            var result = _sut.CalculatePrice(person, zone);

            Assert.Equal(20, result);
        }

    }
}
