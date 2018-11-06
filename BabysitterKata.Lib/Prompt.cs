using System;

namespace BabysitterKata.Lib
{
    public class Prompt
    {  
        public Prompt()
        {
           
            
            var calculator = new Calculator();
            Console.WriteLine("Did you work past midnight?");
            Helpers.questionHandler(Console.ReadLine());
            Console.WriteLine("What time did you start? Enter 5:15 example");
            var startTime = Time.ParseTime(Console.ReadLine());
            
            
            Console.WriteLine("What time did the kids go to bed??");
            var bedTime = Time.ParseTime(Console.ReadLine());

            var workedBeforeBedtime = calculator.calculateTimeRange(startTime, bedTime);
            
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