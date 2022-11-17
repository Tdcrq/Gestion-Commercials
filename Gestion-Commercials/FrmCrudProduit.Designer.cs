namespace Gestion_Commercials
{
    partial class FrmCrudProduit
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
            this.btnProduits = new System.Windows.Forms.Button();
            this.btnSyntheseClients = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnDevis = new System.Windows.Forms.Button();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.listeInfoCategorie = new System.Windows.Forms.ComboBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.txtInfoPrix = new System.Windows.Forms.TextBox();
            this.lblInfoPrix = new System.Windows.Forms.Label();
            this.lblInfoCategorie = new System.Windows.Forms.Label();
            this.txtInfoLibelle = new System.Windows.Forms.TextBox();
            this.lblInfoLibelle = new System.Windows.Forms.Label();
            this.gpBoxInformations = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).BeginInit();
            this.gpBoxInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProduit
            // 
            this.dataGridViewProduit.AllowUserToAddRows = false;
            this.dataGridViewProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDataGridViewModifier});
            this.dataGridViewProduit.Location = new System.Drawing.Point(315, 124);
            this.dataGridViewProduit.Name = "dataGridViewProduit";
            this.dataGridViewProduit.RowHeadersVisible = false;
            this.dataGridViewProduit.RowHeadersWidth = 51;
            this.dataGridViewProduit.RowTemplate.Height = 24;
            this.dataGridViewProduit.Size = new System.Drawing.Size(623, 393);
            this.dataGridViewProduit.TabIndex = 21;
            // 
            // btnDataGridViewModifier
            // 
            this.btnDataGridViewModifier.HeaderText = "modifier";
            this.btnDataGridViewModifier.MinimumWidth = 6;
            this.btnDataGridViewModifier.Name = "btnDataGridViewModifier";
            this.btnDataGridViewModifier.Width = 125;
            // 
            // btnProduits
            // 
            this.btnProduits.Location = new System.Drawing.Point(60, 411);
            this.btnProduits.Name = "btnProduits";
            this.btnProduits.Size = new System.Drawing.Size(123, 23);
            this.btnProduits.TabIndex = 20;
            this.btnProduits.Text = "Produits";
            this.btnProduits.UseVisualStyleBackColor = true;
            // 
            // btnSyntheseClients
            // 
            this.btnSyntheseClients.Location = new System.Drawing.Point(60, 343);
            this.btnSyntheseClients.Name = "btnSyntheseClients";
            this.btnSyntheseClients.Size = new System.Drawing.Size(123, 23);
            this.btnSyntheseClients.TabIndex = 19;
            this.btnSyntheseClients.Text = "Synthèse Clients";
            this.btnSyntheseClients.UseVisualStyleBackColor = true;
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(60, 275);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(123, 23);
            this.btnClients.TabIndex = 18;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            // 
            // btnDevis
            // 
            this.btnDevis.Location = new System.Drawing.Point(60, 211);
            this.btnDevis.Name = "btnDevis";
            this.btnDevis.Size = new System.Drawing.Size(123, 23);
            this.btnDevis.TabIndex = 17;
            this.btnDevis.Text = "Devis";
            this.btnDevis.UseVisualStyleBackColor = true;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(105, 36);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(213, 16);
            this.lblCategorie.TabIndex = 16;
            this.lblCategorie.Text = "Gestion commercials - PRODUITS";
            // 
            // listeInfoCategorie
            // 
            this.listeInfoCategorie.FormattingEnabled = true;
            this.listeInfoCategorie.Location = new System.Drawing.Point(128, 103);
            this.listeInfoCategorie.Name = "listeInfoCategorie";
            this.listeInfoCategorie.Size = new System.Drawing.Size(128, 24);
            this.listeInfoCategorie.TabIndex = 9;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(156, 220);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(103, 23);
            this.btnAjout.TabIndex = 8;
            this.btnAjout.Text = "AJOUTER";
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // txtInfoPrix
            // 
            this.txtInfoPrix.Location = new System.Drawing.Point(128, 157);
            this.txtInfoPrix.Name = "txtInfoPrix";
            this.txtInfoPrix.Size = new System.Drawing.Size(100, 22);
            this.txtInfoPrix.TabIndex = 7;
            // 
            // lblInfoPrix
            // 
            this.lblInfoPrix.AutoSize = true;
            this.lblInfoPrix.Location = new System.Drawing.Point(23, 160);
            this.lblInfoPrix.Name = "lblInfoPrix";
            this.lblInfoPrix.Size = new System.Drawing.Size(84, 16);
            this.lblInfoPrix.TabIndex = 6;
            this.lblInfoPrix.Text = "Prix de vente";
            // 
            // lblInfoCategorie
            // 
            this.lblInfoCategorie.AutoSize = true;
            this.lblInfoCategorie.Location = new System.Drawing.Point(23, 107);
            this.lblInfoCategorie.Name = "lblInfoCategorie";
            this.lblInfoCategorie.Size = new System.Drawing.Size(66, 16);
            this.lblInfoCategorie.TabIndex = 4;
            this.lblInfoCategorie.Text = "Catégorie";
            // 
            // txtInfoLibelle
            // 
            this.txtInfoLibelle.Location = new System.Drawing.Point(128, 52);
            this.txtInfoLibelle.Name = "txtInfoLibelle";
            this.txtInfoLibelle.Size = new System.Drawing.Size(100, 22);
            this.txtInfoLibelle.TabIndex = 3;
            // 
            // lblInfoLibelle
            // 
            this.lblInfoLibelle.AutoSize = true;
            this.lblInfoLibelle.Location = new System.Drawing.Point(23, 55);
            this.lblInfoLibelle.Name = "lblInfoLibelle";
            this.lblInfoLibelle.Size = new System.Drawing.Size(47, 16);
            this.lblInfoLibelle.TabIndex = 2;
            this.lblInfoLibelle.Text = "Libellé";
            // 
            // gpBoxInformations
            // 
            this.gpBoxInformations.Controls.Add(this.listeInfoCategorie);
            this.gpBoxInformations.Controls.Add(this.btnAjout);
            this.gpBoxInformations.Controls.Add(this.txtInfoPrix);
            this.gpBoxInformations.Controls.Add(this.lblInfoPrix);
            this.gpBoxInformations.Controls.Add(this.lblInfoCategorie);
            this.gpBoxInformations.Controls.Add(this.txtInfoLibelle);
            this.gpBoxInformations.Controls.Add(this.lblInfoLibelle);
            this.gpBoxInformations.Location = new System.Drawing.Point(1058, 188);
            this.gpBoxInformations.Name = "gpBoxInformations";
            this.gpBoxInformations.Size = new System.Drawing.Size(290, 269);
            this.gpBoxInformations.TabIndex = 22;
            this.gpBoxInformations.TabStop = false;
            this.gpBoxInformations.Text = "Informations";
            // 
            // FrmCrudProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 564);
            this.Controls.Add(this.dataGridViewProduit);
            this.Controls.Add(this.btnProduits);
            this.Controls.Add(this.btnSyntheseClients);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnDevis);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.gpBoxInformations);
            this.Name = "FrmCrudProduit";
            this.Text = "PRODUIT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).EndInit();
            this.gpBoxInformations.ResumeLayout(false);
            this.gpBoxInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDataGridViewModifier;
        private System.Windows.Forms.Button btnProduits;
        private System.Windows.Forms.Button btnSyntheseClients;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnDevis;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.ComboBox listeInfoCategorie;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.TextBox txtInfoPrix;
        private System.Windows.Forms.Label lblInfoPrix;
        private System.Windows.Forms.Label lblInfoCategorie;
        private System.Windows.Forms.TextBox txtInfoLibelle;
        private System.Windows.Forms.Label lblInfoLibelle;
        private System.Windows.Forms.GroupBox gpBoxInformations;
    }
}