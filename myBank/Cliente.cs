public class Cliente{
    
    public string Titular { get;set; }
    public int Agencia { get;set; }
    public int Conta { get;set; } 

    public static int TotalDeContasCriadas { get;set; }
    private double _saldo;
    public double Saldo {
        get{
            return this._saldo;
        }
        set{
            if (value >= 0){
                this._saldo = value;
            }
        }
    }
     public Cliente() {}

    public Cliente(string cliente_titular, int cliente_agencia, double cliente_saldo)
    { 
        Titular = cliente_titular;
        Agencia = cliente_agencia;
        Saldo = cliente_saldo;

        TotalDeContasCriadas ++;
    }

    public bool Sacar (double valor)
    {
        if(this.Saldo < valor){
            return false;
        }
        else{
            this.Saldo -= valor;
            return true;
        }
    }

    public void Depositar (double valor)
    {
        this.Saldo += valor;
    }

    public bool Transferir (double valor, Cliente contaDestino){
        if (this.Saldo < valor){
            return false;
        }else{
            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }
    }
}