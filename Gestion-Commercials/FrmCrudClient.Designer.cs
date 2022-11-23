﻿namespace Gestion_Commercials
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
            this.dataGridViewProduit = new System.Windows.Forms.DataGridView();
            this.btnDataGridViewModifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEvent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnProduits = new System.Windows.Forms.Button();
            this.btnSyntheseClients = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnDevis = new System.Windows.Forms.Button();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.gpBoxInformations = new System.Windows.Forms.GroupBox();
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
            this.txtRueLiv = new System.Windows.Forms.TextBox();
            this.lblRueLiv = new System.Windows.Forms.Label();
            this.txtRueFac = new System.Windows.Forms.TextBox();
            this.lblRueFac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).BeginInit();
            this.gpBoxInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProduit
            // 
            this.dataGridViewProduit.AllowUserToAddRows = false;
            this.dataGridViewProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDataGridViewModifier,
            this.btnEvent});
            this.dataGridViewProduit.Location = new System.Drawing.Point(202, 92);
            this.dataGridViewProduit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewProduit.Name = "dataGridViewProduit";
            this.dataGridViewProduit.RowHeadersVisible = false;
            this.dataGridViewProduit.RowHeadersWidth = 51;
            this.dataGridViewProduit.RowTemplate.Height = 24;
            this.dataGridViewProduit.Size = new System.Drawing.Size(573, 319);
            this.dataGridViewProduit.TabIndex = 29;
            // 
            // btnDataGridViewModifier
            // 
            this.btnDataGridViewModifier.HeaderText = "modif";
            this.btnDataGridViewModifier.MinimumWidth = 55;
            this.btnDataGridViewModifier.Name = "btnDataGridViewModifier";
            this.btnDataGridViewModifier.Width = 60;
            // 
            // btnEvent
            // 
            this.btnEvent.HeaderText = "supp";
            this.btnEvent.MinimumWidth = 55;
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Width = 55;
            // 
            // btnProduits
            // 
            this.btnProduits.Location = new System.Drawing.Point(52, 325);
            this.btnProduits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProduits.Name = "btnProduits";
            this.btnProduits.Size = new System.Drawing.Size(92, 19);
            this.btnProduits.TabIndex = 28;
            this.btnProduits.Text = "Produits";
            this.btnProduits.UseVisualStyleBackColor = true;
            this.btnProduits.Click += new System.EventHandler(this.btnProduits_Click);
            // 
            // btnSyntheseClients
            // 
            this.btnSyntheseClients.Location = new System.Drawing.Point(52, 270);
            this.btnSyntheseClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSyntheseClients.Name = "btnSyntheseClients";
            this.btnSyntheseClients.Size = new System.Drawing.Size(92, 19);
            this.btnSyntheseClients.TabIndex = 27;
            this.btnSyntheseClients.Text = "Synthèse Clients";
            this.btnSyntheseClients.UseVisualStyleBackColor = true;
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(52, 214);
            this.btnClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(92, 19);
            this.btnClients.TabIndex = 26;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnDevis
            // 
            this.btnDevis.Location = new System.Drawing.Point(52, 162);
            this.btnDevis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDevis.Name = "btnDevis";
            this.btnDevis.Size = new System.Drawing.Size(92, 19);
            this.btnDevis.TabIndex = 25;
            this.btnDevis.Text = "Devis";
            this.btnDevis.UseVisualStyleBackColor = true;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(86, 20);
            this.lblCategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(151, 13);
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
            this.gpBoxInformations.Location = new System.Drawing.Point(796, 92);
            this.gpBoxInformations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpBoxInformations.Name = "gpBoxInformations";
            this.gpBoxInformations.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpBoxInformations.Size = new System.Drawing.Size(237, 319);
            this.gpBoxInformations.TabIndex = 30;
            this.gpBoxInformations.TabStop = false;
            this.gpBoxInformations.Text = "Informations";
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(148, 291);
            this.btnAjout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(77, 19);
            this.btnAjout.TabIndex = 20;
            this.btnAjout.Text = "AJOUTER";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.AjouterClient);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 86);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(76, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(128, 71);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(31, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "email";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(26, 86);
            this.txtFax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(76, 20);
            this.txtFax.TabIndex = 17;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(27, 71);
            this.lblFax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(21, 13);
            this.lblFax.TabIndex = 16;
            this.lblFax.Text = "fax";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(130, 49);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(76, 20);
            this.txtTel.TabIndex = 15;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(128, 33);
            this.lblTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(54, 13);
            this.lblTel.TabIndex = 14;
            this.lblTel.Text = "téléphone";
            // 
            // txtCpLiv
            // 
            this.txtCpLiv.Location = new System.Drawing.Point(130, 266);
            this.txtCpLiv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCpLiv.Name = "txtCpLiv";
            this.txtCpLiv.Size = new System.Drawing.Size(76, 20);
            this.txtCpLiv.TabIndex = 13;
            // 
            // lblCpLivr
            // 
            this.lblCpLivr.AutoSize = true;
            this.lblCpLivr.Location = new System.Drawing.Point(131, 251);
            this.lblCpLivr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpLivr.Name = "lblCpLivr";
            this.lblCpLivr.Size = new System.Drawing.Size(72, 13);
            this.lblCpLivr.TabIndex = 12;
            this.lblCpLivr.Text = "cp facturation";
            // 
            // txtVilleLiv
            // 
            this.txtVilleLiv.Location = new System.Drawing.Point(130, 225);
            this.txtVilleLiv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVilleLiv.Name = "txtVilleLiv";
            this.txtVilleLiv.Size = new System.Drawing.Size(76, 20);
            this.txtVilleLiv.TabIndex = 11;
            // 
            // lblVillLivr
            // 
            this.lblVillLivr.AutoSize = true;
            this.lblVillLivr.Location = new System.Drawing.Point(131, 210);
            this.lblVillLivr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVillLivr.Name = "lblVillLivr";
            this.lblVillLivr.Size = new System.Drawing.Size(78, 13);
            this.lblVillLivr.TabIndex = 10;
            this.lblVillLivr.Text = "ville facturation";
            // 
            // txtNumLiv
            // 
            this.txtNumLiv.Location = new System.Drawing.Point(130, 133);
            this.txtNumLiv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumLiv.Name = "txtNumLiv";
            this.txtNumLiv.Size = new System.Drawing.Size(76, 20);
            this.txtNumLiv.TabIndex = 9;
            // 
            // lblNumLivr
            // 
            this.lblNumLivr.AutoSize = true;
            this.lblNumLivr.Location = new System.Drawing.Point(123, 118);
            this.lblNumLivr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumLivr.Name = "lblNumLivr";
            this.lblNumLivr.Size = new System.Drawing.Size(106, 13);
            this.lblNumLivr.TabIndex = 8;
            this.lblNumLivr.Text = "N° addresse livraison";
            // 
            // txtCpFac
            // 
            this.txtCpFac.Location = new System.Drawing.Point(26, 266);
            this.txtCpFac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCpFac.Name = "txtCpFac";
            this.txtCpFac.Size = new System.Drawing.Size(76, 20);
            this.txtCpFac.TabIndex = 7;
            // 
            // lblCpFac
            // 
            this.lblCpFac.AutoSize = true;
            this.lblCpFac.Location = new System.Drawing.Point(27, 251);
            this.lblCpFac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpFac.Name = "lblCpFac";
            this.lblCpFac.Size = new System.Drawing.Size(72, 13);
            this.lblCpFac.TabIndex = 6;
            this.lblCpFac.Text = "cp facturation";
            // 
            // txtVilleFac
            // 
            this.txtVilleFac.Location = new System.Drawing.Point(26, 225);
            this.txtVilleFac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVilleFac.Name = "txtVilleFac";
            this.txtVilleFac.Size = new System.Drawing.Size(76, 20);
            this.txtVilleFac.TabIndex = 5;
            // 
            // lblVilleFac
            // 
            this.lblVilleFac.AutoSize = true;
            this.lblVilleFac.Location = new System.Drawing.Point(24, 210);
            this.lblVilleFac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVilleFac.Name = "lblVilleFac";
            this.lblVilleFac.Size = new System.Drawing.Size(78, 13);
            this.lblVilleFac.TabIndex = 4;
            this.lblVilleFac.Text = "ville facturation";
            // 
            // txtNumFac
            // 
            this.txtNumFac.Location = new System.Drawing.Point(26, 133);
            this.txtNumFac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumFac.Name = "txtNumFac";
            this.txtNumFac.Size = new System.Drawing.Size(76, 20);
            this.txtNumFac.TabIndex = 3;
            // 
            // lblNumFac
            // 
            this.lblNumFac.AutoSize = true;
            this.lblNumFac.Location = new System.Drawing.Point(9, 118);
            this.lblNumFac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumFac.Name = "lblNumFac";
            this.lblNumFac.Size = new System.Drawing.Size(118, 13);
            this.lblNumFac.TabIndex = 2;
            this.lblNumFac.Text = "N° addresse facturation";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(26, 49);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(76, 20);
            this.txtNom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(27, 33);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(27, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "nom";
            // 
            // txtRueLiv
            // 
            this.txtRueLiv.Location = new System.Drawing.Point(130, 178);
            this.txtRueLiv.Margin = new System.Windows.Forms.Padding(2);
            this.txtRueLiv.Name = "txtRueLiv";
            this.txtRueLiv.Size = new System.Drawing.Size(76, 20);
            this.txtRueLiv.TabIndex = 28;
            // 
            // lblRueLiv
            // 
            this.lblRueLiv.AutoSize = true;
            this.lblRueLiv.Location = new System.Drawing.Point(132, 162);
            this.lblRueLiv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRueLiv.Name = "lblRueLiv";
            this.lblRueLiv.Size = new System.Drawing.Size(63, 13);
            this.lblRueLiv.TabIndex = 27;
            this.lblRueLiv.Text = "rue livraison";
            // 
            // txtRueFac
            // 
            this.txtRueFac.Location = new System.Drawing.Point(26, 178);
            this.txtRueFac.Margin = new System.Windows.Forms.Padding(2);
            this.txtRueFac.Name = "txtRueFac";
            this.txtRueFac.Size = new System.Drawing.Size(76, 20);
            this.txtRueFac.TabIndex = 26;
            // 
            // lblRueFac
            // 
            this.lblRueFac.AutoSize = true;
            this.lblRueFac.Location = new System.Drawing.Point(26, 160);
            this.lblRueFac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRueFac.Name = "lblRueFac";
            this.lblRueFac.Size = new System.Drawing.Size(75, 13);
            this.lblRueFac.TabIndex = 25;
            this.lblRueFac.Text = "rue facturation";
            // 
            // FrmCrudClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 458);
            this.Controls.Add(this.dataGridViewProduit);
            this.Controls.Add(this.btnProduits);
            this.Controls.Add(this.btnSyntheseClients);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnDevis);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.gpBoxInformations);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCrudClient";
            this.Text = "CLIENT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).EndInit();
            this.gpBoxInformations.ResumeLayout(false);
            this.gpBoxInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProduit;
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