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

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();

            IdColumn.DataPropertyName = "code";
            IdColumn.HeaderText = "Id";
            IdColumn.Visible = false;

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();

            NomColumn.DataPropertyName = "nom_cli";
            NomColumn.HeaderText = "nom";
            NomColumn.Width = 43;

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn nbrDevisColumn = new DataGridViewTextBoxColumn();

            nbrDevisColumn.DataPropertyName = "nbrDevis";
            nbrDevisColumn.HeaderText = "nombre de devis";

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn nbrDevisFiniColumn = new DataGridViewTextBoxColumn();

            nbrDevisFiniColumn.DataPropertyName = "nbrDevisFini";
            nbrDevisFiniColumn.HeaderText = "nombre de devi fini";

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn mtnTotalColumn = new DataGridViewTextBoxColumn();

            mtnTotalColumn.DataPropertyName = "mtnTotal";
            mtnTotalColumn.HeaderText = "montant total";

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn dateDernierDeviColumn = new DataGridViewTextBoxColumn();

            dateDernierDeviColumn.DataPropertyName = "dateDernierDevi";
            dateDernierDeviColumn.HeaderText = "date du dernier devi";
            dateDernierDeviColumn.Width = 40;

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
            List<> liste = new List<>();
            liste = 

            // Rattachement de la List à la source de données du datagridview
            dataGridViewSyntheseClients.DataSource = liste;
            #endregion
        }
    }
}
