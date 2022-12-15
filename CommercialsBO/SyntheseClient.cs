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
        private List<Concerner> listConcerner;

        public SyntheseClient(Client cli, List<Devis> listDevis, List<Concerner> concernerList)
        {
            this.Cli = cli;
            this.ListDevis = listDevis;
            this.ListConcerner = concernerList;
        }

        public Client Cli { get => cli; set => cli = value; }
        public string NomCli { get => this.Cli.Nom_cli; set => this.Cli.Nom_cli = value; }
        public List<Devis> ListDevis { get => listDevis; set => listDevis = value; }
        public int NbDevis { get => ListDevis.Count; }
        public List<Concerner> ListConcerner { get => listConcerner; set => listConcerner = value; }
    }
}
