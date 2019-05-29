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
    public partial class AdaugaComandaForm : Form
    {
        CarServiceAPI test;

        private int ClientId;
        public AdaugaComandaForm(int clientId, CarServiceAPI _test)
        {
            ClientId = clientId;
            InitializeComponent();
            test = _test;
        }

        private void anuleazaComandaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdaugaComandaBtn_Click(object sender, EventArgs e)
        {
            Client client = test.GetClient(ClientId);
            Comanda comanda = new Comanda()
            {
                StareComanda = 1,
                DataSystem = DateTime.Now,
                DataProgramare = DateTime.Parse(dataProgramareTp.Text),
                KmBord = int.Parse(kmBordTb.Text),
                Descriere = descriereTtb.Text,
                ClientClientId = ClientId,
                Client = client
            };
            test.AddComanda(comanda);

            this.Close();
        }

        private void AdaugaDetaliiBtn_Click(object sender, EventArgs e)
        {
            if (descriereTtb.Text == "") return;
            Client client = test.GetClient(ClientId);
            Comanda comanda = new Comanda()
            {
                StareComanda = 1,
                DataSystem = DateTime.Now,
                DataProgramare = dataProgramareTp.Value,
                KmBord = kmBordTb.Text != ""  ? int.Parse(kmBordTb.Text): 0,
                Descriere = descriereTtb.Text,
                ClientClientId = ClientId,
                Client = client
            };
            //test.AddComanda(comanda);
            AdaugaDetaliiForm adaugaDetaliiForm = new AdaugaDetaliiForm(comanda,test);
            adaugaDetaliiForm.Show();
            this.Close();
        }
    }
}
