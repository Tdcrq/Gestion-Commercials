using CommercialsBLL;
using CommercialDAL;
using CommercialsBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            foreach(Client client in liste)
            {
                Console.WriteLine(client.NumLiv.ToString() + " " + client.RueLiv.ToString() + "," + client.VilleLiv.ToString() + "," + client.CpLiv.ToString());
            }
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

        private void AjouterClient(object sender, EventArgs e)
        {
            bool verifAjoutClient = false;

            string nom = txtNom.Text;
            int numFac = 0, numLiv = 0;
            #region Verif des int
            if (txtNumFac.Text != "" || txtNumLiv.Text != "")
            {
                numFac = int.Parse(txtNumFac.Text);
                numLiv = int.Parse(txtNumLiv.Text);
                string rueFac = txtRueFac.Text;
                string rueLiv = txtRueLiv.Text;
                string villeFac = txtVilleFac.Text;
                string villeLiv = txtVilleLiv.Text;
                string cpFac = txtCpFac.Text;
                string cpLiv = txtCpLiv.Text;
                string tel = txtTel.Text;
                string fax = txtFax.Text;
                string email = txtEmail.Text;

                Client cli = new Client(nom, numFac, rueFac, villeFac, cpFac, numLiv, rueLiv, villeLiv, cpLiv, tel, fax, email);
                verifAjoutClient = GestionClients.CreerClient(cli);
                if (!verifAjoutClient)
                {
                    MessageBox.Show("ERREUR LORS DE L'INSERTION", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez renseigner tous les champs", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
            /* Actualisation  des données du DGV */
            List<Client> liste = new List<Client>();
            liste = GestionClients.GetClients();
            dataGridViewProduit.DataSource = liste;
        }
    }
}
