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
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();

            NomColumn.DataPropertyName = "nom_cli";
            NomColumn.HeaderText = "Nom";

            /*
            
            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn numFac = new DataGridViewTextBoxColumn();

            numFac.DataPropertyName = "num_fac_cli";
            numFac.HeaderText = "N°";

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn rueFac = new DataGridViewTextBoxColumn();

            rueFac.DataPropertyName = "rue_fac_cli";
            rueFac.HeaderText = "rue";

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn villeFac = new DataGridViewTextBoxColumn();

            villeFac.DataPropertyName = "rue_fac_cli";
            villeFac.HeaderText = "rue";
            
             */

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn tel = new DataGridViewTextBoxColumn();

            tel.DataPropertyName = "telephone_cli";
            tel.HeaderText = "telephone";

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn fax = new DataGridViewTextBoxColumn();

            fax.DataPropertyName = "fax_cli";
            fax.HeaderText = "fax";

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn email = new DataGridViewTextBoxColumn();

            email.DataPropertyName = "email_cli";
            email.HeaderText = "email";


            // Ajout des 2 en-têtes de colonne au datagridview
            dataGridViewProduit.Columns.Add(NomColumn);
            dataGridViewProduit.Columns.Add(tel);
            dataGridViewProduit.Columns.Add(fax);
            dataGridViewProduit.Columns.Add(email);

            // Définition du style apporté au datagridview
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

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
