namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                Console.WriteLine("Sistema de Gerenviamento de Biblioteca");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros ");
                Console.WriteLine("3. Buscar Livroo por Título");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();
                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o título do livro: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Digite o autor do livro: ");
                        string autor = Console.ReadLine();
                        Console.Write("Digite o ano de publicação do livro: ");
                        int anoPublicacao = int.Parse(Console.ReadLine());
                        Livro livro = new Livro(titulo, autor, anoPublicacao);
                        biblioteca.AdicionarLivro(livro);
                        break;

                    case "2":
                        biblioteca.ListarLivros();
                        break;
                    
                    case "3":
                        Console.Write("Digite o tituloa do livro: ");
                        string tituloBusca = Console.ReadLine();
                        biblioteca.BuscarLivroPorTitulo(tituloBusca);
                        break;
                        
                    case "4":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente! ");
                        break;

                }

            }
            
        }
    }
}
