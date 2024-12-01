using ExerciseFive;
namespace Exercici_5_Proves_i_Refraccio
{
    public class Methode1
    {
        [Fact]
        public void validateAgeTest1()
        {
            var PersonaHelper = new PersonaHelper();
            int age = -1;
            int result = PersonaHelper.ClassifyAge(age);
            Assert.Equal(0, result);
        }
        [Fact]
        public void validateAgeTest2()
        {
            var PersonaHelper = new PersonaHelper();
            int age = 0;
            int result = PersonaHelper.ClassifyAge(age);
            Assert.Equal(0, result);
        }
        [Fact]
        public void validateAgeTest3()
        {
            var PersonaHelper = new PersonaHelper();
            int age = 18;
            int result = PersonaHelper.ClassifyAge(age);
            Assert.Equal(1, result);
        }
        [Fact]
        public void validateAgeTest4()
        {
            var PersonaHelper = new PersonaHelper();
            int age = 65;
            int result = PersonaHelper.ClassifyAge(age);
            Assert.Equal(1, result);
        }
        [Fact]
        public void validateAgeTest5()
        {
            var PersonaHelper = new PersonaHelper();
            int age = 66;
            int result = PersonaHelper.ClassifyAge(age);
            Assert.Equal(2, result);
        }
        [Fact]
        public void validateAgeTest6()
        {
            var PersonaHelper = new PersonaHelper();
            int age = 120;
            int result = PersonaHelper.ClassifyAge(age);
            Assert.Equal(2, result);
        }
    }
    public class Metode2
    {
        [Fact]
        public void IsEvenTest1()
        {
            var PersonaHelper = new PersonaHelper();
            int age = 43;
            bool result = PersonaHelper.IsEven(age);
            Assert.False(result);
        }
        [Fact]
        public void IsEvenTest2()
        {
            var PersonaHelper = new PersonaHelper();
            int age = 88;
            bool result = PersonaHelper.IsEven(age);
            Assert.True(result);
        }
    }
}