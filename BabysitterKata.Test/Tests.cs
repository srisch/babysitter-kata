using System.Runtime.InteropServices;
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
        private const int rateBeforeBedtime = 12;
        private const int rateAfterBedtime = 8;
        private const int rateAfterMidnight = 16;
        
        //method_condition_result

        [Fact]
        public void Calculator_WhenTheHoursAreAfterMidnight_ReturnsAmountMadeDuringTimePeriod()
        {
            var calculator = new Calculator();
            const int hours = 1;
            var afterMidnight = calculator.Calculate(hours, rateAfterMidnight);
            const int expectedRate = hours * rateAfterMidnight;
            afterMidnight.Should().Be(expectedRate);
        }

        [Fact]
        public void Calculator_WhenTheHoursAreFromBedtimeToMidnight_ReturnsAmountMadeDuringTimePeriod()
        {
            var calculator = new Calculator();
            const int hours = 1;
            var afterBedtime = calculator.Calculate(hours, rateAfterBedtime);
            const int expectedRate = hours * rateAfterBedtime;
            afterBedtime.Should().Be(expectedRate);
        }

        [Fact]
        public void Calculator_WhenTheHoursAreBeforeBedtime_ReturnsAmountMadeDuringTimePeriod()
        {
            var calculator = new Calculator();
            const int hours = 1;
            var beforeBedtime = calculator.Calculate(hours, rateBeforeBedtime);
            const int expectedRate = hours * rateBeforeBedtime;
            beforeBedtime.Should().Be(expectedRate);
        }

        //[Fact]
//        public void TotalAfterMidnight()
//        {
//            const int hoursAfterMidnight = 4;
//            const int expectedEarnings = 64;
//            var afterMidnight = new Calculator(hoursAfterMidnight, rateAfterMidnight);
//            Assert.Equal(afterMidnight.Balance, expectedEarnings);
//        }
//
//        [Fact]
//        public void TotalBeforeMidnight()
//        {
//            const int hoursBeforeBed = 3;
//            const int expectedEarnings = 68;
//            const int hoursAfterBed = 4;
//            var beforeBed = new Calculator(hoursBeforeBed, rateBeforeBedtime);
//            var afterBed = new Calculator(hoursAfterBed, rateAfterBed);
//            var actualEarnings = afterBed.Balance + beforeBed.Balance;
//            Assert.Equal(actualEarnings, expectedEarnings);
//        }
    }
}