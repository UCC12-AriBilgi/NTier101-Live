using NTier101_Live.DAL;
using NTier101_Live.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier101_Live.BLL
{
    // Bu class yönlendirici bir class (MVC yapısındaki Controller)
    // Form tarafıyla haberleşcek
    public class datUserBLL
    {
        private datUserDAO datUserDAO;

        // constructor
        public datUserBLL()
        {
           datUserDAO = new datUserDAO();
        }

        // UserID bilgisine göre kayıt okuma
        public datUser getUser(int UserID)
        {
            datUser datUser = new datUser();

            DataTable dataTable = new DataTable();

            dataTable= datUserDAO.getUser(UserID);

            foreach (DataRow row in dataTable.Rows) 
            { 
                datUser.UserName = row["UserName"].ToString();
                datUser.UserPassw = row["UserPassw"].ToString() ;
                datUser.Ad = row["Ad"].ToString();
                datUser.Soyad = row["Soyad"].ToString();
                datUser.TCKimlik = row["TCKimlik"].ToString();
                datUser.MudurlukID = Convert.ToInt32(row["MudurlukID"].ToString());

            }

            return datUser;

        }

        // Login ekranından gelen bilgiler göre kullanıcı okuma (V/Y)
        public datUser getQuery(string username,string userpassw)
        {
            datUser datUser = new datUser();

            DataTable dataTable = new DataTable();

            dataTable = datUserDAO.searchUserNamePassw(username,userpassw);

            foreach (DataRow row in dataTable.Rows)
            {
                datUser.UserName = row["UserName"].ToString();
                datUser.UserPassw = row["UserPassw"].ToString();
                datUser.Ad= row["Ad"].ToString();
                datUser.Soyad = row["Soyad"].ToString();
            }

            return datUser;

        }

        // Insert
        public datUser insertUser(string UserName,string UserPassw,string Ad,string Soyad,string TCKimlik,int MudurlukID) 
        {
            datUser datUser = new datUser();

            DataTable dataTable = new DataTable();

            datUserDAO.insertUser(UserName, UserPassw, Ad, Soyad,TCKimlik,MudurlukID);

            foreach (DataRow row in dataTable.Rows)
            {
                row["UserName"]=datUser.UserName;
                row["UserPassw"] = datUser.UserPassw;
                row["Ad"] = datUser.Ad;
                row["Soyad"] = datUser.Soyad;
                row["TCKimlik"] = datUser.TCKimlik;
                row["MudurlukID"] = datUser.MudurlukID;

            }

            return datUser;
        }

        // Update
        public datUser updateUser(int UserID,string UserName, string UserPassw, string Ad, string Soyad, string TCKimlik, int MudurlukID)
        {
            datUser datUser = new datUser();

            DataTable dataTable = new DataTable();

            datUserDAO.updateUser(UserID,UserName, UserPassw, Ad, Soyad, TCKimlik, MudurlukID);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    row["UserName"] = datUser.UserName;
            //    row["UserPassw"] = datUser.UserPassw;
            //    row["Ad"] = datUser.Ad;
            //    row["Soyad"] = datUser.Soyad;
            //    row["TCKimlik"] = datUser.TCKimlik;
            //    row["MudurlukID"] = datUser.MudurlukID;

            //}

            return datUser;
        }

        // Delete
        public datUser deleteUser(int UserID)
        {
            datUser datUser = new datUser();

            DataTable dataTable = new DataTable();

            datUserDAO.deleteUser(UserID);

            return datUser;
        }



    }
}
