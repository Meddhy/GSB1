namespace GSB
{
    partial class FrmVisiteMaj
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
            this.pnlGrpBoxVisite = new System.Windows.Forms.Panel();
            this.grpBoxVisite = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnVisiteMaj = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblVisiteMaj_2 = new System.Windows.Forms.Label();
            this.lblVisiteMaj_1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnlDgvVisite = new System.Windows.Forms.Panel();
            this.dgvVisiteMaj = new System.Windows.Forms.DataGridView();
            this.pnlGrpBoxVisite.SuspendLayout();
            this.grpBoxVisite.SuspendLayout();
            this.pnlDgvVisite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteMaj)).BeginInit();
            this.SuspendLayout();
            
            // 
            // pnlGrpBoxVisite
            // 
            this.pnlGrpBoxVisite.Controls.Add(this.grpBoxVisite);
            this.pnlGrpBoxVisite.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGrpBoxVisite.Location = new System.Drawing.Point(519, 93);
            this.pnlGrpBoxVisite.Name = "pnlGrpBoxVisite";
            this.pnlGrpBoxVisite.Size = new System.Drawing.Size(281, 320);
            this.pnlGrpBoxVisite.TabIndex = 13;
            // 
            // grpBoxVisite
            // 
            this.grpBoxVisite.Controls.Add(this.lblDate);
            this.grpBoxVisite.Controls.Add(this.lblNom);
            this.grpBoxVisite.Controls.Add(this.btnVisiteMaj);
            this.grpBoxVisite.Controls.Add(this.dtpDate);
            this.grpBoxVisite.Controls.Add(this.lblVisiteMaj_2);
            this.grpBoxVisite.Controls.Add(this.lblVisiteMaj_1);
            this.grpBoxVisite.Controls.Add(this.lbl1);
            this.grpBoxVisite.Location = new System.Drawing.Point(11, 26);
            this.grpBoxVisite.Name = "grpBoxVisite";
            this.grpBoxVisite.Size = new System.Drawing.Size(258, 250);
            this.grpBoxVisite.TabIndex = 0;
            this.grpBoxVisite.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(123, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "label1";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(129, 31);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "label1";
            // 
            // btnVisiteMaj
            // 
            this.btnVisiteMaj.Location = new System.Drawing.Point(79, 207);
            this.btnVisiteMaj.Name = "btnVisiteMaj";
            this.btnVisiteMaj.Size = new System.Drawing.Size(75, 23);
            this.btnVisiteMaj.TabIndex = 5;
            this.btnVisiteMaj.Text = "Modifier";
            this.btnVisiteMaj.UseVisualStyleBackColor = true;
            this.btnVisiteMaj.Click += new System.EventHandler(this.btnVisiteMaj_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(20, 158);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 4;
            // 
            // lblVisiteMaj_2
            // 
            this.lblVisiteMaj_2.AutoSize = true;
            this.lblVisiteMaj_2.Location = new System.Drawing.Point(93, 118);
            this.lblVisiteMaj_2.Name = "lblVisiteMaj_2";
            this.lblVisiteMaj_2.Size = new System.Drawing.Size(61, 13);
            this.lblVisiteMaj_2.TabIndex = 3;
            this.lblVisiteMaj_2.Text = "est remi au ";
            // 
            // lblVisiteMaj_1
            // 
            this.lblVisiteMaj_1.AutoSize = true;
            this.lblVisiteMaj_1.Location = new System.Drawing.Point(17, 80);
            this.lblVisiteMaj_1.Name = "lblVisiteMaj_1";
            this.lblVisiteMaj_1.Size = new System.Drawing.Size(100, 13);
            this.lblVisiteMaj_1.TabIndex = 2;
            this.lblVisiteMaj_1.Text = "prévu initialement le";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(17, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(106, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Le rendez-vous chez";
            // 
            // pnlDgvVisite
            // 
            this.pnlDgvVisite.Controls.Add(this.dgvVisiteMaj);
            this.pnlDgvVisite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgvVisite.Location = new System.Drawing.Point(0, 93);
            this.pnlDgvVisite.Name = "pnlDgvVisite";
            this.pnlDgvVisite.Size = new System.Drawing.Size(519, 320);
            this.pnlDgvVisite.TabIndex = 14;
            // 
            // dgvVisiteMaj
            // 
            this.dgvVisiteMaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteMaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisiteMaj.Location = new System.Drawing.Point(0, 0);
            this.dgvVisiteMaj.Name = "dgvVisiteMaj";
            this.dgvVisiteMaj.Size = new System.Drawing.Size(519, 320);
            this.dgvVisiteMaj.TabIndex = 0;
            this.dgvVisiteMaj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisiteMaj_CellContentClick);
            this.dgvVisiteMaj.SelectionChanged += new System.EventHandler(this.dgvVisiteMaj_SelectionChanged);
            // 
            // FrmVisiteMaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDgvVisite);
            this.Controls.Add(this.pnlGrpBoxVisite);
            this.Name = "FrmVisiteMaj";
            this.Text = "FrmVisiteMaj";
            this.Load += new System.EventHandler(this.FrmVisiteMaj_Load);
            this.Controls.SetChildIndex(this.pnlGrpBoxVisite, 0);
            this.Controls.SetChildIndex(this.pnlDgvVisite, 0);
            this.pnlGrpBoxVisite.ResumeLayout(false);
            this.grpBoxVisite.ResumeLayout(false);
            this.grpBoxVisite.PerformLayout();
            this.pnlDgvVisite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteMaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrpBoxVisite;
        private System.Windows.Forms.Panel pnlDgvVisite;
        private System.Windows.Forms.GroupBox grpBoxVisite;
        private System.Windows.Forms.DataGridView dgvVisiteMaj;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblVisiteMaj_2;
        private System.Windows.Forms.Label lblVisiteMaj_1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnVisiteMaj;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDate;
    }
}