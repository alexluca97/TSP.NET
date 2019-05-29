using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectCarService;

namespace CarServiceUI
{
    public partial class FinalizareForm : Form
    {
        CarServiceAPI test;

        public FinalizareForm(CarServiceAPI _test)
        {
            test = _test;
            InitializeComponent();
            List<Comanda> comandas = test.GetAllComands();

            foreach(var com in comandas)
            {
                if(com.StareComanda == 1)
                {
                    ListViewItem mc = new ListViewItem(com.Client.Nume);
                    mc.SubItems.Add(com.Client.Prenume);
                    mc.SubItems.Add(com.Descriere);
                    clientiLv.Items.Add(mc);
                }
            }
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void finalizareBtn_Click(object sender, EventArgs e)
        {

        }

        private void pieseCbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clientiLv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
