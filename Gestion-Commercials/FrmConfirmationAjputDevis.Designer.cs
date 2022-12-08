namespace Gestion_Commercials
{
    partial class FrmConfirmationAjputDevis
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
            this.lblPhraseDevis = new System.Windows.Forms.Label();
            this.lblDateDevis = new System.Windows.Forms.Label();
            this.lblNomDevis = new System.Windows.Forms.Label();
            this.dataGridViewConcerner = new System.Windows.Forms.DataGridView();
            this.btnAjout = new System.Windows.Forms.Button();
            this.lblInfoDgv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPhraseDevis
            // 
            this.lblPhraseDevis.AutoSize = true;
            this.lblPhraseDevis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhraseDevis.Location = new System.Drawing.Point(40, 64);
            this.lblPhraseDevis.Name = "lblPhraseDevis";
            this.lblPhraseDevis.Size = new System.Drawing.Size(159, 125);
            this.lblPhraseDevis.TabIndex = 0;
            this.lblPhraseDevis.Text = "Devis du clients :\r\n\r\ndu ,\r\n\r\nconcernant :";
            // 
            // lblDateDevis
            // 
            this.lblDateDevis.AutoSize = true;
            this.lblDateDevis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDevis.Location = new System.Drawing.Point(86, 113);
            this.lblDateDevis.Name = "lblDateDevis";
            this.lblDateDevis.Size = new System.Drawing.Size(180, 25);
            this.lblDateDevis.TabIndex = 1;
            this.lblDateDevis.Text = " date creation devis";
            // 
            // lblNomDevis
            // 
            this.lblNomDevis.AutoSize = true;
            this.lblNomDevis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomDevis.Location = new System.Drawing.Point(205, 64);
            this.lblNomDevis.Name = "lblNomDevis";
            this.lblNomDevis.Size = new System.Drawing.Size(100, 25);
            this.lblNomDevis.TabIndex = 2;
            this.lblNomDevis.Text = "nom client";
            // 
            // dataGridViewConcerner
            // 
            this.dataGridViewConcerner.AllowUserToAddRows = false;
            this.dataGridViewConcerner.AllowUserToDeleteRows = false;
            this.dataGridViewConcerner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConcerner.Location = new System.Drawing.Point(45, 256);
            this.dataGridViewConcerner.Name = "dataGridViewConcerner";
            this.dataGridViewConcerner.RowHeadersVisible = false;
            this.dataGridViewConcerner.RowHeadersWidth = 51;
            this.dataGridViewConcerner.RowTemplate.Height = 24;
            this.dataGridViewConcerner.Size = new System.Drawing.Size(613, 283);
            this.dataGridViewConcerner.TabIndex = 3;
            // 
            // btnAjout
            // 
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(536, 579);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(122, 44);
            this.btnAjout.TabIndex = 4;
            this.btnAjout.Text = "valider";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // lblInfoDgv
            // 
            this.lblInfoDgv.AutoSize = true;
            this.lblInfoDgv.Location = new System.Drawing.Point(42, 237);
            this.lblInfoDgv.Name = "lblInfoDgv";
            this.lblInfoDgv.Size = new System.Drawing.Size(502, 16);
            this.lblInfoDgv.TabIndex = 5;
            this.lblInfoDgv.Text = "(Vous devez remplir les champs, quantité produit et remise produit obligatoiremen" +
    "t)*";
            // 
            // FrmConfirmationAjputDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 635);
            this.Controls.Add(this.lblInfoDgv);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.dataGridViewConcerner);
            this.Controls.Add(this.lblNomDevis);
            this.Controls.Add(this.lblDateDevis);
            this.Controls.Add(this.lblPhraseDevis);
            this.Name = "FrmConfirmationAjputDevis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RECAPITULATIF DU DEVIS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhraseDevis;
        private System.Windows.Forms.Label lblDateDevis;
        private System.Windows.Forms.Label lblNomDevis;
        private System.Windows.Forms.DataGridView dataGridViewConcerner;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Label lblInfoDgv;
    }
}