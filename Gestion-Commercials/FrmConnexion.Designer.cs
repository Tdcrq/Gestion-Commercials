namespace Gestion_Commercials
{
    partial class FrmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIdCo = new System.Windows.Forms.Label();
            this.lblMdpCo = new System.Windows.Forms.Label();
            this.txtIdCo = new System.Windows.Forms.TextBox();
            this.txtMdpCo = new System.Windows.Forms.TextBox();
            this.btnCo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdCo
            // 
            this.lblIdCo.AutoSize = true;
            this.lblIdCo.Location = new System.Drawing.Point(312, 78);
            this.lblIdCo.Name = "lblIdCo";
            this.lblIdCo.Size = new System.Drawing.Size(150, 16);
            this.lblIdCo.TabIndex = 0;
            this.lblIdCo.Text = "Saisisez votre identifiant";
            // 
            // lblMdpCo
            // 
            this.lblMdpCo.AutoSize = true;
            this.lblMdpCo.Location = new System.Drawing.Point(302, 167);
            this.lblMdpCo.Name = "lblMdpCo";
            this.lblMdpCo.Size = new System.Drawing.Size(176, 16);
            this.lblMdpCo.TabIndex = 0;
            this.lblMdpCo.Text = "Saisisez votre mot de passe";
            // 
            // txtIdCo
            // 
            this.txtIdCo.Location = new System.Drawing.Point(315, 118);
            this.txtIdCo.Name = "txtIdCo";
            this.txtIdCo.Size = new System.Drawing.Size(147, 22);
            this.txtIdCo.TabIndex = 1;
            // 
            // txtMdpCo
            // 
            this.txtMdpCo.Location = new System.Drawing.Point(315, 203);
            this.txtMdpCo.Name = "txtMdpCo";
            this.txtMdpCo.PasswordChar = '*';
            this.txtMdpCo.Size = new System.Drawing.Size(147, 22);
            this.txtMdpCo.TabIndex = 2;
            // 
            // btnCo
            // 
            this.btnCo.Location = new System.Drawing.Point(315, 257);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(147, 30);
            this.btnCo.TabIndex = 3;
            this.btnCo.Text = "connexion";
            this.btnCo.UseVisualStyleBackColor = true;
            this.btnCo.Click += new System.EventHandler(this.btnCo_Click);
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCo);
            this.Controls.Add(this.lblIdCo);
            this.Controls.Add(this.txtMdpCo);
            this.Controls.Add(this.txtIdCo);
            this.Controls.Add(this.lblMdpCo);
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONNEXION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCo;
        private System.Windows.Forms.Label lblMdpCo;
        private System.Windows.Forms.TextBox txtIdCo;
        private System.Windows.Forms.TextBox txtMdpCo;
        private System.Windows.Forms.Button btnCo;
    }
}
