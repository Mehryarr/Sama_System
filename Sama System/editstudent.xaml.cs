using System;
using System.Windows;
using System.Data;

namespace Sama_System
{
    /// <summary>
    /// Interaction logic for editstudent.xaml
    /// </summary>
    public partial class editstudent : Window
    {
        public editstudent()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Student";
            DataTable a = new DataTable();
            a = md.ShowData();
            datagridview2.ItemsSource = a.DefaultView;
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "update Student set Stno=N'" + textbox1.Text + "',Stname=N'" + textbox2.Text + "' ,Stfamily=N'" + textbox3.Text +
            "' ,Stfield=N'" + textbox4.Text +"' where Stno=N'" + textbox1.Text + "'";
            md.ManData();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "delete from Student where Stno = N'" + textbox1.Text + "'";
            md.ManData();
        }
    }
}
