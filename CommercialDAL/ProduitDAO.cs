using CommercialsBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialDAL
{
    public static class ProduitDAO
    {
        public static bool ModifierProduitDAO(Produit pro)
        {
            /* Chaîne de connexion*/
            SqlConnection conn = new SqlConnection("Data Source=UI-VICTUS;Initial Catalog=DECLICINFO;Integrated Security=True");
            conn.Open();

            /* Préparation de la requete */
            SqlCommand command = new SqlCommand(
                "UPDATE DECLICINFO.dbo.PRODUIT SET libelle_prod = @label, prix_ht_prod = @prix, fk_code_cat = @categ WHERE code_prod = @id",
                conn
            );
            /* Attributions valeurs aux parametres de la requete */
            command.Parameters.AddWithValue("@label", pro.Label);
            command.Parameters.AddWithValue("@prix", pro.Prix);
            command.Parameters.AddWithValue("@categ", pro.IdCateg);
            command.Parameters.AddWithValue("@id", pro.Id);

            /* Récupération du nombre d'enregistrement */
            int nbEnr = command.ExecuteNonQuery();

            /* Fermeture de la connexion */
            conn.Close();

            if (nbEnr == 1) 
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool AjoutProduitDAO(Produit pro)
        {
            /* Chaîne de connexion*/
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OOCQKQH;Initial Catalog=DECLICINFO;Integrated Security=True");
            conn.Open();

            /* Préparation de la requete */
            SqlCommand command = new SqlCommand(
                "INSERT INTO DECLICINFO.dbo.PRODUIT(libelle_prod,prix_ht_prod,fk_code_cat) VALUES( @label, @prix, @categ)",
                conn
            );
            /* Attributions valeurs aux parametres de la requete */
            command.Parameters.AddWithValue("@label", pro.Label);
            command.Parameters.AddWithValue("@prix", pro.Prix);
            command.Parameters.AddWithValue("@categ", pro.IdCateg);

            /* Récupération du nombre d'enregistrement */
            int nbEnr = command.ExecuteNonQuery();

            /* Fermeture de la connexion */
            conn.Close();

            if (nbEnr == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
