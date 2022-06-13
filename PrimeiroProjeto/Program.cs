using System;
using System.Globalization;

namespace GeraEstoque;

class Program
{
    public static void Main(string[] args)
    {
        //Menu menu = new Menu(); 

        CadastrarProdutos produtos = new CadastrarProdutos();


        //Exercicio 06
        Console.SetCursorPosition(5, 2);
        Console.WriteLine("Seja bem vindo(a) ao GeraEstoque 1.0");
        Console.SetCursorPosition(5, 4);
        Console.WriteLine("===================================");
        Console.SetCursorPosition(5, 5);
        Console.WriteLine("1 - Cadastrar Produto");
        Console.SetCursorPosition(5, 6);
        Console.WriteLine("2 - Editar Produto");
        Console.SetCursorPosition(5,7);
        Console.WriteLine("3 - Excluir Produto");
        Console.SetCursorPosition(5, 8);
        Console.WriteLine("0 - Sair");
        Console.SetCursorPosition(5, 11);
        Console.Write(" Digite a Opçao: ");
        Console.ReadLine();

        //exercicio 07
        Console.Clear();
        Console.WriteLine("Cadastro de Produtos");
        Console.WriteLine("=====================");
        Console.Write("Digite o nome do produto: ");
        produtos.Nome = Console.ReadLine();
        Console.Write("Digite a quantidade em estoque: ");
        produtos.Quantidade = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor do produto: ");
        produtos.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("");

        Console.WriteLine();
        Console.WriteLine("Dados do Cadastro: " + produtos);
        //exercicio 08
       

       

    }

    
}