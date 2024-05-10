using CalcularTaxApp.Interface;

namespace CalcularTaxApp.Class
{
    public class CalcularTaxPorPais : ICalcularTax
    {
        public decimal CalcularTax(decimal income, decimal deduction, Pais pais)
        {

            decimal montoTax = (income - deduction) * (pais.porcentajeTax / 100);

            return montoTax;

        }
    }
}