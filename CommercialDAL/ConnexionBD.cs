using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CommercialDAL
{
    public class ConnexionBD
    {
        private SqlConnection maConnexion;
        private static ConnexionBD uneConnexionBD; // instance d'une connexion
        private string chaineConnexion; // chaîne de connexion à la BD
                                        // Accesseur en lecture de la chaîne de connexion
        public string GetchaineConnexion()
        {
            return chaineConnexion;
        }
        // Accesseur en écriture de la chaîne de connexion
        public void SetchaineConnexion(string ch)
        {
            chaineConnexion = ch;
        }
        // Accesseur en lecture, renvoi une instance de connexion
        public static ConnexionBD GetConnexionBD()
        {
            if (uneConnexionBD == null)
            {
                uneConnexionBD = new ConnexionBD();
            }
            return uneConnexionBD;
        }
        // Constructeur privé
        private ConnexionBD()
        {
        }
        public SqlConnection GetSqlConnexion()
        {
            if (maConnexion == null)
            {
                maConnexion = new SqlConnection();
            }
            maConnexion.ConnectionString = chaineConnexion;
            // Si la connexion est fermée, on l’ouvre
            if (maConnexion.State == System.Data.ConnectionState.Closed)
            {
                maConnexion.Open();
            }
            return maConnexion;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        public void CloseConnexion()
        {
            // Si la connexion est ouverte, on la ferme
            if (this.maConnexion != null && this.maConnexion.State !=
            System.Data.ConnectionState.Closed)
            {
                this.maConnexion.Close();
            }
        }
    }
}
