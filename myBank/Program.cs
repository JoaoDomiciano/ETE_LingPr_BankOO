using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente contaDoJoao = new Cliente("Joao", 752, 752672, 120);
            Cliente contaDaBarbara = new Cliente("Barbara", 863, 863146, 100);

            Console.WriteLine(contaDoJoao.titular);
        }
    }
}
