using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBO
{
    public class Concerner
    {
        Produit prod;
        Devis dev;
        private int qte_prod;
        private float remise_prod;

        public Concerner(Produit prod, Devis dev, int qte_prod, float remise_prod)
        {
            this.prod = prod;
            this.dev = dev;
            this.qte_prod = qte_prod;
            this.remise_prod = remise_prod;
        }

        public Concerner(Produit prod, Devis dev)
        {
            this.prod = prod;
            this.dev = dev;
        }

        public Concerner(Produit prod)
        {
            this.prod = prod;
        }

        public Produit Prod { get => prod; set => prod = value; }
        public Devis Dev { get => dev; set => dev = value; }
        public int Qte_prod { get => qte_prod; set => qte_prod = value; }
        public float Remise_prod { get => remise_prod; set => remise_prod = value; }
        public int Id_prod { get => Prod.Id_prod; set => Prod.Id_prod = value; }
        public string Libelle_prod { get => Prod.Libelle_prod; set => Prod.Libelle_prod = value; }
        public float Prix_prod { get => Prod.Prix_ht_prod; set => Prod.Prix_ht_prod = value; }
    }
}