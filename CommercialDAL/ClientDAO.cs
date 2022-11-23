using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommercialsBO;

namespace CommercialDAL
{
    public class ClientDAO
    {
        private static ClientDAO unClientDAO;
        // Accesseur en lecture, renvoi une instance
        public static ClientDAO GetunClientDAO()
        {
            if (unClientDAO == null)
            {
                unClientDAO = new ClientDAO();
            }
            return unClientDAO;
        }

        // Cette méthode retourne une List contenant les objets Client contenus dans la table Client
        public static List<Client> GetClient()
        {
            string nom, rueFac, rueLiv, villeFac, villeLiv, cpFac, cpLiv, tel, fax, email;
            int code, numFac, numLiv;
            Client unClient;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Clients
            List<Client> lesClients = new List<Client>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM DECLICINFO.dbo.CLIENT";
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                code = int.Parse(monReader["code_cli"].ToString());
                if (monReader["nom_cli"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monReader["nom_cli"].ToString();
                }
                if (monReader["num_fac_cli"] == DBNull.Value)
                {
                    numFac = default(int);
                }
                else
                {
                    numFac = int.Parse(monReader["num_fac_cli"].ToString());
                }
                if (monReader["rue_fac_cli"] == DBNull.Value)
                {
                    rueFac = default(string);
                }
                else
                {
                    rueFac = monReader["rue_fac_cli"].ToString();
                }
                if (monReader["ville_fac_cli"] == DBNull.Value)
                {
                    villeFac = default(string);
                }
                else
                {
                    villeFac = monReader["ville_fac_cli"].ToString();
                }
                if (monReader["cp_fac_cli"] == DBNull.Value)
                {
                    cpFac = default(string);
                }
                else
                {
                    cpFac = monReader["cp_fac_cli"].ToString();
                }
                if (monReader["num_liv_cli"] == DBNull.Value)
                {
                    numLiv = default(int);
                }
                else
                {
                    numLiv = int.Parse(monReader["num_liv_cli"].ToString());
                }
                if (monReader["rue_liv_cli"] == DBNull.Value)
                {
                    rueLiv = default(string);
                }
                else
                {
                    rueLiv = monReader["rue_liv_cli"].ToString();
                }
                if (monReader["ville_liv_cli"] == DBNull.Value)
                {
                    villeLiv = default(string);
                }
                else
                {
                    villeLiv = monReader["ville_liv_cli"].ToString();
                }
                if (monReader["cp_liv_cli"] == DBNull.Value)
                {
                    cpLiv = default(string);
                }
                else
                {
                    cpLiv = monReader["cp_liv_cli"].ToString();
                }
                if (monReader["telephone_cli"] == DBNull.Value)
                {
                    tel = default(string);
                }
                else
                {
                    tel = monReader["telephone_cli"].ToString();
                }
                if (monReader["fax_cli"] == DBNull.Value)
                {
                    fax = default(string);
                }
                else
                {
                    fax = monReader["fax_cli"].ToString();
                }
                if (monReader["email_cli"] == DBNull.Value)
                {
                    email = default(string);
                }
                else
                {
                    email = monReader["email_cli"].ToString();
                }

                unClient = new Client(code, nom, numFac, rueFac, villeFac, cpFac, numLiv, rueLiv, villeLiv, cpLiv, tel, fax, email);
                lesClients.Add(unClient);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesClients;
        }

        public static int AjoutClient(Client unClient)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();


            SqlCommand cmd = new SqlCommand(
                "INSERT INTO DECLICINFO.dbo.CLIENT(nom_cli, num_fac_cli, rue_fac_cli, ville_fac_cli, cp_fac_cli, num_liv_cli, rue_liv_cli, ville_liv_cli, cp_liv_cli, telephone_cli, fax_cli, email_cli) " +
                "VALUES(@nom, @num_fac, @rue_fac, @ville_fac, @cp_fac, @num_liv, @rue_liv, @ville_liv, @cp_liv, @tel, @fax, @email)",
                maConnexion
            );
            cmd.Parameters.AddWithValue("@nom", unClient.Nom_cli);
            cmd.Parameters.AddWithValue("@num_fac", unClient.NumFac);
            cmd.Parameters.AddWithValue("@rue_fac", unClient.RueFac);
            cmd.Parameters.AddWithValue("@ville_fac", unClient.VilleFac);
            cmd.Parameters.AddWithValue("@cp_fac", unClient.CpFac);
            cmd.Parameters.AddWithValue("@num_liv", unClient.NumLiv);
            cmd.Parameters.AddWithValue("@rue_liv", unClient.RueLiv);
            cmd.Parameters.AddWithValue("@ville_liv", unClient.VilleLiv);
            cmd.Parameters.AddWithValue("@cp_liv", unClient.CpLiv);
            cmd.Parameters.AddWithValue("@tel", unClient.Tel);
            cmd.Parameters.AddWithValue("@fax", unClient.Fax);
            cmd.Parameters.AddWithValue("@email", unClient.Email);

            /* Exécution de la requête + stockage du nbre de ligne impactée */
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            Console.WriteLine(nbEnr);
            return nbEnr;
        }
    }
}