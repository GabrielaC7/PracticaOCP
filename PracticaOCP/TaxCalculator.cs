using System;
using System.Collections.Generic;

namespace PracticaOCP
{
    public class TaxCalculator
    {
        private readonly IDictionary<string, ITaxStrategy> _taxStrategies;

        public TaxCalculator()
        {
            _taxStrategies = new Dictionary<string, ITaxStrategy>
            {
                { "India", new IndiaTaxStrategy() },
                { "USA", new USATaxStrategy() },
                { "UK", new UKTaxStrategy() },
                { "France", new FranceTaxStrategy() }
                // Agregar más estrategias aquí
            };
        }

        public decimal Calculate(decimal income, decimal deduction, string country)
        {
            decimal taxableIncome = income - deduction;

            if (_taxStrategies.ContainsKey(country))
            {
                return _taxStrategies[country].CalculateTax(taxableIncome);
            }

            throw new NotImplementedException($"No tax strategy implemented for country: {country}");
        }
    }
}


