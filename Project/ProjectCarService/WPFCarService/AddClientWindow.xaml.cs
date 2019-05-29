using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFCarService
{
    /// <summary>
    /// Interaction logic for AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        ServiceClient srvClt;
        public AddClientWindow(ServiceClient _srvClt)
        {
            InitializeComponent();
            srvClt = _srvClt;
        }

        private void AdaugaBtn_Click(object sender, RoutedEventArgs e)
        {
            srvClt.AddClient(new ProjectCarService.Client
            {
                Nume = NumeTb.Text,
                Prenume = PrenumeTb.Text,
                Adresa = AdresaTb.Text,
                Localitate = LocalitateTb.Text,
                Judet = JudetTb.Text,
                Telefon = TelefonTb.Text,
                Email = EmailTb.Text
            });
            this.Close();
        }

        private void AnuleazaBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
