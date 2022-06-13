/*
  ✨✨✨✨✨✨✨✨
     💫💫💫💫💫💫 
 😴Bruno Pennacchioni💤
          and
   👻Paula Farias👻
     💫💫💫💫💫💫
  ✨✨✨✨✨✨✨✨
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;

namespace gestorMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e){
            OpenFileDialog op = new OpenFileDialog();
            
            if (op.ShowDialog() == DialogResult.OK){
                textBox5.Text = op.FileName;
            }
        }
        private void button2_Click(object sender, EventArgs e){
            MailMessage mail = new MailMessage(textBox8.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if (textBox5.Text != string.Empty){
                mail.Attachments.Add(new Attachment(textBox5.Text));
            }
            SmtpClient client;
            if (comboBox1.SelectedIndex == 0){
                client = new SmtpClient("smtp.gmail.com");
            }
            else{
                client = new SmtpClient("smtp-mail.outlook.com");
            }
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(textBox8.Text, textBox7.Text);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Mail enviado", " ", MessageBoxButtons.OK);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
/*
  ✨✨✨✨✨✨✨✨
     💫💫💫💫💫💫 
 😴Bruno Pennacchioni💤
        🔥and🔥
   👻Paula Farias👻
     💫💫💫💫💫💫
  ✨✨✨✨✨✨✨✨
*/