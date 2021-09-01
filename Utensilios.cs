using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TRAB03{
    public class Utensilios : Emprestimo
    {
        protected string Descricao;
        protected string tipoMaterial;
        public Utensilios(int tipo, string dtRet, string dtDev, string dtDvEft, string email, string desc, string mat) : base(tipo, dtRet, dtDev, dtDvEft, email)
        {
            this.Descricao = desc;
            this.tipoMaterial = mat;
        }

        public override string ToString()
        {
            return base.ToString() + "Descrição: " + this.Descricao + "\n" + "Material: " + this.tipoMaterial+ "\n";
        }


    }
}