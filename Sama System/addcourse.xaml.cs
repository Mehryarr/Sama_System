﻿using System;
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
    /// Interaction logic for addcourse.xaml
    /// </summary>
    public partial class addcourse : Window
    {
        public addcourse()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Course";
            DataTable a = new DataTable();
            a = md.ShowData();
            datagridview1.ItemsSource = a.DefaultView;
        }

        private void insrt_Click(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "insert into Course values(N'" + textbox1.Text + "',N'" +
            textbox2.Text + "',N'" + textbox3.Text + "',N'" + textbox4.Text + "')";
            md.ManData();
        }
    }
}
