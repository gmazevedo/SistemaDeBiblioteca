using System;

namespace SistemaDeBiblioteca
{
    public class Biblioteca
    {
        public List<Livro> Livros {get;set;}
        public List<Pessoa> Pessoas {get;set;}

        public Biblioteca()
        {
            Livros = [];
            Pessoas = [];
        }

        public void CadastrarLivro(Livro livro)
        {
            Livros.Add(livro);
            Console.WriteLine("LIVRO CADASTRADO\n");
        }

        public void CadastrarUsuario(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
            Console.WriteLine("USUARIO CADASTRADO\n");
        }

        public void ListrarLivros()
        {
            Console.WriteLine("-- LISTA DE LIVROS --\n");
            foreach(Livro livro in Livros)
            {
                Console.WriteLine($"ISBN: {livro.Isbn} - Nome: {livro.Titulo} - Status: {livro.Status}\n");
            }
        }

        public void EmprestarLivro(Livro livro, Pessoa pessoa)
        {
            pessoa.PegarLivro(livro);
            livro.Emprestar(pessoa.Nome);
        }

        public Livro? BuscarLivroPorIsbn(int isbn)
        {
            return Livros.Find(item => item.Isbn == isbn);
        }
    }
}