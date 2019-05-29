using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddForm : System.Windows.Forms.Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddPersonBtn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Persons\\" + FirstNameTb.Text
                + " " + LastNameTb.Text + ".txt");
            sw.WriteLine(label1.Text + ": " + FirstNameTb.Text);
            sw.WriteLine(label2.Text + ": " + LastNameTb.Text);
            sw.WriteLine(label3.Text + ": " + PhoneTb.Text);
            sw.WriteLine(label4.Text + ": " + AgeTb.Text);
            sw.WriteLine(label5.Text + ": " + EmailTb.Text);
            sw.WriteLine(label6.Text + ": " + GenderCb.Text);
            sw.WriteLine(label7.Text + ": " + AddressTb.Text);

            sw.Close();

            StreamReader sr = new StreamReader(Application.StartupPath + "\\Persons\\" + FirstNameTb.Text
                + " " + LastNameTb.Text + ".txt");

            ReadFileRTB.Text = sr.ReadToEnd();

            sr.Close();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mm = new MainMenuForm();
            mm.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
