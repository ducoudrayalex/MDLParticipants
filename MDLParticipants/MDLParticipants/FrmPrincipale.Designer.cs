namespace MDLParticipants
{
    partial class FrmPrincipale
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
            this.CmbParticipants = new System.Windows.Forms.ComboBox();
            this.LblParticipant = new System.Windows.Forms.Label();
            this.LblDateArrivee = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtDateArriveeParticipant = new System.Windows.Forms.DateTimePicker();
            this.DtHeureArriveeParticipant = new System.Windows.Forms.DateTimePicker();
            this.BtnEnregistrerArrivee = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbParticipants
            // 
            this.CmbParticipants.FormattingEnabled = true;
            this.CmbParticipants.Location = new System.Drawing.Point(133, 22);
            this.CmbParticipants.Name = "CmbParticipants";
            this.CmbParticipants.Size = new System.Drawing.Size(193, 21);
            this.CmbParticipants.TabIndex = 0;
            this.CmbParticipants.SelectedIndexChanged += new System.EventHandler(this.CmbParticipants_SelectedIndexChanged);
            // 
            // LblParticipant
            // 
            this.LblParticipant.AutoSize = true;
            this.LblParticipant.Location = new System.Drawing.Point(59, 25);
            this.LblParticipant.Name = "LblParticipant";
            this.LblParticipant.Size = new System.Drawing.Size(68, 13);
            this.LblParticipant.TabIndex = 1;
            this.LblParticipant.Text = "Participants :";
            // 
            // LblDateArrivee
            // 
            this.LblDateArrivee.AutoSize = true;
            this.LblDateArrivee.Location = new System.Drawing.Point(6, 62);
            this.LblDateArrivee.Name = "LblDateArrivee";
            this.LblDateArrivee.Size = new System.Drawing.Size(121, 13);
            this.LblDateArrivee.TabIndex = 2;
            this.LblDateArrivee.Text = "Date et heure d\'arrivée :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEnregistrerArrivee);
            this.groupBox1.Controls.Add(this.DtHeureArriveeParticipant);
            this.groupBox1.Controls.Add(this.DtDateArriveeParticipant);
            this.groupBox1.Controls.Add(this.LblDateArrivee);
            this.groupBox1.Controls.Add(this.LblParticipant);
            this.groupBox1.Controls.Add(this.CmbParticipants);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // DtDateArriveeParticipant
            // 
            this.DtDateArriveeParticipant.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtDateArriveeParticipant.Location = new System.Drawing.Point(134, 62);
            this.DtDateArriveeParticipant.MaxDate = new System.DateTime(2015, 9, 15, 0, 0, 0, 0);
            this.DtDateArriveeParticipant.MinDate = new System.DateTime(2015, 9, 13, 0, 0, 0, 0);
            this.DtDateArriveeParticipant.Name = "DtDateArriveeParticipant";
            this.DtDateArriveeParticipant.Size = new System.Drawing.Size(78, 20);
            this.DtDateArriveeParticipant.TabIndex = 3;
            this.DtDateArriveeParticipant.Value = new System.DateTime(2015, 9, 13, 0, 0, 0, 0);
            // 
            // DtHeureArriveeParticipant
            // 
            this.DtHeureArriveeParticipant.CustomFormat = "HH:mm";
            this.DtHeureArriveeParticipant.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtHeureArriveeParticipant.Location = new System.Drawing.Point(219, 61);
            this.DtHeureArriveeParticipant.Name = "DtHeureArriveeParticipant";
            this.DtHeureArriveeParticipant.ShowUpDown = true;
            this.DtHeureArriveeParticipant.Size = new System.Drawing.Size(54, 20);
            this.DtHeureArriveeParticipant.TabIndex = 4;
            // 
            // BtnEnregistrerArrivee
            // 
            this.BtnEnregistrerArrivee.Location = new System.Drawing.Point(171, 99);
            this.BtnEnregistrerArrivee.Name = "BtnEnregistrerArrivee";
            this.BtnEnregistrerArrivee.Size = new System.Drawing.Size(75, 23);
            this.BtnEnregistrerArrivee.TabIndex = 5;
            this.BtnEnregistrerArrivee.Text = "Enregistrer";
            this.BtnEnregistrerArrivee.UseVisualStyleBackColor = true;
            this.BtnEnregistrerArrivee.Click += new System.EventHandler(this.BtnEnregistrerArrivee_Click);
            // 
            // FrmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 413);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipale";
            this.Text = "Gestion Participations";
            this.Load += new System.EventHandler(this.FrmPrincipale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbParticipants;
        private System.Windows.Forms.Label LblParticipant;
        private System.Windows.Forms.Label LblDateArrivee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtHeureArriveeParticipant;
        private System.Windows.Forms.DateTimePicker DtDateArriveeParticipant;
        private System.Windows.Forms.Button BtnEnregistrerArrivee;
    }
}