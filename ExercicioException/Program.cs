using System;
using System.Globalization;
using ExercicioException.Entidades;
using ExercicioException.Entidades.exception;

namespace ExercicioException {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados da conta: ");
            Console.Write("Numero da conta: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Titular: ");
            string nome = Console.ReadLine();
            Console.Write("Saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Limite de saque: ");
            double LimiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta conta = new Conta(n, nome, saldo, LimiteSaque);

            Console.Write("Entre com o valor so saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try {
                conta.Saque(saque);
                Console.WriteLine(conta);

            }
            catch (SaqueException e) {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
