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
            this.components = new System.ComponentModel.Container();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.btnDevis = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnSyntheseClients = new System.Windows.Forms.Button();
            this.btnProduits = new System.Windows.Forms.Button();
            this.dataGridViewProduit = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixhtprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkcodecatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDataGridViewModifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pRODUITBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dECLICINFODataSet = new Gestion_Commercials.DECLICINFODataSet();
            this.gpBoxInformations = new System.Windows.Forms.GroupBox();
            this.listeInfoCategorie = new System.Windows.Forms.ComboBox();
            this.cATEGORIEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dECLICINFODataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjout = new System.Windows.Forms.Button();
            this.txtInfoPrix = new System.Windows.Forms.TextBox();
            this.lblInfoPrix = new System.Windows.Forms.Label();
            this.lblInfoCategorie = new System.Windows.Forms.Label();
            this.txtInfoLibelle = new System.Windows.Forms.TextBox();
            this.lblInfoLibelle = new System.Windows.Forms.Label();
            this.cATEGORIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dECLICINFODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.cATEGORIETableAdapter = new Gestion_Commercials.DECLICINFODataSetTableAdapters.CATEGORIETableAdapter();
            this.dECLICINFODataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUITTableAdapter = new Gestion_Commercials.DECLICINFODataSetTableAdapters.PRODUITTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUITBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dECLICINFODataSet)).BeginInit();
            this.gpBoxInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dECLICINFODataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dECLICINFODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dECLICINFODataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUITBindingSource)).BeginInit();
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
            // dataGridViewProduit
            // 
            this.dataGridViewProduit.AllowUserToAddRows = false;
            this.dataGridViewProduit.AutoGenerateColumns = false;
            this.dataGridViewProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.libelleprodDataGridViewTextBoxColumn,
            this.prixhtprodDataGridViewTextBoxColumn,
            this.fkcodecatDataGridViewTextBoxColumn,
            this.btnDataGridViewModifier});
            this.dataGridViewProduit.DataSource = this.pRODUITBindingSource1;
            this.dataGridViewProduit.Location = new System.Drawing.Point(180, 80);
            this.dataGridViewProduit.Name = "dataGridViewProduit";
            this.dataGridViewProduit.RowHeadersVisible = false;
            this.dataGridViewProduit.RowHeadersWidth = 51;
            this.dataGridViewProduit.RowTemplate.Height = 24;
            this.dataGridViewProduit.Size = new System.Drawing.Size(623, 393);
            this.dataGridViewProduit.TabIndex = 5;
            this.dataGridViewProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModifLigne);
            // 
            // id
            // 
            this.id.DataPropertyName = "code_prod";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // libelleprodDataGridViewTextBoxColumn
            // 
            this.libelleprodDataGridViewTextBoxColumn.DataPropertyName = "libelle_prod";
            this.libelleprodDataGridViewTextBoxColumn.HeaderText = "nom";
            this.libelleprodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.libelleprodDataGridViewTextBoxColumn.Name = "libelleprodDataGridViewTextBoxColumn";
            this.libelleprodDataGridViewTextBoxColumn.Width = 125;
            // 
            // prixhtprodDataGridViewTextBoxColumn
            // 
            this.prixhtprodDataGridViewTextBoxColumn.DataPropertyName = "prix_ht_prod";
            this.prixhtprodDataGridViewTextBoxColumn.HeaderText = "prix ht";
            this.prixhtprodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixhtprodDataGridViewTextBoxColumn.Name = "prixhtprodDataGridViewTextBoxColumn";
            this.prixhtprodDataGridViewTextBoxColumn.Width = 125;
            // 
            // fkcodecatDataGridViewTextBoxColumn
            // 
            this.fkcodecatDataGridViewTextBoxColumn.DataPropertyName = "fk_code_cat";
            this.fkcodecatDataGridViewTextBoxColumn.HeaderText = "catégorie";
            this.fkcodecatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fkcodecatDataGridViewTextBoxColumn.Name = "fkcodecatDataGridViewTextBoxColumn";
            this.fkcodecatDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnDataGridViewModifier
            // 
            this.btnDataGridViewModifier.HeaderText = "modifier";
            this.btnDataGridViewModifier.MinimumWidth = 6;
            this.btnDataGridViewModifier.Name = "btnDataGridViewModifier";
            this.btnDataGridViewModifier.Width = 125;
            // 
            // pRODUITBindingSource1
            // 
            this.pRODUITBindingSource1.DataMember = "PRODUIT";
            this.pRODUITBindingSource1.DataSource = this.dECLICINFODataSet;
            // 
            // dECLICINFODataSet
            // 
            this.dECLICINFODataSet.DataSetName = "DECLICINFODataSet";
            this.dECLICINFODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gpBoxInformations.Location = new System.Drawing.Point(903, 144);
            this.gpBoxInformations.Name = "gpBoxInformations";
            this.gpBoxInformations.Size = new System.Drawing.Size(280, 320);
            this.gpBoxInformations.TabIndex = 6;
            this.gpBoxInformations.TabStop = false;
            this.gpBoxInformations.Text = "Informations";
            // 
            // listeInfoCategorie
            // 
            this.listeInfoCategorie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cATEGORIEBindingSource1, "code_cat", true));
            this.listeInfoCategorie.DataSource = this.cATEGORIEBindingSource1;
            this.listeInfoCategorie.DisplayMember = "libelle_cat";
            this.listeInfoCategorie.FormattingEnabled = true;
            this.listeInfoCategorie.Location = new System.Drawing.Point(137, 173);
            this.listeInfoCategorie.Name = "listeInfoCategorie";
            this.listeInfoCategorie.Size = new System.Drawing.Size(128, 24);
            this.listeInfoCategorie.TabIndex = 9;
            this.listeInfoCategorie.ValueMember = "code_cat";
            // 
            // cATEGORIEBindingSource1
            // 
            this.cATEGORIEBindingSource1.DataMember = "CATEGORIE";
            this.cATEGORIEBindingSource1.DataSource = this.dECLICINFODataSetBindingSource2;
            // 
            // dECLICINFODataSetBindingSource2
            // 
            this.dECLICINFODataSetBindingSource2.DataSource = this.dECLICINFODataSet;
            this.dECLICINFODataSetBindingSource2.Position = 0;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(162, 277);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(103, 23);
            this.btnAjout.TabIndex = 8;
            this.btnAjout.Text = "AJOUTER";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
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
            this.lblInfoPrix.Size = new System.Drawing.Size(84, 16);
            this.lblInfoPrix.TabIndex = 6;
            this.lblInfoPrix.Text = "Prix de vente";
            // 
            // lblInfoCategorie
            // 
            this.lblInfoCategorie.AutoSize = true;
            this.lblInfoCategorie.Location = new System.Drawing.Point(32, 177);
            this.lblInfoCategorie.Name = "lblInfoCategorie";
            this.lblInfoCategorie.Size = new System.Drawing.Size(66, 16);
            this.lblInfoCategorie.TabIndex = 4;
            this.lblInfoCategorie.Text = "Catégorie";
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
            // cATEGORIEBindingSource
            // 
            this.cATEGORIEBindingSource.DataMember = "CATEGORIE";
            this.cATEGORIEBindingSource.DataSource = this.dECLICINFODataSet;
            // 
            // dECLICINFODataSetBindingSource
            // 
            this.dECLICINFODataSetBindingSource.DataSource = this.dECLICINFODataSet;
            this.dECLICINFODataSetBindingSource.Position = 0;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(938, 80);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(75, 23);
            this.btnNouveau.TabIndex = 0;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(1065, 80);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // cATEGORIETableAdapter
            // 
            this.cATEGORIETableAdapter.ClearBeforeFill = true;
            // 
            // dECLICINFODataSetBindingSource1
            // 
            this.dECLICINFODataSetBindingSource1.DataSource = this.dECLICINFODataSet;
            this.dECLICINFODataSetBindingSource1.Position = 0;
            // 
            // pRODUITBindingSource
            // 
            this.pRODUITBindingSource.DataMember = "PRODUIT";
            this.pRODUITBindingSource.DataSource = this.dECLICINFODataSetBindingSource;
            // 
            // pRODUITTableAdapter
            // 
            this.pRODUITTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCrudProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 657);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.gpBoxInformations);
            this.Controls.Add(this.dataGridViewProduit);
            this.Controls.Add(this.btnProduits);
            this.Controls.Add(this.btnSyntheseClients);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnDevis);
            this.Controls.Add(this.lblCategorie);
            this.Name = "FrmCrudProduit";
            this.Text = "PRODUIT";
            this.Load += new System.EventHandler(this.FrmCrudProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUITBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dECLICINFODataSet)).EndInit();
            this.gpBoxInformations.ResumeLayout(false);
            this.gpBoxInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dECLICINFODataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dECLICINFODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dECLICINFODataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUITBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Button btnDevis;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnSyntheseClients;
        private System.Windows.Forms.Button btnProduits;
        private System.Windows.Forms.DataGridView dataGridViewProduit;
        private System.Windows.Forms.GroupBox gpBoxInformations;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtInfoPrix;
        private System.Windows.Forms.Label lblInfoPrix;
        private System.Windows.Forms.Label lblInfoCategorie;
        private System.Windows.Forms.TextBox txtInfoLibelle;
        private System.Windows.Forms.Label lblInfoLibelle;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.ComboBox listeInfoCategorie;
        private System.Windows.Forms.BindingSource dECLICINFODataSetBindingSource;
        private DECLICINFODataSet dECLICINFODataSet;
        private System.Windows.Forms.BindingSource cATEGORIEBindingSource;
        private DECLICINFODataSetTableAdapters.CATEGORIETableAdapter cATEGORIETableAdapter;
        private System.Windows.Forms.BindingSource dECLICINFODataSetBindingSource1;
        private System.Windows.Forms.BindingSource dECLICINFODataSetBindingSource2;
        private System.Windows.Forms.BindingSource pRODUITBindingSource;
        private DECLICINFODataSetTableAdapters.PRODUITTableAdapter pRODUITTableAdapter;
        private System.Windows.Forms.BindingSource cATEGORIEBindingSource1;
        private System.Windows.Forms.BindingSource pRODUITBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixhtprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkcodecatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnDataGridViewModifier;
    }
}