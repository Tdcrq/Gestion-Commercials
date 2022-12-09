using CommercialsBLL;
using CommercialsBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Commercials
{
    public partial class FrmConfirmationModifDevis : Form
    {
        public FrmConfirmationModifDevis(DonneesDevis dd)
        {
            InitializeComponent();
            #region labelle
            lblIdDevis.Text = dd.IdDevis.ToString();
            #endregion

            #region DGV
            // Blocage de la génération automatique des colonnes
            dataGridViewModifDevis.AutoGenerateColumns = false;
            dataGridViewModifDevis.ColumnHeadersVisible = true;

           // Colonne 1
            DataGridViewTextBoxColumn IdProdColumn = new DataGridViewTextBoxColumn();
            IdProdColumn.DataPropertyName = "Id_prod";
            IdProdColumn.HeaderText = "Identifiant Produit";
            IdProdColumn.Visible = false;

            // Colonne 2
            DataGridViewTextBoxColumn libelleProduitColumn = new DataGridViewTextBoxColumn();
            libelleProduitColumn.DataPropertyName = "Libelle_prod";
            libelleProduitColumn.HeaderText = "Libelle Produits";
            libelleProduitColumn.ReadOnly = true;

            // Colonne 3
            DataGridViewTextBoxColumn PrixTColumn = new DataGridViewTextBoxColumn();
            PrixTColumn.DataPropertyName = "Prix_prod";
            PrixTColumn.HeaderText = "Prix TTC";
            PrixTColumn.ReadOnly = true;

            // Colonne 4
            DataGridViewTextBoxColumn QuantiterColumn = new DataGridViewTextBoxColumn();
            QuantiterColumn.DataPropertyName = "Qte_prod";
            QuantiterColumn.HeaderText = "quantiter produit";
            QuantiterColumn.Width = 140;
            QuantiterColumn.ReadOnly = false;

            // Colonne 5
            DataGridViewTextBoxColumn RemiseColumn = new DataGridViewTextBoxColumn();
            RemiseColumn.DataPropertyName = "Remise_prod";
            RemiseColumn.HeaderText = "remise produit";
            RemiseColumn.Width = 120;
            PrixTColumn.ReadOnly = false;

            dataGridViewModifDevis.Columns.Add(IdProdColumn);
            dataGridViewModifDevis.Columns.Add(libelleProduitColumn);
            dataGridViewModifDevis.Columns.Add(PrixTColumn);
            dataGridViewModifDevis.Columns.Add(QuantiterColumn);
            dataGridViewModifDevis.Columns.Add(RemiseColumn);

            // Définition du style apporté au datagridview
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridViewModifDevis.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            Devis dev = new Devis(int.Parse(dd.Dev.Id_devis.ToString()), int.Parse(dd.Dev.TxTva.ToString()));

            List<Concerner> listProduitConcerner = new List<Concerner>();
            listProduitConcerner = GestionConcerner.GetConcernerList(dev);
            dataGridViewModifDevis.DataSource = listProduitConcerner;
            #endregion

            #region comboBox
            List<Client> listeClient = GestionClients.GetClients();
            cbNomClient.DisplayMember = "nom_cli";
            cbNomClient.ValueMember = "Code";
            cbNomClient.DataSource = listeClient;
            cbNomClient.Text = dd.Cli.Nom_cli;

            List<Statut> listeStatut = GestionStatut.GetStatut();
            cbStatut.DisplayMember = "libelle_stat";
            cbStatut.ValueMember = "code_stat";
            cbStatut.DataSource = listeStatut;
            cbStatut.Text = dd.LibelleStatut;

            List<Produit> listeProduit = GestionProduits.GetProduits();
            cbProduit.DisplayMember = "Libelle_prod";
            cbProduit.ValueMember = "Id_prod";
            cbProduit.DataSource = listeProduit;
            #endregion

            #region dateTimePicker
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "MM-dd-yyyy ";
            dtpDate.Value = DateTime.Parse(dd.DateDevis.ToString());
            #endregion
        }

        private void btnAjoutProd_Click(object sender, EventArgs e)
        {
            bool verifAjout = false;
            int qte = int.Parse(txtQteProd.Text);
            float rem = float.Parse(txtRemProd.Text);
            Produit prod = new Produit(int.Parse(cbProduit.SelectedValue.ToString()), cbProduit.Text);
            Devis dev = new Devis(int.Parse(lblIdDevis.Text.ToString()));
            Concerner concerne = new Concerner(prod, dev, qte, rem);

            verifAjout = GestionConcerner.CreerConcerner(concerne);
            if (!verifAjout)
            {
                MessageBox.Show("ERREUR LORS DE L'INSERTION", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            List<Produit> listProduitConcerner = new List<Produit>();
            listProduitConcerner = GestionConcerner.GetProduitList(dev);
            dataGridViewModifDevis.DataSource = listProduitConcerner;
        }
    }
}
