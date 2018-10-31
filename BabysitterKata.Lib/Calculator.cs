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
    }

}