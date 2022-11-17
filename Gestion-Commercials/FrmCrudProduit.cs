﻿using CommercialsBLL;
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

            // Blocage de la génération automatique des colonnes
            dataGridViewProduit.AutoGenerateColumns = false;

            dataGridViewProduit.ColumnHeadersVisible = true;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();

            IdColumn.DataPropertyName = "code_prod";
            IdColumn.HeaderText = "Identifiant";
            IdColumn.Visible = false;

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();

            NomColumn.DataPropertyName = "libelle_prod";
            NomColumn.HeaderText = "Nom du Produit";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn PrixColumn = new DataGridViewTextBoxColumn();

            PrixColumn.DataPropertyName = "prix_ht_prod";
            PrixColumn.HeaderText = "Prix";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn CategColumn = new DataGridViewTextBoxColumn();

            CategColumn.DataPropertyName = "fk_code_cat";
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
            //dataGridViewProduit.DataSource = liste;
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
        }

        private void BtnModifLigne(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine("TTT");
            if (e.ColumnIndex == 4)
            {
                bool verifModif = false;

                int id = int.Parse(dataGridViewProduit.Rows[e.RowIndex].Cells[0].Value.ToString());
                string lbl = dataGridViewProduit.Rows[e.RowIndex].Cells[1].Value.ToString();
                float prix = float.Parse(dataGridViewProduit.Rows[e.RowIndex].Cells[2].Value.ToString());
                int categ = int.Parse(dataGridViewProduit.Rows[e.RowIndex].Cells[3].Value.ToString());

                Produit prod = new Produit(id, lbl, prix, categ);

                verifModif = GestionProduits.ModifierProduit(prod);

                if (!verifModif)
                {
                    MessageBox.Show("ERREUR LORS DE LA MODIFICATION", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
