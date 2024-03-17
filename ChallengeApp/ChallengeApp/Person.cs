namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string? name, string? surname, char? sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        protected string? Name { get; private set; }
        protected string? Surname { get; private set; }
        protected char? Sex { get; private set; }
    }
}