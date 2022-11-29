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
            cbNomClient.ValueMember = "code_cli";
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
            foreach (Produit unProd in listeProd)
            {

                this.checkListProd.Items.Add(unProd.Libelle_prod, false);
            }
            #endregion
        }
    }
}
