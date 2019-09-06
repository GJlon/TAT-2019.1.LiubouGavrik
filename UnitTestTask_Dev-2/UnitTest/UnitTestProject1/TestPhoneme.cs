using System;
using NUnit.Framework;
using taskDev2;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestPhoneme
    {
        /// <summary>
        /// Pervytest must pass the test, because entered correctly, 
        /// the second and third test should not pass the test
        /// </summary>
        /// <param name="input"></param>
        /// <param name="expected"></param>
        [TestCase("молоко+", "молоко+")]
        [TestCase("молоко", "молоко+")]
        [TestCase("мо+локо+", "молоко+")]
        public void TestFindShockPosition(string input, string expected)
        {
            Phoneme phoneme = new Phoneme();
            Assert.AreEqual(expected, input);
        }

        /// <summary>
        /// This test is using for the general method that calls all the rest
        /// </summary>
        /// <param name="input"></param>
        /// <param name="expected"></param>
        [TestCase("молоко+", "малако")]
        [TestCase("яйцо+", "йайцо")]
        [TestCase("ме+сто", "м'эста")]
        [TestCase("сде+лать", "зд'элат'")]
        public void TestReturnString(string input, string expected)
        {
            var phoneme = new Phoneme(input);
            int l = input.Length;
            var actual = phoneme.ReturnString(l);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Add english 'o' in the first word.
        /// Should show an error, because the word contains the English letter 'o'
        /// </summary>
        /// <param name="input"></param>
        /// <param name="expected"></param>
        [TestCase("мoлоко+")]
        public void TestCheckingEnglishLetters(string input)
        {
            var phoneme = new Phoneme(input);
            Assert.Throws<FormatException>(() => phoneme.CheckingEnglishLetters());
        }

        /// <summary>
        /// Test used to check that only one plus in the word. If not return exception
        /// </summary>
        /// <param name="input"></param>
        /// <param name="expected"></param>
        [TestCase("я+блоко+")]
        public void TestCheckingPositionOfPlus(string input)
        {
            var phoneme = new Phoneme(input);
            Assert.Throws<FormatException>(() => phoneme.CheckingPositionOfPlus());
        }

        /// <summary>
        /// Check method which work with vowels
        /// </summary>
        [TestCase("я+блоко", "йа+блоко")]
        [TestCase("ёлка", "йолка")]
        [TestCase("семья+", "семйа+")]
        public void TestWorkWithVowels(string input, string expected)
        {
            var phoneme = new Phoneme(input);
            int l = input.Length;
            var actual = phoneme.WorkWithVowels(ref l);
            Assert.AreEqual(expected, actual);
        }
    }
}
