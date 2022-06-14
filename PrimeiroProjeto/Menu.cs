namespace GeraEstoque;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        DrawCanvas();
        ShowOptions();
        CadastrarProdutos.Start();


        var option = short.Parse(Console.ReadLine());//selecionar a opçao
        switch (option)
        {
            case 1: CadastrarProdutos.Start(); break;
            case 2: break;
            case 3: break;
            case 4: break;
            case 0: break;

            default: ShowOptions(); break;
        }


    }
    
    public static void DrawCanvas()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        //Console.ForegroundColor = ConsoleColor.DarkRed;

        PrintHorizontalLine();
        for (int i = 0; i < 25; i++)
        {
            Console.Write("|");

            for (int line = 0; line <= 50; line++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write(Environment.NewLine);
        }
        PrintHorizontalLine();
    }

    static void PrintHorizontalLine()
    {
        Console.Write("+");

        for (int i = 0; i <= 50; i++)
            Console.Write("-");

        Console.Write("+");
        Console.Write(Environment.NewLine);
    }
    //Exercicio 06
    static void ShowOptions()
    {
        Console.SetCursorPosition(5, 2);
        Console.WriteLine("Seja bem vindo(a) ao GeraEstoque 1.0");
        Console.SetCursorPosition(5, 4);
        Console.WriteLine("===================================");
        Console.SetCursorPosition(5, 5);
        Console.WriteLine("1 - Cadastrar Produto");
        Console.SetCursorPosition(5, 6);
        Console.WriteLine("2 - Editar Produto");
        Console.SetCursorPosition(5, 7);
        Console.WriteLine("3 - Excluir Produto");
        Console.SetCursorPosition(5, 8);
        Console.WriteLine("0 - Sair");

        Console.SetCursorPosition(5, 11);
        Console.Write(" Digite a Opçao: ");
        Console.ReadLine();
    }

}








