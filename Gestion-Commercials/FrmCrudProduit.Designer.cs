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
            this.lblCategorie = new System.Windows.Forms.Label();
            this.btnDevis = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnSyntheseClients = new System.Windows.Forms.Button();
            this.btnProduits = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpBoxInformations = new System.Windows.Forms.GroupBox();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblInfoCode = new System.Windows.Forms.Label();
            this.txtInfoCode = new System.Windows.Forms.TextBox();
            this.txtInfoLibelle = new System.Windows.Forms.TextBox();
            this.lblInfoLibelle = new System.Windows.Forms.Label();
            this.lblInfoCategorie = new System.Windows.Forms.Label();
            this.txtInfoPrix = new System.Windows.Forms.TextBox();
            this.lblInfoPrix = new System.Windows.Forms.Label();
            this.btnInfoEnvoie = new System.Windows.Forms.Button();
            this.listeInfoCategorie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpBoxInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(80, 8);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(213, 16);
            this.lblCategorie.TabIndex = 0;
            this.lblCategorie.Text = "Gestion commercials - PRODUITS";
            // 
            // btnDevis
            // 
            this.btnDevis.Location = new System.Drawing.Point(29, 80);
            this.btnDevis.Name = "btnDevis";
            this.btnDevis.Size = new System.Drawing.Size(123, 23);
            this.btnDevis.TabIndex = 1;
            this.btnDevis.Text = "Devis";
            this.btnDevis.UseVisualStyleBackColor = true;
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(29, 144);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(123, 23);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            // 
            // btnSyntheseClients
            // 
            this.btnSyntheseClients.Location = new System.Drawing.Point(29, 212);
            this.btnSyntheseClients.Name = "btnSyntheseClients";
            this.btnSyntheseClients.Size = new System.Drawing.Size(123, 23);
            this.btnSyntheseClients.TabIndex = 3;
            this.btnSyntheseClients.Text = "Synthèse Clients";
            this.btnSyntheseClients.UseVisualStyleBackColor = true;
            // 
            // btnProduits
            // 
            this.btnProduits.Location = new System.Drawing.Point(29, 280);
            this.btnProduits.Name = "btnProduits";
            this.btnProduits.Size = new System.Drawing.Size(123, 23);
            this.btnProduits.TabIndex = 4;
            this.btnProduits.Text = "Produits";
            this.btnProduits.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(366, 384);
            this.dataGridView1.TabIndex = 5;
            // 
            // gpBoxInformations
            // 
            this.gpBoxInformations.Controls.Add(this.listeInfoCategorie);
            this.gpBoxInformations.Controls.Add(this.btnInfoEnvoie);
            this.gpBoxInformations.Controls.Add(this.txtInfoPrix);
            this.gpBoxInformations.Controls.Add(this.lblInfoPrix);
            this.gpBoxInformations.Controls.Add(this.lblInfoCategorie);
            this.gpBoxInformations.Controls.Add(this.txtInfoLibelle);
            this.gpBoxInformations.Controls.Add(this.lblInfoLibelle);
            this.gpBoxInformations.Controls.Add(this.txtInfoCode);
            this.gpBoxInformations.Controls.Add(this.lblInfoCode);
            this.gpBoxInformations.Location = new System.Drawing.Point(602, 144);
            this.gpBoxInformations.Name = "gpBoxInformations";
            this.gpBoxInformations.Size = new System.Drawing.Size(280, 320);
            this.gpBoxInformations.TabIndex = 6;
            this.gpBoxInformations.TabStop = false;
            this.gpBoxInformations.Text = "Informations";
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(637, 80);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(75, 23);
            this.btnNouveau.TabIndex = 0;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(764, 80);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // lblInfoCode
            // 
            this.lblInfoCode.AutoSize = true;
            this.lblInfoCode.Location = new System.Drawing.Point(32, 68);
            this.lblInfoCode.Name = "lblInfoCode";
            this.lblInfoCode.Size = new System.Drawing.Size(50, 20);
            this.lblInfoCode.TabIndex = 0;
            this.lblInfoCode.Text = "Code";
            // 
            // txtInfoCode
            // 
            this.txtInfoCode.Location = new System.Drawing.Point(137, 65);
            this.txtInfoCode.Name = "txtInfoCode";
            this.txtInfoCode.Size = new System.Drawing.Size(100, 22);
            this.txtInfoCode.TabIndex = 1;
            // 
            // txtInfoLibelle
            // 
            this.txtInfoLibelle.Location = new System.Drawing.Point(137, 122);
            this.txtInfoLibelle.Name = "txtInfoLibelle";
            this.txtInfoLibelle.Size = new System.Drawing.Size(100, 22);
            this.txtInfoLibelle.TabIndex = 3;
            // 
            // lblInfoLibelle
            // 
            this.lblInfoLibelle.AutoSize = true;
            this.lblInfoLibelle.Location = new System.Drawing.Point(32, 125);
            this.lblInfoLibelle.Name = "lblInfoLibelle";
            this.lblInfoLibelle.Size = new System.Drawing.Size(47, 16);
            this.lblInfoLibelle.TabIndex = 2;
            this.lblInfoLibelle.Text = "Libellé";
            // 
            // lblInfoCategorie
            // 
            this.lblInfoCategorie.AutoSize = true;
            this.lblInfoCategorie.Location = new System.Drawing.Point(32, 177);
            this.lblInfoCategorie.Name = "lblInfoCategorie";
            this.lblInfoCategorie.Size = new System.Drawing.Size(83, 20);
            this.lblInfoCategorie.TabIndex = 4;
            this.lblInfoCategorie.Text = "Catégorie";
            // 
            // txtInfoPrix
            // 
            this.txtInfoPrix.Location = new System.Drawing.Point(137, 227);
            this.txtInfoPrix.Name = "txtInfoPrix";
            this.txtInfoPrix.Size = new System.Drawing.Size(100, 22);
            this.txtInfoPrix.TabIndex = 7;
            // 
            // lblInfoPrix
            // 
            this.lblInfoPrix.AutoSize = true;
            this.lblInfoPrix.Location = new System.Drawing.Point(32, 230);
            this.lblInfoPrix.Name = "lblInfoPrix";
            this.lblInfoPrix.Size = new System.Drawing.Size(105, 20);
            this.lblInfoPrix.TabIndex = 6;
            this.lblInfoPrix.Text = "Prix de vente";
            // 
            // btnInfoEnvoie
            // 
            this.btnInfoEnvoie.Location = new System.Drawing.Point(190, 277);
            this.btnInfoEnvoie.Name = "btnInfoEnvoie";
            this.btnInfoEnvoie.Size = new System.Drawing.Size(75, 23);
            this.btnInfoEnvoie.TabIndex = 8;
            this.btnInfoEnvoie.Text = "Envoyer";
            this.btnInfoEnvoie.UseVisualStyleBackColor = true;
            // 
            // listeInfoCategorie
            // 
            this.listeInfoCategorie.FormattingEnabled = true;
            this.listeInfoCategorie.Location = new System.Drawing.Point(137, 173);
            this.listeInfoCategorie.Name = "listeInfoCategorie";
            this.listeInfoCategorie.Size = new System.Drawing.Size(128, 24);
            this.listeInfoCategorie.TabIndex = 9;
            // 
            // FrmCrudProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 531);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.gpBoxInformations);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnProduits);
            this.Controls.Add(this.btnSyntheseClients);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnDevis);
            this.Controls.Add(this.lblCategorie);
            this.Name = "FrmCrudProduit";
            this.Text = "PRODUIT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpBoxInformations.ResumeLayout(false);
            this.gpBoxInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Button btnDevis;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnSyntheseClients;
        private System.Windows.Forms.Button btnProduits;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpBoxInformations;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtInfoPrix;
        private System.Windows.Forms.Label lblInfoPrix;
        private System.Windows.Forms.Label lblInfoCategorie;
        private System.Windows.Forms.TextBox txtInfoLibelle;
        private System.Windows.Forms.Label lblInfoLibelle;
        private System.Windows.Forms.TextBox txtInfoCode;
        private System.Windows.Forms.Label lblInfoCode;
        private System.Windows.Forms.Button btnInfoEnvoie;
        private System.Windows.Forms.ComboBox listeInfoCategorie;
    }
}