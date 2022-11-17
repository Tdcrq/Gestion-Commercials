using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CommercialDAL;
using CommercialsBO;

namespace CommercialsBLL
{
    public class GestionProduits
    {
        private static GestionProduits uneGestionProduits; // objet BLL

        // Accesseur en lecture
        public static GestionProduits GetGestionProduits()
        {
            if (uneGestionProduits == null)
            {
                uneGestionProduits = new GestionProduits();
            }
            return uneGestionProduits;
        }

        // Méthode qui renvoit une List d'objets Produit en faisant appel àla méthode GetProduits() de la DAL
        public static List<Produit> GetProduits()
        {
            return ProduitDAO.GetProduits();
        }

        // Méthode qui renvoi l’objet Produit en l'ajoutant à la BD avec la méthode AjoutProduit de la DAL
        public static bool CreerProduit(Produit ut)
        {
            return ProduitDAO.AjoutProduit(ut) != 0;
        }

        // Méthode qui modifie un nouvel Produit avec la méthode UpdateProduit de la DAL
        public static bool ModifierProduit(Produit ut)
        {
            return ProduitDAO.UpdateProduit(ut) != 0;
        }
    }
}

