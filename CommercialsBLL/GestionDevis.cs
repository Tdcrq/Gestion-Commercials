using CommercialDAL;
using CommercialsBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBLL
{
    public class GestionDevis
    {
        private static GestionDevis unStatut;

        public static GestionDevis GetGestionStatut()
        {
            if (unStatut == null)
            {
                unStatut = new GestionDevis();
            }
            return unStatut;
        }
        public static bool CreerDevis(Devis devis)
        {
            return DevisDAO.AjoutDevis(devis) != 0;
        }
        public static List<Devis> GetDevisConcerner()
        {
            return DevisDAO.GetDevisConcerner();
        }

        public static Devis GetDevisParId(int id)
        {
            return DevisDAO.GetDevisParId(id);
        }

        public static bool SupprimerDevis(Devis dev)
        {
            return DevisDAO.SupprimerDevis(dev) != 0;
        }
        public static bool ModifierDevis(Devis dev)
        {
            return DevisDAO.ModifierDevis(dev) != 0;
        }
    }
}
