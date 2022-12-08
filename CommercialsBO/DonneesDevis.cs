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
        private Concerner concerner;
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
                Somme += prod.Prix_ht_prod;
            }
        }

        public Client Cli { get => Cli1; set => Cli1 = value; }
        public Devis Dev { get => Dev1; set => Dev1 = value; }
        public List<Produit> ProduitList { get => ProduitList1; set => ProduitList1 = value; }
        public Statut Stat { get => Stat1; set => Stat1 = value; }

        public int IdDevis { get => this.Dev.Id_devis; }
        public string NomCli { get => this.Cli.Nom_cli; }
        public string DateDevis { get => this.Dev.Date_dev.ToString("yyyy-MM-dd"); }
        public int NbProduit { get => this.ProduitList.Count(); }
        public float PrixTTC { get => Somme; }
        public string LibelleStatut { get => this.Stat.Libelle_stat; }

        public Client Cli1 { get => cli; set => cli = value; }
        public Concerner Concerner1 { get => concerner; set => concerner = value; }
        public Devis Dev1 { get => dev; set => dev = value; }
        public List<Produit> ProduitList1 { get => produitList; set => produitList = value; }
        public Statut Stat1 { get => stat; set => stat = value; }
        public float Somme { get => somme; set => somme = value; }
    }
}
