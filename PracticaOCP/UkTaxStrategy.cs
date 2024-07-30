using PracticaOCP;

namespace PracticaOCP
{
    public class UKTaxStrategy : ITaxStrategy
{
    public decimal CalculateTax(decimal taxableIncome)
    {
        decimal taxAmount = 0;
        if (taxableIncome <= 12500)
        {
            taxAmount = 0;
        }
        else if (taxableIncome <= 50000)
        {
            taxAmount = (taxableIncome - 12500) * 0.2m;
        }
        else if (taxableIncome <= 150000)
        {
            taxAmount = (taxableIncome - 50000) * 0.4m + 7500;
        }
        else
        {
            taxAmount = (taxableIncome - 150000) * 0.45m + 47500;
        }
        return taxAmount;
    }
}
}
