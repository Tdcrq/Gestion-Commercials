using CommercialDAL;
using CommercialsBLL;
using CommercialsBO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Gestion_Commercials
{
    public partial class FrmCrudDevis : Form
    {
        public FrmCrudDevis()
        {
            InitializeComponent();
            ConnexionBD.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Gestion_Commercials.Properties.Settings.DECLICINFOConnectionString"]);


            #region comboBox
            List<Client> listeClient = GestionClients.GetClients();
            cbNomClient.DisplayMember = "nom_cli";
            cbNomClient.ValueMember = "Code";
            cbNomClient.DataSource = listeClient;

            List<Statut> listeStatut = GestionStatut.GetStatut();
            cbStatut.DisplayMember = "libelle_stat";
            cbStatut.ValueMember = "code_stat";
            cbStatut.DataSource = listeStatut;
            /*combobox des categories produits*/
            /*List<Categorie> listeCat = GestionCategories.GetCategories();
            cbCategProd.DisplayMember = "libelle_cat";
            cbCategProd.ValueMember = "code_cat";
            cbCategProd.DataSource = listeCat;*/
            #endregion

            #region checkedListBox
            List<Produit> listeProd = GestionProduits.GetProduits();
            /*foreach (Produit unProd in listeProd)
            {

                this.checkListProd.Items.Add(unProd.Id_prod, false);
                this.checkListProd.Items.Add(unProd.Libelle_prod, false);
            }*/
            checkListProd.DataSource = listeProd;
            checkListProd.DisplayMember = "Libelle_prod";
            checkListProd.ValueMember = "Id_prod";
            #endregion
            #region dateTimePicker
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "MM-dd-yyyy ";
            #endregion
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            bool verifAjoutDevis = false;
            int TauxTva;
            int i = 0;

            if (txtTauxTva.Text !="" && int.TryParse(txtTauxTva.Text, out TauxTva))
            {
                #region ajout d'un devis en BDD
                /*string dateTime = dtpDate.Value.ToString();
                string[] dateTimeSplit = dateTime.Split(' ');
                string date = dateTimeSplit[0];
                string[] dateFormaBd = date.Split('/');
                date = dateFormaBd[2]+"-"+dateFormaBd[1]+"-"+dateFormaBd[0];*/
                DateTime date = dtpDate.Value;

                int statut = int.Parse(cbStatut.SelectedValue.ToString());
                int client = int.Parse(cbNomClient.SelectedValue.ToString());

                Statut unStatut = new Statut(statut, cbStatut.Text);
                Client unClient = new Client(client, cbNomClient.Text);
                Devis unDevis = new Devis(TauxTva, date, unStatut, unClient);

                verifAjoutDevis = GestionDevis.CreerDevis(unDevis);
                if (!verifAjoutDevis)
                {
                    MessageBox.Show("ERREUR LORS DE L'INSERTION", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
                #region ajout d'un objet concerner en BDD
                int codeProd;

                #endregion
            }
            else
            {
                MessageBox.Show("Veuillez renseigner le champ taux TVA avec un entier", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDevis_Click(object sender, EventArgs e)
        {
            Console.WriteLine(cbNomClient.SelectedValue);
        }
    }
}
