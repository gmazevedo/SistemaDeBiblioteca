using System;

namespace SistemaDeBiblioteca
{
    public class Livro
    {
        public const string EMPRESTADO = "Emprestado";
        public const string DISPONIVEL = "Disponivel";

        public int Isbn {get; set;}
        public string Titulo {get; set;}
        public string Status {get; set;}
        public string Locatario {get; set;}

        public Livro(int isbn, string titulo)
        {
            (Isbn, Titulo) = (isbn, titulo);

            Locatario = "";
            Status = DISPONIVEL;
        }

        public void Emprestar(string nome)
        {
            if(Status == DISPONIVEL)
            {
                Locatario = nome;
                Status = EMPRESTADO;
                Console.WriteLine("Livro locado com sucesso.\n");
            } 
            else
            {
                Console.WriteLine("Lívro indisponível para empréstimo.\n");
            }
        }

        public void Devolver()
        {
            Status = DISPONIVEL;
            Locatario = "";
        }
    }    
}
