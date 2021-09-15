public class Cliente{
    
    public string titular; 
    public int agencia;
    public int conta; 
    public double saldo;

    public Cliente() {}

    public Cliente(string cliente_titular, int cliente_agencia, int cliente_conta, double cliente_saldo)
    { 
        titular = cliente_titular;
        agencia = cliente_agencia;
        conta = cliente_conta;
        saldo = cliente_saldo;
    }

    public bool Sacar (double valor)
    {
        if(this.saldo < valor){
            return false;
        }
        else{
            this.saldo -= valor;
            return true;
        }
    }

    public void Depositar (double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir (double valor, Cliente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }
    }

}