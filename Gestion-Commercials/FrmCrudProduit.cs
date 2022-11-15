using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: cette ligne de code charge les données dans la table 'dECLICINFODataSet.CATEGORIE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cATEGORIETableAdapter.Fill(this.dECLICINFODataSet.CATEGORIE);

        }
    }
}
