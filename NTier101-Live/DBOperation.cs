using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTier101_Live
{
    internal class DBOperation
    {
        private SqlDataAdapter dataAdapter;
        public SqlConnection Connection { get; set; }

        // constructor
        public DBOperation()
        {
            dataAdapter = new SqlDataAdapter();
            
            Connection = new SqlConnection(@"Data Source=EGITMEN;Initial Catalog=NTier101DB;Integrated Security=True;TrustServerCertificate=True;");
        }

        // VT ye bağlanmak için
        private SqlConnection openConnection()
        {
            // vt ile olan bağlantıyı acmak ve durumunu geriye döndürmek (acıldı mı/acılmadı mı)

            // bağlantı durumunun kontrolu (acık mı/değil mi)
            if (Connection.State == System.Data.ConnectionState.Closed || Connection.State == System.Data.ConnectionState.Broken)
            {
                Connection.Open();
            }

            return Connection;
        }

        // Klasik CRUD (Create/Read/Update/Delete) işlemleri

        // Select(Read) Kısmı

        public DataTable executeSelectQuery(string _query, SqlParameter[] _parameters)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();

            dt = null;

            // SQL Sorgusunu çalıştıracak kısım

            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = _query;
                cmd.Parameters.AddRange( _parameters );
                cmd.ExecuteNonQuery();

                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(ds); // gelen sonucu ds içine doldur

                dt = ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message.ToString());
                return null;
            }

            return dt;

        }

        // Insert(Create) kısmı
        public bool executeInsertQuery(string _query, SqlParameter[] _parameters)
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = _query;
                cmd.Parameters.AddRange(_parameters);
                dataAdapter.InsertCommand = cmd;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message.ToString());
                return false;

            }

            return true;

        }

        // Update kısmı
        public bool executeUpdateQuery(string _query, SqlParameter[] _parameters)
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = _query;
                cmd.Parameters.AddRange(_parameters);
                dataAdapter.UpdateCommand = cmd;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message.ToString());
                return false;

            }

            return true;
        }

        // Delete kısmı
        public bool executeDeleteQuery(string _query)
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = _query;
                dataAdapter.DeleteCommand = cmd;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message.ToString());
                return false;

            }

            return true;
        }


    }
}
