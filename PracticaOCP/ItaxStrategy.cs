namespace PracticaOCP
{
    public interface ITaxStrategy
    {
        decimal CalculateTax(decimal taxableIncome);
    }
}
