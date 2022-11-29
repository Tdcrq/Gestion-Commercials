﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBO
{
    internal class Devis
    {
        private Int32 id_devis;
        private Int32 txTva;
        private DateTime date_dev;
        private Statut stat;
        private Client cli;

        public Devis(int id_devis, int txTva, DateTime date_dev, Statut stat, Client cli)
        {
            this.Id_devis = id_devis;
            this.TxTva = txTva;
            this.Date_dev = date_dev;
            this.Stat = stat;
            this.Cli = cli;
        }

        public int Id_devis { get => id_devis; set => id_devis = value; }
        public int TxTva { get => txTva; set => txTva = value; }
        public DateTime Date_dev { get => date_dev; set => date_dev = value; }
        public Client Cli { get => cli; set => cli = value; }
        internal Statut Stat { get => stat; set => stat = value; }
    }
}