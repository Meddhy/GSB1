namespace GSB
{
    partial class frmBilan
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
            this.panelSelection = new System.Windows.Forms.Panel();
            this.cbxPraticien = new System.Windows.Forms.ComboBox();
            this.cbxDate = new System.Windows.Forms.ComboBox();
            this.panelSaisie = new System.Windows.Forms.Panel();
            this.btnEnregister = new System.Windows.Forms.Button();
            this.dgvEchantillons = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cptQuantite = new System.Windows.Forms.NumericUpDown();
            this.cbxEchantillon = new System.Windows.Forms.ComboBox();
            this.msgBilan = new System.Windows.Forms.Label();
            this.msgSecondMedicament = new System.Windows.Forms.Label();
            this.msgPremierMedicament = new System.Windows.Forms.Label();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.cbxSecondMedicament = new System.Windows.Forms.ComboBox();
            this.cbxPremierMedicament = new System.Windows.Forms.ComboBox();
            this.panelSelection.SuspendLayout();
            this.panelSaisie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cptQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSelection
            // 
            this.panelSelection.Controls.Add(this.cbxPraticien);
            this.panelSelection.Controls.Add(this.cbxDate);
            this.panelSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelection.Location = new System.Drawing.Point(0, 29);
            this.panelSelection.Name = "panelSelection";
            this.panelSelection.Size = new System.Drawing.Size(1215, 96);
            this.panelSelection.TabIndex = 13;
            // 
            // cbxPraticien
            // 
            this.cbxPraticien.FormattingEnabled = true;
            this.cbxPraticien.Location = new System.Drawing.Point(473, 32);
            this.cbxPraticien.Name = "cbxPraticien";
            this.cbxPraticien.Size = new System.Drawing.Size(260, 21);
            this.cbxPraticien.TabIndex = 1;
            this.cbxPraticien.SelectionChangeCommitted += new System.EventHandler(this.cbxPraticien_SelectionChangeCommitted);
            // 
            // cbxDate
            // 
            this.cbxDate.FormattingEnabled = true;
            this.cbxDate.Location = new System.Drawing.Point(128, 28);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.Size = new System.Drawing.Size(220, 21);
            this.cbxDate.TabIndex = 0;
            this.cbxDate.SelectionChangeCommitted += new System.EventHandler(this.cbxDate_SelectionChangeCommitted);
            // 
            // panelSaisie
            // 
            this.panelSaisie.Controls.Add(this.btnEnregister);
            this.panelSaisie.Controls.Add(this.dgvEchantillons);
            this.panelSaisie.Controls.Add(this.btnAjouter);
            this.panelSaisie.Controls.Add(this.cptQuantite);
            this.panelSaisie.Controls.Add(this.cbxEchantillon);
            this.panelSaisie.Controls.Add(this.msgBilan);
            this.panelSaisie.Controls.Add(this.msgSecondMedicament);
            this.panelSaisie.Controls.Add(this.msgPremierMedicament);
            this.panelSaisie.Controls.Add(this.txtBilan);
            this.panelSaisie.Controls.Add(this.cbxSecondMedicament);
            this.panelSaisie.Controls.Add(this.cbxPremierMedicament);
            this.panelSaisie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSaisie.Location = new System.Drawing.Point(0, 125);
            this.panelSaisie.Name = "panelSaisie";
            this.panelSaisie.Size = new System.Drawing.Size(1215, 349);
            this.panelSaisie.TabIndex = 14;
            // 
            // btnEnregister
            // 
            this.btnEnregister.Location = new System.Drawing.Point(365, 296);
            this.btnEnregister.Name = "btnEnregister";
            this.btnEnregister.Size = new System.Drawing.Size(237, 23);
            this.btnEnregister.TabIndex = 10;
            this.btnEnregister.Text = "Enregister le bilan";
            this.btnEnregister.UseVisualStyleBackColor = true;
            this.btnEnregister.Click += new System.EventHandler(this.btnEnregister_Click);
            // 
            // dgvEchantillons
            // 
            this.dgvEchantillons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEchantillons.Location = new System.Drawing.Point(600, 89);
            this.dgvEchantillons.Name = "dgvEchantillons";
            this.dgvEchantillons.Size = new System.Drawing.Size(358, 182);
            this.dgvEchantillons.TabIndex = 9;
            this.dgvEchantillons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEchantillons_CellContentClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(1014, 43);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(141, 24);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cptQuantite
            // 
            this.cptQuantite.Location = new System.Drawing.Point(887, 44);
            this.cptQuantite.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cptQuantite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cptQuantite.Name = "cptQuantite";
            this.cptQuantite.Size = new System.Drawing.Size(72, 20);
            this.cptQuantite.TabIndex = 7;
            this.cptQuantite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxEchantillon
            // 
            this.cbxEchantillon.FormattingEnabled = true;
            this.cbxEchantillon.Location = new System.Drawing.Point(597, 43);
            this.cbxEchantillon.Name = "cbxEchantillon";
            this.cbxEchantillon.Size = new System.Drawing.Size(246, 21);
            this.cbxEchantillon.TabIndex = 6;
            // 
            // msgBilan
            // 
            this.msgBilan.AutoSize = true;
            this.msgBilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBilan.ForeColor = System.Drawing.Color.Red;
            this.msgBilan.Location = new System.Drawing.Point(88, 259);
            this.msgBilan.Name = "msgBilan";
            this.msgBilan.Size = new System.Drawing.Size(35, 13);
            this.msgBilan.TabIndex = 5;
            this.msgBilan.Text = "label1";
            // 
            // msgSecondMedicament
            // 
            this.msgSecondMedicament.AutoSize = true;
            this.msgSecondMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgSecondMedicament.ForeColor = System.Drawing.Color.Red;
            this.msgSecondMedicament.Location = new System.Drawing.Point(88, 108);
            this.msgSecondMedicament.Name = "msgSecondMedicament";
            this.msgSecondMedicament.Size = new System.Drawing.Size(35, 13);
            this.msgSecondMedicament.TabIndex = 4;
            this.msgSecondMedicament.Text = "label1";
            // 
            // msgPremierMedicament
            // 
            this.msgPremierMedicament.AutoSize = true;
            this.msgPremierMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgPremierMedicament.ForeColor = System.Drawing.Color.Red;
            this.msgPremierMedicament.Location = new System.Drawing.Point(88, 55);
            this.msgPremierMedicament.Name = "msgPremierMedicament";
            this.msgPremierMedicament.Size = new System.Drawing.Size(35, 13);
            this.msgPremierMedicament.TabIndex = 3;
            this.msgPremierMedicament.Text = "label1";
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(87, 135);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(285, 121);
            this.txtBilan.TabIndex = 2;
            // 
            // cbxSecondMedicament
            // 
            this.cbxSecondMedicament.FormattingEnabled = true;
            this.cbxSecondMedicament.Location = new System.Drawing.Point(87, 84);
            this.cbxSecondMedicament.Name = "cbxSecondMedicament";
            this.cbxSecondMedicament.Size = new System.Drawing.Size(289, 21);
            this.cbxSecondMedicament.TabIndex = 1;
            // 
            // cbxPremierMedicament
            // 
            this.cbxPremierMedicament.FormattingEnabled = true;
            this.cbxPremierMedicament.Location = new System.Drawing.Point(87, 27);
            this.cbxPremierMedicament.Name = "cbxPremierMedicament";
            this.cbxPremierMedicament.Size = new System.Drawing.Size(295, 21);
            this.cbxPremierMedicament.TabIndex = 0;
            // 
            // frmBilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 511);
            this.Controls.Add(this.panelSaisie);
            this.Controls.Add(this.panelSelection);
            this.Name = "frmBilan";
            this.Text = "frmBilan";
            this.Load += new System.EventHandler(this.frmBilan_Load);
            this.Controls.SetChildIndex(this.panelSelection, 0);
            this.Controls.SetChildIndex(this.panelSaisie, 0);
            this.panelSelection.ResumeLayout(false);
            this.panelSaisie.ResumeLayout(false);
            this.panelSaisie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cptQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSelection;
        private System.Windows.Forms.Panel panelSaisie;
        private System.Windows.Forms.ComboBox cbxPraticien;
        private System.Windows.Forms.ComboBox cbxDate;
        private System.Windows.Forms.Label msgPremierMedicament;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.ComboBox cbxSecondMedicament;
        private System.Windows.Forms.ComboBox cbxPremierMedicament;
        private System.Windows.Forms.ComboBox cbxEchantillon;
        private System.Windows.Forms.Label msgBilan;
        private System.Windows.Forms.Label msgSecondMedicament;
        private System.Windows.Forms.DataGridView dgvEchantillons;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.NumericUpDown cptQuantite;
        private System.Windows.Forms.Button btnEnregister;
    }
}