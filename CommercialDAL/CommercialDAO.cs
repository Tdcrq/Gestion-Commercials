using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommercialsBO; // Référence la couche BO
using System.Data.SqlClient;


namespace CommercialDAL
{
    public class CommercialDAO
    {
        private static CommercialDAO unCommercialDAO;
        // Accesseur en lecture, renvoi une instance
        public static CommercialDAO GetunCommercialDAO()
        {
            if (unCommercialDAO == null)
            {
                unCommercialDAO = new CommercialDAO();
            }
            return unCommercialDAO;
        }

        // Cette méthode retourne une List contenant les objets Commercials contenus dans la table Identification
        public static List<Commercial> VerifCommercials(Commercial Comm)
        {
            string identifiant = Comm.GetIdentifiant();
            string mdp= Comm.GetMdp();
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Commercials
            List<Commercial> lesCommercials = new List<Commercial>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM Commercial  WHERE id_com = " + identifiant;
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                if(mdp == monReader["mdp_com"].ToString())
                {
                    Comm.SetVerif(true);
                }
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesCommercials;
        }
    }
}
