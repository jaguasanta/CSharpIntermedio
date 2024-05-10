using CalcularTaxApp.Class;

class Program
{
    static void Main(string[] args)
    {
        string codigoPais = "RD";
        decimal porcTax = 25;
        decimal income = 10000;
        decimal deduction = 8000;

        Pais _pais = new Pais(codigoPais, porcTax);

        CalcularTaxPorPais calcularTaxPorPais = new CalcularTaxPorPais();

        Console.WriteLine("Tax: " + _pais.codigoPais + " " + calcularTaxPorPais.CalcularTax(income, deduction, _pais));

    }
}

