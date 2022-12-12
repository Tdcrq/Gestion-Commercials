namespace Gestion_Commercials
{
    partial class FrmCrudClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.btnDataGridViewModifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEvent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnProduits = new System.Windows.Forms.Button();
            this.btnSyntheseClients = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnDevis = new System.Windows.Forms.Button();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.gpBoxInformations = new System.Windows.Forms.GroupBox();
            this.txtRueLiv = new System.Windows.Forms.TextBox();
            this.lblRueLiv = new System.Windows.Forms.Label();
            this.txtRueFac = new System.Windows.Forms.TextBox();
            this.lblRueFac = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtCpLiv = new System.Windows.Forms.TextBox();
            this.lblCpLivr = new System.Windows.Forms.Label();
            this.txtVilleLiv = new System.Windows.Forms.TextBox();
            this.lblVillLivr = new System.Windows.Forms.Label();
            this.txtNumLiv = new System.Windows.Forms.TextBox();
            this.lblNumLivr = new System.Windows.Forms.Label();
            this.txtCpFac = new System.Windows.Forms.TextBox();
            this.lblCpFac = new System.Windows.Forms.Label();
            this.txtVilleFac = new System.Windows.Forms.TextBox();
            this.lblVilleFac = new System.Windows.Forms.Label();
            this.txtNumFac = new System.Windows.Forms.TextBox();
            this.lblNumFac = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.gpBoxInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDataGridViewModifier,
            this.btnEvent});
            this.dataGridViewClient.Location = new System.Drawing.Point(269, 113);
            this.dataGridViewClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowHeadersVisible = false;
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(764, 393);
            this.dataGridViewClient.TabIndex = 29;
            this.dataGridViewClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEvent);
            // 
            // btnDataGridViewModifier
            // 
            this.btnDataGridViewModifier.HeaderText = "modif";
            this.btnDataGridViewModifier.MinimumWidth = 55;
            this.btnDataGridViewModifier.Name = "btnDataGridViewModifier";
            this.btnDataGridViewModifier.ReadOnly = true;
            this.btnDataGridViewModifier.Width = 60;
            // 
            // btnEvent
            // 
            this.btnEvent.HeaderText = "supp";
            this.btnEvent.MinimumWidth = 55;
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.ReadOnly = true;
            this.btnEvent.Width = 55;
            // 
            // btnProduits
            // 
            this.btnProduits.Location = new System.Drawing.Point(69, 400);
            this.btnProduits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduits.Name = "btnProduits";
            this.btnProduits.Size = new System.Drawing.Size(123, 23);
            this.btnProduits.TabIndex = 28;
            this.btnProduits.Text = "Produits";
            this.btnProduits.UseVisualStyleBackColor = true;
            this.btnProduits.Click += new System.EventHandler(this.btnProduits_Click);
            // 
            // btnSyntheseClients
            // 
            this.btnSyntheseClients.Location = new System.Drawing.Point(69, 332);
            this.btnSyntheseClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSyntheseClients.Name = "btnSyntheseClients";
            this.btnSyntheseClients.Size = new System.Drawing.Size(123, 23);
            this.btnSyntheseClients.TabIndex = 27;
            this.btnSyntheseClients.Text = "Synthèse Clients";
            this.btnSyntheseClients.UseVisualStyleBackColor = true;
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(69, 263);
            this.btnClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(123, 23);
            this.btnClients.TabIndex = 26;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnDevis
            // 
            this.btnDevis.Location = new System.Drawing.Point(69, 199);
            this.btnDevis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDevis.Name = "btnDevis";
            this.btnDevis.Size = new System.Drawing.Size(123, 23);
            this.btnDevis.TabIndex = 25;
            this.btnDevis.Text = "Devis";
            this.btnDevis.UseVisualStyleBackColor = true;
            this.btnDevis.Click += new System.EventHandler(this.btnDevis_Click);
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(115, 25);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(190, 16);
            this.lblCategorie.TabIndex = 24;
            this.lblCategorie.Text = "Gestion commercials - CLIENT";
            // 
            // gpBoxInformations
            // 
            this.gpBoxInformations.Controls.Add(this.txtRueLiv);
            this.gpBoxInformations.Controls.Add(this.lblRueLiv);
            this.gpBoxInformations.Controls.Add(this.txtRueFac);
            this.gpBoxInformations.Controls.Add(this.lblRueFac);
            this.gpBoxInformations.Controls.Add(this.btnAjout);
            this.gpBoxInformations.Controls.Add(this.txtEmail);
            this.gpBoxInformations.Controls.Add(this.lblEmail);
            this.gpBoxInformations.Controls.Add(this.txtFax);
            this.gpBoxInformations.Controls.Add(this.lblFax);
            this.gpBoxInformations.Controls.Add(this.txtTel);
            this.gpBoxInformations.Controls.Add(this.lblTel);
            this.gpBoxInformations.Controls.Add(this.txtCpLiv);
            this.gpBoxInformations.Controls.Add(this.lblCpLivr);
            this.gpBoxInformations.Controls.Add(this.txtVilleLiv);
            this.gpBoxInformations.Controls.Add(this.lblVillLivr);
            this.gpBoxInformations.Controls.Add(this.txtNumLiv);
            this.gpBoxInformations.Controls.Add(this.lblNumLivr);
            this.gpBoxInformations.Controls.Add(this.txtCpFac);
            this.gpBoxInformations.Controls.Add(this.lblCpFac);
            this.gpBoxInformations.Controls.Add(this.txtVilleFac);
            this.gpBoxInformations.Controls.Add(this.lblVilleFac);
            this.gpBoxInformations.Controls.Add(this.txtNumFac);
            this.gpBoxInformations.Controls.Add(this.lblNumFac);
            this.gpBoxInformations.Controls.Add(this.txtNom);
            this.gpBoxInformations.Controls.Add(this.lblNom);
            this.gpBoxInformations.Location = new System.Drawing.Point(1061, 113);
            this.gpBoxInformations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBoxInformations.Name = "gpBoxInformations";
            this.gpBoxInformations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBoxInformations.Size = new System.Drawing.Size(316, 393);
            this.gpBoxInformations.TabIndex = 30;
            this.gpBoxInformations.TabStop = false;
            this.gpBoxInformations.Text = "Informations";
            // 
            // txtRueLiv
            // 
            this.txtRueLiv.Location = new System.Drawing.Point(173, 219);
            this.txtRueLiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRueLiv.Name = "txtRueLiv";
            this.txtRueLiv.Size = new System.Drawing.Size(100, 22);
            this.txtRueLiv.TabIndex = 28;
            // 
            // lblRueLiv
            // 
            this.lblRueLiv.AutoSize = true;
            this.lblRueLiv.Location = new System.Drawing.Point(176, 199);
            this.lblRueLiv.Name = "lblRueLiv";
            this.lblRueLiv.Size = new System.Drawing.Size(79, 16);
            this.lblRueLiv.TabIndex = 27;
            this.lblRueLiv.Text = "rue livraison";
            // 
            // txtRueFac
            // 
            this.txtRueFac.Location = new System.Drawing.Point(35, 219);
            this.txtRueFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRueFac.Name = "txtRueFac";
            this.txtRueFac.Size = new System.Drawing.Size(100, 22);
            this.txtRueFac.TabIndex = 26;
            // 
            // lblRueFac
            // 
            this.lblRueFac.AutoSize = true;
            this.lblRueFac.Location = new System.Drawing.Point(35, 197);
            this.lblRueFac.Name = "lblRueFac";
            this.lblRueFac.Size = new System.Drawing.Size(90, 16);
            this.lblRueFac.TabIndex = 25;
            this.lblRueFac.Text = "rue facturation";
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(197, 358);
            this.btnAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(103, 23);
            this.btnAjout.TabIndex = 20;
            this.btnAjout.Text = "AJOUTER";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.AjouterClient);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(173, 106);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(171, 87);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 16);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "email";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(35, 106);
            this.txtFax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 22);
            this.txtFax.TabIndex = 17;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(36, 87);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(24, 16);
            this.lblFax.TabIndex = 16;
            this.lblFax.Text = "fax";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(173, 60);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 22);
            this.txtTel.TabIndex = 15;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(171, 41);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(67, 16);
            this.lblTel.TabIndex = 14;
            this.lblTel.Text = "téléphone";
            // 
            // txtCpLiv
            // 
            this.txtCpLiv.Location = new System.Drawing.Point(173, 327);
            this.txtCpLiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCpLiv.Name = "txtCpLiv";
            this.txtCpLiv.Size = new System.Drawing.Size(100, 22);
            this.txtCpLiv.TabIndex = 13;
            // 
            // lblCpLivr
            // 
            this.lblCpLivr.AutoSize = true;
            this.lblCpLivr.Location = new System.Drawing.Point(175, 309);
            this.lblCpLivr.Name = "lblCpLivr";
            this.lblCpLivr.Size = new System.Drawing.Size(86, 16);
            this.lblCpLivr.TabIndex = 12;
            this.lblCpLivr.Text = "cp facturation";
            // 
            // txtVilleLiv
            // 
            this.txtVilleLiv.Location = new System.Drawing.Point(173, 277);
            this.txtVilleLiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVilleLiv.Name = "txtVilleLiv";
            this.txtVilleLiv.Size = new System.Drawing.Size(100, 22);
            this.txtVilleLiv.TabIndex = 11;
            // 
            // lblVillLivr
            // 
            this.lblVillLivr.AutoSize = true;
            this.lblVillLivr.Location = new System.Drawing.Point(175, 258);
            this.lblVillLivr.Name = "lblVillLivr";
            this.lblVillLivr.Size = new System.Drawing.Size(95, 16);
            this.lblVillLivr.TabIndex = 10;
            this.lblVillLivr.Text = "ville facturation";
            // 
            // txtNumLiv
            // 
            this.txtNumLiv.Location = new System.Drawing.Point(173, 164);
            this.txtNumLiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumLiv.Name = "txtNumLiv";
            this.txtNumLiv.Size = new System.Drawing.Size(100, 22);
            this.txtNumLiv.TabIndex = 9;
            // 
            // lblNumLivr
            // 
            this.lblNumLivr.AutoSize = true;
            this.lblNumLivr.Location = new System.Drawing.Point(164, 145);
            this.lblNumLivr.Name = "lblNumLivr";
            this.lblNumLivr.Size = new System.Drawing.Size(135, 16);
            this.lblNumLivr.TabIndex = 8;
            this.lblNumLivr.Text = "N° addresse livraison";
            // 
            // txtCpFac
            // 
            this.txtCpFac.Location = new System.Drawing.Point(35, 327);
            this.txtCpFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCpFac.Name = "txtCpFac";
            this.txtCpFac.Size = new System.Drawing.Size(100, 22);
            this.txtCpFac.TabIndex = 7;
            // 
            // lblCpFac
            // 
            this.lblCpFac.AutoSize = true;
            this.lblCpFac.Location = new System.Drawing.Point(36, 309);
            this.lblCpFac.Name = "lblCpFac";
            this.lblCpFac.Size = new System.Drawing.Size(86, 16);
            this.lblCpFac.TabIndex = 6;
            this.lblCpFac.Text = "cp facturation";
            // 
            // txtVilleFac
            // 
            this.txtVilleFac.Location = new System.Drawing.Point(35, 277);
            this.txtVilleFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVilleFac.Name = "txtVilleFac";
            this.txtVilleFac.Size = new System.Drawing.Size(100, 22);
            this.txtVilleFac.TabIndex = 5;
            // 
            // lblVilleFac
            // 
            this.lblVilleFac.AutoSize = true;
            this.lblVilleFac.Location = new System.Drawing.Point(32, 258);
            this.lblVilleFac.Name = "lblVilleFac";
            this.lblVilleFac.Size = new System.Drawing.Size(95, 16);
            this.lblVilleFac.TabIndex = 4;
            this.lblVilleFac.Text = "ville facturation";
            // 
            // txtNumFac
            // 
            this.txtNumFac.Location = new System.Drawing.Point(35, 164);
            this.txtNumFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumFac.Name = "txtNumFac";
            this.txtNumFac.Size = new System.Drawing.Size(100, 22);
            this.txtNumFac.TabIndex = 3;
            // 
            // lblNumFac
            // 
            this.lblNumFac.AutoSize = true;
            this.lblNumFac.Location = new System.Drawing.Point(12, 145);
            this.lblNumFac.Name = "lblNumFac";
            this.lblNumFac.Size = new System.Drawing.Size(146, 16);
            this.lblNumFac.TabIndex = 2;
            this.lblNumFac.Text = "N° addresse facturation";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(35, 60);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 22);
            this.txtNom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(36, 41);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(33, 16);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "nom";
            // 
            // FrmCrudClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 564);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.btnProduits);
            this.Controls.Add(this.btnSyntheseClients);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnDevis);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.gpBoxInformations);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCrudClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.gpBoxInformations.ResumeLayout(false);
            this.gpBoxInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button btnProduits;
        private System.Windows.Forms.Button btnSyntheseClients;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnDevis;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.GroupBox gpBoxInformations;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNumFac;
        private System.Windows.Forms.Label lblNumFac;
        private System.Windows.Forms.TextBox txtVilleFac;
        private System.Windows.Forms.Label lblVilleFac;
        private System.Windows.Forms.TextBox txtCpLiv;
        private System.Windows.Forms.Label lblCpLivr;
        private System.Windows.Forms.TextBox txtVilleLiv;
        private System.Windows.Forms.Label lblVillLivr;
        private System.Windows.Forms.TextBox txtNumLiv;
        private System.Windows.Forms.Label lblNumLivr;
        private System.Windows.Forms.TextBox txtCpFac;
        private System.Windows.Forms.Label lblCpFac;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.DataGridViewButtonColumn btnDataGridViewModifier;
        private System.Windows.Forms.DataGridViewButtonColumn btnEvent;
        private System.Windows.Forms.TextBox txtRueLiv;
        private System.Windows.Forms.Label lblRueLiv;
        private System.Windows.Forms.TextBox txtRueFac;
        private System.Windows.Forms.Label lblRueFac;
    }
}