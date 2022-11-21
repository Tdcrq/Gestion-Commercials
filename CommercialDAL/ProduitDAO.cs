using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommercialsBO;

namespace CommercialDAL
{
    public class ProduitDAO
    {
        private static ProduitDAO unProduitDAO;
        // Accesseur en lecture, renvoi une instance
        public static ProduitDAO GetunProduitDAO()
        {
            if (unProduitDAO == null)
            {
                unProduitDAO = new ProduitDAO();
            }
            return unProduitDAO;
        }

        // Cette méthode retourne une List contenant les objets Produits contenus dans la table Identification
        public static List<Produit> GetProduits()
        {
            int id, fk_cat;
            string nom;
            float prix;
            Produit unProduit;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Produits
            List<Produit> lesProduits = new List<Produit>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM DECLICINFO.dbo.PRODUIT";
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id = int.Parse(monReader["code_prod"].ToString());
                if (monReader["libelle_prod"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monReader["libelle_prod"].ToString();
                }
                if (monReader["prix_ht_prod"] == DBNull.Value)
                {
                    prix = default(float);
                }
                else
                {
                    prix = float.Parse(monReader["prix_ht_prod"].ToString());
                }
                if (monReader["fk_code_cat"] == DBNull.Value)
                {
                    fk_cat = default(int);
                }
                else
                {
                    fk_cat = int.Parse(monReader["fk_code_cat"].ToString());
                }
                unProduit = new Produit(id, nom, prix, fk_cat);
                lesProduits.Add(unProduit);
                //Console.WriteLine(id);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesProduits;
        }

        public static int AjoutProduit(Produit unProduit)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO DECLICINFO.dbo.PRODUIT(libelle_prod, prix_ht_prod, fk_code_cat) " +
                "VALUES(@libelle, @prix, @fk_id_cat)",
                maConnexion
            );
            cmd.Parameters.AddWithValue("@libelle", unProduit.Libelle_prod);
            cmd.Parameters.AddWithValue("@prix", unProduit.Prix_ht_prod);
            cmd.Parameters.AddWithValue("@fk_id_cat", unProduit.Fk_id_cat);
            /* Exécution de la requête + stockage du nbre de ligne impactée */
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        // Cette méthode modifie un Produit passé en paramètre dans la BD
        public static int UpdateProduit(Produit unProduit)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();            
            /* Préparation de la requête */
            SqlCommand cmd = new SqlCommand(
                "UPDATE DECLICINFO.dbo.PRODUIT " +
                "SET libelle_prod = @libelle, prix_ht_prod = @prix, fk_code_cat = @fk_id_cat " +
                "WHERE code_prod = @id",
                maConnexion
            );
            cmd.Parameters.AddWithValue("@libelle", unProduit.Libelle_prod);
            cmd.Parameters.AddWithValue("@prix", unProduit.Prix_ht_prod);
            cmd.Parameters.AddWithValue("@fk_id_cat", unProduit.Fk_id_cat);
            cmd.Parameters.AddWithValue("@id", unProduit.Id_prod);
            /* Exécution de la requête + stockage du nbre de ligne impactée */
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        // Cette méthode supprime de la BD un utilisateur dont l'id est passé en paramètre
        public static int DeleteProduit(Produit unProduit)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM DECLICINFO.dbo.PRODUIT WHERE code_prod = @id",
                maConnexion
            );
            cmd.Parameters.AddWithValue("@id", unProduit.Id_prod);
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

    }
}

