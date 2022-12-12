namespace Gestion_Commercials
{
    partial class FrmConfirmationModifDevis
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
            this.lblNomClient = new System.Windows.Forms.Label();
            this.cbNomClient = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblProduit = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnAjoutProd = new System.Windows.Forms.Button();
            this.gbNvProduit = new System.Windows.Forms.GroupBox();
            this.txtRemProd = new System.Windows.Forms.TextBox();
            this.lblRemProd = new System.Windows.Forms.Label();
            this.txtQteProd = new System.Windows.Forms.TextBox();
            this.cbProduit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatut = new System.Windows.Forms.ComboBox();
            this.dataGridViewModifDevis = new System.Windows.Forms.DataGridView();
            this.supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblIdDevis = new System.Windows.Forms.Label();
            this.gbNvProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifDevis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomClient.Location = new System.Drawing.Point(59, 51);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(100, 25);
            this.lblNomClient.TabIndex = 1;
            this.lblNomClient.Text = "nom client";
            // 
            // cbNomClient
            // 
            this.cbNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNomClient.FormattingEnabled = true;
            this.cbNomClient.Location = new System.Drawing.Point(23, 78);
            this.cbNomClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNomClient.Name = "cbNomClient";
            this.cbNomClient.Size = new System.Drawing.Size(181, 33);
            this.cbNomClient.TabIndex = 22;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(238, 81);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(330, 30);
            this.dtpDate.TabIndex = 25;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(371, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 25);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "date";
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduit.Location = new System.Drawing.Point(110, 39);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(71, 25);
            this.lblProduit.TabIndex = 26;
            this.lblProduit.Text = "produit";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(294, 39);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(145, 25);
            this.lblProd.TabIndex = 41;
            this.lblProd.Text = "quantité produit";
            // 
            // btnAjout
            // 
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(576, 575);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(197, 44);
            this.btnAjout.TabIndex = 44;
            this.btnAjout.Text = "valider modification ";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnAjoutProd
            // 
            this.btnAjoutProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutProd.Location = new System.Drawing.Point(299, 105);
            this.btnAjoutProd.Name = "btnAjoutProd";
            this.btnAjoutProd.Size = new System.Drawing.Size(122, 44);
            this.btnAjoutProd.TabIndex = 46;
            this.btnAjoutProd.Text = "valider";
            this.btnAjoutProd.UseVisualStyleBackColor = true;
            this.btnAjoutProd.Click += new System.EventHandler(this.btnAjoutProd_Click);
            // 
            // gbNvProduit
            // 
            this.gbNvProduit.Controls.Add(this.txtRemProd);
            this.gbNvProduit.Controls.Add(this.lblRemProd);
            this.gbNvProduit.Controls.Add(this.txtQteProd);
            this.gbNvProduit.Controls.Add(this.lblProduit);
            this.gbNvProduit.Controls.Add(this.btnAjoutProd);
            this.gbNvProduit.Controls.Add(this.cbProduit);
            this.gbNvProduit.Controls.Add(this.lblProd);
            this.gbNvProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNvProduit.Location = new System.Drawing.Point(23, 136);
            this.gbNvProduit.Name = "gbNvProduit";
            this.gbNvProduit.Size = new System.Drawing.Size(750, 167);
            this.gbNvProduit.TabIndex = 47;
            this.gbNvProduit.TabStop = false;
            this.gbNvProduit.Text = "Pour ajouter un produit";
            // 
            // txtRemProd
            // 
            this.txtRemProd.Location = new System.Drawing.Point(498, 69);
            this.txtRemProd.Name = "txtRemProd";
            this.txtRemProd.Size = new System.Drawing.Size(182, 30);
            this.txtRemProd.TabIndex = 49;
            // 
            // lblRemProd
            // 
            this.lblRemProd.AutoSize = true;
            this.lblRemProd.Location = new System.Drawing.Point(515, 39);
            this.lblRemProd.Name = "lblRemProd";
            this.lblRemProd.Size = new System.Drawing.Size(112, 25);
            this.lblRemProd.TabIndex = 48;
            this.lblRemProd.Text = "taux remise";
            // 
            // txtQteProd
            // 
            this.txtQteProd.Location = new System.Drawing.Point(280, 69);
            this.txtQteProd.Name = "txtQteProd";
            this.txtQteProd.Size = new System.Drawing.Size(182, 30);
            this.txtQteProd.TabIndex = 47;
            // 
            // cbProduit
            // 
            this.cbProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduit.FormattingEnabled = true;
            this.cbProduit.Location = new System.Drawing.Point(46, 66);
            this.cbProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProduit.Name = "cbProduit";
            this.cbProduit.Size = new System.Drawing.Size(181, 33);
            this.cbProduit.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "statut";
            // 
            // cbStatut
            // 
            this.cbStatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatut.FormattingEnabled = true;
            this.cbStatut.Location = new System.Drawing.Point(592, 78);
            this.cbStatut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatut.Name = "cbStatut";
            this.cbStatut.Size = new System.Drawing.Size(181, 33);
            this.cbStatut.TabIndex = 48;
            // 
            // dataGridViewModifDevis
            // 
            this.dataGridViewModifDevis.AllowUserToAddRows = false;
            this.dataGridViewModifDevis.AllowUserToDeleteRows = false;
            this.dataGridViewModifDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModifDevis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supprimer});
            this.dataGridViewModifDevis.Location = new System.Drawing.Point(23, 373);
            this.dataGridViewModifDevis.Name = "dataGridViewModifDevis";
            this.dataGridViewModifDevis.RowHeadersVisible = false;
            this.dataGridViewModifDevis.RowHeadersWidth = 51;
            this.dataGridViewModifDevis.RowTemplate.Height = 24;
            this.dataGridViewModifDevis.Size = new System.Drawing.Size(750, 150);
            this.dataGridViewModifDevis.TabIndex = 49;
            // 
            // supprimer
            // 
            this.supprimer.HeaderText = "supp";
            this.supprimer.MinimumWidth = 6;
            this.supprimer.Name = "supprimer";
            this.supprimer.Width = 125;
            // 
            // lblIdDevis
            // 
            this.lblIdDevis.AutoSize = true;
            this.lblIdDevis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDevis.Location = new System.Drawing.Point(23, 13);
            this.lblIdDevis.Name = "lblIdDevis";
            this.lblIdDevis.Size = new System.Drawing.Size(78, 25);
            this.lblIdDevis.TabIndex = 50;
            this.lblIdDevis.Text = "id devis";
            this.lblIdDevis.Visible = false;
            // 
            // FrmConfirmationModifDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 655);
            this.Controls.Add(this.lblIdDevis);
            this.Controls.Add(this.dataGridViewModifDevis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStatut);
            this.Controls.Add(this.gbNvProduit);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cbNomClient);
            this.Controls.Add(this.lblNomClient);
            this.Name = "FrmConfirmationModifDevis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmComfirmationModif";
            this.gbNvProduit.ResumeLayout(false);
            this.gbNvProduit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifDevis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.ComboBox cbNomClient;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnAjoutProd;
        private System.Windows.Forms.GroupBox gbNvProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatut;
        private System.Windows.Forms.TextBox txtQteProd;
        private System.Windows.Forms.ComboBox cbProduit;
        private System.Windows.Forms.DataGridView dataGridViewModifDevis;
        private System.Windows.Forms.DataGridViewButtonColumn supprimer;
        private System.Windows.Forms.TextBox txtRemProd;
        private System.Windows.Forms.Label lblRemProd;
        private System.Windows.Forms.Label lblIdDevis;
    }
}