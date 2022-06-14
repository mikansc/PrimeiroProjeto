
namespace GeraEstoque
{
    class CadastrarProdutos
    {
       
        //variaveis
        public string? nome;
        public int quantidadeEmEstoque;
        public double valorCompra;
        public double valorVenda;

        public static void Start()
        {
            Console.Clear();
            CadastrarProdutos produtos = new CadastrarProdutos();

            //exercicio 07
            Console.Clear();
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Cadastro de Produtos");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("=====================");
            Console.SetCursorPosition(5, 6);
            Console.Write("Digite o nome do produto: ");
            produtos.nome = Console.ReadLine();

            Console.SetCursorPosition(5, 7);
            Console.Write("Digite a quantidade em estoque: ");
            produtos.quantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(5, 8);
            Console.Write("Digite o valor de compras do produto: ");
            produtos.valorCompra = double.Parse(Console.ReadLine());

            Console.SetCursorPosition(5, 9);
            Console.Write("Digite o valor de venda do produto: ");
            produtos.valorVenda = double.Parse(Console.ReadLine());

            //exercicio09


            Guid id = Guid.NewGuid();
            

            printInfProduto(id, produtos.nome, produtos.quantidadeEmEstoque, produtos.valorCompra, produtos.valorVenda);


        }
        static void printInfProduto(Guid id, string nome, int qtd, double compra, double venda)
        {

            Console.Clear();
            Console.WriteLine("Produto cadastrado com sucesso!");

            Console.Clear();
            Menu.DrawCanvas(); 

            Console.SetCursorPosition(2, 4);
            Console.WriteLine("ID:" + id);
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Nome do Produto:" + nome);
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("Quantidade em Estoque:" + qtd);
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("Valor de Compra: R$ " + compra);
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("Valor de Venda: R$ " + venda);
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
            Console.ReadLine();
            Menu.Show();
        }
       
    }


}

