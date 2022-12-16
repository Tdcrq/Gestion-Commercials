using CommercialDAL;
using CommercialsBLL;
using CommercialsBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Commercials
{
    public partial class FrmSyntheseClient : Form
    {
        public FrmSyntheseClient()
        {
            InitializeComponent();
            ConnexionBD.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Gestion_Commercials.Properties.Settings.DECLICINFOConnectionString"]);

            #region DGV
            // Blocage de la génération automatique des colonnes
            dataGridViewSyntheseClients.AutoGenerateColumns = false;

            dataGridViewSyntheseClients.ColumnHeadersVisible = true;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();

            IdColumn.DataPropertyName = "codeCli";
            IdColumn.HeaderText = "Id";
            IdColumn.Visible = false;

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();

            NomColumn.DataPropertyName = "NomClient";
            NomColumn.HeaderText = "nom";
            NomColumn.Width = 43;

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn nbrDevisColumn = new DataGridViewTextBoxColumn();

            nbrDevisColumn.DataPropertyName = "NbDevis";
            nbrDevisColumn.HeaderText = "nombre de devis";
            nbrDevisColumn.Width = 140;

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn nbrDevisFiniColumn = new DataGridViewTextBoxColumn();

            nbrDevisFiniColumn.DataPropertyName = "NbDevisAcceptes";
            nbrDevisFiniColumn.HeaderText = "nombre de devi fini";
            nbrDevisFiniColumn.Width = 150;

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn mtnTotalColumn = new DataGridViewTextBoxColumn();

            mtnTotalColumn.DataPropertyName = "MontantTotalHt";
            mtnTotalColumn.HeaderText = "montant total";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn dateDernierDeviColumn = new DataGridViewTextBoxColumn();

            dateDernierDeviColumn.DataPropertyName = "DateDernierDevis";
            dateDernierDeviColumn.HeaderText = "date du dernier devi";
            dateDernierDeviColumn.Width = 150;

            // Ajout des 2 en-têtes de colonne au datagridview
            dataGridViewSyntheseClients.Columns.Add(IdColumn);
            dataGridViewSyntheseClients.Columns.Add(NomColumn);
            dataGridViewSyntheseClients.Columns.Add(nbrDevisColumn);
            dataGridViewSyntheseClients.Columns.Add(nbrDevisFiniColumn);
            dataGridViewSyntheseClients.Columns.Add(mtnTotalColumn);
            dataGridViewSyntheseClients.Columns.Add(dateDernierDeviColumn);

            // Définition du style apporté au datagridview
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 9, FontStyle.Bold);

            dataGridViewSyntheseClients.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Création d'un objet List client à afficher dans le datagridview
            List<SyntheseClient> liste = new List<SyntheseClient>();
            liste = GestionSyntheses.GetSyntheseClient();

            //attachement de la List à la source de données du datagridview
            dataGridViewSyntheseClients.DataSource = liste;
            #endregion
        }

        private void btnAnnulFiltr_Click(object sender, EventArgs e)
        {
            // Création d'un objet List client à afficher dans le datagridview
            List<SyntheseClient> liste = new List<SyntheseClient>();
            liste = GestionSyntheses.GetSyntheseClient();

            //attachement de la List à la source de données du datagridview
            dataGridViewSyntheseClients.DataSource = liste;
        }

        private void btnAjoutFiltr_Click(object sender, EventArgs e)
        {
            List<SyntheseClient> temp = new List<SyntheseClient>();
            List<SyntheseClient> liste = new List<SyntheseClient>();
            liste = GestionSyntheses.GetSyntheseClient();

            DateTime debutFiltre = dTPDebutFiltre.Value;
            DateTime finFiltre = dTPFinFiltre.Value;

            foreach (SyntheseClient sC in liste)
            {
                foreach (Devis d in sC.ListDevis)
                {
                    if (!temp.Contains(sC))
                    {
                        if (d.Date_dev < debutFiltre && d.Date_dev > finFiltre)
                        {
                            temp.Add(sC);
                        }
                    }
                }
            }

            foreach (SyntheseClient sC2 in temp)
            {
                liste.Remove(sC2);
            }

            dataGridViewSyntheseClients.DataSource = liste;
        }
    }
}
