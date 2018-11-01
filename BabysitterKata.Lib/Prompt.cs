using System;

namespace BabysitterKata.Lib
{
    public class Prompt
    {  
        public Prompt()
        {
            var calculator = new Calculator();
            Console.WriteLine("How many hours did you work before bedtime?");
            var workedBeforeBedtime = Convert.ToInt32(Console.ReadLine());
            var amountMadeBeforeBedtime = calculator.CalculateSubTotal(workedBeforeBedtime, (int)Rates.BeforeBedtime);
            Console.WriteLine("How many hours did you work after bedtime? ");
            var workedAfterBedtime = Convert.ToInt32(Console.ReadLine());
            var amountMadeBeforeMidnight = calculator.CalculateSubTotal(workedAfterBedtime, (int)Rates.AfterBedtime);
            Console.WriteLine("How many hours did you work after midnight?");
            var workedAfterMidnight = Convert.ToInt32(Console.ReadLine());
            var amountMadeAfterMidnight = calculator.CalculateSubTotal(workedAfterMidnight, (int)Rates.AfterMidnight);
            var totalMade = calculator.grandTotal;
            Console.WriteLine("You made: $" + totalMade);
        }
    }
}