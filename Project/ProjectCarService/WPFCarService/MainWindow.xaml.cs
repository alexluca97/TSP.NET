using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using WCFCarService;

namespace WPFCarService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ServiceClient srvClt = new ServiceClient();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchClientBtn_Click(object sender, RoutedEventArgs e)
        {
            //var listaClienti = srvClt.GetAllClients();
            //ClientLv.ItemsSource = listaClienti;
        }

        private void AddClientBtn_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow addClientWindow = new AddClientWindow(srvClt);
            addClientWindow.Show();
        }

        private void AddAutoBtn_Click(object sender, RoutedEventArgs e)
        {
            AddAutoWindow addAutoWindow = new AddAutoWindow(srvClt,1);
            addAutoWindow.Show();
        }
    }
}
