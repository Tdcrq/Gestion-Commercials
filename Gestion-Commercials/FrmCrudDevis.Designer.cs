namespace Gestion_Commercials
{
    partial class FrmCrudDevis
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
            this.checkListProd = new System.Windows.Forms.CheckedListBox();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.btnDataGridViewModifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEvent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnProduits = new System.Windows.Forms.Button();
            this.btnSyntheseClients = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnDevis = new System.Windows.Forms.Button();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.gpBoxInformations = new System.Windows.Forms.GroupBox();
            this.lblProd = new System.Windows.Forms.Label();
            this.txtMontantTTC = new System.Windows.Forms.TextBox();
            this.lblMontantTTC = new System.Windows.Forms.Label();
            this.txtHtAr = new System.Windows.Forms.TextBox();
            this.lblHtAr = new System.Windows.Forms.Label();
            this.txtRemise = new System.Windows.Forms.TextBox();
            this.lblRemise = new System.Windows.Forms.Label();
            this.txtMontantTva = new System.Windows.Forms.TextBox();
            this.lblMontantTva = new System.Windows.Forms.Label();
            this.txtHtHr = new System.Windows.Forms.TextBox();
            this.lblHtHr = new System.Windows.Forms.Label();
            this.txtTauxTva = new System.Windows.Forms.TextBox();
            this.lblTauxTva = new System.Windows.Forms.Label();
            this.cbStatut = new System.Windows.Forms.ComboBox();
            this.lblStatut = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbNomClient = new System.Windows.Forms.ComboBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.lblNomClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.gpBoxInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkListProd
            // 
            this.checkListProd.FormattingEnabled = true;
            this.checkListProd.Location = new System.Drawing.Point(129, 120);
            this.checkListProd.Name = "checkListProd";
            this.checkListProd.Size = new System.Drawing.Size(181, 55);
            this.checkListProd.TabIndex = 40;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDataGridViewModifier,
            this.btnEvent});
            this.dataGridViewClient.Location = new System.Drawing.Point(260, 130);
            this.dataGridViewClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowHeadersVisible = false;
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(764, 393);
            this.dataGridViewClient.TabIndex = 36;
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
            this.btnProduits.Location = new System.Drawing.Point(60, 417);
            this.btnProduits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduits.Name = "btnProduits";
            this.btnProduits.Size = new System.Drawing.Size(123, 23);
            this.btnProduits.TabIndex = 35;
            this.btnProduits.Text = "Produits";
            this.btnProduits.UseVisualStyleBackColor = true;
            // 
            // btnSyntheseClients
            // 
            this.btnSyntheseClients.Location = new System.Drawing.Point(60, 349);
            this.btnSyntheseClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSyntheseClients.Name = "btnSyntheseClients";
            this.btnSyntheseClients.Size = new System.Drawing.Size(123, 23);
            this.btnSyntheseClients.TabIndex = 34;
            this.btnSyntheseClients.Text = "Synthèse Clients";
            this.btnSyntheseClients.UseVisualStyleBackColor = true;
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(60, 280);
            this.btnClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(123, 23);
            this.btnClients.TabIndex = 33;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            // 
            // btnDevis
            // 
            this.btnDevis.Location = new System.Drawing.Point(60, 216);
            this.btnDevis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDevis.Name = "btnDevis";
            this.btnDevis.Size = new System.Drawing.Size(123, 23);
            this.btnDevis.TabIndex = 32;
            this.btnDevis.Text = "Devis";
            this.btnDevis.UseVisualStyleBackColor = true;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(106, 42);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(183, 16);
            this.lblCategorie.TabIndex = 31;
            this.lblCategorie.Text = "Gestion commercials - DEVIS";
            // 
            // gpBoxInformations
            // 
            this.gpBoxInformations.Controls.Add(this.checkListProd);
            this.gpBoxInformations.Controls.Add(this.lblProd);
            this.gpBoxInformations.Controls.Add(this.txtMontantTTC);
            this.gpBoxInformations.Controls.Add(this.lblMontantTTC);
            this.gpBoxInformations.Controls.Add(this.txtHtAr);
            this.gpBoxInformations.Controls.Add(this.lblHtAr);
            this.gpBoxInformations.Controls.Add(this.txtRemise);
            this.gpBoxInformations.Controls.Add(this.lblRemise);
            this.gpBoxInformations.Controls.Add(this.txtMontantTva);
            this.gpBoxInformations.Controls.Add(this.lblMontantTva);
            this.gpBoxInformations.Controls.Add(this.txtHtHr);
            this.gpBoxInformations.Controls.Add(this.lblHtHr);
            this.gpBoxInformations.Controls.Add(this.txtTauxTva);
            this.gpBoxInformations.Controls.Add(this.lblTauxTva);
            this.gpBoxInformations.Controls.Add(this.cbStatut);
            this.gpBoxInformations.Controls.Add(this.lblStatut);
            this.gpBoxInformations.Controls.Add(this.dtpDate);
            this.gpBoxInformations.Controls.Add(this.lblDate);
            this.gpBoxInformations.Controls.Add(this.cbNomClient);
            this.gpBoxInformations.Controls.Add(this.btnAjout);
            this.gpBoxInformations.Controls.Add(this.lblNomClient);
            this.gpBoxInformations.Location = new System.Drawing.Point(1052, 130);
            this.gpBoxInformations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBoxInformations.Name = "gpBoxInformations";
            this.gpBoxInformations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBoxInformations.Size = new System.Drawing.Size(316, 393);
            this.gpBoxInformations.TabIndex = 37;
            this.gpBoxInformations.TabStop = false;
            this.gpBoxInformations.Text = "Informations";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(23, 120);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(48, 16);
            this.lblProd.TabIndex = 38;
            this.lblProd.Text = "produit";
            // 
            // txtMontantTTC
            // 
            this.txtMontantTTC.Location = new System.Drawing.Point(175, 283);
            this.txtMontantTTC.Name = "txtMontantTTC";
            this.txtMontantTTC.Size = new System.Drawing.Size(110, 22);
            this.txtMontantTTC.TabIndex = 37;
            // 
            // lblMontantTTC
            // 
            this.lblMontantTTC.AutoSize = true;
            this.lblMontantTTC.Location = new System.Drawing.Point(172, 264);
            this.lblMontantTTC.Name = "lblMontantTTC";
            this.lblMontantTTC.Size = new System.Drawing.Size(84, 16);
            this.lblMontantTTC.TabIndex = 36;
            this.lblMontantTTC.Text = "montant TTC";
            // 
            // txtHtAr
            // 
            this.txtHtAr.Location = new System.Drawing.Point(175, 239);
            this.txtHtAr.Name = "txtHtAr";
            this.txtHtAr.Size = new System.Drawing.Size(110, 22);
            this.txtHtAr.TabIndex = 35;
            // 
            // lblHtAr
            // 
            this.lblHtAr.AutoSize = true;
            this.lblHtAr.Location = new System.Drawing.Point(172, 220);
            this.lblHtAr.Name = "lblHtAr";
            this.lblHtAr.Size = new System.Drawing.Size(103, 16);
            this.lblHtAr.TabIndex = 34;
            this.lblHtAr.Text = "HT avec remise";
            // 
            // txtRemise
            // 
            this.txtRemise.Location = new System.Drawing.Point(259, 198);
            this.txtRemise.Name = "txtRemise";
            this.txtRemise.Size = new System.Drawing.Size(26, 22);
            this.txtRemise.TabIndex = 33;
            // 
            // lblRemise
            // 
            this.lblRemise.AutoSize = true;
            this.lblRemise.Location = new System.Drawing.Point(172, 198);
            this.lblRemise.Name = "lblRemise";
            this.lblRemise.Size = new System.Drawing.Size(81, 16);
            this.lblRemise.TabIndex = 32;
            this.lblRemise.Text = "Taux remise";
            // 
            // txtMontantTva
            // 
            this.txtMontantTva.Location = new System.Drawing.Point(39, 283);
            this.txtMontantTva.Name = "txtMontantTva";
            this.txtMontantTva.Size = new System.Drawing.Size(100, 22);
            this.txtMontantTva.TabIndex = 31;
            // 
            // lblMontantTva
            // 
            this.lblMontantTva.AutoSize = true;
            this.lblMontantTva.Location = new System.Drawing.Point(36, 264);
            this.lblMontantTva.Name = "lblMontantTva";
            this.lblMontantTva.Size = new System.Drawing.Size(84, 16);
            this.lblMontantTva.TabIndex = 30;
            this.lblMontantTva.Text = "montant TVA";
            // 
            // txtHtHr
            // 
            this.txtHtHr.Location = new System.Drawing.Point(39, 239);
            this.txtHtHr.Name = "txtHtHr";
            this.txtHtHr.Size = new System.Drawing.Size(100, 22);
            this.txtHtHr.TabIndex = 29;
            // 
            // lblHtHr
            // 
            this.lblHtHr.AutoSize = true;
            this.lblHtHr.Location = new System.Drawing.Point(36, 220);
            this.lblHtHr.Name = "lblHtHr";
            this.lblHtHr.Size = new System.Drawing.Size(99, 16);
            this.lblHtHr.TabIndex = 28;
            this.lblHtHr.Text = "HT hors remise";
            // 
            // txtTauxTva
            // 
            this.txtTauxTva.Location = new System.Drawing.Point(109, 192);
            this.txtTauxTva.Name = "txtTauxTva";
            this.txtTauxTva.Size = new System.Drawing.Size(26, 22);
            this.txtTauxTva.TabIndex = 27;
            // 
            // lblTauxTva
            // 
            this.lblTauxTva.AutoSize = true;
            this.lblTauxTva.Location = new System.Drawing.Point(36, 198);
            this.lblTauxTva.Name = "lblTauxTva";
            this.lblTauxTva.Size = new System.Drawing.Size(67, 16);
            this.lblTauxTva.TabIndex = 26;
            this.lblTauxTva.Text = "Taux TVA";
            // 
            // cbStatut
            // 
            this.cbStatut.FormattingEnabled = true;
            this.cbStatut.Location = new System.Drawing.Point(129, 84);
            this.cbStatut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatut.Name = "cbStatut";
            this.cbStatut.Size = new System.Drawing.Size(181, 24);
            this.cbStatut.TabIndex = 25;
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(23, 92);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(38, 16);
            this.lblStatut.TabIndex = 24;
            this.lblStatut.Text = "statut";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(86, 57);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(224, 22);
            this.dtpDate.TabIndex = 23;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(23, 62);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 16);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "date";
            // 
            // cbNomClient
            // 
            this.cbNomClient.FormattingEnabled = true;
            this.cbNomClient.Location = new System.Drawing.Point(129, 28);
            this.cbNomClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNomClient.Name = "cbNomClient";
            this.cbNomClient.Size = new System.Drawing.Size(181, 24);
            this.cbNomClient.TabIndex = 21;
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
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Location = new System.Drawing.Point(23, 36);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(67, 16);
            this.lblNomClient.TabIndex = 0;
            this.lblNomClient.Text = "nom client";
            // 
            // FrmCrudDevis
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
            this.Name = "FrmCrudDevis";
            this.Text = "DEVIS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.gpBoxInformations.ResumeLayout(false);
            this.gpBoxInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.DataGridViewButtonColumn btnDataGridViewModifier;
        private System.Windows.Forms.DataGridViewButtonColumn btnEvent;
        private System.Windows.Forms.Button btnProduits;
        private System.Windows.Forms.Button btnSyntheseClients;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnDevis;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.GroupBox gpBoxInformations;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.ComboBox cbNomClient;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbStatut;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.TextBox txtTauxTva;
        private System.Windows.Forms.Label lblTauxTva;
        private System.Windows.Forms.TextBox txtHtHr;
        private System.Windows.Forms.Label lblHtHr;
        private System.Windows.Forms.TextBox txtMontantTva;
        private System.Windows.Forms.Label lblMontantTva;
        private System.Windows.Forms.TextBox txtMontantTTC;
        private System.Windows.Forms.Label lblMontantTTC;
        private System.Windows.Forms.TextBox txtHtAr;
        private System.Windows.Forms.Label lblHtAr;
        private System.Windows.Forms.TextBox txtRemise;
        private System.Windows.Forms.Label lblRemise;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.CheckedListBox checkListProd;
    }
}