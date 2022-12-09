using CommercialsBO;
using CommercialDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBLL
{
    public class GestionDonneesDevis
    {
        public static List<DonneesDevis> GetDonneesDevis()
        {
            List<DonneesDevis> lesDonnees= new List<DonneesDevis>();
            List<Produit> lesProduits;
            List<Devis> listDev = DevisDAO.GetAllDevisConcerner();
            List<Concerner> concernerList = new List<Concerner>();
            DonneesDevis uneDonnee;
            foreach (Devis dev in listDev)
            {
                lesProduits = GestionConcerner.GetProduitList(dev);
                foreach (Produit produit in lesProduits)
                {
                    concernerList.Add(GestionConcerner.GetConcernerParId(produit, dev));
                }
                uneDonnee = new DonneesDevis(dev.Cli, dev, lesProduits, dev.Stat);
                lesDonnees.Add(uneDonnee);
            }
            return lesDonnees;
        }

        public static bool SupprimerDevis(DonneesDevis dd)
        {
            bool verif = false;
            verif = ConcernerDAO.SupprimerConcerner(dd) != 0;
            if (!verif)
            {

            }
            return verif;
        }
    }
}
