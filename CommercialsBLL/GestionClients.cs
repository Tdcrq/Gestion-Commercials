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
    public class GestionClients
    {
        private static GestionClients uneGestionClients; // objet BLL

        // Accesseur en lecture
        public static GestionClients GetGestionClients()
        {
            if (uneGestionClients == null)
            {
                uneGestionClients = new GestionClients();
            }
            return uneGestionClients;
        }

        // Méthode qui renvoit une List d'objets Produit en faisant appel àla méthode GetClients() de la DAL
        public static List<Client> GetClients()
        {
            return ClientDAO.GetClient();
        }

        public static bool CreerClient(Client cli)
        {
            return ClientDAO.AjoutClient(cli) != 0;
        }
        
        public static bool SupprimerClient(Client cli)
        {
            return ClientDAO.SupprimerClient(cli) != 0;
        }

        public static bool ModifierClient(Client cli)
        {
            return ClientDAO.UpdateClient(cli) != 0;
        }
    }
}
