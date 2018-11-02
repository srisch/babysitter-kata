using System;

namespace BabysitterKata.Lib
{
    public class Prompt
    {  
        public Prompt()
        {
            var calculator = new Calculator();
            Console.WriteLine("How many hours did you work before bedtime?");
            var workedBeforeBedtime = Helpers.CheckValue(Console.ReadLine());
            calculator.CalculateSubTotal(workedBeforeBedtime, (int)Rates.BeforeBedtime);
            Console.WriteLine("How many hours did you work after bedtime? ");
            var workedAfterBedtime = Helpers.CheckValue(Console.ReadLine());
            calculator.CalculateSubTotal(workedAfterBedtime, (int)Rates.AfterBedtime);
            Console.WriteLine("How many hours did you work after midnight?");
            var workedAfterMidnight = Helpers.CheckValue(Console.ReadLine());
            calculator.CalculateSubTotal(workedAfterMidnight, (int)Rates.AfterMidnight);
            var totalMade = calculator.grandTotal;
            Console.WriteLine("You made: $" + totalMade);
        }
    }
}