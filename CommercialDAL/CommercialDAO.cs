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
        // Cette méthode retourne une List contenant les objets Commercials contenus dans la table Identification
        public static void VerifCommercials(Commercial Comm)
        {
            string identifiant = Comm.GetIdentifiant();
            string mdp = Comm.GetMdp();

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand("select * from DECLICINFO.dbo.COMMERCIAL WHERE id_com = @identifiant", maConnexion);
            cmd.Parameters.AddWithValue("identifiant", identifiant);

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                if (mdp == monReader["mdp_com"].ToString())
                {
                    Comm.SetVerif(true);
                }
            }
            // Fermeture de la connexion
            maConnexion.Close();
        }
    }
}