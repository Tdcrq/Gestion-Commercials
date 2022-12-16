using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBO
{
    public class SyntheseClient
    {
        private Client cli;
        private List<Devis> listDevis;
        private int nbDevisAcceptes;
        private float montantTotalHt;
        private string dateDernierDevis;

        public SyntheseClient(Client cli, List<Devis> listDevis, int nbDevisAcceptes, float montantTotalHt, DateTime dateDernierDevis)
        {
            this.Cli = cli;
            this.ListDevis = listDevis;
            this.NbDevisAcceptes = nbDevisAcceptes;
            this.MontantTotalHt = montantTotalHt;
            this.dateDernierDevis = dateDernierDevis.ToString("dd-MM-yyyy");
        }

        public Client Cli { get => cli; set => cli = value; }
        public string NomClient { get => this.Cli.Nom_cli; }
        public int CodeClient { get => this.Cli.Code; }
        public List<Devis> ListDevis { get => listDevis; set => listDevis = value; }
        public int NbDevis { get => this.ListDevis.Count; }
        public int NbDevisAcceptes { get => nbDevisAcceptes; set => nbDevisAcceptes = value; }
        public float MontantTotalHt { get => montantTotalHt; set => montantTotalHt = value; }
        public string DateDernierDevis { get => dateDernierDevis; }
    }
}
