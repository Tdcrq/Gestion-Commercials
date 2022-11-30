using CommercialsBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialDAL
{
    public class DevisDAO
    {
        private static DevisDAO unDevisDAO;
        // Accesseur en lecture, renvoi une instance
        public static DevisDAO GetunDevisDAO()
        {
            if (unDevisDAO == null)
            {
                unDevisDAO = new DevisDAO();
            }
            return unDevisDAO;
        }

        public static int AjoutDevis(Devis unDevis)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO DECLICINFO.dbo.DEVIS(tx_tva_dev, date_dev, fk_code_stat, fk_code_cli)" +
                "values(@TVA, @date, @fk_code_stat, @fk_code_cli)",
                maConnexion
            );
            cmd.Parameters.AddWithValue("@TVA", unDevis.TxTva);
            cmd.Parameters.AddWithValue("@date", unDevis.Date_dev);
            cmd.Parameters.AddWithValue("@fk_code_stat", unDevis.Cli.Code);
            cmd.Parameters.AddWithValue("@fk_code_cli", unDevis.Stat.Code_stat);
            /* Exécution de la requête + stockage du nbre de ligne impactée */
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}
