using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Madam",true)] 
        [InlineData("LeveL",true)]
        [InlineData("Civic",true)]
        [InlineData("Gopi",false)]
        
        public void IsPalindromeTest(string word, bool expected)
        {
            var wordSmith = new WordSmith();
            //Act
            var actual = wordSmith.IsPalindrome(word);
            //Testing
            Assert.Equal(expected, actual);
        }
    }
}
