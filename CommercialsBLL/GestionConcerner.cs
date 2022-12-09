using CommercialDAL;
using CommercialsBLL;
using CommercialsBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace CommercialsBLL
{
    public class GestionConcerner
    {
        private static GestionConcerner concerne;

        public static GestionConcerner GetGestionConcerner()
        {
            if (concerne == null)
            {
                concerne = new GestionConcerner();
            }
            return concerne;
        }
        public static bool CreerConcerner(Concerner concerner)
        {
            return ConcernerDAO.AjoutConcerner(concerner) != 0;
        }

        public static List<Produit> GetProduitList(Devis dev)
        {
            return ConcernerDAO.GetProduitList(dev);
        }

        public static Concerner GetConcernerParId(Produit prod, Devis dev)
        {
            return ConcernerDAO.GetConcernerParId(prod, dev);
        }
    }
}
