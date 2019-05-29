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
    /// Interaction logic for AddAutoWindow.xaml
    /// </summary>
    public partial class AddAutoWindow : Window
    {
        ServiceClient srvClt;
        public AddAutoWindow(ServiceClient _srvClt,int idClient)
        {
            InitializeComponent();
        }
    }
}
