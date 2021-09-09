public class Cliente{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo;

    public Cliente () {};
    public Cliente (string titular, int agencia, int numero, double saldo)
    {
        this.titular = titular;
        this.agencia = agencia;
        this.numero = numero;
        this.saldo = saldo;
    }
}