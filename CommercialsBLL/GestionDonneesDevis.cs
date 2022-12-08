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
            List<Devis> listDev = DevisDAO.GetDevisConcerner();
            DonneesDevis uneDonnee;
            foreach (Devis dev in listDev)
            {
                lesProduits = GestionConcerner.GetProduitList(dev);
                uneDonnee = new DonneesDevis(dev.Cli, dev, lesProduits, dev.Stat);
                lesDonnees.Add(uneDonnee);
            }
            return lesDonnees;
        }
    }
}
