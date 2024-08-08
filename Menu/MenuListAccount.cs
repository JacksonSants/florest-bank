using FlorestBank.Model;

namespace FlorestBank.Menu;

internal class MenuListAccount
{
    public void OrdenarContaPorNome(List<Conta> contas)
    {
        Console.Clear();
        if (contas.Count != 0)
        {
            Console.WriteLine("---- Contas registradas no sistema ----");

            var ordenarPorNome = contas.OrderBy(a => a.Titular);

            foreach (var conta in ordenarPorNome)
            {
                Console.WriteLine($"\nNome do titular: {conta.Titular}");
                Console.WriteLine($"Número da conta: {conta.Numero}");
                Console.WriteLine($"Saldo: {conta.Saldo}");

            }
            Console.WriteLine("\nAperte na tecla 'Enter' para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Nenhuma conta registrada no sistema.");
            Console.WriteLine("\nAperte na tecla 'Enter' para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
    }

    public void OrdenarContaPorNumero(List<Conta> contas)
    {
        Console.Clear();
        if (contas.Count != 0)
        {
            Console.WriteLine("---- Contas registradas no sistema ----");

            var ordenarPorNumero = contas.OrderBy(a => a.Numero);
            foreach (var conta in ordenarPorNumero)
            {
                Console.WriteLine($"\nConta: {conta.Tipo.TipoContaUsuario}");
                Console.WriteLine($"\nNome do titular: {conta.Titular}");
                Console.WriteLine($"Número da conta: {conta.Numero}");
                Console.WriteLine($"Saldo: {conta.Saldo}");

            }
            Console.WriteLine("\nAperte na tecla 'Enter' para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Nenhuma conta registrada no sistema.");
            Console.WriteLine("\nAperte na tecla 'Enter' para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }

}
