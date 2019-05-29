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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + "\\Persons\\" + FirstNameTb.Text
                + " " + LastNameTb.Text + ".txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                MessageBox.Show("File Deleted with success");
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
