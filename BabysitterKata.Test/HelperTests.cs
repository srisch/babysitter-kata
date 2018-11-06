using Xunit;
using BabysitterKata.Lib;
using FluentAssertions;

namespace BabysitterKata.Test
{
    public class HelperTests
    {
        [Fact]
        public void Helpers_WhenPassingDoubleAsAString_ShouldReturnOne()
        {
            const string testDouble = "1.5";
            var converted = Helpers.CheckValue(testDouble);
            converted.Should().Be(1);
        }
        
        [Fact]
        public void Helpers_WhenPassingAIntAsString_ShouldBeConvertedToInt()
        {
            const string testDouble = "5";
            var converted = Helpers.CheckValue(testDouble);
            converted.Should().NotBe(0);
        }

        [Fact]
        public void Helpers_WhenAnsweringYesToWorkingAfterMidnight_ShouldReturnTrue()
        {
            const string UserAnswer = "Yes";
            Helpers.questionHandler(UserAnswer);
            Helpers.AfterMidnightAnswer.Should().BeTrue();
        }
        
        [Fact]
        public void Helpers_WhenAnsweringNoToWorkingAfterMidnight_ShouldReturnFalse()
        {
            const string UserAnswer = "No";
            Helpers.questionHandler(UserAnswer);
            Helpers.AfterMidnightAnswer.Should().BeFalse();
        }
        
    }
}