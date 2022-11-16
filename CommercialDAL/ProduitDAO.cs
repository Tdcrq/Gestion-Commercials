using CommercialsBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialDAL
{
    public class ProduitDAO
    {
        public static int ModifierProduitDAO(Produit pro)
        {
            int nbEnr = 0;

            /* Chaîne de connexion*/
            SqlConnection conn = new SqlConnection("Data Source=UI-VICTUS;Initial Catalog=BD_Utilisateurs;Integrated Security=True");
            conn.Open();

            /* Préparation de la requete */
            SqlCommand command = new SqlCommand(
                "UPDATE PRODUIT SET label_prod = @label, prix_ht_prod = @prix, fk_code_cat = @categ WHERE code_prod = @id",
                conn
            );
            /* Attributions valeurs aux parametres de la requete */
            command.Parameters.AddWithValue("@label", pro.Label);
            command.Parameters.AddWithValue("@prix", pro.Prix);
            command.Parameters.AddWithValue("@categ", pro.IdCateg);
            command.Parameters.AddWithValue("@id", pro.Id);

            /* Éxécution de la requete */
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE PRODUIT SET label_prod = @label, prix_ht_prod = @prix, fk_code_cat = @categ.Label";

            /* Récupération du nombre d'enregistrement */
            nbEnr = cmd.ExecuteNonQuery();

            /* Fermeture de la connexion */
            conn.Close();

            return nbEnr;
        }
    }
}
