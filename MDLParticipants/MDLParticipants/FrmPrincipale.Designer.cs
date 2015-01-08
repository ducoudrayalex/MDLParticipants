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
            this.SuspendLayout();
            // 
            // CmbParticipants
            // 
            this.CmbParticipants.FormattingEnabled = true;
            this.CmbParticipants.Location = new System.Drawing.Point(92, 38);
            this.CmbParticipants.Name = "CmbParticipants";
            this.CmbParticipants.Size = new System.Drawing.Size(193, 21);
            this.CmbParticipants.TabIndex = 0;
            this.CmbParticipants.SelectedIndexChanged += new System.EventHandler(this.CmbParticipants_SelectedIndexChanged);
            // 
            // LblParticipant
            // 
            this.LblParticipant.AutoSize = true;
            this.LblParticipant.Location = new System.Drawing.Point(13, 41);
            this.LblParticipant.Name = "LblParticipant";
            this.LblParticipant.Size = new System.Drawing.Size(68, 13);
            this.LblParticipant.TabIndex = 1;
            this.LblParticipant.Text = "Participants :";
            // 
            // FrmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 413);
            this.Controls.Add(this.LblParticipant);
            this.Controls.Add(this.CmbParticipants);
            this.Name = "FrmPrincipale";
            this.Text = "Gestion Participations";
            this.Load += new System.EventHandler(this.FrmPrincipale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbParticipants;
        private System.Windows.Forms.Label LblParticipant;
    }
}