using System.Globalization;
namespace poo_csharp
{
    internal class Conta
    {

        public string Nome { get; set; }
        public string Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string nome, string numero)
        {
            Nome = nome;
            Numero = numero;
          
        }

        public Conta(string nome, string numero, double saldo) : this(nome, numero)
        {
            Saldo = saldo;
        }


        public void DepositoConta(double valor)
        {
            Saldo += valor;
        }

        public void SaqueConta(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return
                "Titular: " + Nome + " "
                + "Número: " + Numero + " "
                + "Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
