using NTier101_Live.BLL;
using NTier101_Live.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTier101_Live.PL
{
    public partial class frmLogin : Form
    {
        datUserBLL datUserBLL = new datUserBLL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btonLogin_Click(object sender, EventArgs e)
        {
            datUser datUser = new datUser();

            datUser = datUserBLL.getQuery(tboxUserName.Text, tboxUserPassw.Text);

            if (datUser.UserName == null || datUser.UserPassw == null)
            {
                MessageBox.Show("Hatalı giriş yaptınız. Lütfen kontrol ediniz...");
            }
            else
            {
                MessageBox.Show("Doğru giriş yaptınız... ");
            }


        }
    }
}
