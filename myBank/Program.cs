using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {            
            Funcionario funcionarioFernando = new Funcionario();
            funcionarioFernando.Nome = "Fernando";
            funcionarioFernando.CPF = "123.123.123-12";
            funcionarioFernando.Cargo = "Vendedor";
            funcionarioFernando.Salario = 1000;

            Funcionario funcionarioGustavo = new Funcionario();
            funcionarioGustavo.Nome = "Gustavo";
            funcionarioGustavo.CPF = "456.456.456-45";
            funcionarioGustavo.Cargo = "Vendedor";
            funcionarioGustavo.Salario = 1000;

            Cliente contaDoJoao = new Cliente("Joao", 752, 120, funcionarioFernando);
            Cliente contaDaBarbara = new Cliente("Barbara", 863, 100, funcionarioGustavo);
            Cliente contaDaMaria = new Cliente("Maria", 123, 150, funcionarioFernando);

            Console.WriteLine("Comissão FERNANDO: " + funcionarioFernando.Comissão);
            Console.WriteLine("Comissão GUSTAVO: " + funcionarioGustavo.Comissão);
        }
    }
}
