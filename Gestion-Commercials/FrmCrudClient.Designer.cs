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
            this.BtnActualiser = new System.Windows.Forms.Button();
            this.dataGridViewProduit = new System.Windows.Forms.DataGridView();
            this.btnDataGridViewModifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEvent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnProduits = new System.Windows.Forms.Button();
            this.btnSyntheseClients = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnDevis = new System.Windows.Forms.Button();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.gpBoxInformations = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtCpLivr = new System.Windows.Forms.TextBox();
            this.lblCpLivr = new System.Windows.Forms.Label();
            this.txtVillLivr = new System.Windows.Forms.TextBox();
            this.lblVillLivr = new System.Windows.Forms.Label();
            this.txtNumLivr = new System.Windows.Forms.TextBox();
            this.lblNumLivr = new System.Windows.Forms.Label();
            this.txtCpFac = new System.Windows.Forms.TextBox();
            this.lblCpFac = new System.Windows.Forms.Label();
            this.txtVilleFac = new System.Windows.Forms.TextBox();
            this.lblVilleFac = new System.Windows.Forms.Label();
            this.txtNumFac = new System.Windows.Forms.TextBox();
            this.lblNumFac = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).BeginInit();
            this.gpBoxInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnActualiser
            // 
            this.BtnActualiser.Location = new System.Drawing.Point(570, 512);
            this.BtnActualiser.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualiser.Name = "BtnActualiser";
            this.BtnActualiser.Size = new System.Drawing.Size(112, 28);
            this.BtnActualiser.TabIndex = 31;
            this.BtnActualiser.Text = "ACTUALISER";
            this.BtnActualiser.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProduit
            // 
            this.dataGridViewProduit.AllowUserToAddRows = false;
            this.dataGridViewProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDataGridViewModifier,
            this.btnEvent});
            this.dataGridViewProduit.Location = new System.Drawing.Point(324, 113);
            this.dataGridViewProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProduit.Name = "dataGridViewProduit";
            this.dataGridViewProduit.RowHeadersVisible = false;
            this.dataGridViewProduit.RowHeadersWidth = 51;
            this.dataGridViewProduit.RowTemplate.Height = 24;
            this.dataGridViewProduit.Size = new System.Drawing.Size(648, 393);
            this.dataGridViewProduit.TabIndex = 29;
            // 
            // btnDataGridViewModifier
            // 
            this.btnDataGridViewModifier.HeaderText = "modifier";
            this.btnDataGridViewModifier.MinimumWidth = 6;
            this.btnDataGridViewModifier.Name = "btnDataGridViewModifier";
            this.btnDataGridViewModifier.Width = 80;
            // 
            // btnEvent
            // 
            this.btnEvent.HeaderText = "supprimer";
            this.btnEvent.MinimumWidth = 6;
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Width = 125;
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
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(114, 25);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(213, 16);
            this.lblCategorie.TabIndex = 24;
            this.lblCategorie.Text = "Gestion commercials - PRODUITS";
            // 
            // gpBoxInformations
            // 
            this.gpBoxInformations.Controls.Add(this.button1);
            this.gpBoxInformations.Controls.Add(this.txtEmail);
            this.gpBoxInformations.Controls.Add(this.lblEmail);
            this.gpBoxInformations.Controls.Add(this.txtFax);
            this.gpBoxInformations.Controls.Add(this.lblFax);
            this.gpBoxInformations.Controls.Add(this.txtTel);
            this.gpBoxInformations.Controls.Add(this.lblTel);
            this.gpBoxInformations.Controls.Add(this.txtCpLivr);
            this.gpBoxInformations.Controls.Add(this.lblCpLivr);
            this.gpBoxInformations.Controls.Add(this.txtVillLivr);
            this.gpBoxInformations.Controls.Add(this.lblVillLivr);
            this.gpBoxInformations.Controls.Add(this.txtNumLivr);
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
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(174, 106);
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
            this.txtTel.Location = new System.Drawing.Point(174, 60);
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
            // txtCpLivr
            // 
            this.txtCpLivr.Location = new System.Drawing.Point(174, 275);
            this.txtCpLivr.Name = "txtCpLivr";
            this.txtCpLivr.Size = new System.Drawing.Size(100, 22);
            this.txtCpLivr.TabIndex = 13;
            // 
            // lblCpLivr
            // 
            this.lblCpLivr.AutoSize = true;
            this.lblCpLivr.Location = new System.Drawing.Point(175, 256);
            this.lblCpLivr.Name = "lblCpLivr";
            this.lblCpLivr.Size = new System.Drawing.Size(86, 16);
            this.lblCpLivr.TabIndex = 12;
            this.lblCpLivr.Text = "cp facturation";
            // 
            // txtVillLivr
            // 
            this.txtVillLivr.Location = new System.Drawing.Point(174, 224);
            this.txtVillLivr.Name = "txtVillLivr";
            this.txtVillLivr.Size = new System.Drawing.Size(100, 22);
            this.txtVillLivr.TabIndex = 11;
            // 
            // lblVillLivr
            // 
            this.lblVillLivr.AutoSize = true;
            this.lblVillLivr.Location = new System.Drawing.Point(175, 205);
            this.lblVillLivr.Name = "lblVillLivr";
            this.lblVillLivr.Size = new System.Drawing.Size(95, 16);
            this.lblVillLivr.TabIndex = 10;
            this.lblVillLivr.Text = "ville facturation";
            // 
            // txtNumLivr
            // 
            this.txtNumLivr.Location = new System.Drawing.Point(174, 169);
            this.txtNumLivr.Name = "txtNumLivr";
            this.txtNumLivr.Size = new System.Drawing.Size(100, 22);
            this.txtNumLivr.TabIndex = 9;
            // 
            // lblNumLivr
            // 
            this.lblNumLivr.AutoSize = true;
            this.lblNumLivr.Location = new System.Drawing.Point(164, 150);
            this.lblNumLivr.Name = "lblNumLivr";
            this.lblNumLivr.Size = new System.Drawing.Size(135, 16);
            this.lblNumLivr.TabIndex = 8;
            this.lblNumLivr.Text = "N° addresse livraison";
            // 
            // txtCpFac
            // 
            this.txtCpFac.Location = new System.Drawing.Point(35, 275);
            this.txtCpFac.Name = "txtCpFac";
            this.txtCpFac.Size = new System.Drawing.Size(100, 22);
            this.txtCpFac.TabIndex = 7;
            // 
            // lblCpFac
            // 
            this.lblCpFac.AutoSize = true;
            this.lblCpFac.Location = new System.Drawing.Point(36, 256);
            this.lblCpFac.Name = "lblCpFac";
            this.lblCpFac.Size = new System.Drawing.Size(86, 16);
            this.lblCpFac.TabIndex = 6;
            this.lblCpFac.Text = "cp facturation";
            // 
            // txtVilleFac
            // 
            this.txtVilleFac.Location = new System.Drawing.Point(35, 224);
            this.txtVilleFac.Name = "txtVilleFac";
            this.txtVilleFac.Size = new System.Drawing.Size(100, 22);
            this.txtVilleFac.TabIndex = 5;
            // 
            // lblVilleFac
            // 
            this.lblVilleFac.AutoSize = true;
            this.lblVilleFac.Location = new System.Drawing.Point(32, 205);
            this.lblVilleFac.Name = "lblVilleFac";
            this.lblVilleFac.Size = new System.Drawing.Size(95, 16);
            this.lblVilleFac.TabIndex = 4;
            this.lblVilleFac.Text = "ville facturation";
            // 
            // txtNumFac
            // 
            this.txtNumFac.Location = new System.Drawing.Point(35, 169);
            this.txtNumFac.Name = "txtNumFac";
            this.txtNumFac.Size = new System.Drawing.Size(100, 22);
            this.txtNumFac.TabIndex = 3;
            // 
            // lblNumFac
            // 
            this.lblNumFac.AutoSize = true;
            this.lblNumFac.Location = new System.Drawing.Point(12, 150);
            this.lblNumFac.Name = "lblNumFac";
            this.lblNumFac.Size = new System.Drawing.Size(146, 16);
            this.lblNumFac.TabIndex = 2;
            this.lblNumFac.Text = "N° addresse facturation";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(35, 60);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "AJOUTER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmCrudClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 564);
            this.Controls.Add(this.BtnActualiser);
            this.Controls.Add(this.dataGridViewProduit);
            this.Controls.Add(this.btnProduits);
            this.Controls.Add(this.btnSyntheseClients);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnDevis);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.gpBoxInformations);
            this.Name = "FrmCrudClient";
            this.Text = "CLIENT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).EndInit();
            this.gpBoxInformations.ResumeLayout(false);
            this.gpBoxInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnActualiser;
        private System.Windows.Forms.DataGridView dataGridViewProduit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDataGridViewModifier;
        private System.Windows.Forms.DataGridViewButtonColumn btnEvent;
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
        private System.Windows.Forms.TextBox txtCpLivr;
        private System.Windows.Forms.Label lblCpLivr;
        private System.Windows.Forms.TextBox txtVillLivr;
        private System.Windows.Forms.Label lblVillLivr;
        private System.Windows.Forms.TextBox txtNumLivr;
        private System.Windows.Forms.Label lblNumLivr;
        private System.Windows.Forms.TextBox txtCpFac;
        private System.Windows.Forms.Label lblCpFac;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Button button1;
    }
}