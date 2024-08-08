


namespace FlorestBank.Model;

internal class Conta
{
    public Conta(string titular, int numero, double saldo, TipoConta tipoConta)
    {
        TipoConta TipoContaUsuario;
        Titular = titular;
        Numero = numero;
        Saldo = saldo;
        Tipo = tipoConta;
    }

    public string Titular { get; set; }
    public int Numero { get; set; }
    public double Saldo { get; set; }

    public TipoConta Tipo { get; set; }

    public double Depositar(double deposito)
    {
        Saldo += deposito;
        return Saldo;
    }

    public double Sacar(double saque)
    {
        Saldo -= saque;
        return Saldo;
    }
}
