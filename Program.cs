using System;

namespace Projetobanco
{
    class Program
    {
        static void Main(string[] args)
        {


            ContaBancaria c1;
            c1 = new ContaBancaria();

            Console.WriteLine("Numero da conta: ");
            int numero_conta = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();


            Console.WriteLine("Deposito Inicial? [S/N]");
            string tem_dep_ini = Console.ReadLine();

            if (tem_dep_ini == "s" || tem_dep_ini == "S")
            {
                Console.WriteLine("Digite o Deposito Inicial");
                double dep_ini = double.Parse(Console.ReadLine());
                c1 = new ContaBancaria(numero_conta, nome, dep_ini);
            }
            else
            {
                c1 = new ContaBancaria(numero_conta, nome);
            }

            Console.WriteLine(c1);

            Console.WriteLine("Deposito: ");
            double deposito = double.Parse(Console.ReadLine());
            c1.Deposito(deposito);
            Console.WriteLine(c1);


            Console.WriteLine("Saque: ");
            c1.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine(c1);


        }
    }
}
