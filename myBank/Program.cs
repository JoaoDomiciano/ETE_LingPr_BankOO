using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {            
            Funcionario funcionarioAdonay = new Funcionario();
            funcionarioAdonay.Nome = "Adonay";
            funcionarioAdonay.CPF = "123.123.123-12";
            funcionarioAdonay.Cargo = "Vendedor";
            funcionarioAdonay.Salario = 1000;

            Funcionario funcionarioKilltiz = new Funcionario();
            funcionarioKilltiz.Nome = "Killtiz";
            funcionarioKilltiz.CPF = "456.456.456-45";
            funcionarioKilltiz.Cargo = "Vendedor";
            funcionarioKilltiz.Salario = 1000;

            Cliente contaDoJoaoDomiciano = new Cliente("Joao Domiciano", 752, 120, funcionarioAdonay);
            Cliente contaDaRafaelySantos = new Cliente("Rafaely Santos", 863, 100, funcionarioKilltiz);
            Cliente contaDaIsabelePereira = new Cliente("Isabele Pereira", 123, 150, funcionarioAdonay);

            Console.WriteLine("O funcionário Adonay ganhou R$" + funcionarioAdonay.Comissão + " de comissão.");
            Console.WriteLine("O funcionário Killtiz ganhou R$" + funcionarioKilltiz.Comissão + " de comissão.");
            Console.WriteLine("Foram criadas " + Cliente.TotalDeContasCriadas + " contas e será pago R$" + Cliente.TotalDeComissao + " de comissão.\r\n");

            Console.WriteLine("O saldo da conta do(a) " + contaDoJoaoDomiciano.Titular + " é R$" + contaDoJoaoDomiciano.Saldo + ".");
            Console.WriteLine("O saldo da conta do(a) " + contaDaRafaelySantos.Titular + " é R$" + contaDaRafaelySantos.Saldo + ".");
            Console.WriteLine("O saldo da conta do(a) " + contaDaIsabelePereira.Titular + " é R$" + contaDaIsabelePereira.Saldo + ".\r\n");

            contaDaRafaelySantos.Depositar(50);
            Console.WriteLine("Rafaely depositou R$50. Seu novo saldo é R$" + contaDaRafaelySantos.Saldo);

            contaDaIsabelePereira.Sacar(50);
            Console.WriteLine("Isabele sacou R$50. Seu novo saldo é R$" + contaDaIsabelePereira.Saldo + ".\r\n");

            contaDaIsabelePereira.Transferir(100, contaDoJoaoDomiciano);
            Console.WriteLine("Isabele transferiu R$100 para a conta do João. Seu novo saldo é R$" + contaDaIsabelePereira.Saldo);
            Console.WriteLine("O saldo da conta do(a) " + contaDoJoaoDomiciano.Titular + " é R$" + contaDoJoaoDomiciano.Saldo + ".");
        }
    }
}
