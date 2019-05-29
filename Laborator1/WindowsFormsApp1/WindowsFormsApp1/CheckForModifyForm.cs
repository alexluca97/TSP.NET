using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CheckForModifyForm : Form
    {
        public CheckForModifyForm()
        {
            InitializeComponent();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + "\\Persons\\" + FirstNameTb.Text
                + " " + LastNameTb.Text + ".txt";
            if (File.Exists(filePath))
            {
                this.Hide();
                ModifyForm mf = new ModifyForm(filePath);
                mf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Name");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mm = new MainMenuForm();
            mm.ShowDialog();
        }
    }
}
