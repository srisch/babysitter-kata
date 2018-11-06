using System;

namespace BabysitterKata.Lib
{
    public class Prompt
    {  
        public Prompt()
        {
            DateTime date1 = new DateTime(2018, 1, 1, 5, 0,0,0);
            DateTime date2 = new DateTime(2018, 1, 1, 6, 30,0,0);
            TimeSpan interval = date2 - date1;
            Console.WriteLine(interval.Hours);
            
            var calculator = new Calculator();
            Console.WriteLine("Did you work past midnight?");
            Helpers.questionHandler(Console.ReadLine());
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