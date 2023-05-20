using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;
using System.Windows.Documents;


namespace Sama_System
{
    class MyData
    {
     
            public string strsql;
            public DataTable ShowData()
            {
                SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr1"].ConnectionString);
                con1.Open();
                SqlDataAdapter da = new SqlDataAdapter(strsql, con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con1.Close();
                return (dt);
            }
            public void ManData()
            {
                SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr1"].ConnectionString);
                con1.Open();
                SqlCommand c1 = new SqlCommand();
                c1.Connection = con1;
                c1.CommandText = strsql;
            try
            {
                c1.ExecuteNonQuery();
                  MessageBox.Show("داده وارد شد!","توجه",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("داده اشکال دارد!","اخطار",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
            con1.Close();
            }
    }
    
}

