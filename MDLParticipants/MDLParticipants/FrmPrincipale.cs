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

using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Ecc;
using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.Codec.Util;

namespace MDLParticipants
{
    public partial class FrmPrincipale : Form
    {

        String idParticipant;

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
                this.idParticipant = this.CmbParticipants.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idParticipant = this.CmbParticipants.SelectedValue.ToString();
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
                String cleWifi = GenerateKeyWPA(20);
                MessageBox.Show(cleWifi);
                this.UneConnexion.AjoutDateHeureArriveeParticipant(Convert.ToInt16(this.CmbParticipants.SelectedValue), Convert.ToDateTime(dateString),cleWifi);
                MessageBox.Show("Date d'arrivée du participant \"" + this.CmbParticipants.Text + "\"ajouté");

                this.showImage(generateQrCode(this.idParticipant, 5));
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Une clef (ou "passphrase") WPA peut avoir une taille comprise entre 8 et 63 caractères. 
        /// Le choix des caractères est libre. 
        /// </summary>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        private string GenerateKeyWPA(int maxLength)
        {
            #region initVars
            string tmp = "";
            tmp = string.Empty;

            int iVal = 11;
            char c = (char)iVal;
            int k = 0;
            Random rd = new Random(System.DateTime.Now.Millisecond);
            bool b1;
            bool b2;
            bool b3;
            bool b4;

            #endregion
            while (tmp.Length != maxLength)
            {
                iVal = rd.Next(0, 123);
                c = (char)iVal;

                b1 = char.IsLetterOrDigit(c);
                b2 = char.IsNumber(c);
                b3 = (b1 || b2);

                if (!b1)
                    goto next;

                b4 = (char.IsSeparator(c) || char.IsSymbol(c) || char.IsPunctuation(c) || char.IsWhiteSpace(c));

                if (b4)
                    goto next;

                if (char.IsSurrogate(c))
                    goto next;

                if (tmp.Length > 1 && tmp[tmp.Length - 1] == c)
                    goto next;

                if (b3)
                {
                    if ((char.IsNumber(c) || char.IsDigit(c)))
                    {
                        int num = int.Parse(c.ToString());
                        if (num < 10)
                            tmp += iVal.ToString();
                    }
                    else
                    {
                        if (char.IsLetter(c))
                        {
                            if (tmp.Length == 0)
                                tmp += c;
                            else
                                if (tmp[tmp.Length - 1] != c)
                                    tmp += c;
                        }
                    }
                }
            next:
                k++;
            }
            return tmp;
        }

        private Image generateQrCode(string input, int qrlevel)
        {

            string toenc = input;

            MessagingToolkit.QRCode.Codec.QRCodeEncoder qe = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();

            qe.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;

            qe.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L; // - Using LOW for more storage

            qe.QRCodeVersion = qrlevel;

            System.Drawing.Bitmap bm = qe.Encode(toenc);

            return bm;

        }

        public void showImage(Image image)
        {
            Form frm = new Form();
            frm.Show();
            PictureBox PictureBox2 = new PictureBox();
            PictureBox2.Image = image;
            PictureBox2.Show();
            frm.Controls.Add(PictureBox2);
            PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
