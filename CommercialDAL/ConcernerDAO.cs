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

        public static List<Produit> GetProduitList(Devis dev)
        {
            int id;
            Categorie fk_cat;
            string nom;
            float prix;
            Produit unProduit;
            List<Produit> lesProduits = new List<Produit>();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand(
                "SELECT P.code_prod, Cat.code_cat, Cat.libelle_cat, P.libelle_prod, ((P.prix_ht_prod - C.remise_prod) * (1+(D.tx_tva_dev/100))) AS prix_ttc_prod " +
                "FROM DECLICINFO.dbo.PRODUIT P, DECLICINFO.dbo.Concerner C, DECLICINFO.dbo.DEVIS D, DECLICINFO.dbo.CATEGORIE Cat " +
                "WHERE C.fk_code_prod = P.code_prod " +
                "AND Cat.code_cat = P.fk_code_cat " +
                "AND C.fk_code_dev = D.code_dev " +
                "AND C.fk_code_dev = @id_dev",
                maConnexion
            );
            cmd.Parameters.AddWithValue("@id_dev", dev.Id_devis);

            SqlDataReader monReader = cmd.ExecuteReader();
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
                if (monReader["prix_ttc_prod"] == DBNull.Value)
                {
                    prix = default(float);
                }
                else
                {
                    prix = float.Parse(monReader["prix_ttc_prod"].ToString());
                }
                fk_cat = new Categorie((int)monReader["code_cat"], monReader["libelle_cat"].ToString());
                //fk_cat =  GestionCategories.GetCategorieById(int.Parse(monReader["fk_code_cat"].ToString()));
                unProduit = new Produit(id, nom, prix, fk_cat);
                lesProduits.Add(unProduit);
            }
            maConnexion.Close();
            return lesProduits;
        }

        public static int SupprimerConcerner(DonneesDevis dd)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();


            SqlCommand cmd = new SqlCommand(
                "DELETE FROM DECLICINFO.dbo.Concerner " +
                "WHERE fk_code_dev = @id_dev ",
                maConnexion
            );
            cmd.Parameters.AddWithValue("@id_dev", dd.Dev.Id_devis);
            nbEnr = cmd.ExecuteNonQuery();
            maConnexion.Close();
            return nbEnr;
        }
    }
}
