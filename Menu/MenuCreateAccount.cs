using FlorestBank.Model;

namespace FlorestBank.Menu;

internal class MenuCreateAccount
{
    public void CriarContaCorrente(List<Conta> contas)
    {
        Console.Clear();
        Console.WriteLine($"---- Criar Conta Corrente ----");

        Console.Write("Nome do titular: ");
        string nomeTitulo = Console.ReadLine()!;

        Console.Write("Número de conta: ");
        int numeroConta = int.Parse(Console.ReadLine()!);

        Console.Write("Saldo: ");
        int saldo = int.Parse(Console.ReadLine()!);

        TipoConta contaCorrente = new TipoConta();

        Conta newConta = new Conta(nomeTitulo, numeroConta, saldo, contaCorrente);
        contas.Add(newConta);

        Console.WriteLine("\nAperte na tecla 'Enter' para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }

    public void CriarContaPoupanca(List<Conta> contas)
    {
        Console.Clear();
        Console.WriteLine($"---- Criar Conta Poupança ----");

        Console.Write("Nome do titular: ");
        string nomeTitulo = Console.ReadLine()!;

        Console.Write("Número de conta: ");
        int numeroConta = int.Parse(Console.ReadLine()!);

        Console.Write("Saldo: ");
        int saldo = int.Parse(Console.ReadLine()!);

        TipoConta contaPoupanca = new TipoConta();

        Conta newConta = new Conta(nomeTitulo, numeroConta, saldo, contaPoupanca);
        contas.Add(newConta);

        Console.WriteLine("\nAperte na tecla 'Enter' para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
