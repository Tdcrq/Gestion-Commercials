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
            this.cbStatut = new System.Windows.Forms.ComboBox();
            this.lblProduit = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDataGridViewSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAjout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbNvProduit = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbNvProduit.SuspendLayout();
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
            this.dtpDate.Size = new System.Drawing.Size(318, 30);
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
            // cbStatut
            // 
            this.cbStatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatut.FormattingEnabled = true;
            this.cbStatut.Location = new System.Drawing.Point(46, 66);
            this.cbStatut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatut.Name = "cbStatut";
            this.cbStatut.Size = new System.Drawing.Size(181, 33);
            this.cbStatut.TabIndex = 27;
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
            this.lblProd.Size = new System.Drawing.Size(151, 25);
            this.lblProd.TabIndex = 41;
            this.lblProd.Text = "quantiter produit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDataGridViewSupprimer});
            this.dataGridView1.Location = new System.Drawing.Point(23, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 203);
            this.dataGridView1.TabIndex = 43;
            // 
            // btnDataGridViewSupprimer
            // 
            this.btnDataGridViewSupprimer.HeaderText = "sup";
            this.btnDataGridViewSupprimer.MinimumWidth = 6;
            this.btnDataGridViewSupprimer.Name = "btnDataGridViewSupprimer";
            this.btnDataGridViewSupprimer.ReadOnly = true;
            this.btnDataGridViewSupprimer.Width = 125;
            // 
            // btnAjout
            // 
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(651, 578);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(122, 44);
            this.btnAjout.TabIndex = 44;
            this.btnAjout.Text = "valider";
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(195, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 44);
            this.button1.TabIndex = 46;
            this.button1.Text = "valider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbNvProduit
            // 
            this.gbNvProduit.Controls.Add(this.textBox1);
            this.gbNvProduit.Controls.Add(this.lblProduit);
            this.gbNvProduit.Controls.Add(this.button1);
            this.gbNvProduit.Controls.Add(this.cbStatut);
            this.gbNvProduit.Controls.Add(this.lblProd);
            this.gbNvProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNvProduit.Location = new System.Drawing.Point(143, 136);
            this.gbNvProduit.Name = "gbNvProduit";
            this.gbNvProduit.Size = new System.Drawing.Size(533, 167);
            this.gbNvProduit.TabIndex = 47;
            this.gbNvProduit.TabStop = false;
            this.gbNvProduit.Text = "Ajouter un produit";
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
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(592, 78);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 33);
            this.comboBox1.TabIndex = 48;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 30);
            this.textBox1.TabIndex = 47;
            // 
            // FrmConfirmationModifDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gbNvProduit);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cbNomClient);
            this.Controls.Add(this.lblNomClient);
            this.Name = "FrmConfirmationModifDevis";
            this.Text = "FrmComfirmationModif";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbNvProduit.ResumeLayout(false);
            this.gbNvProduit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.ComboBox cbNomClient;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbStatut;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.DataGridViewButtonColumn btnDataGridViewSupprimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbNvProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}