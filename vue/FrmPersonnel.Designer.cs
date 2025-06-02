namespace MediaTek86.vue
{
    partial class FrmPersonnel
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
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.grbAjoutPersonnel = new System.Windows.Forms.GroupBox();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.btnModifPersonnel = new System.Windows.Forms.Button();
            this.btnSupprPersonnel = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblAffectation = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cboAffectation = new System.Windows.Forms.ComboBox();
            this.btnConfirmAjoutPersonnel = new System.Windows.Forms.Button();
            this.btnAnnulAjoutPersonnel = new System.Windows.Forms.Button();
            this.grbPersonnel.SuspendLayout();
            this.grbAjoutPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnAbsences);
            this.grbPersonnel.Controls.Add(this.btnSupprPersonnel);
            this.grbPersonnel.Controls.Add(this.btnModifPersonnel);
            this.grbPersonnel.Controls.Add(this.dgvPersonnel);
            this.grbPersonnel.Location = new System.Drawing.Point(12, 12);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(643, 268);
            this.grbPersonnel.TabIndex = 0;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "personnel";
            // 
            // grbAjoutPersonnel
            // 
            this.grbAjoutPersonnel.Controls.Add(this.btnAnnulAjoutPersonnel);
            this.grbAjoutPersonnel.Controls.Add(this.btnConfirmAjoutPersonnel);
            this.grbAjoutPersonnel.Controls.Add(this.cboAffectation);
            this.grbAjoutPersonnel.Controls.Add(this.txtMail);
            this.grbAjoutPersonnel.Controls.Add(this.txtTel);
            this.grbAjoutPersonnel.Controls.Add(this.txtPrenom);
            this.grbAjoutPersonnel.Controls.Add(this.txtNom);
            this.grbAjoutPersonnel.Controls.Add(this.lblAffectation);
            this.grbAjoutPersonnel.Controls.Add(this.lblMail);
            this.grbAjoutPersonnel.Controls.Add(this.lblTel);
            this.grbAjoutPersonnel.Controls.Add(this.lblPrenom);
            this.grbAjoutPersonnel.Controls.Add(this.lblNom);
            this.grbAjoutPersonnel.Location = new System.Drawing.Point(12, 286);
            this.grbAjoutPersonnel.Name = "grbAjoutPersonnel";
            this.grbAjoutPersonnel.Size = new System.Drawing.Size(643, 160);
            this.grbAjoutPersonnel.TabIndex = 1;
            this.grbAjoutPersonnel.TabStop = false;
            this.grbAjoutPersonnel.Text = "Ajouter personnel";
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(6, 19);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.Size = new System.Drawing.Size(631, 212);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // btnModifPersonnel
            // 
            this.btnModifPersonnel.Location = new System.Drawing.Point(6, 237);
            this.btnModifPersonnel.Name = "btnModifPersonnel";
            this.btnModifPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnModifPersonnel.TabIndex = 1;
            this.btnModifPersonnel.Text = "modifier";
            this.btnModifPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnSupprPersonnel
            // 
            this.btnSupprPersonnel.Location = new System.Drawing.Point(87, 237);
            this.btnSupprPersonnel.Name = "btnSupprPersonnel";
            this.btnSupprPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnSupprPersonnel.TabIndex = 2;
            this.btnSupprPersonnel.Text = "supprimer";
            this.btnSupprPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnAbsences
            // 
            this.btnAbsences.Location = new System.Drawing.Point(168, 237);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(75, 23);
            this.btnAbsences.TabIndex = 3;
            this.btnAbsences.Text = "absences";
            this.btnAbsences.UseVisualStyleBackColor = true;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 30);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(27, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(6, 63);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(42, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "prenom";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(307, 30);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(18, 13);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "tel";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(307, 63);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(25, 13);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "mail";
            // 
            // lblAffectation
            // 
            this.lblAffectation.AutoSize = true;
            this.lblAffectation.Location = new System.Drawing.Point(307, 101);
            this.lblAffectation.Name = "lblAffectation";
            this.lblAffectation.Size = new System.Drawing.Size(57, 13);
            this.lblAffectation.TabIndex = 4;
            this.lblAffectation.Text = "affectation";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(54, 30);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(247, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(54, 60);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(247, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(370, 27);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(267, 20);
            this.txtTel.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(370, 60);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(267, 20);
            this.txtMail.TabIndex = 8;
            // 
            // cboAffectation
            // 
            this.cboAffectation.FormattingEnabled = true;
            this.cboAffectation.Location = new System.Drawing.Point(370, 98);
            this.cboAffectation.Name = "cboAffectation";
            this.cboAffectation.Size = new System.Drawing.Size(267, 21);
            this.cboAffectation.TabIndex = 9;
            // 
            // btnConfirmAjoutPersonnel
            // 
            this.btnConfirmAjoutPersonnel.Location = new System.Drawing.Point(6, 128);
            this.btnConfirmAjoutPersonnel.Name = "btnConfirmAjoutPersonnel";
            this.btnConfirmAjoutPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAjoutPersonnel.TabIndex = 10;
            this.btnConfirmAjoutPersonnel.Text = "confirmer";
            this.btnConfirmAjoutPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnAnnulAjoutPersonnel
            // 
            this.btnAnnulAjoutPersonnel.Location = new System.Drawing.Point(87, 128);
            this.btnAnnulAjoutPersonnel.Name = "btnAnnulAjoutPersonnel";
            this.btnAnnulAjoutPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulAjoutPersonnel.TabIndex = 11;
            this.btnAnnulAjoutPersonnel.Text = "annuler";
            this.btnAnnulAjoutPersonnel.UseVisualStyleBackColor = true;
            // 
            // Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 453);
            this.Controls.Add(this.grbAjoutPersonnel);
            this.Controls.Add(this.grbPersonnel);
            this.Name = "Personnel";
            this.Text = "Personnel";
            this.grbPersonnel.ResumeLayout(false);
            this.grbAjoutPersonnel.ResumeLayout(false);
            this.grbAjoutPersonnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.GroupBox grbAjoutPersonnel;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Button btnSupprPersonnel;
        private System.Windows.Forms.Button btnModifPersonnel;
        private System.Windows.Forms.Label lblAffectation;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnConfirmAjoutPersonnel;
        private System.Windows.Forms.Button btnAnnulAjoutPersonnel;
        private System.Windows.Forms.ComboBox cboAffectation;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
    }
}