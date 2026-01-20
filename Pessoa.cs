using System;

namespace SistemaDeBiblioteca
{    public class Pessoa
    {
        Random rnd = new Random();
        public int Id {get;set;}
        public string Nome {get;set;}
        public List<Livro> LivrosLocados {get;set;}

        public Pessoa(string nome)
        {
            (Nome) = (nome);
            LivrosLocados = [];
            Id = rnd.Next();
        }

        public void PegarLivro(Livro livro)
        {
            if(livro.Status == Livro.DISPONIVEL)
            {
                LivrosLocados.Add(livro);
            }
        }

        public void DevolverLivro(Livro livro)
        {
            LivrosLocados.Remove(livro);
        }

    }    
}
