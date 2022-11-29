using CommercialDAL;
using CommercialsBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBLL
{
    public class GestionStatut
    {
        private static GestionStatut unStatut;

        public static GestionStatut GetGestionStatut()
        {
            if (unStatut == null)
            {
                unStatut = new GestionStatut();
            }
            return unStatut;
        }
        public static List<Statut> GetStatut()
        {
            return StatutDAO.GetStatut();
        }
    }
}
