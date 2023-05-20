using System;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Win32;

namespace Sama_System
{
    /// <summary>
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {

            InitializeComponent();
            customisdesign();
            acname.Text = Getname.nm;
            level.Text = Getname.lv;
            if (MainWindow.flag == 1)
            {
                @new.Visibility = Visibility.Collapsed;
                edit.Visibility = Visibility.Collapsed;
                user0.Visibility = Visibility.Collapsed;
                user0.IsEnabled = false;
            }
        }
        #region opening and closing vertical submenues
        private void customisdesign()
        {
            submenu0.Visibility = Visibility.Collapsed;
            submenu1.Visibility = Visibility.Collapsed;
            submenu2.Visibility = Visibility.Collapsed;
            submenu3.Visibility = Visibility.Collapsed;
        }
        private void hidesubmenu()
        {
            if (submenu0.Visibility == Visibility.Visible)
            {
                submenu0.Visibility = Visibility.Collapsed;
            }
            if (submenu1.Visibility==Visibility.Visible)
            {
                submenu1.Visibility = Visibility.Collapsed;
            }
            if (submenu2.Visibility == Visibility.Visible)
            {
                submenu2.Visibility = Visibility.Collapsed;
            }
            if (submenu3.Visibility == Visibility.Visible)
            {
                submenu3.Visibility = Visibility.Collapsed;
            }
        }
        private void showsubmenu(StackPanel submenu)
        {
            if (submenu.Visibility==Visibility.Collapsed)
            {
                submenu.Visibility = Visibility.Visible;
            }
            else
                submenu.Visibility = Visibility.Collapsed;
        }
        #endregion
        #region backup and restore
        private void backupdata(string filename)
        {
            SqlConnection oconnection = null;
            try
            {
                string commmand = @"backup Database [University2] to Disk= '" + filename + "'";
                SqlCommand ocommand = null;
                oconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr1"].ConnectionString);
                if(oconnection.State!=ConnectionState.Open)
                {
                    oconnection.Open();
                }
                ocommand = new SqlCommand(commmand,oconnection);
                ocommand.ExecuteNonQuery();
                MessageBox.Show("تهیه نسخه پشتیبان با موفقیت انجام شد!","توجه",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("خطا:" + ex.Message);
            }
            oconnection.Close();
        }
        private void restoredata(string filename)
        {
            SqlConnection oconnection = null;
            try
            {
                string command = "ALTER DATABASE [University2] SET SINGLE_USER WITH ROLLBACK IMMEDIATE USE master RESTORE DATABASE [University2] FROM DISK='" 
                    +filename + "' WITH REPLACE";
                SqlCommand ocommand = null;
                oconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr1"].ConnectionString);
                if (oconnection.State != ConnectionState.Open)
                {
                    oconnection.Open();
                }
                ocommand = new SqlCommand(command, oconnection);
                ocommand.ExecuteNonQuery();
                MessageBox.Show("بازیابی پشتیبان با موفقیت انجام شد!", "توجه", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا:" + ex.Message);
            }
            oconnection.Close();
        }
        #endregion

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            openmenu.Visibility = Visibility.Visible;
            closemenu.Visibility = Visibility.Collapsed;
            hidesubmenu();
        }

        private void new_Click(object sender, RoutedEventArgs e)
        {
            showsubmenu(submenu1);
        }

        private void user_Click(object sender, RoutedEventArgs e)
        {
            Addusers a = new Addusers();
            a.ShowDialog();
            hidesubmenu();
        }

        private void student_Click(object sender, RoutedEventArgs e)
        {
            addstudent a = new addstudent();
            a.ShowDialog();
            hidesubmenu();
        }

        private void course_Click(object sender, RoutedEventArgs e)
        {
            addcourse a = new addcourse();
            a.ShowDialog();
            hidesubmenu();
        }

        private void teacher_Click(object sender, RoutedEventArgs e)
        {
            addteacher a = new addteacher();
            a.ShowDialog();
            hidesubmenu();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            showsubmenu(submenu2);
        }

        private void user2_Click(object sender, RoutedEventArgs e)
        {
            edituser a = new edituser();
            a.ShowDialog();
            hidesubmenu();
        }

        private void student2_Click(object sender, RoutedEventArgs e)
        {
            editstudent a = new editstudent();
            a.ShowDialog();
            hidesubmenu();
        }

        private void course2_Click(object sender, RoutedEventArgs e)
        {
            editcourse a = new editcourse();
            a.ShowDialog();
            hidesubmenu();
        }

        private void teacher2_Click(object sender, RoutedEventArgs e)
        {
            editteacher a = new editteacher();
            a.ShowDialog();
            hidesubmenu();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            showsubmenu(submenu3);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void openmenu_Click(object sender, RoutedEventArgs e)
        {
            openmenu.Visibility = Visibility.Collapsed;
            closemenu.Visibility = Visibility.Visible;
        }

        private void closemenu_Click(object sender, RoutedEventArgs e)
        {
            openmenu.Visibility = Visibility.Visible;
            closemenu.Visibility = Visibility.Collapsed;
        }

        private void user0_Click(object sender, RoutedEventArgs e)
        {
            showuser a = new showuser();
            a.ShowDialog();
            hidesubmenu();
        }

        private void student0_Click(object sender, RoutedEventArgs e)
        {
            showstudent a = new showstudent();
            a.ShowDialog();
            hidesubmenu(); 
        }

        private void course0_Click(object sender, RoutedEventArgs e)
        {
            showcourse a = new showcourse();
            a.ShowDialog();
            hidesubmenu();
        }

        private void teacher0_Click(object sender, RoutedEventArgs e)
        {
            showteacher a = new showteacher();
            a.ShowDialog();
            hidesubmenu();
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            showsubmenu(submenu0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AboutBox a = new AboutBox();
            a.ShowDialog();
        }

        private void backup_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog a = new SaveFileDialog();
            string filename = string.Empty;
            a.OverwritePrompt = true;
            a.Title = "Saving backup";
            a.Filter = @"(.Bak)|*.Bak|ALL FILES|*.*";
            a.FileName = DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss");
            if(a.ShowDialog()==true)
            {
                filename = a.FileName;
                backupdata(filename);
            }
        }

        private void restore_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            string filename = string.Empty;
            a.Title = "restore backup";
            a.Filter = @"(.Bak)|*.Bak|ALL FILES|*.*";
            a.FileName = DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss");
            if (a.ShowDialog() == true)
            {
                filename = a.FileName;
                restoredata(filename);
            }
        }

        private void user3_Click(object sender, RoutedEventArgs e)
        {
            hidesubmenu();
        }

        private void student3_Click(object sender, RoutedEventArgs e)
        {
            searchstudent a = new searchstudent();
            a.ShowDialog();
            hidesubmenu();
        }

        private void course3_Click(object sender, RoutedEventArgs e)
        {
            searchcourse a = new searchcourse();
            a.ShowDialog();
            hidesubmenu();
        }

        private void teacher3_Click(object sender, RoutedEventArgs e)
        {
            searchteacher a = new searchteacher();
            a.ShowDialog();
            hidesubmenu();
        }
    }
}
