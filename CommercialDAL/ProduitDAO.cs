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
        public static List<CommercialsBO.Produit> GetProduits()
        {
            int id, fk_cat;
            string nom;
            float prix;
            Produit unProduit;
            // Connexion à la BD
            SqlConnection maConnexion =
           ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Produits
            List<Produit> lesProduits = new List<Produit>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM DECLICINFO.dbo.PRODUIT";
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["code.prod"].ToString());
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
                if (monReader["prix_ht_prod"] == DBNull.Value)
                {
                    fk_cat = default(int);
                }
                else
                {
                    fk_cat = int.Parse(monReader["prix_ht_prod"].ToString());
                }
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
            SqlConnection maConnexion =
           ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO DECLICINFO.dbo.PRODUIT values('" +
           unProduit.Libelle_prod + "')";
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
            SqlConnection maConnexion =
           ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE DECLICINFO.dbo.PRODUIT SET libelle_prod = '"
                + unProduit.Libelle_prod + "' WHERE code.prod = " + unProduit.Id_prod;
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}

