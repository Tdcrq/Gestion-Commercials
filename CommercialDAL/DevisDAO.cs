﻿using CommercialsBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommercialsBLL;

namespace CommercialDAL
{
    public class DevisDAO
    {
        private static DevisDAO unDevisDAO;
        // Accesseur en lecture, renvoi une instance
        public static DevisDAO GetunDevisDAO()
        {
            if (unDevisDAO == null)
            {
                unDevisDAO = new DevisDAO();
            }
            return unDevisDAO;
        }
        public static List<Devis> GetDevisConcerner()
        {
            int code, tx_TVA;
            DateTime date;
            Statut stat;
            Client unClient;
            Devis unDevisConcerner;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Clients
            List<Devis> lesDevisConcerners = new List<Devis>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "select * from DECLICINFO.dbo.DEVIS, DECLICINFO.dbo.STATUT, DECLICINFO.dbo.CLIENT " +
                              "WHERE code_dev = (SELECT MAX(code_dev) FROM DECLICINFO.dbo.DEVIS) " +
                              "and fk_code_stat = code_stat " +
                              "and fk_code_cli = code_cli";
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                code = int.Parse(monReader["code_dev"].ToString());
                tx_TVA = int.Parse(monReader["tx_tva_dev"].ToString());
                stat = new Statut(int.Parse(monReader["code_stat"].ToString()), monReader["libelle_stat"].ToString());
                unClient = new Client(int.Parse(monReader["code_cli"].ToString()), monReader["nom_cli"].ToString(), int.Parse(monReader["num_fac_cli"].ToString()), 
                                      monReader["rue_fac_cli"].ToString(), monReader["ville_fac_cli"].ToString(), monReader["cp_fac_cli"].ToString(), 
                                      int.Parse(monReader["num_liv_cli"].ToString()),monReader["rue_liv_cli"].ToString(), monReader["ville_liv_cli"].ToString(), 
                                      monReader["cp_liv_cli"].ToString(), monReader["telephone_cli"].ToString(), monReader["fax_cli"].ToString(), monReader["email_cli"].ToString());
                unDevisConcerner = new Devis(code, tx_TVA, stat, unClient);
                lesDevisConcerners.Add(unDevisConcerner);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesDevisConcerners;
        }
        public static int AjoutDevis(Devis unDevis)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO DECLICINFO.dbo.DEVIS(tx_tva_dev, date_dev, fk_code_stat, fk_code_cli)" +
                "values(@TVA, @date, @fk_code_stat, @fk_code_cli)",
                maConnexion
            );
            cmd.Parameters.AddWithValue("@TVA", unDevis.TxTva);
            cmd.Parameters.AddWithValue("@date", unDevis.Date_dev);
            cmd.Parameters.AddWithValue("@fk_code_stat", unDevis.Cli.Code);
            cmd.Parameters.AddWithValue("@fk_code_cli", unDevis.Stat.Code_stat);
            /* Exécution de la requête + stockage du nbre de ligne impactée */
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}
