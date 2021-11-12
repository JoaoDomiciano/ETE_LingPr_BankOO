using System;
namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {            
            Gerente gerenteCachorrinho = new Gerente
            {
                Nome = "Cachorrinho_Pancudo",
                CPF = "111.111.111-11",
                Salario = 7000
            };

            Vendedor funcionarioGabriel = new Vendedor
            {
                Nome = "Gabriel",
                CPF = "222.222.222-22",
                Salario = 3000
            };

            Vendedor funcionarioKilltiz = new Vendedor
            {
                Nome = "Killtiz",
                CPF = "333.333.333-33",
                Salario = 2000
            };

            Vendedor funcionarioAdonay = new Vendedor
            {
                Nome = "Adonay",
                CPF = "444.444.444-44",
                Salario = 1000
            };

            Cliente contaDoJoaoDomiciano = new Cliente("Joao Domiciano", 752, 120, funcionarioGabriel);
            Cliente contaDaRafaelySantos = new Cliente("Rafaely Santos", 863, 100, funcionarioKilltiz);
            Cliente contaDaIsabelePereira = new Cliente("Isabele Pereira", 123, 150, funcionarioAdonay);

            Console.WriteLine("\r\nO vendedor " + funcionarioGabriel.Nome + " ganha de bonificação anual R$" + funcionarioGabriel.RemuneracaoTotal(funcionarioGabriel.Bonificacao) + "\r\nE sua remuneração anual é de R$ " + funcionarioGabriel.RemuneracaoTotal(funcionarioGabriel.Salario) + "\r\nPor Fim ele terá "+ funcionarioGabriel.CalcularFerias() +" dias de ferias.\r\n");
            Console.WriteLine("\r\nO vendedor " + funcionarioKilltiz.Nome + " ganha de bonificação anual R$" + funcionarioKilltiz.RemuneracaoTotal(funcionarioKilltiz.Bonificacao) + "\r\nE sua remuneração anual é de R$ " + funcionarioKilltiz.RemuneracaoTotal(funcionarioKilltiz.Salario) + "\r\nPor Fim ele terá "+ funcionarioKilltiz.CalcularFerias() +" dias de ferias.\r\n");
            Console.WriteLine("\r\nO vendedor " + funcionarioAdonay.Nome + " ganha de bonificação anual R$" + funcionarioAdonay.RemuneracaoTotal(funcionarioAdonay.Bonificacao) + "\r\nE sua remuneração anual é de R$ " + funcionarioAdonay.RemuneracaoTotal(funcionarioAdonay.Salario) + "\r\nPor Fim ele terá "+ funcionarioAdonay.CalcularFerias() +" dias de ferias.\r\n");
            
            /*Console.WriteLine("O funcionário Killtiz ganhou R$" + funcionarioKilltiz.Comissão + " de comissão.");
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
        */
        }
    }
}
