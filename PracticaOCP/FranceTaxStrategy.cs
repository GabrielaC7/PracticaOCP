namespace PracticaOCP
{
    public class FranceTaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal taxableIncome)
        {
            decimal taxAmount = 0;
            if (taxableIncome <= 10064)
            {
                taxAmount = 0;
            }
            else if (taxableIncome <= 25659)
            {
                taxAmount = (taxableIncome - 10064) * 0.11m;
            }
            else if (taxableIncome <= 73369)
            {
                taxAmount = (taxableIncome - 25659) * 0.3m + 1715.5m;
            }
            else if (taxableIncome <= 157806)
            {
                taxAmount = (taxableIncome - 73369) * 0.41m + 14095.5m;
            }
            else
            {
                taxAmount = (taxableIncome - 157806) * 0.45m + 45717.94m;
            }
            return taxAmount;
        }
    }
}
