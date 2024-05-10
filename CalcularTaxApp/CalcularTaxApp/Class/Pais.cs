using CalcularTaxApp.Interface;

namespace CalcularTaxApp.Class
{
    public class Pais
    {
        public string codigoPais { get; set; }

        public decimal porcentajeTax { get; set; }

        public Pais(string CodigoPais, decimal PorcentajeTax)
        {

            this.codigoPais = CodigoPais;
            this.porcentajeTax = PorcentajeTax;
        }

    }
}
