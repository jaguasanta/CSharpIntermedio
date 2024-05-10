
using CalcularTaxApp.Class;

namespace CalcularTaxApp.Interface
{
    public interface ICalcularTax
    {

        decimal CalcularTax(decimal income, decimal deduction, Pais pais);

    }
}
