using System;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Sama_System
{
    /// <summary>
    /// Interaction logic for Addusers.xaml
    /// </summary>
    public partial class Addusers : Window
    {
        public Addusers()
        {
            InitializeComponent();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "insert into Users values(N'" + textbox1.Text + "',N'" +
            textbox2.Text + "',N'" + combobox1.Text + "')";
            md.ManData();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Users";
            DataTable a = new DataTable();
           a= md.ShowData();
            datagridview1.ItemsSource =a.DefaultView;
                
        }
    }
}
