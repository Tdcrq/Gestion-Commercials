using CommercialsBO;
using CommercialsBLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Remoting.Messaging;

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
            int id;
            Categorie fk_cat;
            string nom;
            float prix;
            Produit unProduit;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Produits
            List<Produit> lesProduits = new List<Produit>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM DECLICINFO.dbo.PRODUIT, DECLICINFO.dbo.CATEGORIE WHERE fk_code_cat = code_cat";
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
                fk_cat = new Categorie((int)monReader["code_cat"], monReader["libelle_cat"].ToString());
                //fk_cat =  GestionCategories.GetCategorieById(int.Parse(monReader["fk_code_cat"].ToString()));
                unProduit = new Produit(id, nom, prix, fk_cat);
                lesProduits.Add(unProduit);
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
            cmd.Parameters.AddWithValue("@fk_id_cat", unProduit.Cat.Code_cat);
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
            cmd.Parameters.AddWithValue("@fk_id_cat", unProduit.Cat.Code_cat);
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
                "DELETE FROM DECLICINFO.dbo.PRODUIT " +
                "WHERE code_prod = @id " +
                "AND code_prod not in (SELECT fk_code_prod FROM DECLICINFO.dbo.Concerner)",
                maConnexion
            );
            cmd.Parameters.AddWithValue("@id", unProduit.Id_prod);
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static List<Produit> GetProduitsConfirmation(List<Produit> listeConcerner)
        {
            int id;
            string nom;
            float prix;
            Produit unProduit;
            // Création d'une liste vide d'objets Produits
            List<Produit> lesProduits = new List<Produit>();

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "select code_prod, libelle_prod, prix_ht_prod from DECLICINFO.dbo.PRODUIT where code_prod in (@checkedProd);";
            foreach(Produit prod in listeConcerner)
            {
                cmd.Parameters.AddWithValue("@checkedProd", prod.Id_prod);
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
                    unProduit = new Produit(id, nom, prix);
                    lesProduits.Add(unProduit);
                }
                monReader.Close();
                cmd.Parameters.Clear();
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesProduits;
        }
    }
}

