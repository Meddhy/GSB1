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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxPraticien = new System.Windows.Forms.ComboBox();
            this.cbxDate = new System.Windows.Forms.ComboBox();
            this.panelSaisie = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panelSelection.Controls.Add(this.label7);
            this.panelSelection.Controls.Add(this.label6);
            this.panelSelection.Controls.Add(this.cbxPraticien);
            this.panelSelection.Controls.Add(this.cbxDate);
            this.panelSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelection.Location = new System.Drawing.Point(0, 29);
            this.panelSelection.Name = "panelSelection";
            this.panelSelection.Size = new System.Drawing.Size(1215, 96);
            this.panelSelection.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Horaire des Praticiens";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Liste des Praticiens";
            // 
            // cbxPraticien
            // 
            this.cbxPraticien.FormattingEnabled = true;
            this.cbxPraticien.Location = new System.Drawing.Point(597, 32);
            this.cbxPraticien.Name = "cbxPraticien";
            this.cbxPraticien.Size = new System.Drawing.Size(246, 21);
            this.cbxPraticien.TabIndex = 1;
            this.cbxPraticien.SelectionChangeCommitted += new System.EventHandler(this.cbxPraticien_SelectionChangeCommitted);
            // 
            // cbxDate
            // 
            this.cbxDate.FormattingEnabled = true;
            this.cbxDate.Location = new System.Drawing.Point(176, 32);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.Size = new System.Drawing.Size(248, 21);
            this.cbxDate.TabIndex = 0;
            this.cbxDate.SelectionChangeCommitted += new System.EventHandler(this.cbxDate_SelectionChangeCommitted);
            // 
            // panelSaisie
            // 
            this.panelSaisie.Controls.Add(this.label5);
            this.panelSaisie.Controls.Add(this.label4);
            this.panelSaisie.Controls.Add(this.label3);
            this.panelSaisie.Controls.Add(this.label2);
            this.panelSaisie.Controls.Add(this.label1);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Médicament";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(884, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quantité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bilan de la visite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Premier médicament présenté";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Second médicament proposé";
            // 
            // btnEnregister
            // 
            this.btnEnregister.Location = new System.Drawing.Point(389, 297);
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
            this.dgvEchantillons.Location = new System.Drawing.Point(597, 73);
            this.dgvEchantillons.Name = "dgvEchantillons";
            this.dgvEchantillons.Size = new System.Drawing.Size(358, 208);
            this.dgvEchantillons.TabIndex = 9;
            this.dgvEchantillons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEchantillons_CellContentClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(996, 29);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(141, 24);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cptQuantite
            // 
            this.cptQuantite.Location = new System.Drawing.Point(887, 30);
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
            this.cbxEchantillon.Location = new System.Drawing.Point(597, 29);
            this.cbxEchantillon.Name = "cbxEchantillon";
            this.cbxEchantillon.Size = new System.Drawing.Size(246, 21);
            this.cbxEchantillon.TabIndex = 6;
            // 
            // msgBilan
            // 
            this.msgBilan.AutoSize = true;
            this.msgBilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBilan.ForeColor = System.Drawing.Color.Red;
            this.msgBilan.Location = new System.Drawing.Point(57, 284);
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
            this.msgSecondMedicament.Location = new System.Drawing.Point(173, 114);
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
            this.msgPremierMedicament.Location = new System.Drawing.Point(173, 54);
            this.msgPremierMedicament.Name = "msgPremierMedicament";
            this.msgPremierMedicament.Size = new System.Drawing.Size(38, 13);
            this.msgPremierMedicament.TabIndex = 3;
            this.msgPremierMedicament.Text = "label 1";
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(60, 160);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(364, 121);
            this.txtBilan.TabIndex = 2;
            // 
            // cbxSecondMedicament
            // 
            this.cbxSecondMedicament.FormattingEnabled = true;
            this.cbxSecondMedicament.Location = new System.Drawing.Point(176, 89);
            this.cbxSecondMedicament.Name = "cbxSecondMedicament";
            this.cbxSecondMedicament.Size = new System.Drawing.Size(248, 21);
            this.cbxSecondMedicament.TabIndex = 1;
            // 
            // cbxPremierMedicament
            // 
            this.cbxPremierMedicament.FormattingEnabled = true;
            this.cbxPremierMedicament.Location = new System.Drawing.Point(176, 29);
            this.cbxPremierMedicament.Name = "cbxPremierMedicament";
            this.cbxPremierMedicament.Size = new System.Drawing.Size(248, 21);
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
            this.panelSelection.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}