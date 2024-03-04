namespace ChallengeApp
{
    public class Employee
    {

        private List<int> score = new List<int>();
        public string name { get; private set; }
        public string surname { get; private set; }
        public byte age { get; set; }

        public Employee(string name, string surname, byte age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;

        }

        public int Result
        {
            get { return this.score.Sum(); }
        }

        public void AddScore(int score)
        {
            this.score.Add(score);

        }
    }
}
