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
    public partial class MecaniciForm : Form
    {
        CarServiceAPI test;
        Client _client;
        Auto _auto;
        public MecaniciForm(Client client, Auto auto, CarServiceAPI _test)
        {
            test = _test;
            _client = client;
            _auto = auto;
            InitializeComponent();
            clientRtb.Text = String.Format("{0} {1} cu detaliile masinii:{2}.", client.Nume, client.Prenume, auto.SerieSasiu);
            List<Mecanic> mecanics = test.GetAllMecanics();

            foreach (var mecanic in mecanics)
            {
                ListViewItem mc = new ListViewItem(mecanic.MecanicId.ToString());
                mc.SubItems.Add(mecanic.Nume);
                mc.SubItems.Add(mecanic.Prenume);
                //if(mecanic.DetaliuComandas != null )
                //{
                    mc.SubItems.Add("Liber");
                //}
                //else
                //{
                //    mc.SubItems.Add(mecanic.DetaliuComandas.ToString());
                //}

                mecanicLv.Items.Add(mc);
            }
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alegeBtn_Click(object sender, EventArgs e)
        {
            if (mecanicLv.SelectedItems.Count == 0) return;
            var index = mecanicLv.SelectedIndices.Count - 1;
            Mecanic meca = test.GetMecanic(int.Parse(mecanicLv.SelectedItems[index].SubItems[0].Text));
            List<Mecanic> mecanics = new List<Mecanic>();
            Comanda comanda = new Comanda();
            List<Comanda> comands = test.GetAllComands();

            DetaliuComanda detaliu;
            List<DetaliuComanda> detaliuComands = test.GetAllDetailsCommands();
            mecanics.Add(meca);
            foreach (var cm in comands)
            {
                if(cm.ClientClientId == _client.ClientId)
                {
                    comanda = cm;
                    comanda.StareComanda = 2;
                    test.UpdateComanda(comanda);
                }
            }

            foreach(var dc in detaliuComands)
            {
                if(dc.Comanda == comanda)
                {
                    detaliu = dc;
                    detaliu.Mecanics = mecanics;
                    test.UpdateDetaliuComanda(detaliu);
                }
            }
        }
    }
}
