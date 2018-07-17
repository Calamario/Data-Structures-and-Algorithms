using Challenge_FindRepeated;
using System;
using Xunit;

namespace RepeatedWordTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("it", "There was once a big dog that ate many apples until it became full but it never really was full")]
        [InlineData("summer", "It was a queer, sultry summer the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...")]
        [InlineData("was", "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...")]
        public void CanFindRepeatedWord(string repeatedWord, string text)
        {
            Assert.Equal(repeatedWord, Program.RepeatedWord(text));
        }

        [Theory]
        [InlineData("Hello my name is mario")]
        [InlineData("I like big apples")]
        [InlineData("Because small apples makes me sad like wet dog")]
        public void CanReturnEmptyStringIfNORepreatedWord(string text)
        {
            Assert.Equal("", Program.RepeatedWord(text));
        }
    }
}
