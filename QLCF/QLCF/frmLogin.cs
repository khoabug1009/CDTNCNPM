using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLCF
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        QLCFEntities db = new QLCFEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool checkExit(string Username)
        {
            var us = db.Users.FirstOrDefault(x => x.Username == Username);
            if (us != null)
                return true;
            else
                return false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool us = checkExit(txtUsername.Text);

            if (!us)
            {
                MessageBox.Show("Tên đăng nhập không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string pass = txtPass.Text;
            User user = db.Users.FirstOrDefault(x => x.Username == txtUsername.Text);
            if (user.Password.Equals(pass))
            {
                
                MessageBox.Show("Đăng nhập thành công");
                
                MainForm frm = new MainForm(user);
                frm.ShowDialog();
            }
        }
    }
}