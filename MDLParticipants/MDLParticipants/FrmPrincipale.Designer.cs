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
            this.grpBoxEnregistrement = new System.Windows.Forms.GroupBox();
            this.BtnEnregistrerArrivee = new System.Windows.Forms.Button();
            this.DtHeureArriveeParticipant = new System.Windows.Forms.DateTimePicker();
            this.DtDateArriveeParticipant = new System.Windows.Forms.DateTimePicker();
            this.grpBoxEnregistrement.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbParticipants
            // 
            this.CmbParticipants.FormattingEnabled = true;
            this.CmbParticipants.Location = new System.Drawing.Point(174, 22);
            this.CmbParticipants.Name = "CmbParticipants";
            this.CmbParticipants.Size = new System.Drawing.Size(193, 21);
            this.CmbParticipants.TabIndex = 0;
            this.CmbParticipants.SelectedIndexChanged += new System.EventHandler(this.CmbParticipants_SelectedIndexChanged);
            // 
            // LblParticipant
            // 
            this.LblParticipant.AutoSize = true;
            this.LblParticipant.Location = new System.Drawing.Point(100, 25);
            this.LblParticipant.Name = "LblParticipant";
            this.LblParticipant.Size = new System.Drawing.Size(68, 13);
            this.LblParticipant.TabIndex = 1;
            this.LblParticipant.Text = "Participants :";
            // 
            // LblDateArrivee
            // 
            this.LblDateArrivee.AutoSize = true;
            this.LblDateArrivee.Location = new System.Drawing.Point(100, 59);
            this.LblDateArrivee.Name = "LblDateArrivee";
            this.LblDateArrivee.Size = new System.Drawing.Size(121, 13);
            this.LblDateArrivee.TabIndex = 2;
            this.LblDateArrivee.Text = "Date et heure d\'arrivée :";
            // 
            // grpBoxEnregistrement
            // 
            this.grpBoxEnregistrement.Controls.Add(this.BtnEnregistrerArrivee);
            this.grpBoxEnregistrement.Controls.Add(this.DtHeureArriveeParticipant);
            this.grpBoxEnregistrement.Controls.Add(this.DtDateArriveeParticipant);
            this.grpBoxEnregistrement.Controls.Add(this.LblDateArrivee);
            this.grpBoxEnregistrement.Controls.Add(this.LblParticipant);
            this.grpBoxEnregistrement.Controls.Add(this.CmbParticipants);
            this.grpBoxEnregistrement.Location = new System.Drawing.Point(12, 12);
            this.grpBoxEnregistrement.Name = "grpBoxEnregistrement";
            this.grpBoxEnregistrement.Size = new System.Drawing.Size(473, 136);
            this.grpBoxEnregistrement.TabIndex = 3;
            this.grpBoxEnregistrement.TabStop = false;
            this.grpBoxEnregistrement.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnEnregistrerArrivee
            // 
            this.BtnEnregistrerArrivee.Location = new System.Drawing.Point(188, 95);
            this.BtnEnregistrerArrivee.Name = "BtnEnregistrerArrivee";
            this.BtnEnregistrerArrivee.Size = new System.Drawing.Size(105, 23);
            this.BtnEnregistrerArrivee.TabIndex = 5;
            this.BtnEnregistrerArrivee.Text = "Enregistrer";
            this.BtnEnregistrerArrivee.UseVisualStyleBackColor = true;
            this.BtnEnregistrerArrivee.Click += new System.EventHandler(this.BtnEnregistrerArrivee_Click);
            // 
            // DtHeureArriveeParticipant
            // 
            this.DtHeureArriveeParticipant.CustomFormat = "HH:mm";
            this.DtHeureArriveeParticipant.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtHeureArriveeParticipant.Location = new System.Drawing.Point(313, 58);
            this.DtHeureArriveeParticipant.Name = "DtHeureArriveeParticipant";
            this.DtHeureArriveeParticipant.ShowUpDown = true;
            this.DtHeureArriveeParticipant.Size = new System.Drawing.Size(54, 20);
            this.DtHeureArriveeParticipant.TabIndex = 4;
            // 
            // DtDateArriveeParticipant
            // 
            this.DtDateArriveeParticipant.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtDateArriveeParticipant.Location = new System.Drawing.Point(228, 59);
            this.DtDateArriveeParticipant.MaxDate = new System.DateTime(2015, 9, 15, 0, 0, 0, 0);
            this.DtDateArriveeParticipant.MinDate = new System.DateTime(2015, 9, 13, 0, 0, 0, 0);
            this.DtDateArriveeParticipant.Name = "DtDateArriveeParticipant";
            this.DtDateArriveeParticipant.Size = new System.Drawing.Size(78, 20);
            this.DtDateArriveeParticipant.TabIndex = 3;
            this.DtDateArriveeParticipant.Value = new System.DateTime(2015, 9, 13, 0, 0, 0, 0);
            // 
            // FrmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 413);
            this.Controls.Add(this.grpBoxEnregistrement);
            this.Name = "FrmPrincipale";
            this.Text = "Gestion Participations";
            this.Load += new System.EventHandler(this.FrmPrincipale_Load);
            this.grpBoxEnregistrement.ResumeLayout(false);
            this.grpBoxEnregistrement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbParticipants;
        private System.Windows.Forms.Label LblParticipant;
        private System.Windows.Forms.Label LblDateArrivee;
        private System.Windows.Forms.GroupBox grpBoxEnregistrement;
        private System.Windows.Forms.DateTimePicker DtHeureArriveeParticipant;
        private System.Windows.Forms.DateTimePicker DtDateArriveeParticipant;
        private System.Windows.Forms.Button BtnEnregistrerArrivee;
    }
}