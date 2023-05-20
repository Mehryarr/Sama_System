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
using System.Data;
namespace Sama_System
{
    /// <summary>
    /// Interaction logic for showuser.xaml
    /// </summary>
    public partial class showuser : Window
    {
        public showuser()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Users";
            DataTable a = new DataTable();
            a = md.ShowData();
            datagridview1.ItemsSource = a.DefaultView;
        }
    }
}
