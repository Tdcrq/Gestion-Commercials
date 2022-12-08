using CommercialDAL;
using CommercialsBLL;
using CommercialsBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Gestion_Commercials
{
    public partial class FrmCrudDevis : Form
    {
        public FrmCrudDevis()
        {
            InitializeComponent();
            ConnexionBD.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Gestion_Commercials.Properties.Settings.DECLICINFOConnectionString"]);

            #region DGV
            // Blocage de la génération automatique des colonnes
            dataGridViewDevis.AutoGenerateColumns = false;
            dataGridViewDevis.ColumnHeadersVisible = true;

            // Colonne 1
            DataGridViewTextBoxColumn IdDevisColumn = new DataGridViewTextBoxColumn();
            IdDevisColumn.DataPropertyName = "IdDevis";
            IdDevisColumn.HeaderText = "Identifiant Devis";
            IdDevisColumn.Visible = false;

            // Colonne 2
            DataGridViewTextBoxColumn NomClientColumn = new DataGridViewTextBoxColumn();
            NomClientColumn.DataPropertyName = "NomCli";
            NomClientColumn.HeaderText = "Nom Client";

            // Colonne 3
            DataGridViewTextBoxColumn DateDevisColumn = new DataGridViewTextBoxColumn();
            DateDevisColumn.DataPropertyName = "DateDevis";
            DateDevisColumn.HeaderText = "Date du Devis";
            
            // Colonne 4
            DataGridViewTextBoxColumn NbProduitColumn = new DataGridViewTextBoxColumn();
            NbProduitColumn.DataPropertyName = "NbProduit";
            NbProduitColumn.HeaderText = "Nombre de Produits";

            // Colonne 5
            DataGridViewTextBoxColumn PrixTtcColumn = new DataGridViewTextBoxColumn();
            PrixTtcColumn.DataPropertyName = "PrixTTC";
            PrixTtcColumn.HeaderText = "Prix TTC";

            // Colonne 6
            DataGridViewTextBoxColumn StatutColumn= new DataGridViewTextBoxColumn();
            StatutColumn.DataPropertyName = "LibelleStatut";
            StatutColumn.HeaderText = "Statut";

            // Définition du style apporté au datagridview
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridViewDevis.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            List<DonneesDevis> listDevis = new List<DonneesDevis>();
            listDevis = GestionDonneesDevis.GetDonneesDevis();
            dataGridViewDevis.DataSource = listDevis;
            #endregion

            #region comboBox
            List<Client> listeClient = GestionClients.GetClients();
            cbNomClient.DisplayMember = "nom_cli";
            cbNomClient.ValueMember = "Code";
            cbNomClient.DataSource = listeClient;

            dataGridViewDevis.Columns.Add(IdDevisColumn);
            dataGridViewDevis.Columns.Add(NomClientColumn);
            dataGridViewDevis.Columns.Add(NbProduitColumn);
            dataGridViewDevis.Columns.Add(PrixTtcColumn);
            dataGridViewDevis.Columns.Add(StatutColumn);

            List<Statut> listeStatut = GestionStatut.GetStatut();
            cbStatut.DisplayMember = "libelle_stat";
            cbStatut.ValueMember = "code_stat";
            cbStatut.DataSource = listeStatut;

            /*combobox des categories produits*/
            /*List<Categorie> listeCat = GestionCategories.GetCategories();
            cbCategProd.DisplayMember = "libelle_cat";
            cbCategProd.ValueMember = "code_cat";
            cbCategProd.DataSource = listeCat;*/
            #endregion

            #region checkedListBox
            List<Produit> listeProd = GestionProduits.GetProduits();
            checkListProd.DataSource = listeProd;
            checkListProd.DisplayMember = "Libelle_prod";
            checkListProd.ValueMember = "Id_prod";
            #endregion

            #region dateTimePicker
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "MM-dd-yyyy ";
            #endregion
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            bool verifAjoutDevis = false;
            int TauxTva;
            int TauxRemise;
            int i = 0;

            if (txtTauxTva.Text !="" && int.TryParse(txtTauxTva.Text, out TauxTva) && txtRemise.Text != "" && int.TryParse(txtRemise.Text, out TauxRemise))
            {
                #region ajout d'un devis en BDD
                DateTime date = dtpDate.Value;

                int statut = int.Parse(cbStatut.SelectedValue.ToString());
                int client = int.Parse(cbNomClient.SelectedValue.ToString());

                Statut unStatut = new Statut(statut, cbStatut.Text);
                Client unClient = new Client(client, cbNomClient.Text);
                Devis unDevis = new Devis(TauxTva, date, unStatut, unClient);
                List<Devis> listeDevisConcerner = new List<Devis>();

                verifAjoutDevis = GestionDevis.CreerDevis(unDevis);
                if (!verifAjoutDevis)
                {
                    MessageBox.Show("ERREUR LORS DE L'INSERTION", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion

                #region ajout d'un objet concerner en BDD
                bool verifAjoutConcerner = false;
                int remProd = int.Parse(txtRemise.Text.ToString());
                int qteProd = 1/*int.Parse(.ToString())*/;
                Produit unProduit = null;
                Concerner concerne = null;
                List<Concerner> listeConcerner = new List<Concerner>();
                foreach (Produit prod in checkListProd.CheckedItems)
                {
                    unProduit = new Produit(int.Parse(prod.Id_prod.ToString()), checkListProd.Items[i].ToString());
                    listeDevisConcerner = GestionDevis.GetDevisConcerner();
                    unDevis = listeDevisConcerner[0];
                    concerne = new Concerner(unProduit, unDevis, qteProd, remProd);
                    /*listeConcerner.Add(concerne);*/
                }
                FrmConfirmationDevis frmConfirmationDevis;
                frmConfirmationDevis = new FrmConfirmationDevis(unClient, unDevis, listeConcerner);
                frmConfirmationDevis.ShowDialog();

                /*verifAjoutConcerner = GestionConcerner.CreerConcerner(concerne);
                if (!verifAjoutConcerner)
                {
                    MessageBox.Show("ERREUR LORS DE L'INSERTION", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/

                #endregion
            }
            else
            {
                MessageBox.Show("Veuillez renseigner les champs taux TVA et taux remise avec un entier", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
