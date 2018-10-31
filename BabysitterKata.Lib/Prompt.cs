using System;

namespace BabysitterKata.Lib
{
    public class Prompt
    {  
        private const int RateBeforeBed = 12;
        private const int RateAfterBed = 8;
        private const int RateAfterMidnight = 16;

        public Prompt()
        {
            var calculator = new Calculator();
            Console.WriteLine("How many hours did you work before bedtime?");
            var workedBeforeBedtime = Convert.ToInt32(Console.ReadLine());
            var amountMadeBeforeBedtime = calculator.CalculateSubTotal(workedBeforeBedtime, RateBeforeBed);
            Console.WriteLine("How many hours did you work after bedtime? ");
            var workedAfterBedtime = Convert.ToInt32(Console.ReadLine());
            var amountMadeBeforeMidnight = calculator.CalculateSubTotal(workedAfterBedtime, RateAfterBed);
            Console.WriteLine("How many hours did you work after midnight?");
            var workedAfterMidnight = Convert.ToInt32(Console.ReadLine());
            var amountMadeAfterMidnight = calculator.CalculateSubTotal(workedAfterMidnight, RateAfterMidnight);
            var totalMade = calculator.grandTotal;
            Console.WriteLine("You made: $" + totalMade);
        }
    }
}