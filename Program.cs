using FlorestBank.Model;
using FlorestBank.Menu;
using System;
TipoConta contaCorrente = new TipoConta();
TipoConta contaPoupanca = new TipoConta();
List<Conta> contas = new List<Conta>{
    new Conta("Thiago Alcântara", 1327, 100f, contaCorrente),
    new Conta("Felipe Santos", 3219, 1200f, contaPoupanca),
    new Conta("Hugo Boss", 8956, 210f, contaCorrente),
    new Conta("Mateus Figueiredo", 4389, 8000f, contaPoupanca)
};
void ExibirMenu()
{
    Console.Clear();
    Menu.Logo();
    Console.WriteLine($"\n1 - Acessar Conta\n2 - Criar Conta\n3- Listas Contas\n4 Remover Conta");
    Console.Write("Digite a opção que deseja realizar: ");
    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            ExibirMenu();
            break;
        case 2:
            Menu.ExibirTipoCriacaoDeConta(contas);
            ExibirMenu();
            break;
        case 3:
            Menu.ExibirOpcaoListaConta(contas);
            ExibirMenu();
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
    }
}
ExibirMenu();