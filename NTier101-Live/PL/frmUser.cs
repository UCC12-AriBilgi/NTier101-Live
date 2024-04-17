using NTier101_Live.BLL;
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



        #endregion

    }
}
