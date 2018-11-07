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
            
            if (Helpers.AfterMidnightAnswer)
            {
                //Console.WriteLine("Late night! What time did you go home?");
                //var workedAfterMidnight = Time.ParseTime(Console.ReadLine());
                //var madeAfterMidnight = calculator.calculateTimeRange(something, workedAfterMidnight);
                //calculator.CalculateSubTotal(madeAfterMidnight, (int)Rates.AfterMidnight);
            }
            {
                Console.WriteLine("What time did you go home?");
                var endOfNight = Helpers.CheckValue(Console.ReadLine());
                var sample = calculator.calculateTimeRange(bedTime, endOfNight);
                calculator.CalculateSubTotal(sample, (int) Rates.AfterBedtime);
            }
            
            var totalMade = calculator.grandTotal;
            Console.WriteLine("You made: $" + totalMade);
        }
    }
}