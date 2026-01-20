using System;
using System.Data.Common;

namespace SistemaDeBiblioteca
{
    class Program
    {
        static void Main()
        {
            Biblioteca biblioteca = new Biblioteca();
            Livro livro1 = new Livro(1, "Dom Casmurro");
            Livro livro2 = new Livro(2, "Assassinato no Expresso Oriente");
            Livro livro3 = new Livro(3, "O Continente");
            Livro livro4 = new Livro(4, "O Cortiço");
            Livro livro5 = new Livro(5, "Quarto de Despejo");

            biblioteca.CadastrarLivro(livro1);
            biblioteca.CadastrarLivro(livro2);
            biblioteca.CadastrarLivro(livro3);
            biblioteca.CadastrarLivro(livro4);
            biblioteca.CadastrarLivro(livro5);


            Console.WriteLine("Bem vindo a Biblioteca Ponei!\n");
            int opcao;
            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Listar todos os livros");
                Console.WriteLine("2 - Emprestar livro");
                Console.WriteLine("3 - Sair");
                opcao = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        biblioteca.ListrarLivros();
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome do locatario\n");
                        string nome = Console.ReadLine();
                        Pessoa pessoa = new Pessoa(nome);
                        biblioteca.CadastrarUsuario(pessoa);

                        biblioteca.ListrarLivros();

                        Console.WriteLine("Digite o ISBN do livro desejado\n");
                        int isbn = int.Parse(Console.ReadLine());
                        Livro livroEscolhido = biblioteca.BuscarLivroPorIsbn(isbn);
                        if(livroEscolhido != null)
                        {
                            biblioteca.EmprestarLivro(livroEscolhido, pessoa);
                        } 
                        break;
                    default:
                        break;
                }
            } while(opcao != 3);


            /*Console.WriteLine("-- TESTE CLASSE LIVRO --\n");
            Livro livro1 = new Livro(1, "Dom Casmurro");
            Console.WriteLine($"{livro1.Titulo} - Status: {livro1.Status}\n");

            livro1.Emprestar("Gessica");
            Console.WriteLine($"{livro1.Titulo} - Status: {livro1.Status} - Locatario: {livro1.Locatario}\n");

            livro1.Devolver();
            Console.WriteLine($"{livro1.Titulo} - Status: {livro1.Status} - Locatario: {livro1.Locatario}\n");
        
            Console.WriteLine("-- TESTE CLASSE PESSOA --\n");
            Pessoa pessoa1 = new Pessoa(1, "João");
            Console.WriteLine($"Id: {pessoa1.Id} - Nome: {pessoa1.Nome} - Livros Locados: {string.Join(" ", pessoa1.LivrosLocados.Select(l => l.Titulo))}\n");

            pessoa1.PegarLivro(livro1);
            Console.WriteLine($"Id: {pessoa1.Id} - Nome: {pessoa1.Nome} - Livros Locados: {string.Join(" ", pessoa1.LivrosLocados.Select(l => l.Titulo))}\n");

            pessoa1.DevolverLivro(livro1);
            Console.WriteLine($"Id: {pessoa1.Id} - Nome: {pessoa1.Nome} - Livros Locados: {string.Join(" ", pessoa1.LivrosLocados.Select(l => l.Titulo))}\n");
        
            Console.WriteLine("-- TESTE CLASSE BIBLIOTECA --\n");
            Biblioteca biblioteca1 = new Biblioteca();

            biblioteca1.CadastrarLivro(livro1);
            biblioteca1.ListrarLivros();

            biblioteca1.CadastrarUsuario(pessoa1);
            Console.WriteLine($"Pessoas: {string.Join(" ", biblioteca1.Pessoas.Select(P => P.Nome))}\n");


            biblioteca1.EmprestarLivro(livro1, pessoa1);
            Console.WriteLine($"{livro1.Titulo} - Status: {livro1.Status}\n");
            Console.WriteLine($"Nome: {pessoa1.Nome} - Livros Locados: {string.Join(" ", pessoa1.LivrosLocados.Select(l => l.Titulo))}\n");
            */
        }

    }


}
