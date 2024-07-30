using System;

namespace PracticaOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Impuestos");

            // Crear una instancia de TaxCalculator
            TaxCalculator taxCalculator = new TaxCalculator();

            // Ejemplo de uso con datos ficticios
            decimal income = 50000;
            decimal deduction = 10000;

            // Lista de países para los cuales se calculará el impuesto
            string[] countries = { "India", "USA", "UK", "France" };

            foreach (var country in countries)
            {
                try
                {
                    // Calcular el impuesto para cada país
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
