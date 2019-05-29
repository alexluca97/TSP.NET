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
    //Adauga un autovehicul unui client ce are deja cel putin un autovehicul
    public partial class AdaugaVehiculForm : Form
    {
        CarServiceAPI test = new CarServiceAPI();
        private int IdClient;
        public AdaugaVehiculForm(int idClient)
        {
            IdClient = idClient;
            InitializeComponent();
        }

        private void anuleazaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adaugaAutoBtn_Click(object sender, EventArgs e)
        {
            if (nrAutoTb.Text == "" || serieSasiuTb.Text == "" || codSasiuTb.Text == "" || denumireAutoTb.Text == "") return;
            if (serieSasiuTb.Text[6] != codSasiuTb.Text[0] && serieSasiuTb.Text[7] != codSasiuTb.Text[1]) return;
            // if (serieSasiuTb.Text.Length < 25) return;

            Client client = test.GetClient(IdClient);

            Sasiu sasiu = new Sasiu()
            {
                CodSasiu = codSasiuTb.Text,
                Denumire = denumireAutoTb.Text,
            };
            test.AddSasiu(sasiu);

            sasiu = test.GetSasiuByCodeAndName(sasiu.CodSasiu, sasiu.Denumire);

            Auto auto = new Auto()
            {
                NumarAuto = nrAutoTb.Text,
                SerieSasiu = serieSasiuTb.Text,
                ClientClientId = IdClient,
                SasiuSasiuId = sasiu.SasiuId,
                Sasiu = sasiu,
                Client = client
            };

            test.AddAuto(auto);

            this.Close();
        }
    }
}
