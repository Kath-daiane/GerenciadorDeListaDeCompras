using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de compras
        List<string> listaCompras = new List<string>();

        // Adicionando 5 itens à lista
        Console.Write("Digite o nome do item a adicionar: ");
        string item1 = Console.ReadLine();
        listaCompras.Add(item1);
        Console.WriteLine($"Item '{item1}' adicionado à lista.");

        Console.Write("Digite o nome do item a adicionar: ");
        string item2 = Console.ReadLine();
        listaCompras.Add(item2);
        Console.WriteLine($"Item '{item2}' adicionado à lista.");

        Console.Write("Digite o nome do item a adicionar: ");
        string item3 = Console.ReadLine();
        listaCompras.Add(item3);
        Console.WriteLine($"Item '{item3}' adicionado à lista.");

        Console.Write("Digite o nome do item a adicionar: ");
        string item4 = Console.ReadLine();
        listaCompras.Add(item4);
        Console.WriteLine($"Item '{item4}' adicionado à lista.");

        Console.Write("Digite o nome do item a adicionar: ");
        string item5 = Console.ReadLine();
        listaCompras.Add(item5);
        Console.WriteLine($"Item '{item5}' adicionado à lista.");

        // Exibir todos os itens na lista
        Console.WriteLine("\nItens na lista de compras:");
        foreach (var item in listaCompras)
        {
            Console.WriteLine($"- {item}");
        }

        // Remover um item específico
        Console.Write("\nDigite o nome do item a remover: ");
        string itemRemover = Console.ReadLine();

        if (listaCompras.Contains(itemRemover))
        {
            listaCompras.Remove(itemRemover);
            Console.WriteLine($"Item '{itemRemover}' removido da lista.");
        }
        else
        {
            Console.WriteLine($"Item '{itemRemover}' não encontrado na lista.");
        }

        // Exibir itens restantes na lista
        Console.WriteLine("\nItens restantes na lista de compras:");
        if (listaCompras.Count > 0)
        {
            foreach (var item in listaCompras)
            {
                Console.WriteLine($"- {item}");
            }
        }
        else
        {
            Console.WriteLine("A lista está vazia.");
        }
    }
}
