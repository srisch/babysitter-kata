using BabysitterKata.Cli;
using BabysitterKata.Lib;
using FluentAssertions;
using Xunit;

// Bedtime is based on 8pm.
// 5pm - 8pm = 3 Hours
// 8pm - Midnight = 4 hours

namespace BabysitterKata.Test
{
    public class CalculatorTest

    {
        private const int rateBeforeBed = 12;
        private const int rateAfterBed = 8;
        private const int rateAfterMidnight = 16;
        
        
        //method_condition_result

        [Fact]
        public void Calculator_WhenTHeHoursAreAfterMidnight_ReturnsTheNightlyRate()
        {
            const int hours = 1;
            var afterMidnight = new Calculator(hours, rateAfterMidnight);
            // Assert.Equal(afterMidnight.Balance, rateAfterMidnight);
            afterMidnight.Balance.Should().Be(rateAfterMidnight);
        }

        [Fact]
        public void Calculator_WhenHoursAreFromBedtimeToMidnight_ReturnsTheNightlyRate()
        {
            const int hours = 1;
            var afterBedtime = new Calculator(hours, rateAfterBed);
            Assert.Equal(afterBedtime.Balance, rateAfterBed);
        }

        [Fact]
        public void CalcBeforeBed()
        {
            const int hours = 1;
            //const int expectedRate = 12;
            var beforeBedtime = new Calculator(hours, rateBeforeBed);
            Assert.Equal(beforeBedtime.Balance, rateBeforeBed);
        }

        [Fact]
        public void TotalAfterMidnight()
        {
            const int hoursAfterMidnight = 4;
            const int expectedEarnings = 64;
            var afterMidnight = new Calculator(hoursAfterMidnight, rateAfterMidnight);
            Assert.Equal(afterMidnight.Balance, expectedEarnings);
        }

        [Fact]
        public void TotalBeforeMidnight()
        {
            const int hoursBeforeBed = 3;
            const int expectedEarnings = 68;
            const int hoursAfterBed = 4;
            var beforeBed = new Calculator(hoursBeforeBed, rateBeforeBed);
            var afterBed = new Calculator(hoursAfterBed, rateAfterBed);
            var actualEarnings = afterBed.Balance + beforeBed.Balance;
            Assert.Equal(actualEarnings, expectedEarnings);
        }
    }
}