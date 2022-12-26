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
using DevExpress.XtraPrinting;
using System.Diagnostics;

namespace QLCF
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        Customer customer = new Customer();
        QLCFEntities db = new QLCFEntities();
        int _ID;
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            loadCustomer();
            txtID.Enabled = false;
        }
        public void loadCustomer()
        {
            gcCustomer.DataSource = db.Customers.ToList();
            gvCustomer.OptionsBehavior.Editable = false;
        }

        private void gvCustomer_Click(object sender, EventArgs e)
        {
            if (gvCustomer.RowCount > 0)
            {
                _ID = Int32.Parse(gvCustomer.GetFocusedRowCellValue("ID").ToString());
                txtID.Text = gvCustomer.GetFocusedRowCellValue("ID").ToString();
                txtFullname.Text = gvCustomer.GetFocusedRowCellValue("Fullname").ToString();
                txtPhoneNumber.Text = gvCustomer.GetFocusedRowCellValue("PhoneNumber").ToString();
                txtInvoiceNumber.Text = gvCustomer.GetFocusedRowCellValue("InvoiceNumber").ToString();
                txtAddress.Text = gvCustomer.GetFocusedRowCellValue("Address").ToString();
                txtNote.Text = gvCustomer.GetFocusedRowCellValue("Note").ToString();
                txtPoint.Text = gvCustomer.GetFocusedRowCellValue("Point").ToString();

            }
        }
        public void reset()
        {
            txtFullname.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtNote.Clear();
            txtPoint.Clear();
            txtInvoiceNumber.Clear();
            txtID.Clear();
        }
        public bool checkghichu(string user)
        {
            if (user.Length > 300)
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtFullname.Text == "" || txtPhoneNumber.Text == "")
            {
                 MessageBox.Show("Vui Lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(checkghichu(txtNote.Text) == false){
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Mô Tả có độ dài không quá 300 kí tự", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (checkAddress(txtAddress.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Địa chi có độ dài từ 5- 255 kí tự", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                customer.Fullname = txtFullname.Text;
                customer.Address = txtFullname.Text;
                customer.PhoneNumber = txtPhoneNumber.Text;
                customer.Note = txtNote.Text;
                customer.Point = 0;
                customer.Address = txtAddress.Text;
                customer.InvoiceNumber = 0;

                db.Customers.Add(customer);
                db.SaveChanges();
                reset();
                loadCustomer();
            }
        }
        public void update(Customer xx)
        {

            Customer _xx = db.Customers.FirstOrDefault(x => x.ID == xx.ID);
            _xx.Fullname = xx.Fullname;
            _xx.PhoneNumber = xx.PhoneNumber;
            _xx.Note = xx.Note;
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Vui Lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkghichu(txtNote.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Mô Tả có độ dài không quá 300 kí tự", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkAddress(txtAddress.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Địa chi có độ dài từ 5- 255 kí tự", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Customer xx = db.Customers.FirstOrDefault(x => x.ID == _ID);
                xx.Fullname = txtFullname.Text;
                xx.PhoneNumber = txtPhoneNumber.Text;
                xx.Note = txtNote.Text;
                xx.Address = txtAddress.Text;
                //xx.Password = txtPass.Text;
                update(xx);
                //db.SaveChanges();
                loadCustomer();
                reset();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("bạn có chắc muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Customer xx = db.Customers.FirstOrDefault(x => x.ID == _ID);
                db.Customers.Remove(xx);
                db.SaveChanges();
                loadCustomer();
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            loadCustomer();
            reset();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string path = "output.xlsx";
            gcCustomer.ExportToXlsx(path, new XlsxExportOptionsEx { ExportType = DevExpress.Export.ExportType.WYSIWYG });
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }
    }
}