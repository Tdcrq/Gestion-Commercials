using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBO
{
    public class Produit
    {
        private int id_prod;
        private string libelle_prod;
        private float prix_ht_prod;
        private int fk_id_cat;

        public Produit(int id_prod, string libelle_prod, float prix_ht_prod, int fk_id_cat)
        {
            this.Id_prod = id_prod;
            this.Libelle_prod = libelle_prod;
            this.Prix_ht_prod = prix_ht_prod;
            this.Fk_id_cat = fk_id_cat;
        }

        public Produit(string libelle_prod, float prix_ht_prod, int fk_id_cat)
        {
            this.Libelle_prod = libelle_prod;
            this.Prix_ht_prod = prix_ht_prod;
            this.Fk_id_cat = fk_id_cat;
        }

        public int Id_prod { get => id_prod; set => id_prod = value; }
        public string Libelle_prod { get => libelle_prod; set => libelle_prod = value; }
        public float Prix_ht_prod { get => prix_ht_prod; set => prix_ht_prod = value; }
        public int Fk_id_cat { get => fk_id_cat; set => fk_id_cat = value; }
    }
}
