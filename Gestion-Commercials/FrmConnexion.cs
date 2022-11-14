using CommercialsBLL; // Référence la couche BLL
using CommercialsBO; // Référence la couche BO
using System;
using System.Configuration;
using System.Windows.Forms;


namespace Gestion_Commercials
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionCommercials.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Commercials"]);
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            // Création de l'objet Commercial avec le nom récupéré dans la GUI
            Commercial Comm = new Commercial(txtIdCo.Text, txtMdpCo.Text);

            if (Comm.GetVerif() == true)
            {
                this.Close();
                //FrmConnexion.ShowDialog(); // ouverture du formulaire
            }

        }
    }
}
