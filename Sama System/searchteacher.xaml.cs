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
using System.Configuration;
using System.Data.SqlClient;
namespace Sama_System
{
    /// <summary>
    /// Interaction logic for searchteacher.xaml
    /// </summary>
    public partial class searchteacher : Window
    {
        public searchteacher()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Teacher";
            DataTable a = new DataTable();
            a = md.ShowData();
            datagridview1.ItemsSource = a.DefaultView;
        }

        private void textbox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = ConfigurationManager.ConnectionStrings["ConStr1"].ConnectionString;
            con1.Open();
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "select * from Teacher where Tno='" + textbox1.Text + "'";
            c1.Connection = con1;
            SqlDataReader dr = c1.ExecuteReader();
            object[] x = new object[4];
            if (dr.Read())
            {
                dr.GetValues(x);
                textbox1.Text = x[0].ToString();
                textbox2.Text = x[1].ToString();
                textbox3.Text = x[2].ToString();
                textbox4.Text = x[3].ToString();
            }
            con1.Close();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Teacher where Tno like '%" + textbox5.Text + "%'";
            DataTable a = new DataTable();
            a = md.ShowData();
            datagridview1.ItemsSource = a.DefaultView;
        }
    }
}
