
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()                //objects
        {
            //arrange
            var emp1 = GetEmployee("Ala");
            var emp2 = GetEmployee("Ala");

            //act

            //assert
            Assert.AreNotEqual(emp1, emp2);
        }

        [Test]
        public void ShouldPassWhenTablesAreSame()                           //2D tables
        {
            //arrange
            int[,] array1 = { { 1, 1 }, { 1, 1 } };
            int[,] array2 = { { 1, 1 }, { 1, 1 } };

            //act

            //assert
            Assert.AreEqual(array1, array2);
         }

        [Test]
        public void ShouldPassWhenCharTableIsSameAsString()                           //1D char table vs string
        {
            //arrange
            char[] array1 = {'a','b','c'};
            string string1 = "abc";

            //act

            //assert
            Assert.AreEqual(array1, string1);
        }

        [Test]
        public void ShouldPassWhenEmployeesNamesAreTheSame()                //strings
        {
            //arrange 
            var empl1 = GetEmployee("Andrzej");
            var empl2 = GetEmployee("Andrzej");

            // assert
            Assert.AreEqual(empl1.name, empl2.name);
        }

        [Test]
        public void ShouldPassWhenEmployeesAgeIsEqual()                     //bytes
        {
            //arrange 
            var employ1 = new Employee("Andrzej", "Wiśniewski", 46);
            var employ2 = new Employee("Bożena", "Wiśniewska", 46);

            // act

            // assert
            Assert.AreEqual(employ1.age, employ2.age);
        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}