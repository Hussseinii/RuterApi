using RuterApi.Models;

namespace RuterApi.Extentions
{
    public static class PersonExtention
    {
        public static bool IsVoksen(this Person person)
        {

            return person.Age > 16 && person.Age < 67;
        }

        public static bool IsBarn(this Person person)
        {

            return person.Age > 5 && person.Age < 18;
        }
        public static bool IsHunnor(this Person person)
        {

            return person.Age > 66;
        }
    }
}
