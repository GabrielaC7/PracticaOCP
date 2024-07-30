namespace PracticaOCP
{
    public class IndiaTaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal taxableIncome)
        {
            decimal taxAmount = 0;
            if (taxableIncome <= 250000)
            {
                taxAmount = 0;
            }
            else if (taxableIncome <= 500000)
            {
                taxAmount = (taxableIncome - 250000) * 0.05m;
            }
            else if (taxableIncome <= 1000000)
            {
                taxAmount = (taxableIncome - 500000) * 0.2m + 12500;
            }
            else
            {
                taxAmount = (taxableIncome - 1000000) * 0.3m + 112500;
            }
            return taxAmount;
        }
    }
}
