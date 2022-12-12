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
            dataGridViewClient.AutoGenerateColumns = false;

            dataGridViewClient.ColumnHeadersVisible = true;

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
            dataGridViewClient.Columns.Add(IdColumn);
            dataGridViewClient.Columns.Add(NomColumn);
            dataGridViewClient.Columns.Add(addresseLivColumn);
            dataGridViewClient.Columns.Add(addresseFacColumn);
            dataGridViewClient.Columns.Add(tel);
            dataGridViewClient.Columns.Add(fax);
            dataGridViewClient.Columns.Add(email);

            // Définition du style apporté au datagridview
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 9, FontStyle.Bold);

            dataGridViewClient.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Création d'un objet List client à afficher dans le datagridview
            List<Client> liste = new List<Client>();
            liste = GestionClients.GetClients();

            // Rattachement de la List à la source de données du datagridview
            dataGridViewClient.DataSource = liste;
            #endregion
        }


        #region action menu de gauche
        private void btnClients_Click(object sender, EventArgs e)
        {
            FrmCrudClient FrmClient;
            FrmClient = new FrmCrudClient();
            this.Hide();
            FrmClient.ShowDialog();
        }
        private void btnProduits_Click(object sender, EventArgs e)
        {
            FrmCrudProduit FrmProd;
            FrmProd = new FrmCrudProduit();
            this.Hide();
            FrmProd.ShowDialog();
        }
        private void btnDevis_Click(object sender, EventArgs e)
        {
            FrmCrudDevis FrmDevis;
            FrmDevis = new FrmCrudDevis();
            this.Hide();
            FrmDevis.ShowDialog();
        }
        #endregion

        private void AjouterClient(object sender, EventArgs e)
        {
            bool verifAjoutClient = false;

            int numFac, numLiv;
            #region Verif des champs
            if (txtNom.Text != "" && txtNumFac.Text != "" && txtNumLiv.Text != "" && txtRueFac.Text != "" && txtRueLiv.Text != "" && txtVilleFac.Text != "" && 
                txtVilleLiv.Text != "" && txtCpFac.Text !="" && txtCpLiv.Text!="" && txtTel.Text !="" && txtFax.Text!="" && txtEmail.Text!="")
            {
                string nom = txtNom.Text;
                if (int.TryParse(txtNumFac.Text, out numFac) && int.TryParse(txtNumLiv.Text, out numLiv))
                {
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
                    else
                    {
                        foreach (var groupbox in this.Controls.OfType<GroupBox>())
                        {
                            foreach (var textboxitem in groupbox.Controls.OfType<TextBox>())
                            {
                                textboxitem.Clear();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Entier attendu pour N°Facturation/N°Livraison", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dataGridViewClient.DataSource = liste;
        }

        private void DgvEvent(object sender, DataGridViewCellEventArgs e)
        {
            bool verifModif = false;
            bool verifSuppression = false;
            int id = int.Parse(dataGridViewClient.Rows[e.RowIndex].Cells[2].Value.ToString());

            string addFac = dataGridViewClient.Rows[e.RowIndex].Cells[4].Value.ToString();
            string[] addFacSplit = addFac.Split(',');


            string addLiv = dataGridViewClient.Rows[e.RowIndex].Cells[5].Value.ToString();
            string[] addLivSplit = addLiv.Split(',');

            int NumFac, NumLiv;
            if (dataGridViewClient.Rows[e.RowIndex].Cells[4].Value.ToString() != null && addFacSplit.Length == 4 && addLivSplit.Length == 4 && 
                dataGridViewClient.Rows[e.RowIndex].Cells[6].Value.ToString() != null && dataGridViewClient.Rows[e.RowIndex].Cells[7].Value.ToString() != null && 
                dataGridViewClient.Rows[e.RowIndex].Cells[8].Value.ToString() != null)
            {
                string lbl = dataGridViewClient.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (!int.TryParse(addFacSplit[0], out NumFac) || !int.TryParse(addLivSplit[0], out NumLiv))
                {
                    MessageBox.Show("Veuillez renseigner tous les champs", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string rueFac = addFacSplit[1];
                    string villeFac = addFacSplit[2];
                    string cpFac = addFacSplit[3];

                    string rueLiv = addLivSplit[1];
                    string villeLiv = addLivSplit[2];
                    string cpLiv = addLivSplit[3];

                    string tel = dataGridViewClient.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string fax = dataGridViewClient.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string email = dataGridViewClient.Rows[e.RowIndex].Cells[8].Value.ToString();

                    Client client = new Client(id, lbl, NumFac, rueFac, villeFac, cpFac, NumLiv, rueLiv, villeLiv, cpLiv, tel, fax, email);

                    if (e.ColumnIndex == 0)
                    {
                        verifModif = GestionClients.ModifierClient(client);
                        if (!verifModif)
                        {
                            MessageBox.Show("ERREUR LORS DE LA MODIFICATION", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (e.ColumnIndex == 1)
                    {
                        if (MessageBox.Show("Voulez-vous vraiment supprimer ce client ?", "Validation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            verifSuppression = GestionClients.SupprimerClient(client);
                            if (!verifSuppression)
                            {
                                MessageBox.Show("Ce client est rattaché à un devis,\nimpossible de la supprimer.", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        /* Actualisation  des données du DGV */
                        List<Client> liste = new List<Client>();
                        liste = GestionClients.GetClients();
                        dataGridViewClient.DataSource = liste;
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez renseigner tous les champs", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
