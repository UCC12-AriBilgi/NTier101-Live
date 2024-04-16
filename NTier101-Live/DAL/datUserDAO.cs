using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NTier101_Live.DAL
{
    // DB tablosu üzerinde çeşitli arama...login için sorgulama işlemleri gerçekleştirecek sınıf
    // UserID ve Password e göre kullanıcı var mı/yok mu
    // Insert,Update,Delete işlemlerinin emrini verecek 

    internal class datUserDAO
    {
        private DBOperation DBOperation;

        // constructor
        public datUserDAO()
        {
           DBOperation = new DBOperation();
        }

        // Bir kullanıcının çeşitli bilgilerinin search edileceği kısım
        // Burası bir Login ekranından kullanıcı var mı / yok mu kontrolu için kullanılabilir

        public DataTable searchUserNamePassw(string userName, string userPassw)
        {
            // Parametrik yapı
            string Query = string.Format("SELECT * FROM datUser WHERE UserName=@UserName AND UserPassw=@UserPassw");

            // Parametrelerin tanımlanması ve ayarlanması
            SqlParameter[] sqlParameters = new SqlParameter[2]; // 2 tane parametre var

            sqlParameters[0] = new SqlParameter("UserName", SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("UserPassw",SqlDbType.NVarChar);

            // içini doldurma

            sqlParameters[0].Value = userName;
            sqlParameters[1].Value = userPassw;

            return DBOperation.executeSelectQuery(Query, sqlParameters);

        }

        // UserID ile tablo içinden veri okuma
        public DataTable getUser(int UserID)
        {
            // Parametrik yapı
            string Query = string.Format("SELECT * FROM datUser WHERE UserID=@UserID");

            // Parametrelerin tanımlanması ve ayarlanması
            SqlParameter[] sqlParameters = new SqlParameter[1]; // 1 tane parametre var

            sqlParameters[0] = new SqlParameter("UserID", SqlDbType.TinyInt);

            // içini doldurma

            sqlParameters[0].Value = UserID;

            return DBOperation.executeSelectQuery(Query, sqlParameters); // işi yapan kısım

        }

        // Kullanıcı Ekleme
        public bool insertUser(string UserName, string UserPassw,string Ad,string Soyad,string TCKimlik,int MudurlukID)
        {
            string query;

            query = "INSERT INTO datUser ";
            query += "(UserName,UserPassw,Ad,Soyad,TCKimlik,MudurlukID) VALUES ";
            query += "(@UserName,@UserPassw,@Ad,@Soyad,@TCKimlik,@MudurlukID)";

            // Parametrelerin tanımlanması ve ayarlanması
            SqlParameter[] sqlParameters = new SqlParameter[6]; // 6 tane parametre var

            sqlParameters[0] = new SqlParameter("UserName", SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("UserPassw", SqlDbType.NVarChar);
            sqlParameters[2] = new SqlParameter("Ad", SqlDbType.NVarChar);
            sqlParameters[3] = new SqlParameter("Soyad", SqlDbType.NVarChar);
            sqlParameters[4] = new SqlParameter("TCKimlik", SqlDbType.NVarChar);
            sqlParameters[5] = new SqlParameter("MudurlukID", SqlDbType.TinyInt);

            // içini doldurma

            sqlParameters[0].Value = UserName;
            sqlParameters[1].Value = UserPassw;
            sqlParameters[2].Value = Ad; 
            sqlParameters[3].Value = Soyad;
            sqlParameters[4].Value = TCKimlik;
            sqlParameters[5].Value = MudurlukID;

            return DBOperation.executeInsertQuery(query, sqlParameters); // işi yapan kısım

        }

        // Kullanıcı güncelleme
        public bool updateUser(int UserID,string UserName, string UserPassw, string Ad, string Soyad, string TCKimlik, int MudurlukID)
        {
            string query;

            query = "UPDATE datUser SET ";
            query += "UserName=@UserName,";
            query += "UserPassw=@UserPassw,";
            query += "Ad=@Ad,";
            query += "Soyad=@Soyad,";
            query += "TCKimlik=@TCKimlik,";
            query += "MudurlukID=@MudurlukID ";
            query += "WHERE UserID=@UserID";


            // Parametrelerin tanımlanması ve ayarlanması
            SqlParameter[] sqlParameters = new SqlParameter[7]; // 7 tane parametre var

            sqlParameters[0] = new SqlParameter("UserName", SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("UserPassw", SqlDbType.NVarChar);
            sqlParameters[2] = new SqlParameter("Ad", SqlDbType.NVarChar);
            sqlParameters[3] = new SqlParameter("Soyad", SqlDbType.NVarChar);
            sqlParameters[4] = new SqlParameter("TCKimlik", SqlDbType.NVarChar);
            sqlParameters[5] = new SqlParameter("MudurlukID", SqlDbType.TinyInt);

            // içini doldurma

            sqlParameters[0].Value = UserName;
            sqlParameters[1].Value = UserPassw;
            sqlParameters[2].Value = Ad;
            sqlParameters[3].Value = Soyad;
            sqlParameters[4].Value = TCKimlik;
            sqlParameters[5].Value = MudurlukID;
            sqlParameters[6].Value = UserID;

            return DBOperation.executeUpdateQuery(query, sqlParameters); // işi yapan kısım

        }

        // Kullanıcı silme
        public bool deleteUser(int UserID)
        {
            string query;

            query = "DELETE datUser WHERE UserID=" + UserID.ToString();

            return DBOperation.executeDeleteQuery(query); // işi yapan kısım

        }






    }
}
