using CommercialsBLL;
using CommercialsBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Commercials
{
    public partial class FrmConfirmationAjoutDevis : Form
    {
        public FrmConfirmationAjoutDevis(Client cli, Devis dev, List<Produit> listeConcerner)
        {
            InitializeComponent();

            lblNomDevis.Text = cli.Nom_cli.ToString();
            lblDateDevis.Text = dev.Date_dev.ToString();

            #region DGV
            // Blocage de la génération automatique des colonnes
            dataGridViewConcerner.AutoGenerateColumns = false;

            dataGridViewConcerner.ColumnHeadersVisible = true;

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();

            IdColumn.DataPropertyName = "Id_prod";
            IdColumn.HeaderText = "code produit";
            IdColumn.Visible = false;

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();

            NomColumn.DataPropertyName = "libelle_prod";
            NomColumn.HeaderText = "Libelle produit";
            NomColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn prixProdColumn = new DataGridViewTextBoxColumn();

            prixProdColumn.DataPropertyName = "Prix_ht_prod";
            prixProdColumn.HeaderText = "prix unitaire";
            prixProdColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn qteProdColumn = new DataGridViewTextBoxColumn();

            qteProdColumn.HeaderText = "quantiter produit";
            qteProdColumn.ReadOnly = false;
            qteProdColumn.Width = 140;

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn remProdColumn = new DataGridViewTextBoxColumn();

            remProdColumn.HeaderText = "remise produit";
            remProdColumn.ReadOnly = false;
            remProdColumn.Width = 120;


            // Ajout des 2 en-têtes de colonne au datagridview
            dataGridViewConcerner.Columns.Add(IdColumn);
            dataGridViewConcerner.Columns.Add(NomColumn);
            dataGridViewConcerner.Columns.Add(prixProdColumn);
            dataGridViewConcerner.Columns.Add(qteProdColumn);
            dataGridViewConcerner.Columns.Add(remProdColumn);

            // Définition du style apporté au datagridview
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 9, FontStyle.Bold);

            dataGridViewConcerner.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Création d'un objet List d'Produit à afficher dans le datagridview
            List<Produit> liste = new List<Produit>();
            liste = GestionProduits.GetProduitsConfirmation(listeConcerner);

            // Rattachement de la List à la source de données du datagridview
            dataGridViewConcerner.DataSource = liste;
            #endregion
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            bool verifAjout = false;
            Concerner concerne;
            Produit unProduit;
            Devis unDevis;
            int qteProd;
            float remProd;
            List<Devis> liste = new List<Devis>();
            liste = GestionDevis.GetDevisConcerner();

            for (int i = 0; i < dataGridViewConcerner.Rows.Count; i++)
            {
                unProduit = new Produit(int.Parse(dataGridViewConcerner.Rows[i].Cells[0].Value.ToString()), dataGridViewConcerner.Rows[i].Cells[1].Value.ToString());
                unDevis = new Devis(int.Parse(liste[0].Id_devis.ToString()), int.Parse(liste[0].TxTva.ToString()));
                if (dataGridViewConcerner.Rows[i].Cells[3].Value.ToString() != null && dataGridViewConcerner.Rows[i].Cells[4].Value.ToString() != null)
                {
                    qteProd = int.Parse(dataGridViewConcerner.Rows[i].Cells[3].Value.ToString());
                    remProd = float.Parse(dataGridViewConcerner.Rows[i].Cells[4].Value.ToString());
                    concerne = new Concerner(unProduit, unDevis, qteProd, remProd);

                    verifAjout = GestionConcerner.CreerConcerner(concerne);
                    if (!verifAjout)
                    {
                        MessageBox.Show("ERREUR LORS DE L'INSERTION", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Saisissez une quantité \nainsi qu'un taux de remise pour chaque produit\n(le taux de remise peut etre null)", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}