﻿using CommercialsBO;
using CommercialDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBLL
{
    public class GestionSyntheses
    {
        public float getPrixTotalHt(SyntheseClient SCli)
        {
            /// <summary>Renvoie la somme totale des pirx des devis pour un client</summary>
            float somme = 0;
            foreach(Devis dev in SCli.ListDevis)
            {
                foreach(Concerner c in SCli.ListConcerner)
                {
                    somme += c.Qte_prod * c.Prix_prod;
                }
            }
            return somme;
        }

        public Devis getDernierDevis(Client cli)
        {
            ///<summary>Renvoie le dernier devis effectué pour un client</summary>
            return DevisDAO.getDernierDevis(cli);
        }
    }
}
