using System;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Sama_System
{
   
    public partial class addstudent : Window
    {
        public addstudent()
        {
            InitializeComponent();
        }

        private void insrt_Click(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "insert into Student values(N'" + textbox1.Text + "',N'" +
            textbox2.Text + "',N'" + textbox3.Text + "',N'" + textbox4.Text+ "')";
            md.ManData();
        }


        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Student";
            DataTable a = new DataTable();
            a = md.ShowData();
            datagridview2.ItemsSource = a.DefaultView;
        }
    }
}
