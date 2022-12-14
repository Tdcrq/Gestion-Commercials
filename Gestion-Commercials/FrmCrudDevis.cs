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
using static System.Net.Mime.MediaTypeNames;
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

            // Colonne 2
            DataGridViewTextBoxColumn IdDevisColumn = new DataGridViewTextBoxColumn();
            IdDevisColumn.DataPropertyName = "IdDevis";
            IdDevisColumn.HeaderText = "Identifiant Devis";
            IdDevisColumn.Visible = false;

            // Colonne 3
            DataGridViewTextBoxColumn NomClientColumn = new DataGridViewTextBoxColumn();
            NomClientColumn.DataPropertyName = "NomCli";
            NomClientColumn.HeaderText = "Nom Client";

            // Colonne 4
            DataGridViewTextBoxColumn DateDevisColumn = new DataGridViewTextBoxColumn();
            DateDevisColumn.DataPropertyName = "DateDevis";
            DateDevisColumn.HeaderText = "Date du Devis";
            
            // Colonne 5
            DataGridViewTextBoxColumn NbProduitColumn = new DataGridViewTextBoxColumn();
            NbProduitColumn.DataPropertyName = "NbProduit";
            NbProduitColumn.HeaderText = "Nombre de Produits";

            // Colonne 6
            DataGridViewTextBoxColumn PrixTtcColumn = new DataGridViewTextBoxColumn();
            PrixTtcColumn.DataPropertyName = "PrixTTC";
            PrixTtcColumn.HeaderText = "Prix TTC";

            // Colonne 7
            DataGridViewTextBoxColumn StatutColumn= new DataGridViewTextBoxColumn();
            StatutColumn.DataPropertyName = "LibelleStatut";
            StatutColumn.HeaderText = "Statut";

            dataGridViewDevis.Columns.Add(IdDevisColumn);
            dataGridViewDevis.Columns.Add(NomClientColumn);
            dataGridViewDevis.Columns.Add(DateDevisColumn);
            dataGridViewDevis.Columns.Add(NbProduitColumn);
            dataGridViewDevis.Columns.Add(PrixTtcColumn);
            dataGridViewDevis.Columns.Add(StatutColumn);

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
                DateTime date = DateTime.Parse(dtpDate.Value.ToString("yyyy-MM-dd"));

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

                #region recuperation des produit du devis et redirection vers FrmConfirmationDevis
                Produit unProduit = null;

                List<Produit> listeProduitsConcerner = new List<Produit>();

                foreach (Produit prod in checkListProd.CheckedItems)
                {
                    unProduit = new Produit(int.Parse(prod.Id_prod.ToString()), prod.Libelle_prod.ToString());
                    listeDevisConcerner = GestionDevis.GetDevisConcerner();
                    listeProduitsConcerner.Add(prod);
                }
                FrmConfirmationAjoutDevis frmConfirmationDevis;
                frmConfirmationDevis = new FrmConfirmationAjoutDevis(unClient, unDevis, listeProduitsConcerner);
                frmConfirmationDevis.ShowDialog();

                #endregion
            }
            else
            {
                MessageBox.Show("Veuillez renseigner les champs taux TVA et taux remise avec un entier", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            List<DonneesDevis> listDevis = new List<DonneesDevis>();
            listDevis = GestionDonneesDevis.GetDonneesDevis();
            dataGridViewDevis.DataSource = listDevis;
        }

        private void DgvEvent(object sender, DataGridViewCellEventArgs e)
        {
            bool verifSuppression;
            DonneesDevis dd;
            List<DonneesDevis> listDevis = new List<DonneesDevis>();
            listDevis = GestionDonneesDevis.GetDonneesDevis();

            Client cli = listDevis[e.RowIndex].Cli;
            Devis dev = listDevis[e.RowIndex].Dev;

            List<Produit> listProd = new List<Produit>();
            listProd = listDevis[e.RowIndex].ProduitList;

            Statut stat = listDevis[e.RowIndex].Stat;

            dd = new DonneesDevis(cli, dev, listProd, stat);

            if (e.ColumnIndex == 0)
            {
                FrmConfirmationModifDevis frmComfirmationModifDevis;
                frmComfirmationModifDevis = new FrmConfirmationModifDevis(dd);
                frmComfirmationModifDevis.ShowDialog();
            } 
            else if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce devis ?", "Validation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    verifSuppression = GestionDevis.SupprimerDevis(dev);
                    if (!verifSuppression)
                    {
                        MessageBox.Show("Erreur du côté serveur lors de la suppression de ce devis. \nVeuillez réessayer dans quelques instants.", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                /* Actualisation  des données du DGV */
                listDevis = GestionDonneesDevis.GetDonneesDevis();
                dataGridViewDevis.DataSource = listDevis;
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
