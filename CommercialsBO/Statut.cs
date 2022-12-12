using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBO
{
    public class Statut
    {
        private int code_stat;
        private string libelle_stat;

        public Statut(int code_stat, string libelle_stat)
        {
            this.Code_stat = code_stat;
            this.Libelle_stat = libelle_stat;
        }

        public int Code_stat { get => code_stat; set => code_stat = value; }
        public string Libelle_stat { get => libelle_stat; set => libelle_stat = value; }
    }
}
