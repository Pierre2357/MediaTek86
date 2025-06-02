namespace MediaTek86.vue
{
    partial class FrmAbsences
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
            this.grbAbsences = new System.Windows.Forms.GroupBox();
            this.grbAjoutAbsences = new System.Windows.Forms.GroupBox();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnModifAbsences = new System.Windows.Forms.Button();
            this.btnSupprAbsences = new System.Windows.Forms.Button();
            this.dtpDebutAbsence = new System.Windows.Forms.DateTimePicker();
            this.dtpFinAbsence = new System.Windows.Forms.DateTimePicker();
            this.lblDebutAbsence = new System.Windows.Forms.Label();
            this.lblFinAbsence = new System.Windows.Forms.Label();
            this.lblMotifAbsence = new System.Windows.Forms.Label();
            this.cboMotifAbsence = new System.Windows.Forms.ComboBox();
            this.btnConfirmAjoutAbsence = new System.Windows.Forms.Button();
            this.btnAnnulAjoutAbsence = new System.Windows.Forms.Button();
            this.grbAbsences.SuspendLayout();
            this.grbAjoutAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAbsences
            // 
            this.grbAbsences.Controls.Add(this.btnSupprAbsences);
            this.grbAbsences.Controls.Add(this.btnModifAbsences);
            this.grbAbsences.Controls.Add(this.dgvAbsences);
            this.grbAbsences.Location = new System.Drawing.Point(12, 12);
            this.grbAbsences.Name = "grbAbsences";
            this.grbAbsences.Size = new System.Drawing.Size(647, 249);
            this.grbAbsences.TabIndex = 0;
            this.grbAbsences.TabStop = false;
            this.grbAbsences.Text = "absences";
            // 
            // grbAjoutAbsences
            // 
            this.grbAjoutAbsences.Controls.Add(this.btnAnnulAjoutAbsence);
            this.grbAjoutAbsences.Controls.Add(this.btnConfirmAjoutAbsence);
            this.grbAjoutAbsences.Controls.Add(this.cboMotifAbsence);
            this.grbAjoutAbsences.Controls.Add(this.lblMotifAbsence);
            this.grbAjoutAbsences.Controls.Add(this.lblFinAbsence);
            this.grbAjoutAbsences.Controls.Add(this.lblDebutAbsence);
            this.grbAjoutAbsences.Controls.Add(this.dtpFinAbsence);
            this.grbAjoutAbsences.Controls.Add(this.dtpDebutAbsence);
            this.grbAjoutAbsences.Location = new System.Drawing.Point(12, 267);
            this.grbAjoutAbsences.Name = "grbAjoutAbsences";
            this.grbAjoutAbsences.Size = new System.Drawing.Size(647, 111);
            this.grbAjoutAbsences.TabIndex = 1;
            this.grbAjoutAbsences.TabStop = false;
            this.grbAjoutAbsences.Text = "ajouter absence";
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(6, 19);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(635, 196);
            this.dgvAbsences.TabIndex = 0;
            // 
            // btnModifAbsences
            // 
            this.btnModifAbsences.Location = new System.Drawing.Point(6, 221);
            this.btnModifAbsences.Name = "btnModifAbsences";
            this.btnModifAbsences.Size = new System.Drawing.Size(75, 23);
            this.btnModifAbsences.TabIndex = 1;
            this.btnModifAbsences.Text = "modifier";
            this.btnModifAbsences.UseVisualStyleBackColor = true;
            // 
            // btnSupprAbsences
            // 
            this.btnSupprAbsences.Location = new System.Drawing.Point(87, 221);
            this.btnSupprAbsences.Name = "btnSupprAbsences";
            this.btnSupprAbsences.Size = new System.Drawing.Size(75, 23);
            this.btnSupprAbsences.TabIndex = 2;
            this.btnSupprAbsences.Text = "supprimer";
            this.btnSupprAbsences.UseVisualStyleBackColor = true;
            // 
            // dtpDebutAbsence
            // 
            this.dtpDebutAbsence.Location = new System.Drawing.Point(46, 27);
            this.dtpDebutAbsence.Name = "dtpDebutAbsence";
            this.dtpDebutAbsence.Size = new System.Drawing.Size(180, 20);
            this.dtpDebutAbsence.TabIndex = 0;
            // 
            // dtpFinAbsence
            // 
            this.dtpFinAbsence.Location = new System.Drawing.Point(356, 27);
            this.dtpFinAbsence.Name = "dtpFinAbsence";
            this.dtpFinAbsence.Size = new System.Drawing.Size(200, 20);
            this.dtpFinAbsence.TabIndex = 1;
            // 
            // lblDebutAbsence
            // 
            this.lblDebutAbsence.AutoSize = true;
            this.lblDebutAbsence.Location = new System.Drawing.Point(6, 33);
            this.lblDebutAbsence.Name = "lblDebutAbsence";
            this.lblDebutAbsence.Size = new System.Drawing.Size(34, 13);
            this.lblDebutAbsence.TabIndex = 2;
            this.lblDebutAbsence.Text = "debut";
            // 
            // lblFinAbsence
            // 
            this.lblFinAbsence.AutoSize = true;
            this.lblFinAbsence.Location = new System.Drawing.Point(332, 32);
            this.lblFinAbsence.Name = "lblFinAbsence";
            this.lblFinAbsence.Size = new System.Drawing.Size(18, 13);
            this.lblFinAbsence.TabIndex = 3;
            this.lblFinAbsence.Text = "fin";
            // 
            // lblMotifAbsence
            // 
            this.lblMotifAbsence.AutoSize = true;
            this.lblMotifAbsence.Location = new System.Drawing.Point(6, 56);
            this.lblMotifAbsence.Name = "lblMotifAbsence";
            this.lblMotifAbsence.Size = new System.Drawing.Size(29, 13);
            this.lblMotifAbsence.TabIndex = 4;
            this.lblMotifAbsence.Text = "motif";
            // 
            // cboMotifAbsence
            // 
            this.cboMotifAbsence.FormattingEnabled = true;
            this.cboMotifAbsence.Location = new System.Drawing.Point(46, 53);
            this.cboMotifAbsence.Name = "cboMotifAbsence";
            this.cboMotifAbsence.Size = new System.Drawing.Size(180, 21);
            this.cboMotifAbsence.TabIndex = 5;
            // 
            // btnConfirmAjoutAbsence
            // 
            this.btnConfirmAjoutAbsence.Location = new System.Drawing.Point(6, 80);
            this.btnConfirmAjoutAbsence.Name = "btnConfirmAjoutAbsence";
            this.btnConfirmAjoutAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAjoutAbsence.TabIndex = 6;
            this.btnConfirmAjoutAbsence.Text = "confirmer";
            this.btnConfirmAjoutAbsence.UseVisualStyleBackColor = true;
            // 
            // btnAnnulAjoutAbsence
            // 
            this.btnAnnulAjoutAbsence.Location = new System.Drawing.Point(87, 80);
            this.btnAnnulAjoutAbsence.Name = "btnAnnulAjoutAbsence";
            this.btnAnnulAjoutAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulAjoutAbsence.TabIndex = 7;
            this.btnAnnulAjoutAbsence.Text = "annuler";
            this.btnAnnulAjoutAbsence.UseVisualStyleBackColor = true;
            // 
            // Absences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 384);
            this.Controls.Add(this.grbAjoutAbsences);
            this.Controls.Add(this.grbAbsences);
            this.Name = "Absences";
            this.Text = "Absences";
            this.grbAbsences.ResumeLayout(false);
            this.grbAjoutAbsences.ResumeLayout(false);
            this.grbAjoutAbsences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAbsences;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.GroupBox grbAjoutAbsences;
        private System.Windows.Forms.Button btnSupprAbsences;
        private System.Windows.Forms.Button btnModifAbsences;
        private System.Windows.Forms.DateTimePicker dtpDebutAbsence;
        private System.Windows.Forms.Label lblMotifAbsence;
        private System.Windows.Forms.Label lblFinAbsence;
        private System.Windows.Forms.Label lblDebutAbsence;
        private System.Windows.Forms.DateTimePicker dtpFinAbsence;
        private System.Windows.Forms.Button btnAnnulAjoutAbsence;
        private System.Windows.Forms.Button btnConfirmAjoutAbsence;
        private System.Windows.Forms.ComboBox cboMotifAbsence;
    }
}