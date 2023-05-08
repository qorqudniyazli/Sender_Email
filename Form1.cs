using Microsoft.VisualBasic.Devices;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Send_Email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSend_Click(object sender, EventArgs e)
        {


            string from = "xxxx.xxxxx@gmail.com";
            string password = "xxxxxxxxx";

            using (MailMessage mail = new(from, TxtTo.Text, TxtSubject.Text, TxtBody.Text))
            using (SmtpClient smtp = new("smtp.gmail.com", 587))
            
            {
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(from, password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                FRM_Alert alert = new FRM_Alert();
                alert.ShowDialog();
                TxtTo.Text = TxtSubject.Text = TxtBody.Text = "";
            }

            #region Test
            //using (MailMessage mail = new MailMessage())
            //{
            //    mail.From = new MailAddress(from);
            //    mail.To.Add(TxtTo.Text);
            //    mail.Subject = TxtSubject.Text;
            //    mail.Body = TxtBody.Text;
            //    mail.SubjectEncoding = Encoding.UTF8;
            //    mail.BodyEncoding = Encoding.UTF8;
            //    mail.IsBodyHtml = true;
            //    mail.Priority = MailPriority.High;

            //    using (SmtpClient smtpClient = new SmtpClient())
            //    {
            //        smtpClient.Credentials = new NetworkCredential(from, password);
            //        smtpClient.Port = 587;
            //        smtpClient.Host = "smtp.mail.gov.az";
            //        smtpClient.EnableSsl = true;
            //        //ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
            //        smtpClient.Send(mail);

            //        FRM_Alert alert = new FRM_Alert();
            //        alert.ShowDialog();
            //        TxtTo.Text = TxtSubject.Text = TxtBody.Text = "";
            //    }
            //} 
            #endregion
        }
    }
}