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
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            bool verifAjout = false;
            int categ = int.Parse(listeInfoCategorie.SelectedValue.ToString());
            string lbl = txtInfoLibelle.Text;
            float prix = float.Parse(txtInfoPrix.Text);

            Produit prod = new Produit(lbl, prix, categ);

            verifAjout = GestionProduits.CreerProduit(prod);
        }

        private void btnModifLigne(object sender, DataGridViewCellEventArgs e)
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
            }
        }
    }
}
