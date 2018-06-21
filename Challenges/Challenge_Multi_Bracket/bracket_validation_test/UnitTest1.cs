using System;
using Xunit;
using Challenge_Multi_Bracket.Classes;
using Challenge_Multi_Bracket;

namespace bracket_validation_test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("()[]{}",true)]
        [InlineData("[[]]()",true)]
        [InlineData("()hello[]",true)]
        [InlineData("({)[}]",true)]
        [InlineData("[][][]",true)]
        [InlineData("hello{}bye[]hello()",true)]
        public void CanReturnTrueForCorrectInput(string value, bool expected)
        {
            Assert.Equal(expected, Program.ValidateBracketEquality(Program.MakeBracketQueue(value)));
        }

        [Theory]
        [InlineData("()[{}", false)]
        [InlineData("[[]()", false)]
        [InlineData("(hello[]", false)]
        [InlineData("({)[]", false)]
        [InlineData("{][]", false)]
        [InlineData("hello}bye]hello)", false)]
        public void CanReturnFalseForCorrectInput(string value, bool expected)
        {
            Assert.Equal(expected, Program.ValidateBracketEquality(Program.MakeBracketQueue(value)));
        }


    }
}
