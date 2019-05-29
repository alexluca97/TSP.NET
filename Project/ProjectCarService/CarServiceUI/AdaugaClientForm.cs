using ProjectCarService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceUI
{
    public partial class AdaugaClientForm : Form
    {
        CarServiceAPI test;

        public AdaugaClientForm(CarServiceAPI _test)
        {
            InitializeComponent();
            test = _test;
        }

        private void adaugaBtn_Click(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"(?<word>\w+)");
            if (!Regex.IsMatch(numeTb.Text, @"^[\p{L} \.\-]+$"))
            {
                return;
            }
            if (!Regex.IsMatch(prenumeTb.Text, @"^[\p{L} \.\-]+$"))
            {
                return; 
            }
            if(!Regex.IsMatch(emailTb.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                return;
            }
            if (!Regex.IsMatch(telefonTb.Text, @"^\d$"))
            {
                return;
            }

            Client client = new Client()
            {
                Nume = numeTb.Text,
                Prenume = prenumeTb.Text,
                Adresa = adresaTb.Text,
                Localitate = localitateTb.Text,
                Judet = judetTb.Text,
                Telefon = telefonTb.Text,
                Email = emailTb.Text
            };

            test.AddClient(client);

            this.Close();
        }

        private void anuleazaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
