using System.Data.SqlClient;
using System.Windows;

namespace Sama_System
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static int flag = 0;
        private void login_Click(object sender, RoutedEventArgs e)
        {  
            SqlConnection con1 = new SqlConnection("server=(local);database=University2;integrated security=true");
            con1.Open();
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "select * from Users where Uname=N'" + textbox1.Text + "' and Upass=N'" + passbox1.Password + "' and Utype=N'"+combobox1.Text+"'";
            c1.Connection = con1;
            SqlDataReader dr = c1.ExecuteReader();
            if (dr.Read())
            {
                if (combobox1.Text == "local")   
                    flag = 1;
                else
                   flag = 0;

                Getname.nm = textbox1.Text;
                Getname.lv = combobox1.Text;
                MainWindow2 m1 = new MainWindow2();
                this.Close();
                m1.ShowDialog();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز یا نوع کاربر اشتباه وارد شده است!", "خطا", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            con1.Close();
        }
        
        private void close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
