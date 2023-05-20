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
    /// Interaction logic for editcourse.xaml
    /// </summary>
    public partial class editcourse : Window
    {
        public editcourse()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Course";
            DataTable a = new DataTable();
            a = md.ShowData();
            datagridview2.ItemsSource = a.DefaultView;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "delete from Course where Cno = N'" + textbox1.Text + "'";
            md.ManData();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "update Course set Cno=N'" + textbox1.Text + "',Cname=N'" + textbox2.Text + "' ,Ctype=N'" + textbox3.Text +
            "' ,Cunit=N'" + textbox4.Text + "' where Cno=N'" + textbox1.Text + "'";
            md.ManData();
        }
    }
}
