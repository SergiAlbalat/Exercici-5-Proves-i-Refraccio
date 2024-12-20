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
    public class Metode3
    {
        [Fact]
        public void NameAnalyserTest1()
        {
            var PersonaHelper = new PersonaHelper();
            string name = "asa";
            var result = PersonaHelper.NameAnalyser(name);
            Assert.True(result.IsShort);
            Assert.True(result.IsPalindrome);
        }
        [Fact]
        public void NameAnalyserTest2()
        {
            var PersonaHelper = new PersonaHelper();
            string name = "ase";
            var result = PersonaHelper.NameAnalyser(name);
            Assert.True(result.IsShort);
            Assert.False(result.IsPalindrome);
        }
        [Fact]
        public void NameAnalyserTest3()
        {
            var PersonaHelper = new PersonaHelper();
            string name = "assssa";
            var result = PersonaHelper.NameAnalyser(name);
            Assert.False(result.IsShort);
            Assert.True(result.IsPalindrome);
        }
        [Fact]
        public void NameAnalyserTest4()
        {
            var PersonaHelper = new PersonaHelper();
            string name = "asasasadasdsadwa";
            var result = PersonaHelper.NameAnalyser(name);
            Assert.False(result.IsShort);
            Assert.False(result.IsPalindrome);
        }
    }
    public class Metode4
    {
        [Fact]
        public void VerifyClourTest1()
        {
            var PersonaHelper = new PersonaHelper();
            string colour = "";
            int result = PersonaHelper.VerifyColour(colour);
            Assert.Equal(-1, result);
        }
        [Fact]
        public void VerifyClourTest2()
        {
            var PersonaHelper = new PersonaHelper();
            string colour = "blau";
            int result = PersonaHelper.VerifyColour(colour);
            Assert.Equal(0, result);
        }
        [Fact]
        public void VerifyClourTest3()
        {
            var PersonaHelper = new PersonaHelper();
            string colour = "verd";
            int result = PersonaHelper.VerifyColour(colour);
            Assert.Equal(0, result);
        }
        [Fact]
        public void VerifyClourTest4()
        {
            var PersonaHelper = new PersonaHelper();
            string colour = "groc";
            int result = PersonaHelper.VerifyColour(colour);
            Assert.Equal(1, result);
        }
    }
    public class Metode5
    {
        [Fact]
        public void PersonalityTest1()
        {
            var PersonaHelper = new PersonaHelper();
            string preference = "mat�";
            int result = PersonaHelper.PersonalityTest(preference);
            Assert.Equal(0, result);
        }
        [Fact]
        public void PersonalityTest2()
        {
            var PersonaHelper = new PersonaHelper();
            string preference = "nit";
            int result = PersonaHelper.PersonalityTest(preference);
            Assert.Equal(1, result);
        }
        [Fact]
        public void PersonalityTest3()
        {
            var PersonaHelper = new PersonaHelper();
            string preference = "nose";
            int result = PersonaHelper.PersonalityTest(preference);
            Assert.Equal(2, result);
        }
    }
}