using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Biblioteca
    {
        private List<Livro> livros = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
            Console.WriteLine("Livro adicionado com sucesso");
        }

        public void ListarLivros()
        {
            if (livros.Count == 0) 
            {
                Console.WriteLine("A Biblioteca está vazia!");
                Console.ReadKey();
            }else
            {
                foreach (var livro in livros)
                { 
                    Console.Write(livro);
                    Console.ReadKey();
                
                }
            }

        }

        public void BuscarLivroPorTitulo(string titulo)
        {
            var livroEncontrado = livros.Find(Livro => Livro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            
            if (livroEncontrado != null )
            {
                Console.WriteLine(livroEncontrado);
                Console.ReadKey();
            }
            else
            { 
                Console.WriteLine("Livro não Encontrado!");
                Console.ReadKey();
            }
        }
    }
}

