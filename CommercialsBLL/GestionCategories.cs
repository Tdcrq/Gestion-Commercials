using CommercialDAL;
using CommercialsBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBLL
{
    public class GestionCategories
    {
        private static GestionCategories uneGestionCategories; // objet BLL

        public static GestionCategories GetGestionCategories()
        {
            if (uneGestionCategories == null)
            {
                uneGestionCategories = new GestionCategories();
            }
            return uneGestionCategories;
        }

        // Méthode qui renvoit une List d'objets Categorie en faisant appel àla méthode GetCategories() de la DAL
        public static List<Categorie> GetCategories()
        {
            return CategorieDAO.GetCategories();
        }

        // Méthode qui renvoi l’objet Categorie en l'ajoprodant à la BD avec la méthode AjoprodCategorie de la DAL
        public static bool CreerCategorie(Categorie prod)
        {
            return CategorieDAO.AjoutCategorie(prod) != 0;
        }

        // Méthode qui modifie un nouvel Categorie avec la méthode UpdateCategorie de la DAL
        public static bool ModifierCategorie(Categorie prod)
        {
            return CategorieDAO.UpdateCategorie(prod) != 0;
        }
    }
}
