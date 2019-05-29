using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenuForm : System.Windows.Forms.Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void AddFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteForm dlt = new DeleteForm();
            dlt.ShowDialog();
        }

        private void ModifyFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckForModifyForm cfmf = new CheckForModifyForm();
            cfmf.ShowDialog();
        }
    }
}
