using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TRAB03{
    public class Livros : Emprestimo
    {
        
        protected string Titulo{get;set;}
        protected string Autor{get;set;}
        protected string Editora{get;set;}
        protected int Ano{get;set;}


        public Livros(string titulo, string autor, string editora, int ano, int tipo, string dtRet, string dtDev, string dtDvEft, string email) : base(tipo, dtRet, dtDev, dtDvEft, email)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Editora = editora;
            this.Ano = ano;
        }

        public override string ToString()
        {
            return base.ToString() + "Autor: " + this.Autor + "\n"+"Titulo: " + this.Titulo + "\n"+"Editora: " + this.Editora +"\n"+"Ano: " + this.Ano + "\n";
        }

    }
}