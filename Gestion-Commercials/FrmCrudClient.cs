using CommercialsBLL;
using CommercialDAL;
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
using System.Configuration;

namespace Gestion_Commercials
{
    public partial class FrmCrudClient : Form
    {
        public FrmCrudClient()
        {
            InitializeComponent();
            ConnexionBD.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Gestion_Commercials.Properties.Settings.DECLICINFOConnectionString"]);
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
