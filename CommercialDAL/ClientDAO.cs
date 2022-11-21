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
            string nom, rueFac, rueLivr, villeFac, villeLiv, cpFac, cpLiv, tel, fax, email;
            int code, numFac, numLivr;
            Client unClient;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Produits
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
                    numLivr = default(int);
                }
                else
                {
                    numLivr = int.Parse(monReader["num_liv_cli"].ToString());
                }
                if (monReader["rue_liv_cli"] == DBNull.Value)
                {
                    rueLivr = default(string);
                }
                else
                {
                    rueLivr = monReader["rue_liv_cli"].ToString();
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

                unClient = new Client(code, nom, numFac, rueFac, villeFac, cpFac, villeLiv, cpLiv, tel, fax, email);
                lesClients.Add(unClient);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesClients;
        }
    }
}