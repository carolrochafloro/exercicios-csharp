using System;
using System.Globalization;

namespace poo_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o número da conta com 4 dígitos: ");
            string numConta = Console.ReadLine();

            while (numConta.Length != 4 || !VerificarDigitos(numConta))
            {
                Console.Write("O número da conta precisa ter 4 dígitos. Insira o número da conta com 4 dígitos: ");
                numConta = Console.ReadLine();
            }

            Console.Write("Insira o nome do titular: ");
            string nome = Console.ReadLine();

            Console.Write("Deseja realizar um depósito inicial? s/n ");
            char deposito = char.Parse(Console.ReadLine());

            if (deposito != 's' && deposito != 'n')
            {
                Console.Write("Opção inválida. Deseja realizar um depósito inicial? s/n ");
                deposito = char.Parse(Console.ReadLine());
            }

            Conta c1 = new Conta(nome, numConta);

            if (deposito == 's')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c1 = new Conta(nome, numConta, valor);
            }

            ExibirDadosDaConta(c1);

            Console.Write("Deseja realizar uma operação na conta? s/n ");
            char operacao;

            while (!char.TryParse(Console.ReadLine(), out operacao) || (operacao != 's' && operacao != 'n'))
            {
                Console.Write("Opção inválida. Deseja realizar uma operação na conta? s/n ");
            }

            if (operacao == 'n')
            {
                Console.WriteLine("Operação finalizada");
                Console.ReadKey();
            }

            while (operacao == 's')
            {
                Console.WriteLine("Selecione a operação: ");
                Console.WriteLine("1- Depósito");
                Console.WriteLine("2- Saque");
                int escolha = int.Parse(Console.ReadLine());

                if (escolha != 1 && escolha != 2)
                {
                    Console.Write("Opção inválida.");
                    Console.WriteLine("Selecione a operação: ");
                    Console.WriteLine("1- Depósito");
                    Console.WriteLine("2- Saque");
                    escolha = int.Parse(Console.ReadLine());
                }

                if (escolha == 1)
                {
                    Console.Write("Digite o valor a ser depositado: ");
                    double depositar = double.Parse(Console.ReadLine());

                    c1.DepositoConta(depositar);
                    ExibirDadosDaConta(c1);

                }

                if (escolha == 2)
                {
                    Console.Write("Digite o valor a ser sacado: ");
                    double sacar = double.Parse(Console.ReadLine());

                    c1.SaqueConta(sacar);
                    ExibirDadosDaConta(c1);
                }

                Console.Write("Deseja realizar uma operação na conta? s/n ");
                while (!char.TryParse(Console.ReadLine(), out operacao) || (operacao != 's' && operacao != 'n'))
                {
                    Console.Write("Opção inválida. Deseja realizar uma operação na conta? s/n ");
                }
                Console.WriteLine("Operação finalizada");
                Console.ReadKey();

            }


            Console.ReadKey();
        }

        static bool VerificarDigitos(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }

            }

            return true;
        }

        static void ExibirDadosDaConta(Conta conta)
        {
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
        }
    }
}
