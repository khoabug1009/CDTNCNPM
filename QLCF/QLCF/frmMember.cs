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
using System.Diagnostics;

namespace QLCF
{
    public partial class frmMember : DevExpress.XtraEditors.XtraForm
    {
        public frmMember()
        {
            InitializeComponent();
        }
        QLCFEntities db = new QLCFEntities();
        int _ID;
        User user = new User();
        private void frmMember_Load(object sender, EventArgs e)
        {
            loadUser();
            loadRole();
            txtID.Enabled = false;
        }
        public void loadUser()
        {
            gcMember.DataSource = db.Users.ToList();
            gvMenber.OptionsBehavior.Editable = false;
        }
        public void loadRole()
        {
            cboRole.DataSource = Role.getList();
            cboRole.DisplayMember = "_display";
            cboRole.ValueMember = "_display";
        }
        private void gvMenber_Click(object sender, EventArgs e)
        {
            if (gvMenber.RowCount > 0)
            {
                _ID = Int32.Parse(gvMenber.GetFocusedRowCellValue("ID").ToString());
                txtID.Text = gvMenber.GetFocusedRowCellValue("ID").ToString();
                txtUsername.Text = gvMenber.GetFocusedRowCellValue("Username").ToString();
                txtFullname.Text = gvMenber.GetFocusedRowCellValue("Fullname").ToString();
                txtSDT.Text = gvMenber.GetFocusedRowCellValue("Phonenumbew").ToString();
                txtEmail.Text = gvMenber.GetFocusedRowCellValue("Email").ToString();
                txtAdress.Text = gvMenber.GetFocusedRowCellValue("Address").ToString();
                cboRole.Text = gvMenber.GetFocusedRowCellValue("Role").ToString();
             
            }
        }
        public void update(User xx)
        {
            User _xx = db.Users.FirstOrDefault(x => x.ID == xx.ID);
            _xx.Username = xx.Username;
            _xx.Fullname = xx.Fullname;
            _xx.Phonenumbew = xx.Phonenumbew;
            _xx.Password = xx.Password;
            _xx.Role = xx.Role;
            _xx.Email = xx.Email;
            _xx.Address = xx.Address;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);
            }
        }
        public void reset()
        {
            txtID.Clear();
            txtUsername.Clear();
            txtAdress.Clear();
            txtEmail.Clear();
            txtFullname.Clear();
            txtSDT.Clear();
        }
        public bool checkUsername(string user)
        {
            if (user.Length < 5 && user.Length > 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkFullname(string fn)
        {
            if (fn.Length < 2 && fn.Length > 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checksdt(string sdt)
        {
            if (sdt.StartsWith("0") && sdt.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool checkEmail(string email)
        {
            if (email.Substring(email.Length - 10, 10) == "@gmail.com")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkAddress(string address)
        {
            if (address.Length > 200 && address.Length < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtFullname.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || txtAdress.Text == "")
            {
                MessageBox.Show("Vui Lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkUsername(txtUsername.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Tên đăng nhập có độ dài từ 5 - 15 kí tự", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkFullname(txtFullname.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Họ và tên có độ dài từ 2 - 50 kí tự", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checksdt(txtSDT.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Số điện thoại có độ dài 10 kí tự và số 0 ở đầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Email phải đúng định dạng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkAddress(txtAdress.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Địa chi có độ dài từ 5- 255 kí tự", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                user.Username = txtUsername.Text;
                user.Fullname = txtFullname.Text;
                user.Phonenumbew = txtSDT.Text;
                user.Role = cboRole.SelectedValue.ToString();
                user.Email = txtEmail.Text;
                user.Address = txtAdress.Text;
                user.Password = "111111";
                db.Users.Add(user);
                db.SaveChanges();
                reset();
                loadUser();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtFullname.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || txtAdress.Text == "")
            {
                MessageBox.Show("Vui Lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkUsername(txtUsername.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Tên đăng nhập có độ dài từ 5 - 15 kí tự", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkFullname(txtFullname.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Họ và tên có độ dài từ 2 - 50 kí tự", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checksdt(txtSDT.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Số điện thoại có độ dài 10 kí tự và số 0 ở đầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Email phải đúng định dạng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkAddress(txtAdress.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Địa chi có độ dài từ 5- 255 kí tự", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                User xx = db.Users.FirstOrDefault(x => x.ID == _ID);
                xx.Username = txtUsername.Text;
                xx.Fullname = txtFullname.Text;
                xx.Phonenumbew = txtSDT.Text;
                xx.Role = cboRole.SelectedValue.ToString();
                xx.Email = txtEmail.Text;
                xx.Address = txtAdress.Text;
                //xx.Password = txtPass.Text;
                update(xx);
                //db.SaveChanges();
                loadUser();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            loadUser();
            reset();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(MessageBox.Show("bạn có chắc muốn xóa","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                User xx = db.Users.FirstOrDefault(x => x.ID == _ID);
                db.Users.Remove(xx);
                db.SaveChanges();
                loadUser();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            User xx = db.Users.FirstOrDefault(x => x.ID == _ID);
            xx.Password = "111111";
            update(xx);
            //db.SaveChanges();
            loadUser();
            MessageBox.Show("Mật khẩu đã được đổi về mặc định!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            string path = "output.xlsx";
            gcMember.ExportToXlsx(path, new DevExpress.XtraPrinting.XlsxExportOptionsEx { ExportType = DevExpress.Export.ExportType.WYSIWYG });
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }

        private void gcMember_Click(object sender, EventArgs e)
        {

        }
    }
}