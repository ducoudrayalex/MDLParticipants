using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading.Tasks;

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
                Bdd.RemplirComboBox(UneConnexion,CmbParticipants,"VPARTICIPANT01");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public DateTime GetDateFinVacation()
        {
            CultureInfo provider = new CultureInfo("fr-FR");
            string dateString = this.DtDateArriveeParticipant.Text + " " + this.DtHeureArriveeParticipant.Text;

            string format = "g";
            return DateTime.ParseExact(dateString, format, provider);
        }

        private void BtnEnregistrerArrivee_Click(object sender, EventArgs e)
        {
            try
            {

                CultureInfo provider = new CultureInfo("fr-FR");
                string dateString = this.DtDateArriveeParticipant.Text + " " + this.DtHeureArriveeParticipant.Text;

                string format = "g";
                DateTime.ParseExact(dateString, format, provider);

                this.UneConnexion.AjoutDateHeureArriveeParticipant(Convert.ToInt16(this.CmbParticipants.SelectedValue), Convert.ToDateTime(dateString));
                MessageBox.Show("Date d'arrivée du participant \"" + this.CmbParticipants.Text + "\"ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
