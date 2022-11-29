using CommercialsBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialDAL
{
    public class StatutDAO
    {
        private static StatutDAO unStatut;

        public static StatutDAO GetGestionStatut()
        {
            if (unStatut == null)
            {
                unStatut = new StatutDAO();
            }
            return unStatut;
        }
        public static List<Statut> GetStatut()
        {
            int id;
            string libelle;
            Statut unStatut;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Statuts
            List<Statut> lesStatuts = new List<Statut>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM DECLICINFO.dbo.STATUT";
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id = int.Parse(monReader["code_stat"].ToString());
                if (monReader["Libelle_stat"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monReader["Libelle_stat"].ToString();
                }
                unStatut = new Statut(id, libelle);
                lesStatuts.Add(unStatut);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesStatuts;
        }
    }
}
