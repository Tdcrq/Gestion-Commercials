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
    public partial class FrmConfirmationDevis : Form
    {
        public FrmConfirmationDevis(Client cli, Devis dev, List<Concerner> listeConcerner)
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

            IdColumn.DataPropertyName = "Prod.Id_prod";
            IdColumn.HeaderText = "code produit";
            IdColumn.Visible = false;

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();

            NomColumn.DataPropertyName = "Prod.libelle_prod";
            NomColumn.HeaderText = "Libelle produit";

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn CodedevisColumn = new DataGridViewTextBoxColumn();

            CodedevisColumn.DataPropertyName = "tx_tva_dev";
            CodedevisColumn.HeaderText = "taux TVA";

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn prixProdColumn = new DataGridViewTextBoxColumn();

            prixProdColumn.DataPropertyName = "Prix_ht_prod";
            prixProdColumn.HeaderText = "prix unitaire";
            prixProdColumn.ReadOnly = false;

            // Création d'une en-tête de colonne pour la colonne 
            DataGridViewTextBoxColumn qteProdColumn = new DataGridViewTextBoxColumn();

            qteProdColumn.DataPropertyName = "qte_prod";
            qteProdColumn.HeaderText = "quantiter produit";


            // Ajout des 2 en-têtes de colonne au datagridview
            dataGridViewConcerner.Columns.Add(IdColumn);
            dataGridViewConcerner.Columns.Add(NomColumn);
            dataGridViewConcerner.Columns.Add(CodedevisColumn);
            dataGridViewConcerner.Columns.Add(prixProdColumn);
            dataGridViewConcerner.Columns.Add(qteProdColumn);

            // Définition du style apporté au datagridview
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 9, FontStyle.Bold);

            dataGridViewConcerner.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Rattachement de la List à la source de données du datagridview
            dataGridViewConcerner.DataSource = listeConcerner;
            #endregion
        }
    }
}