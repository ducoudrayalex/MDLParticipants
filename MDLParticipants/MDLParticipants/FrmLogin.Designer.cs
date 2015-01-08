namespace MDLParticipants
{
    partial class FrmLogin
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
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblMdp = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtMdp = new System.Windows.Forms.TextBox();
            this.BtnConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(60, 74);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(39, 13);
            this.LblLogin.TabIndex = 0;
            this.LblLogin.Text = "Login :";
            // 
            // LblMdp
            // 
            this.LblMdp.AutoSize = true;
            this.LblMdp.Location = new System.Drawing.Point(22, 103);
            this.LblMdp.Name = "LblMdp";
            this.LblMdp.Size = new System.Drawing.Size(77, 13);
            this.LblMdp.TabIndex = 1;
            this.LblMdp.Text = "Mot de passe :";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 25);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(309, 20);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Gestion des arrivées et des particiapations";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(105, 71);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(180, 20);
            this.TxtLogin.TabIndex = 3;
            this.TxtLogin.Text = "employemdl";
            // 
            // TxtMdp
            // 
            this.TxtMdp.Location = new System.Drawing.Point(105, 100);
            this.TxtMdp.Name = "TxtMdp";
            this.TxtMdp.PasswordChar = '*';
            this.TxtMdp.Size = new System.Drawing.Size(180, 20);
            this.TxtMdp.TabIndex = 4;
            this.TxtMdp.Text = "employemdl";
            // 
            // BtnConnection
            // 
            this.BtnConnection.Location = new System.Drawing.Point(128, 126);
            this.BtnConnection.Name = "BtnConnection";
            this.BtnConnection.Size = new System.Drawing.Size(116, 23);
            this.BtnConnection.TabIndex = 5;
            this.BtnConnection.Text = "Connecter";
            this.BtnConnection.UseVisualStyleBackColor = true;
            this.BtnConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 262);
            this.Controls.Add(this.BtnConnection);
            this.Controls.Add(this.TxtMdp);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.LblMdp);
            this.Controls.Add(this.LblLogin);
            this.Name = "FrmLogin";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblMdp;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtMdp;
        private System.Windows.Forms.Button BtnConnection;
    }
}

