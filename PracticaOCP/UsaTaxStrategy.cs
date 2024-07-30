namespace PracticaOCP
{
    public class USATaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal taxableIncome)
        {
            decimal taxAmount = 0;
            if (taxableIncome <= 9875)
            {
                taxAmount = taxableIncome * 0.1m;
            }
            else if (taxableIncome <= 40125)
            {
                taxAmount = (taxableIncome - 9875) * 0.12m + 987.5m;
            }
            else if (taxableIncome <= 85525)
            {
                taxAmount = (taxableIncome - 40125) * 0.22m + 4617.5m;
            }
            else if (taxableIncome <= 163300)
            {
                taxAmount = (taxableIncome - 85525) * 0.24m + 14605.5m;
            }
            else
            {
                taxAmount = (taxableIncome - 163300) * 0.32m + 33271.5m;
            }
            return taxAmount;
        }
    }
}
