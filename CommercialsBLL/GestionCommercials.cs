using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CommercialsBO; // Référence la couche BO
using CommercialDAL; // Référence la couche DAL

namespace CommercialsBLL
{
    public class GestionCommercials
    {
        private static GestionCommercials uneGestionCommercials; // objet BLL

        // Accesseur en lecture
        public static GestionCommercials GetGestionCommercials()
        {
            if (uneGestionCommercials == null)
            {
                uneGestionCommercials = new GestionCommercials();
            }
            return uneGestionCommercials;
        }
    }
}