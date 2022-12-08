using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBO
{
    public class DonneesDevis
    {
        private Client cli;
        private Devis dev;
        private List<Produit> produitList;
        private Statut stat;
        private float somme = 0;

        public DonneesDevis(Client cli, Devis dev, List<Produit> produitList, Statut stat)
        {
            this.Cli = cli;
            this.Dev = dev;
            this.ProduitList = produitList;
            this.Stat = stat;
            foreach(Produit prod in produitList)
            {
                somme += prod.Prix_ht_prod;
            }
        }

        public Client Cli { get => cli; set => cli = value; }
        public Devis Dev { get => dev; set => dev = value; }
        public List<Produit> ProduitList { get => produitList; set => produitList = value; }
        public Statut Stat { get => stat; set => stat = value; }

        public int IdDevis { get => this.Dev.Id_devis; }
        public string NomCli { get => this.Cli.Nom_cli; }
        public DateTime DateDevis { get => this.Dev.Date_dev; }
        public int NbProduit { get => this.ProduitList.Count(); }
        public float PrixTTC { get => somme; }
        public string LibelleStatut { get => this.Stat.Libelle_stat; }
    }
}
