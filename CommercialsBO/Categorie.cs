using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBO
{
    public class Categorie
    {
        private int code_cat;
        private string libelle_cat;

        public Categorie(int code_cat, string libelle_cat)
        {
            this.Code_cat = code_cat;
            this.Libelle_cat = libelle_cat;
        }

        public int Code_cat { get => code_cat; set => code_cat = value; }
        public string Libelle_cat { get => libelle_cat; set => libelle_cat = value; }
    }
}
