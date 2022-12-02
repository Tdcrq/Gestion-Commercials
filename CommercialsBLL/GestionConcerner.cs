using CommercialDAL;
using CommercialsBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
