using NTier101_Live.BLL;
using NTier101_Live.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTier101_Live.PL
{
    public partial class frmUser : Form
    {
        public string Mode; // IUD durumlarını tutacak değişgen
        public int UserID; // U işlemi için

        public SqlCommand command;

        private datUserBLL datUserBLL=new datUserBLL(); // yönlendirici

        public frmUser()
        {
            InitializeComponent();
        }

        #region Form Methods
        
        private void frmUser_Load(object sender, EventArgs e)
        {
            FormInit();

            ShowRecords();
        }

        public void FormInit()
        {
            // formun ilk durum ayarları
            Mode = "";
            
            groupBox1.Enabled = false;

            tboxUserName.Clear();
            tboxUserPassw.Clear();
            tboxAd.Clear();
            tboxSoyad.Clear();
            tboxTCKimlik.Clear();
            tboxMudurlukID.Clear();
        }
        #endregion

        #region Genel Metotlar

        public void ShowRecords()
        {
            DBOperation conn= new DBOperation();


            command= new SqlCommand("SELECT * FROM datUser",conn.Connection);

            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter= new SqlDataAdapter(command);

            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();

            bindingSource.DataSource = dataTable;

            dgrdUsers.DataSource = bindingSource;
        }

        public void IUD()
        {
            // Insert Update Delete işlemlerini halledecek metot

            datUser datUser = new datUser();

            switch (Mode)
            {
                case "I":

                    datUser = datUserBLL.insertUser(tboxUserName.Text, tboxUserPassw.Text, tboxAd.Text, tboxSoyad.Text, tboxTCKimlik.Text, Convert.ToInt32(tboxMudurlukID.Text));

                    MessageBox.Show("Yeni kayıt işlemiz başarılı");

                    break;

                case "U":

                    break;

                case "D":


                    break;





                default:
                    break;
            }

            FormInit();

            ShowRecords();

        }

        #endregion

        #region Button Events
        
        private void btonNew_Click(object sender, EventArgs e)
        {
            Mode = "I";

            groupBox1.Enabled = true;

            tboxUserName.Focus();
        }

        private void btonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btonDelete_Click(object sender, EventArgs e)
        {

        }

        private void btonSave_Click(object sender, EventArgs e)
        {
            IUD();
        }

        #endregion


    }
}
