using CommercialsBLL; // Référence la couche BLL
using CommercialsBO; // Référence la couche BO
using CommercialDAL; // Référence la couche DAL
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
            ConnexionBD.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Gestion_Commercials.Properties.Settings.DECLICINFOConnectionString"]);
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            // Création de l'objet Commercial avec le nom récupéré dans la GUI
            Commercial Comm = new Commercial(txtIdCo.Text, txtMdpCo.Text);
            CommercialDAO.VerifCommercials(Comm);

            if (Comm.GetVerif() == true)
            {
                this.Close();
                //FrmConnexion.ShowDialog(); // ouverture du formulaire
            }
            else
            {
                MessageBox.Show("IDENTIFIANT OU MOT DE PASSE INCORRECT", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}