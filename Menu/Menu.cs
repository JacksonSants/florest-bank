using FlorestBank.Model;
using System;

namespace FlorestBank.Menu;
internal class Menu
{
    public static void Logo()
    {
        Console.WriteLine(@"
▒█▀▀▀ █░░ █▀▀█ █▀▀█ █▀▀ █▀▀ ▀▀█▀▀ 　 ▒█▀▀█ █▀▀█ █▀▀▄ █░█ 
▒█▀▀▀ █░░ █░░█ █▄▄▀ █▀▀ ▀▀█ ░░█░░ 　 ▒█▀▀▄ █▄▄█ █░░█ █▀▄ 
▒█░░░ ▀▀▀ ▀▀▀▀ ▀░▀▀ ▀▀▀ ▀▀▀ ░░▀░░ 　 ▒█▄▄█ ▀░░▀ ▀░░▀ ▀░▀");
        Console.WriteLine("Bem vindo ao Florest Bank!\n");
    }

    public static void ExibirTipoCriacaoDeConta(List<Conta> contas)
    {
        Console.WriteLine($"---- Criar Conta ----");
        Console.WriteLine($"1 - Conta Corrente\n2 - Conta Poupança");

        Console.Write($"Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 1:
                MenuCreateAccount menu1 = new MenuCreateAccount();
                menu1.CriarContaCorrente(contas);
                break;
            case 2:
                MenuCreateAccount menu2 = new MenuCreateAccount();
                menu2.CriarContaPoupanca(contas);
                break;
        }
    }

    internal static void ExibirOpcaoListaConta(List<Conta> contas)
    {
        Console.WriteLine($"---- Exibir Contas ----");
        Console.WriteLine($"\n1 - Ordernar contas por Nome\n2 - Ordernar contas por Número da conta");

        Console.Write($"Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 1:
                MenuListAccount menu1 = new MenuListAccount();
                menu1.OrdenarContaPorNome(contas);
                break;
            case 2:
                MenuListAccount menu2 = new MenuListAccount();
                menu2.OrdenarContaPorNumero(contas);
                break;
        }
    }
}
