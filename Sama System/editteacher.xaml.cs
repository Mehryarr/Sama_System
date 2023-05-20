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
    /// Interaction logic for editteacher.xaml
    /// </summary>
    public partial class editteacher : Window
    {
        public editteacher()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Teacher";
            DataTable a = new DataTable();
            a = md.ShowData();
            datagridview2.ItemsSource = a.DefaultView;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "delete from Teacher where Tno = N'" + textbox1.Text + "'";
            md.ManData();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "update Teacher set Tno=N'" + textbox1.Text + "',Tname=N'" + textbox2.Text + "' ,Tdegree=N'" + textbox3.Text +
            "' ,Tsalary=N'" + textbox4.Text + "' where Tno=N'" + textbox1.Text + "'";
            md.ManData();
        }
    }
}
