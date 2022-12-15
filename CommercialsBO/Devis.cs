using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBO
{
    public class Devis
    {
        private Int32 id_devis;
        private float txTva;
        private DateTime date_dev;
        private Statut stat;
        private Client cli;

        public Devis(int id_devis, int txTva, DateTime date_dev, Statut stat, Client cli)
        {
            this.Id_devis = id_devis;
            this.TxTva = txTva;
            this.date_dev = date_dev;
            this.Stat = stat;
            this.Cli = cli;
        }

        public Devis(int txTva, DateTime date_dev, Statut stat, Client cli)
        {
            this.TxTva = txTva;
            this.date_dev = date_dev;
            this.Stat = stat;
            this.Cli = cli;
        }

        public Devis(DateTime date_dev, Statut stat, Client cli, int id_devis)
        {
            this.TxTva = txTva;
            this.date_dev = date_dev;
            this.Stat = stat;
            this.Cli = cli;
            this.Id_devis = id_devis;
        }

        public Devis(int id_devis, int txTva, Statut stat, Client cli)
        {
            this.Id_devis = id_devis;
            this.TxTva = txTva;
            this.Stat = stat;
            this.Cli = cli;
        }

        public Devis(int id_devis, int txTva)
        {
            this.Id_devis = id_devis;
            this.TxTva = txTva;
        }

        public Devis(int id_devis)
        {
            this.Id_devis = id_devis;
        }

        public Devis(DateTime date)
        {
            this.Date_dev = date;
        }

        public int Id_devis { get => id_devis; set => id_devis = value; }
        public float TxTva { get => txTva; set => txTva = value; }
        public DateTime Date_dev { get => date_dev; set => date_dev = value; }
        public Client Cli { get => cli; set => cli = value; }
        public Statut Stat { get => stat; set => stat = value; }
    }
}
