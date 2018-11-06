using System;

namespace BabysitterKata.Lib
{
    public class Calculator
    {
         public Calculator()
        {
            grandTotal = 0;
        }

        public int grandTotal;

        public int Calculate(int hoursWorked, int hourlyRate)
        {
            return hourlyRate * hoursWorked;
        }

        public int CalculateSubTotal(int hoursWorked, int hourlyRate)
        {
            var subTotal = Calculate(hoursWorked, hourlyRate);
            AddToGrandTotal(subTotal);

            return subTotal;
        }

        private void AddToGrandTotal(int subTotal)
        {
            grandTotal += subTotal;
        }

        public int calculateTimeRange(int start, int end)
        {
            var date1 = new DateTime(2018, 1, 1, start, 0,0,0);
            var date2 = new DateTime(2018, 1, 1, end, 0,0,0);
            var interval = date2 - date1;
            return interval.Hours;
        }

        public void CalculateTimeRangeExample(int hours, int rate)
        {
            var amountMade = hours * rate;
            AddToGrandTotal(amountMade);
        }
    }

}