using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente contaDoJoao = new Cliente("Joao", 752, 752672, 120);
            Cliente contaDaBarbara = new Cliente("Barbara", 863, 863146, 100);
            Cliente contaDaMaria = new Cliente("Maria", 123, 267254, 150);

            Console.WriteLine("O titular da conta é: " + contaDaBarbara.titular);
            Console.WriteLine("O titular da conta é: " + contaDoJoao.titular);
            Console.WriteLine("O titular da conta é: " + contaDaMaria.titular);

            contaDaBarbara.Sacar(50);
            contaDaMaria.Sacar(20);

            Console.WriteLine("O saldo da conta da Barbara é: " + contaDaBarbara.saldo);
            Console.WriteLine("O saldo da conta da Maria é: " + contaDaMaria.saldo);

            contaDaBarbara.Depositar(20);
            Console.WriteLine("O saldo da conta da Barbara é: " + contaDaBarbara.saldo);

            contaDaBarbara.Transferir(100, contaDoJoao);
            Console.WriteLine("O saldo da conta da Barbara é: " + contaDaBarbara.saldo);
            Console.WriteLine("O saldo da conta do João é: " + contaDoJoao.saldo);
        }
    }
}
