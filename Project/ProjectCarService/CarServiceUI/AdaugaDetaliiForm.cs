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
using ProjectCarService;

namespace CarServiceUI
{
    public partial class AdaugaDetaliiForm : Form
    {
        private Comanda comanda;
        CarServiceAPI test;
        public AdaugaDetaliiForm(Comanda _comanda, CarServiceAPI _test)
        {
            test = _test;
            comanda = _comanda;
            InitializeComponent();
        }

        private void AnuleazaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdaugaFotoBtn_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    imaginePb.ImageLocation = imageLocation;
                }
            }
            catch (Exception) {
                MessageBox.Show("Eroare la incarcarea imaginii!");
            }
        }

        private void AdaugaDetaliiBtn_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();

            imaginePb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            byte[] buff = ms.GetBuffer();


            Imagine imagine = new Imagine()
            {
                Titlu = TitluTb.Text,
                Descriere = DescriereLabel.Text,
                Data = DataDetaliiTp.Value,
                Foto = buff
            };
            List<Imagine> imagines = new List<Imagine>();
            imagines.Add(imagine);

            DetaliuComanda detaliuComanda = new DetaliuComanda()
            {
                Comanda = this.comanda,
                Imagines = imagines
            };

            imagine.DetaliuComanda = detaliuComanda;

            test.AddDetaliuComanda(detaliuComanda);
            test.AddImagine(imagine);
            
            this.Close();
        }
    }
}
