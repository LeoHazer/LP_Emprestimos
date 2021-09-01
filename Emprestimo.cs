using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TRAB03{

 

    public class Emprestimo
    {

        protected int tipo{get;set;} //Checa se é livro ou utensílio 
        protected string dt_Retirada {get; set;}
        protected string dt_Devolucao {get; set;}
        protected string dt_DevEfetiva {get; set;}
        protected string email {get;set;}

        protected DateTime dtR{get;set;}
        protected DateTime dtDv{get;set;}
        protected DateTime dtDf{get;set;}

        public Emprestimo() 
        {
            dt_Retirada = null;
            dt_Devolucao = null;
            dt_DevEfetiva = null;
        }

         

        public Emprestimo(int tipo, string dtRet, string dtDev, string dtDvEft, string email){
            this.dt_Retirada = dtRet;
            this.dt_Devolucao = dtDev;
            this.dt_DevEfetiva = dtDvEft;
            this.email = email;
            this.tipo = tipo;

            dtR = Convert.ToDateTime(dtRet);
            dtDv = Convert.ToDateTime(dtDev);
            dtDf = Convert.ToDateTime(dtDvEft);
            
        }

            private static void ConverteHora(string valor){
            DateTime convHora;

                try
                {
                    convHora = Convert.ToDateTime(valor);
                    Console.WriteLine(" '{0}' converte para {1} {2} hora.",
                    valor, convHora,
                    convHora.Kind.ToString());
                }
                catch (FormatException)
                {
                    
                    Console.WriteLine(" '{0}' não é um formato adequado", valor);
                } 
        }

        public override string ToString()
        {
            return "Tipo de empréstimo: " + tipo +"\n"+
            "Data de Retirada: " + dtR.Day+"/"+dtR.Month+"/"+dtR.Year + "\n" +
            "Data de Devolução: " + dtDv.Day+"/"+dtDv.Month+"/"+dtDv.Year  + "\n"+
            "Devolução efetiva: " + dtDf.Day+"/"+dtDf.Month+"/"+dtDf.Year + "\n"+
            "E-mail: " + email + "\n";
            
        }

    }
}

