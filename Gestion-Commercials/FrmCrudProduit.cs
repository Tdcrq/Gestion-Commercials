using CommercialsBLL;
using CommercialDAL;
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
using CommercialsBO;

namespace Gestion_Commercials
{
    public partial class FrmCrudProduit : Form
    {
        public FrmCrudProduit()
        {
            InitializeComponent();
            ConnexionBD.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Gestion_Commercials.Properties.Settings.DECLICINFOConnectionString"]);

            #region DGV
            // Blocage de la génération automatique des colonnes
            dataGridViewProduit.AutoGenerateColumns = false;

            dataGridViewProduit.ColumnHeadersVisible = true;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();

            IdColumn.DataPropertyName = "id_prod";
            IdColumn.HeaderText = "Identifiant";
            IdColumn.Visible = false;

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();

            NomColumn.DataPropertyName = "libelle_prod";
            NomColumn.HeaderText = "Nom";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn PrixColumn = new DataGridViewTextBoxColumn();

            PrixColumn.DataPropertyName = "prix_ht_prod";
            PrixColumn.HeaderText = "Prix";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn CategColumn = new DataGridViewTextBoxColumn();

            CategColumn.DataPropertyName = "fk_id_cat";
            CategColumn.HeaderText = "Catégorie";

            // Ajout des 2 en-têtes de colonne au datagridview
            dataGridViewProduit.Columns.Add(IdColumn);
            dataGridViewProduit.Columns.Add(NomColumn);
            dataGridViewProduit.Columns.Add(PrixColumn);
            dataGridViewProduit.Columns.Add(CategColumn);

            // Définition du style apporté au datagridview
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

            dataGridViewProduit.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Création d'un objet List d'Produit à afficher dans le datagridview
            List<Produit> liste = new List<Produit>();
            liste = GestionProduits.GetProduits();

            // Rattachement de la List à la source de données du datagridview
            dataGridViewProduit.DataSource = liste;
            #endregion

            #region comboBox
            List<Categorie> listeCat = GestionCategories.GetCategories();
            listeInfoCategorie.DisplayMember = "libelle_cat";
            listeInfoCategorie.ValueMember = "code_cat";
            listeInfoCategorie.DataSource = listeCat;
            #endregion
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            bool verifAjout = false;
            int categ = int.Parse(listeInfoCategorie.SelectedValue.ToString());
            string lbl = txtInfoLibelle.Text;
            float prix = float.Parse(txtInfoPrix.Text);

            Produit prod = new Produit(lbl, prix, categ);

            verifAjout = GestionProduits.CreerProduit(prod);
            if (!verifAjout)
            {
                MessageBox.Show("ERREUR LORS DE L'INSERTION", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Création d'un objet List d'Produit à afficher dans le datagridview
            List<Produit> liste = new List<Produit>();
            liste = GestionProduits.GetProduits();

            // Rattachement de la List à la source de données du datagridview
            dataGridViewProduit.DataSource = liste;
        }

        private void BtnEvent(object sender, DataGridViewCellEventArgs e)
        {
            bool verifModif = false;
            bool verifSuppression = false;
            int id = int.Parse(dataGridViewProduit.Rows[e.RowIndex].Cells[2].Value.ToString());
            string lbl = dataGridViewProduit.Rows[e.RowIndex].Cells[3].Value.ToString();
            float prix = float.Parse(dataGridViewProduit.Rows[e.RowIndex].Cells[4].Value.ToString());
            int categ = int.Parse(dataGridViewProduit.Rows[e.RowIndex].Cells[5].Value.ToString());

            Produit prod = new Produit(id, lbl, prix, categ);

            if (e.ColumnIndex == 0)
            {
                verifModif = GestionProduits.ModifierProduit(prod);
                if (!verifModif)
                {
                    MessageBox.Show("ERREUR LORS DE LA MODIFICATION", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.ColumnIndex == 1)
            {
                verifSuppression = GestionProduits.DeleteProduit(prod);
                if (!verifSuppression)
                {
                    MessageBox.Show("ERREUR LORS DE LA SUPPRESSION", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Création d'un objet List d'Produit à afficher dans le datagridview
            List<Produit> liste = new List<Produit>();
            liste = GestionProduits.GetProduits();

            // Rattachement de la List à la source de données du datagridview
            dataGridViewProduit.DataSource = liste;
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
