using CommercialsBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialDAL
{
    public class CategorieDAO
    {
        private static CategorieDAO uneCategorieDAO;
        // Accesseur en lecture, renvoi une instance
        public static CategorieDAO GetuneCategorieDAO()
        {
            if (uneCategorieDAO == null)
            {
                uneCategorieDAO = new CategorieDAO();
            }
            return uneCategorieDAO;
        }

        // Cette méthode retourne une List contenant les objets Categories contenus dans la table Identification
        public static List<Categorie> GetCategories()
        {
            int id;
            string nom;
            Categorie uneCategorie;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Categories
            List<Categorie> lesCategories = new List<Categorie>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM DECLICINFO.dbo.Categorie";
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id = int.Parse(monReader["code_cat"].ToString());
                if (monReader["Libelle_cat"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monReader["Libelle_cat"].ToString();
                }
                uneCategorie = new Categorie(id, nom);
                lesCategories.Add(uneCategorie);
                //Console.WriteLine(id);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesCategories;
        }

        public static int AjoutCategorie(Categorie uneCategorie)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO DECLICINFO.dbo.Categorie values(@libelle)", 
                maConnexion
            );
            cmd.Parameters.AddWithValue("@libelle", uneCategorie.Libelle_cat);
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        // Cette méthode modifie une Categorie passé en paramètre dans la BD
        public static int UpdateCategorie(Categorie uneCategorie)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand(
                "UPDATE DECLICINFO.dbo.Categorie SET Libelle_cat = @libelle" +
                "WHERE code_cat = @code_cat",
                maConnexion
            );
            cmd.Parameters.AddWithValue("@libelle", uneCategorie.Libelle_cat);
            cmd.Parameters.AddWithValue("@code_cat", uneCategorie.Code_cat);
            nbEnr = cmd.ExecuteNonQuery();
            Console.WriteLine(nbEnr);
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        
        public static Categorie GetCategorieById(int id)
        {
            string libelle;
            Categorie uneCategorie;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Categories
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = maConnexion;
            cmd2.CommandText = "SELECT * FROM DECLICINFO.dbo.Categorie WHERE code_cat = @code";
            cmd2.Parameters.AddWithValue("@code", id);
            SqlDataReader monReader = cmd2.ExecuteReader();

            libelle = monReader["libelle_cat"].ToString();
            uneCategorie = new Categorie(id, libelle);

            return uneCategorie;
        }
    }
}
