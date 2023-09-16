namespace RuterApi.Models
{
    public class Person
    {
        public int Age { get; set; }
        public bool IsMilitary { get; set; }
        public Person(int age, bool isMilitary = false)
        {
            Age = age;
            IsMilitary = isMilitary;
        }
    }
}
