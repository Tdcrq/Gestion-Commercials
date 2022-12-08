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

        public Concerner(Produit prod)
        {
            this.prod = prod;
        }

        public Produit Prod { get => prod; set => prod = value; }
        public Devis Dev { get => dev; set => dev = value; }
        public int Qte_prod { get => qte_prod; set => qte_prod = value; }
        public float Remise_prod { get => remise_prod; set => remise_prod = value; }
    }
}
