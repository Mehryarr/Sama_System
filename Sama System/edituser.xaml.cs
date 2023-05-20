
using System.Windows;
using System.Data;

namespace Sama_System
{
    /// <summary>
    /// Interaction logic for edituser.xaml
    /// </summary>
    public partial class edituser : Window
    {
        public edituser()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Users";
            DataTable a = new DataTable();
            a = md.ShowData();
            datagridview2.ItemsSource = a.DefaultView;
        }

        private void insrt_Click(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "delete from Users where Uname = N'" +textbox1.Text + "'";
            md.ManData();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            string s;
            s = textbox1.Text;
            MyData md = new MyData();
            md.strsql = "update Users set Uname='" + textbox1.Text + "',Upass='" + textbox2.Text + "' ,Utype='" + combobox1.Text +
                "' where Uname='" + s+ "'";
      
            md.ManData();
            
        }
    }
}
