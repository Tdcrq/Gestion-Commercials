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
            this.btnEvent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnProduits = new System.Windows.Forms.Button();
            this.btnSyntheseClients = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnDevis = new System.Windows.Forms.Button();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.listeInfoCategorie = new System.Windows.Forms.ComboBox();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.txtInfoPrix = new System.Windows.Forms.TextBox();
            this.lblInfoPrix = new System.Windows.Forms.Label();
            this.lblInfoCategorie = new System.Windows.Forms.Label();
            this.txtInfoLibelle = new System.Windows.Forms.TextBox();
            this.lblInfoLibelle = new System.Windows.Forms.Label();
            this.gpBoxInformations = new System.Windows.Forms.GroupBox();
            this.BtnActualiser = new System.Windows.Forms.Button();
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
            this.dataGridViewProduit.Location = new System.Drawing.Point(236, 101);
            this.dataGridViewProduit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewProduit.Name = "dataGridViewProduit";
            this.dataGridViewProduit.RowHeadersVisible = false;
            this.dataGridViewProduit.RowHeadersWidth = 51;
            this.dataGridViewProduit.RowTemplate.Height = 24;
            this.dataGridViewProduit.Size = new System.Drawing.Size(486, 319);
            this.dataGridViewProduit.TabIndex = 21;
            this.dataGridViewProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BtnEvent);
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
            // 
            // btnProduits
            // 
            this.btnProduits.Location = new System.Drawing.Point(45, 334);
            this.btnProduits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProduits.Name = "btnProduits";
            this.btnProduits.Size = new System.Drawing.Size(92, 19);
            this.btnProduits.TabIndex = 20;
            this.btnProduits.Text = "Produits";
            this.btnProduits.UseVisualStyleBackColor = true;
            // 
            // btnSyntheseClients
            // 
            this.btnSyntheseClients.Location = new System.Drawing.Point(45, 279);
            this.btnSyntheseClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSyntheseClients.Name = "btnSyntheseClients";
            this.btnSyntheseClients.Size = new System.Drawing.Size(92, 19);
            this.btnSyntheseClients.TabIndex = 19;
            this.btnSyntheseClients.Text = "Synthèse Clients";
            this.btnSyntheseClients.UseVisualStyleBackColor = true;
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(45, 223);
            this.btnClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(92, 19);
            this.btnClients.TabIndex = 18;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            // 
            // btnDevis
            // 
            this.btnDevis.Location = new System.Drawing.Point(45, 171);
            this.btnDevis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDevis.Name = "btnDevis";
            this.btnDevis.Size = new System.Drawing.Size(92, 19);
            this.btnDevis.TabIndex = 17;
            this.btnDevis.Text = "Devis";
            this.btnDevis.UseVisualStyleBackColor = true;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(79, 29);
            this.lblCategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(169, 13);
            this.lblCategorie.TabIndex = 16;
            this.lblCategorie.Text = "Gestion commercials - PRODUITS";
            // 
            // listeInfoCategorie
            // 
            this.listeInfoCategorie.FormattingEnabled = true;
            this.listeInfoCategorie.Location = new System.Drawing.Point(96, 84);
            this.listeInfoCategorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeInfoCategorie.Name = "listeInfoCategorie";
            this.listeInfoCategorie.Size = new System.Drawing.Size(97, 21);
            this.listeInfoCategorie.TabIndex = 9;
            // 
            // BtnAjout
            // 
            this.BtnAjout.Location = new System.Drawing.Point(117, 179);
            this.BtnAjout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(77, 19);
            this.BtnAjout.TabIndex = 8;
            this.BtnAjout.Text = "AJOUTER";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // txtInfoPrix
            // 
            this.txtInfoPrix.Location = new System.Drawing.Point(96, 128);
            this.txtInfoPrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInfoPrix.Name = "txtInfoPrix";
            this.txtInfoPrix.Size = new System.Drawing.Size(76, 20);
            this.txtInfoPrix.TabIndex = 7;
            // 
            // lblInfoPrix
            // 
            this.lblInfoPrix.AutoSize = true;
            this.lblInfoPrix.Location = new System.Drawing.Point(17, 130);
            this.lblInfoPrix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoPrix.Name = "lblInfoPrix";
            this.lblInfoPrix.Size = new System.Drawing.Size(69, 13);
            this.lblInfoPrix.TabIndex = 6;
            this.lblInfoPrix.Text = "Prix de vente";
            // 
            // lblInfoCategorie
            // 
            this.lblInfoCategorie.AutoSize = true;
            this.lblInfoCategorie.Location = new System.Drawing.Point(17, 87);
            this.lblInfoCategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoCategorie.Name = "lblInfoCategorie";
            this.lblInfoCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblInfoCategorie.TabIndex = 4;
            this.lblInfoCategorie.Text = "Catégorie";
            // 
            // txtInfoLibelle
            // 
            this.txtInfoLibelle.Location = new System.Drawing.Point(96, 42);
            this.txtInfoLibelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInfoLibelle.Name = "txtInfoLibelle";
            this.txtInfoLibelle.Size = new System.Drawing.Size(76, 20);
            this.txtInfoLibelle.TabIndex = 3;
            // 
            // lblInfoLibelle
            // 
            this.lblInfoLibelle.AutoSize = true;
            this.lblInfoLibelle.Location = new System.Drawing.Point(17, 45);
            this.lblInfoLibelle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoLibelle.Name = "lblInfoLibelle";
            this.lblInfoLibelle.Size = new System.Drawing.Size(37, 13);
            this.lblInfoLibelle.TabIndex = 2;
            this.lblInfoLibelle.Text = "Libellé";
            // 
            // gpBoxInformations
            // 
            this.gpBoxInformations.Controls.Add(this.listeInfoCategorie);
            this.gpBoxInformations.Controls.Add(this.BtnAjout);
            this.gpBoxInformations.Controls.Add(this.txtInfoPrix);
            this.gpBoxInformations.Controls.Add(this.lblInfoPrix);
            this.gpBoxInformations.Controls.Add(this.lblInfoCategorie);
            this.gpBoxInformations.Controls.Add(this.txtInfoLibelle);
            this.gpBoxInformations.Controls.Add(this.lblInfoLibelle);
            this.gpBoxInformations.Location = new System.Drawing.Point(794, 153);
            this.gpBoxInformations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpBoxInformations.Name = "gpBoxInformations";
            this.gpBoxInformations.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpBoxInformations.Size = new System.Drawing.Size(218, 219);
            this.gpBoxInformations.TabIndex = 22;
            this.gpBoxInformations.TabStop = false;
            this.gpBoxInformations.Text = "Informations";
            // 
            // BtnActualiser
            // 
            this.BtnActualiser.Location = new System.Drawing.Point(421, 425);
            this.BtnActualiser.Name = "BtnActualiser";
            this.BtnActualiser.Size = new System.Drawing.Size(84, 23);
            this.BtnActualiser.TabIndex = 23;
            this.BtnActualiser.Text = "ACTUALISER";
            this.BtnActualiser.UseVisualStyleBackColor = true;
            this.BtnActualiser.Click += new System.EventHandler(this.BtnActualiser_Click);
            // 
            // FrmCrudProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 458);
            this.Controls.Add(this.BtnActualiser);
            this.Controls.Add(this.dataGridViewProduit);
            this.Controls.Add(this.btnProduits);
            this.Controls.Add(this.btnSyntheseClients);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnDevis);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.gpBoxInformations);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnProduits;
        private System.Windows.Forms.Button btnSyntheseClients;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnDevis;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.ComboBox listeInfoCategorie;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.TextBox txtInfoPrix;
        private System.Windows.Forms.Label lblInfoPrix;
        private System.Windows.Forms.Label lblInfoCategorie;
        private System.Windows.Forms.TextBox txtInfoLibelle;
        private System.Windows.Forms.Label lblInfoLibelle;
        private System.Windows.Forms.GroupBox gpBoxInformations;
        private System.Windows.Forms.DataGridViewButtonColumn btnDataGridViewModifier;
        private System.Windows.Forms.DataGridViewButtonColumn btnEvent;
        private System.Windows.Forms.Button BtnActualiser;
    }
}