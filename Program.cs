Console.Clear();
string[] nomes = new string[10];
float[] precos = new float[10];
bool[] promocoes = new bool[10];
int qntdProdutos = 0;

while (true)
{
    Console.WriteLine($"");
    Console.WriteLine($"=== GERENCIAMENTO DE PRODUTOS ===");
    Console.WriteLine("1. Cadastrar Produto");
    Console.WriteLine("2. Listar Produtos");
    Console.WriteLine("0. Sair");

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Cadastro do Produto");

            if (qntdProdutos >= 10)
            {
                Console.WriteLine($"Nao e possivel cadastrar mais produtos");

            }

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            nomes[qntdProdutos] = nome;

            Console.Write("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            precos[qntdProdutos] = preco;

            Console.Write("Em promoção (s/n): ");
            bool promocao = Console.ReadLine().ToLower() == "s";
            promocoes[qntdProdutos] = promocao;

            Console.WriteLine("Produto cadastrado com sucesso!");
            qntdProdutos++;

            Thread.Sleep(1500);
            
            Console.Clear();
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
            
            break;
        case 2:
            Console.WriteLine("Lista de Produtos");

            if (qntdProdutos == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado!");

            }
            for (int i = 0; i < qntdProdutos; i++)
            {
                Console.WriteLine($"Nome: {nomes[i]}, Preço: R${precos[i]}, Promoção: {(promocoes[i] ? "Sim" : "Não")}");

            }
            break;


        case 0:
            Console.WriteLine("Obrigado por utilizar o programa!");
            break;
        default:
            Console.WriteLine($"Opcao invalida. tente novante ");

            break;
    }



}


static void Cadastro(int qntdProdutos)
{


}




