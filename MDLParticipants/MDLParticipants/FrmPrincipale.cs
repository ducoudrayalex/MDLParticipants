using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDLParticipants
{
    public partial class FrmPrincipale : Form
    {
        public FrmPrincipale()
        {
            InitializeComponent();
        }
        private Bdd UneConnexion;
        private void FrmPrincipale_Load(object sender, EventArgs e)
        {
            try
            {
                UneConnexion = ((FrmLogin)Owner).UneConnexion;
                CmbParticipants.DataSource = UneConnexion.GetParticipants();
                CmbParticipants.DisplayMember = "libelle";
                CmbParticipants.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
