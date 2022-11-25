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
        public static void VerifCommercials(Commercial Comm)
        {
            CommercialDAO.VerifCommercials(Comm);
        }
    }
}