using RuterApi.Models;

namespace RuterApi.Extentions
{
    public static class PersonExtension
    {
        public static bool IsAdult(this Person person)
        {
            return person.Age > 16 && person.Age < 67;
        }

        public static bool IsChild(this Person person)
        {
            return person.Age > 5 && person.Age < 18;
        }
        public static bool IsHunnor(this Person person)
        {
            return person.Age > 66;
        }
    }
}
