using CommercialsBO;
using CommercialsBLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialDAL
{
    public class ConcernerDAO
    {
        private static ConcernerDAO unConcernerDAO;
        // Accesseur en lecture, renvoi une instance
        public static ConcernerDAO GetunConcernerDAO()
        {
            if (unConcernerDAO == null)
            {
                unConcernerDAO = new ConcernerDAO();
            }
            return unConcernerDAO;
        }

        public static int AjoutConcerner(Concerner concerner)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand(
                "insert into DECLICINFO.dbo.Concerner(fk_code_prod, fk_code_dev, qte_prod, remise_prod)" +
                "values(@fk_code_prod, @fk_code_stat, @qte_prod, @rem_prod)",
                maConnexion
            );
            cmd.Parameters.AddWithValue("@fk_code_prod", concerner.Prod.Id_prod);
            cmd.Parameters.AddWithValue("@fk_code_stat", concerner.Dev.Id_devis);
            cmd.Parameters.AddWithValue("@qte_prod", concerner.Qte_prod);
            cmd.Parameters.AddWithValue("@rem_prod", concerner.Remise_prod);
            /* Exécution de la requête + stockage du nbre de ligne impactée */
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}
