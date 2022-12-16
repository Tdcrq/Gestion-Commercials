using CommercialsBO;
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
            return somme;
        }

        /*public Devis getDernierDevis(Client cli)
        {
            ///<summary>Renvoie le dernier devis effectué pour un client</summary>
            return DevisDAO.getDernierDevis(cli);
        }*/

        public static List<SyntheseClient> GetSyntheseClient()
        {
            List<SyntheseClient> list = new List<SyntheseClient>();
            List<Client> lesClients = ClientDAO.GetClient();
            List<Devis> listDev = DevisDAO.GetAllDevisConcerner();
            int nbDevisAcceptes;
            float montantTotalHt;
            DateTime dateDernierDevis;
            SyntheseClient syntheseClient;
            foreach (Client cli in lesClients)
            {
                nbDevisAcceptes = DevisDAO.GetNbDevisAcceptes(cli);
                montantTotalHt = ClientDAO.GetMontantTotalHt(cli);
                dateDernierDevis = DevisDAO.getDernierDevis(cli);
                syntheseClient = new SyntheseClient(cli, listDev, nbDevisAcceptes, montantTotalHt, dateDernierDevis);
                list.Add(syntheseClient);
            }
            return list;
        }
    }
}
