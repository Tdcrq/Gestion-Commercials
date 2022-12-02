using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBO
{
    public class Produit
    {
        private Int32 id_prod;
        private string libelle_prod;
        private float prix_ht_prod;
        private Categorie cat;

        public Produit(int id_prod, string libelle_prod, float prix_ht_prod, Categorie cat)
        {
            this.Id_prod = id_prod;
            this.Libelle_prod = libelle_prod;
            this.Prix_ht_prod = prix_ht_prod;
            this.Cat = cat;
        }

        public Produit(string libelle_prod, float prix_ht_prod, Categorie cat)
        {
            this.Libelle_prod = libelle_prod;
            this.Prix_ht_prod = prix_ht_prod;
            this.cat = cat;
        }

        public Produit(int id_prod, string libelle_prod)
        {
            this.Id_prod = id_prod;
            this.Libelle_prod = libelle_prod;
        }

        public int Id_prod { get => id_prod; set => id_prod = value; }
        public string Libelle_prod { get => libelle_prod; set => libelle_prod = value; }
        public float Prix_ht_prod { get => prix_ht_prod; set => prix_ht_prod = value; }
        public Categorie Cat { get => cat; set => cat = value; }

        public string CatLib { get => this.Cat.Libelle_cat; }
        public int CatCode { get => this.Cat.Code_cat; }
    }
}
