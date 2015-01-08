using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using System.Configuration;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MDLParticipants
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }
        internal Bdd UneConnexion;
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                UneConnexion = new Bdd(TxtLogin.Text, TxtMdp.Text);
                (new FrmPrincipale()).Show(this);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ControleValide(object sender, EventArgs e)
        {
            if (TxtLogin.Text.Length == 0 || TxtMdp.Text.Length == 0)
            {
                BtnConnection.Enabled = false;
            }
            else
            {
                BtnConnection.Enabled = true;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.ControleValide(sender, e);
        }
    }
}
