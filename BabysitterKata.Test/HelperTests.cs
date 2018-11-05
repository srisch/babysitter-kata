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
    }
}