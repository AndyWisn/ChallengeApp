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

        public Employee(string name)
        {
            this.name = name;
                   
        }

        public int Result
        {
            get { return this.score.Sum(); }
        }

        public void AddScore(int score)                 //add score
        {
            this.score.Add(score);
        }
        public void SubScore(int score)                 //substract score
        {
            this.score.Add(-score);
        }
    }
}
