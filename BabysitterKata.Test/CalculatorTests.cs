using BabysitterKata.Lib;
using FluentAssertions;
using Xunit;

namespace BabysitterKata.Test
{
    public class CalculatorTests
    {
        private const int testHours = 1;

        [Fact]
        public void Calculator_WhenTheHoursAreAfterMidnight_ReturnsAmountMadeDuringTimePeriod()
        {
            var calculator = new Calculator();
            var afterMidnight = calculator.Calculate(testHours, (int)Rates.AfterMidnight);
            const int expectedRate = testHours * (int)Rates.AfterMidnight;
            afterMidnight.Should().Be(expectedRate);
        }

        [Fact]
        public void Calculator_WhenTheHoursAreFromBedtimeToMidnight_ReturnsAmountMadeDuringTimePeriod()
        {
            var calculator = new Calculator();
            var afterBedtime = calculator.Calculate(testHours, (int)Rates.AfterBedtime);
            const int expectedRate = testHours * (int)Rates.AfterBedtime;
            afterBedtime.Should().Be(expectedRate);
        }

        [Fact]
        public void Calculator_WhenTheHoursAreBeforeBedtime_ReturnsAmountMadeDuringTimePeriod()
        {
            var calculator = new Calculator();
            var beforeBedtime = calculator.Calculate(testHours, (int)Rates.BeforeBedtime);
            const int expectedRate = testHours * (int)Rates.BeforeBedtime;
            beforeBedtime.Should().Be(expectedRate);
        }

        [Fact]
        public void Calculator_TheTotalAmountMadeAfterMidnight_ShouldReturnCorrectAmountMade()
        {
            var calculator = new Calculator();
            const int hoursAfterMidnight = 4;
            const int expectedEarnings = 64;
            var afterMidnight = calculator.CalculateSubTotal(hoursAfterMidnight, (int) Rates.AfterMidnight);
            afterMidnight.Should().Be(expectedEarnings);
        }

        [Fact]
        public void Calculator_TheTotalAmountMadeBeforeMidnight_ShouldReturnCorrectAmountMade()
        {
            var calculator = new Calculator();
            const int hoursBeforeBed = 3;
            const int hoursAfterBed = 4;
            const int expectedEarnings = (int)Rates.BeforeBedtime * hoursBeforeBed + (int)Rates.AfterBedtime * hoursAfterBed;

            var beforeBed = calculator.Calculate(hoursBeforeBed, (int) Rates.BeforeBedtime);
            var afterBed = calculator.Calculate(hoursAfterBed,(int)Rates.AfterBedtime);
            var actualEarnings = afterBed + beforeBed;
            actualEarnings.Should().Be(expectedEarnings);
        }
    }
}