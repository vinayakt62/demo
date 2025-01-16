using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace TechASP.SmartAdvocateDiary.SMS_Sending
{

    public partial class frmSendEmail : Form
    {
        MailMessage message;
        SmtpClient smtp;
        public frmSendEmail()
        {
            InitializeComponent();
        }

        private void frmSendEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmSendEmail_Load(object sender, EventArgs e)
        {
            txtMailFrom.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtTo.Text = string.Empty;
            txtSubject.Text = string.Empty;
            txtBody.Text = string.Empty;
            lblAttachment.Text = string.Empty;
            txtMailFrom.Focus();
        }

        private void lnkAttachFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblAttachment.Text = openFileDialog1.FileName;
                lblAttachment.Visible = true;
                lnkAttachFile.Visible = false;
            }
        }
        void smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Email sending cancelled!", "M E S S A G E");
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("Email sent sucessfully!", "M E S S A G E");
            }

            button2.Visible = false;
            button1.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                smtp.SendAsyncCancel();
                MessageBox.Show("Email sending cancelled!", "M E S S A G E");
            }
            catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;

                message = new MailMessage();

                if (txtMailFrom.Text != string.Empty && txtPassword.Text != string.Empty && txtTo.Text != string.Empty)
                {
                    message.To.Add(txtTo.Text);
                    message.Subject = txtSubject.Text;
                    message.From = new MailAddress(txtMailFrom.Text);
                    message.Body = txtBody.Text;
                    if (lblAttachment.Text.Length > 0)
                    {
                        if (System.IO.File.Exists(lblAttachment.Text))
                        {
                            message.Attachments.Add(new Attachment(lblAttachment.Text));
                        }
                    }

                    // set smtp details
                    smtp = new SmtpClient("patilswapnil1889@gmail.com");
                    smtp.Port = 25;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(txtMailFrom.Text, txtPassword.Text);
                    smtp.SendAsync(message, message.Subject);
                    smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);

                    
                }
                else
                {
                    MessageBox.Show("Please provide valid email address", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtMailFrom.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                button2.Visible = false;
                button1.Enabled = true;
            }
        }

        private void txtMailFrom_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (txtMailFrom.Text.Length > 0)
            {
                if (!rEmail.IsMatch(txtMailFrom.Text))
                {
                    MessageBox.Show("Please provide valid email address", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMailFrom.Focus();
                }
            }
        }

        private void txtMailFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMailFrom.Text != string.Empty)
                {
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("ENTER YOUR EMAIL ID!", "M E S S A G E");
                    txtMailFrom.Focus();
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPassword.Text != string.Empty)
                {
                    txtTo.Focus();
                }
                else
                {
                    MessageBox.Show("ENTER YOUR EMAIL ID PASSWORD!", "M E S S A G E");
                    txtMailFrom.Focus();
                }
            }
        }

        private void txtTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTo.Text != string.Empty)
                {
                    txtSubject.Focus();
                }
                else
                {
                    MessageBox.Show("ENTER SENDER EMAIL ID!", "M E S S A G E");
                    txtTo.Focus();
                }
            }
        }

        private void txtSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBody.Focus();
            }
        }

        private void txtBody_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void txtTo_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            //System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9] [\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtTo.Text.Length > 0)
            {
                if (!rEmail.IsMatch(txtTo.Text))
                {
                    MessageBox.Show("Please provide valid email address", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTo.Focus();
                }
            }
        }
    }
}
