using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommercialsBO;
using CommercialsBLL;

namespace Gestion_Commercials
{
    public partial class FrmCrudProduit : Form
    {
        public FrmCrudProduit()
        {
            InitializeComponent();
        }

        private void FrmCrudProduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dECLICINFODataSet.PRODUIT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.pRODUITTableAdapter.Fill(this.dECLICINFODataSet.PRODUIT);
            // TODO: cette ligne de code charge les données dans la table 'dECLICINFODataSet.CATEGORIE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cATEGORIETableAdapter.Fill(this.dECLICINFODataSet.CATEGORIE);
        }

        private void modifLigne(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                string lbl = dataGridViewProduit.Rows[e.RowIndex].Cells[0].Value.ToString();
                float prix = float.Parse(dataGridViewProduit.Rows[e.RowIndex].Cells[1].Value.ToString());
                int categ = int.Parse(dataGridViewProduit.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }
    }
}
