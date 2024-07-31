using System;

namespace PracticaOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Impuestos");

            TaxCalculator taxCalculator = new TaxCalculator();

            decimal income = 50000;
            decimal deduction = 10000;

            string[] countries = { "India", "USA", "UK", "France" };

            foreach (var country in countries)
            {
                try
                {
                    decimal tax = taxCalculator.Calculate(income, deduction, country);
                    Console.WriteLine($"El impuesto para {country} es: {tax}");
                }
                catch (NotImplementedException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
