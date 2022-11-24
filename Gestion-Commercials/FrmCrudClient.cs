using CommercialsBLL;
using CommercialDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommercialsBO;
using System.Configuration;

namespace Gestion_Commercials
{
    public partial class FrmCrudClient : Form
    {
        public FrmCrudClient()
        {
            InitializeComponent();
            ConnexionBD.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Gestion_Commercials.Properties.Settings.DECLICINFOConnectionString"]);

            #region DGV
            // Blocage de la génération automatique des colonnes
            dataGridViewProduit.AutoGenerateColumns = false;

            dataGridViewProduit.ColumnHeadersVisible = true;

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
            DataGridViewTextBoxColumn addresseLivColumn = new DataGridViewTextBoxColumn();

            addresseLivColumn.DataPropertyName = "addresseLiv";
            addresseLivColumn.HeaderText = "addresse liv";

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn addresseFacColumn = new DataGridViewTextBoxColumn();

            addresseFacColumn.DataPropertyName = "addresseFac";
            addresseFacColumn.HeaderText = "addresse fac";

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn tel = new DataGridViewTextBoxColumn();

            tel.DataPropertyName = "Tel";
            tel.HeaderText = "telephone";

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn fax = new DataGridViewTextBoxColumn();

            fax.DataPropertyName = "Fax";
            fax.HeaderText = "fax";
            fax.Width = 40;

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn email = new DataGridViewTextBoxColumn();

            email.DataPropertyName = "Email";
            email.HeaderText = "email";


            // Ajout des 2 en-têtes de colonne au datagridview
            dataGridViewProduit.Columns.Add(IdColumn);
            dataGridViewProduit.Columns.Add(NomColumn);
            dataGridViewProduit.Columns.Add(addresseLivColumn);
            dataGridViewProduit.Columns.Add(addresseFacColumn);
            dataGridViewProduit.Columns.Add(tel);
            dataGridViewProduit.Columns.Add(fax);
            dataGridViewProduit.Columns.Add(email);

            // Définition du style apporté au datagridview
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 9, FontStyle.Bold);

            dataGridViewProduit.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Création d'un objet List client à afficher dans le datagridview
            List<Client> liste = new List<Client>();
            liste = GestionClients.GetClients();

            // Rattachement de la List à la source de données du datagridview
            dataGridViewProduit.DataSource = liste;
            #endregion
        }


        private void btnProduits_Click(object sender, EventArgs e)
        {
            FrmCrudProduit FrmProd;
            FrmProd = new FrmCrudProduit();
            this.Hide();
            FrmProd.ShowDialog();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            FrmCrudClient FrmClient;
            FrmClient = new FrmCrudClient();
            this.Hide();
            FrmClient.ShowDialog();
        }
    }
}
