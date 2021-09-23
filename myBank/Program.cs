using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente contaDoJoao = new Cliente("Joao", 752, 120);
            Cliente contaDaBarbara = new Cliente("Barbara", 863, 100);
            Cliente contaDaMaria = new Cliente("Maria", 123, 150);

            Console.WriteLine("O número da conta da Barbara é: " + contaDaBarbara.Conta);
            Console.WriteLine("O saldo da conta da Barbara é: " + contaDaBarbara.Saldo);
            Console.WriteLine("O número da conta da Joao é: " + contaDoJoao.Conta);
            Console.WriteLine("O saldo da conta do Joao é: " + contaDoJoao.Saldo);

            Console.WriteLine("O saldo da conta do Joao é: " + Cliente.TotalDeContasCriadas);
        }
    }
}
