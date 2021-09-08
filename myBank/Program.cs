using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente contaDoJoao = new Cliente();
            contaDoJoao.titular = "Joao";
            contaDoJoao.agencia = 752;
            contaDoJoao.numero = 752672;
            contaDoJoao.saldo = 120;

            Cliente contaDaBarbara = new Cliente();
            contaDaBarbara.titular = "Barbara";
            contaDaBarbara.agencia = 863;
            contaDaBarbara.numero = 863146;
            contaDaBarbara.saldo = 100;
        }
    }
}
