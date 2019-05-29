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
    public partial class ModifyForm : Form
    {
        private string _filePath {set; get;}

        public ModifyForm(string filePath)
        {
            InitializeComponent();

            _filePath = filePath;
            StreamReader sr = new StreamReader(filePath);

            ReadFileRTB.Text = sr.ReadToEnd();

            sr.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mm = new MainMenuForm();
            mm.ShowDialog();
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {

            var sr = new StreamReader(_filePath);
            var sw = new StreamWriter(_filePath);
            /*String str = @"a
b
c
d
e";

int n = 2;
string[] lines = str
    .Split(Environment.NewLine.ToCharArray())
    .Skip(n)
    .ToArray();

string output = string.Join(Environment.NewLine, lines);*/

        }
    }
}
