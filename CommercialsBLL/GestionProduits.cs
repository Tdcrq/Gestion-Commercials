using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommercialDAL;
using CommercialsBO;

namespace CommercialsBLL
{
    public class GestionProduits
    {
        public static bool ModifierProduit(CommercialsBO.Produit majProduit)
        {
            return ProduitDAO.ModifierProduitDAO(majProduit);
        }
    }
}
