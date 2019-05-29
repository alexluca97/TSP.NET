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
using WCFCarService;

namespace CarServiceUI
{
    public partial class FirstForm : Form
    {
        CarServiceAPI test = new CarServiceAPI();
        Client _client;
        Auto _auto;

        public FirstForm()
        {
            InitializeComponent();
        }

        private void cautaClientBtn_Click(object sender, EventArgs e)
        {
            List<Client> clients = test.GetAllClients();
            clientsListView.Items.Clear();
            foreach (var client in clients)
            {
                ListViewItem cl = new ListViewItem(client.ClientId.ToString());
                cl.SubItems.Add(client.Nume);
                cl.SubItems.Add(client.Prenume);
                cl.SubItems.Add(client.Adresa);
                cl.SubItems.Add(client.Localitate);
                cl.SubItems.Add(client.Telefon);
                cl.SubItems.Add(client.Email);
                clientsListView.Items.Add(cl);
            }
            //CarServiceModelContainer car = new CarServiceModelContainer();
            //car.Clients
                //context vizibil

        }

        private void clientsListView_Click(object sender, EventArgs e)
        {
            if (clientsListView.SelectedItems.Count == 0) return;
            sasiuInfoRtb.Clear();

            var index = clientsListView.SelectedIndices.Count-1;
            List<Auto> autos = test.GetAutoByClientId(int.Parse(clientsListView.SelectedItems[index].SubItems[0].Text));

            autoListView.Items.Clear();

            foreach (var auto in autos)
            {
                ListViewItem au = new ListViewItem(auto.AutoId.ToString());
                au.SubItems.Add(auto.NumarAuto);
                au.SubItems.Add(auto.SerieSasiu);
                au.SubItems.Add(auto.SasiuSasiuId.ToString());
                autoListView.Items.Add(au);
            }

            _client = test.GetClient(int.Parse(clientsListView.SelectedItems[index].SubItems[0].Text));

        }

        private void autoListView_Click(object sender, EventArgs e)
        {
            if (autoListView.SelectedItems.Count == 0) return;
            sasiuInfoRtb.Clear();
            var index = clientsListView.SelectedIndices.Count - 1;

            var info = test.GetSasiu(int.Parse(autoListView.SelectedItems[index].SubItems[3].Text));
            if (info == null) return;

            _auto = test.GetAuto(int.Parse(autoListView.SelectedItems[index].SubItems[3].Text));
            sasiuInfoRtb.Text = info.CodSasiu + " " + info.Denumire;
        }

        private void clientsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adaugaClientBtn_Click(object sender, EventArgs e)
        {
            AdaugaClientForm addForm = new AdaugaClientForm(test);
            addForm.ShowDialog();
        }

        private void adaugaVehiculBtn_Click(object sender, EventArgs e)
        {
            if (clientsListView.SelectedItems.Count == 0) return;

            var index = clientsListView.SelectedIndices.Count - 1;

            AdaugaVehiculForm addVehiculForm = new AdaugaVehiculForm(int.Parse(clientsListView.SelectedItems[index].SubItems[0].Text));
            addVehiculForm.ShowDialog();
        }

        private void creazaComandaBtn_Click(object sender, EventArgs e)
        {

            if (autoListView.SelectedItems.Count == 0) return;
            var index = clientsListView.SelectedIndices.Count - 1;

            AdaugaComandaForm addComandaForm = new AdaugaComandaForm(int.Parse(clientsListView.SelectedItems[index].SubItems[0].Text), test);
            addComandaForm.ShowDialog();
            

        }

        private void mecanicFormBtn_Click(object sender, EventArgs e)
        {
            if (autoListView.SelectedItems.Count == 0) return;
            MecaniciForm mecaniciFormcs = new MecaniciForm(_client,_auto, test);
            mecaniciFormcs.Show();
        }

        private void FinalizareBtn_Click(object sender, EventArgs e)
        {
            FinalizareForm finalizareForm = new FinalizareForm(test);
            finalizareForm.Show();
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
        }
    }
}
