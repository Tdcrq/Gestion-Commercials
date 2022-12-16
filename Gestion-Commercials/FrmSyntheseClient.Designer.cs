namespace Gestion_Commercials
{
    partial class FrmSyntheseClient
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
            this.dataGridViewSyntheseClients = new System.Windows.Forms.DataGridView();
            this.btnProduits = new System.Windows.Forms.Button();
            this.btnSyntheseClients = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnDevis = new System.Windows.Forms.Button();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.gpBoxInformations = new System.Windows.Forms.GroupBox();
            this.btnAnnulFiltr = new System.Windows.Forms.Button();
            this.btnAjoutFiltr = new System.Windows.Forms.Button();
            this.lblDebutFiltre = new System.Windows.Forms.Label();
            this.dTPDebutFiltre = new System.Windows.Forms.DateTimePicker();
            this.lblFinFiltre = new System.Windows.Forms.Label();
            this.dTPFinFiltre = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSyntheseClients)).BeginInit();
            this.gpBoxInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSyntheseClients
            // 
            this.dataGridViewSyntheseClients.AllowUserToAddRows = false;
            this.dataGridViewSyntheseClients.AllowUserToDeleteRows = false;
            this.dataGridViewSyntheseClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSyntheseClients.Location = new System.Drawing.Point(260, 130);
            this.dataGridViewSyntheseClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSyntheseClients.Name = "dataGridViewSyntheseClients";
            this.dataGridViewSyntheseClients.ReadOnly = true;
            this.dataGridViewSyntheseClients.RowHeadersVisible = false;
            this.dataGridViewSyntheseClients.RowHeadersWidth = 51;
            this.dataGridViewSyntheseClients.RowTemplate.Height = 24;
            this.dataGridViewSyntheseClients.Size = new System.Drawing.Size(764, 393);
            this.dataGridViewSyntheseClients.TabIndex = 43;
            // 
            // btnProduits
            // 
            this.btnProduits.Location = new System.Drawing.Point(60, 417);
            this.btnProduits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduits.Name = "btnProduits";
            this.btnProduits.Size = new System.Drawing.Size(123, 23);
            this.btnProduits.TabIndex = 42;
            this.btnProduits.Text = "Produits";
            this.btnProduits.UseVisualStyleBackColor = true;
            // 
            // btnSyntheseClients
            // 
            this.btnSyntheseClients.Location = new System.Drawing.Point(60, 350);
            this.btnSyntheseClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSyntheseClients.Name = "btnSyntheseClients";
            this.btnSyntheseClients.Size = new System.Drawing.Size(123, 23);
            this.btnSyntheseClients.TabIndex = 41;
            this.btnSyntheseClients.Text = "Synthèse Clients";
            this.btnSyntheseClients.UseVisualStyleBackColor = true;
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(60, 281);
            this.btnClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(123, 23);
            this.btnClients.TabIndex = 40;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            // 
            // btnDevis
            // 
            this.btnDevis.Location = new System.Drawing.Point(60, 217);
            this.btnDevis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDevis.Name = "btnDevis";
            this.btnDevis.Size = new System.Drawing.Size(123, 23);
            this.btnDevis.TabIndex = 39;
            this.btnDevis.Text = "Devis";
            this.btnDevis.UseVisualStyleBackColor = true;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(107, 42);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(276, 16);
            this.lblCategorie.TabIndex = 38;
            this.lblCategorie.Text = "Gestion commercials - SYNTHÈSE CLIENTS";
            // 
            // gpBoxInformations
            // 
            this.gpBoxInformations.Controls.Add(this.dTPFinFiltre);
            this.gpBoxInformations.Controls.Add(this.lblFinFiltre);
            this.gpBoxInformations.Controls.Add(this.dTPDebutFiltre);
            this.gpBoxInformations.Controls.Add(this.lblDebutFiltre);
            this.gpBoxInformations.Controls.Add(this.btnAnnulFiltr);
            this.gpBoxInformations.Controls.Add(this.btnAjoutFiltr);
            this.gpBoxInformations.Location = new System.Drawing.Point(1052, 130);
            this.gpBoxInformations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBoxInformations.Name = "gpBoxInformations";
            this.gpBoxInformations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBoxInformations.Size = new System.Drawing.Size(316, 393);
            this.gpBoxInformations.TabIndex = 44;
            this.gpBoxInformations.TabStop = false;
            this.gpBoxInformations.Text = "Filtres";
            // 
            // btnAnnulFiltr
            // 
            this.btnAnnulFiltr.Location = new System.Drawing.Point(85, 358);
            this.btnAnnulFiltr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnulFiltr.Name = "btnAnnulFiltr";
            this.btnAnnulFiltr.Size = new System.Drawing.Size(103, 23);
            this.btnAnnulFiltr.TabIndex = 41;
            this.btnAnnulFiltr.Text = "ANNULER";
            this.btnAnnulFiltr.UseVisualStyleBackColor = true;
            this.btnAnnulFiltr.Click += new System.EventHandler(this.btnAnnulFiltr_Click);
            // 
            // btnAjoutFiltr
            // 
            this.btnAjoutFiltr.Location = new System.Drawing.Point(197, 358);
            this.btnAjoutFiltr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjoutFiltr.Name = "btnAjoutFiltr";
            this.btnAjoutFiltr.Size = new System.Drawing.Size(103, 23);
            this.btnAjoutFiltr.TabIndex = 20;
            this.btnAjoutFiltr.Text = "APPLIQUER";
            this.btnAjoutFiltr.UseVisualStyleBackColor = true;
            this.btnAjoutFiltr.Click += new System.EventHandler(this.btnAjoutFiltr_Click);
            // 
            // lblDebutFiltre
            // 
            this.lblDebutFiltre.AutoSize = true;
            this.lblDebutFiltre.Location = new System.Drawing.Point(136, 70);
            this.lblDebutFiltre.Name = "lblDebutFiltre";
            this.lblDebutFiltre.Size = new System.Drawing.Size(30, 16);
            this.lblDebutFiltre.TabIndex = 42;
            this.lblDebutFiltre.Text = "Du :";
            // 
            // dTPDebutFiltre
            // 
            this.dTPDebutFiltre.Location = new System.Drawing.Point(58, 94);
            this.dTPDebutFiltre.Name = "dTPDebutFiltre";
            this.dTPDebutFiltre.Size = new System.Drawing.Size(200, 22);
            this.dTPDebutFiltre.TabIndex = 43;
            // 
            // lblFinFiltre
            // 
            this.lblFinFiltre.AutoSize = true;
            this.lblFinFiltre.Location = new System.Drawing.Point(136, 188);
            this.lblFinFiltre.Name = "lblFinFiltre";
            this.lblFinFiltre.Size = new System.Drawing.Size(29, 16);
            this.lblFinFiltre.TabIndex = 44;
            this.lblFinFiltre.Text = "Au :";
            // 
            // dTPFinFiltre
            // 
            this.dTPFinFiltre.Location = new System.Drawing.Point(58, 221);
            this.dTPFinFiltre.Name = "dTPFinFiltre";
            this.dTPFinFiltre.Size = new System.Drawing.Size(200, 22);
            this.dTPFinFiltre.TabIndex = 45;
            // 
            // FrmSyntheseClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 564);
            this.Controls.Add(this.dataGridViewSyntheseClients);
            this.Controls.Add(this.btnProduits);
            this.Controls.Add(this.btnSyntheseClients);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnDevis);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.gpBoxInformations);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSyntheseClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSyntheseClient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSyntheseClients)).EndInit();
            this.gpBoxInformations.ResumeLayout(false);
            this.gpBoxInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSyntheseClients;
        private System.Windows.Forms.Button btnProduits;
        private System.Windows.Forms.Button btnSyntheseClients;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnDevis;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.GroupBox gpBoxInformations;
        private System.Windows.Forms.Button btnAjoutFiltr;
        private System.Windows.Forms.Button btnAnnulFiltr;
        private System.Windows.Forms.DateTimePicker dTPFinFiltre;
        private System.Windows.Forms.Label lblFinFiltre;
        private System.Windows.Forms.DateTimePicker dTPDebutFiltre;
        private System.Windows.Forms.Label lblDebutFiltre;
    }
}