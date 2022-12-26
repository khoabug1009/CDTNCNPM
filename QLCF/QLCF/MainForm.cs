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
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        User user;
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        QLCFEntities db = new QLCFEntities();
        int id = 0;
        double TongTien = 0;
        double TongChiet = 0;
        double vat = 0;
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmMember frm = new frmMember();
            frm.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmDanhMuc frm = new frmDanhMuc();
            frm.ShowDialog();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //this.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadFood();
            loadcboFood();
            loadCategoryFood();
            loadUser();
            loadCusstomer();
            cboKhachhang.SelectedValue = "";
            cboDanhMuc.SelectedIndexChanged += CboDanhMuc_SelectedIndexChanged;
            cboKhachhang.SelectedIndexChanged += CboKhachhang_SelectedIndexChanged;
            showselectedbill(false);
            if(!user.Role.Equals("Quản lí"))
            {
                toolStripButton6.Enabled = false;
            }
        }
        public void showselectedbill(bool t)
        {
            cboDanhMuc.Enabled = t;
            cboKhachhang.Enabled = t;
            cboMonAn.Enabled = t;
            cboThuNgan.Enabled = t;
            btnThemMon.Enabled = t;
            spsoluong.Enabled = t;
        }

        private void CboKhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFoodByCategoryFood();
        }
        public void loadCusstomer()
        {
            cboKhachhang.DataSource = db.Customers.ToList();
            cboKhachhang.DisplayMember = "Fullname";
            cboKhachhang.ValueMember = "Fullname";
        }
        public void loadUser()
        {
            cboThuNgan.DataSource = db.Users.Where(x => x.Role == "Thu Ngân").ToList();
            cboThuNgan.DisplayMember = "Fullname";
            cboThuNgan.ValueMember = "ID";
        }
        public void loadcboFood()
        {
            cboMonAn.DataSource = db.Foods.ToList();
            cboMonAn.DisplayMember = "Name";
            cboMonAn.ValueMember = "ID";

        }
        public void loadFood()
        {
            gcDisplayFood.DataSource = db.Foods.ToList();
        }
        public void loadCategoryFood()
        {
            cboDanhMuc.DataSource = db.CategoryFoods.ToList();
            cboDanhMuc.DisplayMember = "Name";
            cboDanhMuc.ValueMember = "Name";
        }
        public void loadFoodByCategoryFood()
        {
            cboMonAn.DataSource = db.Foods.Where(x => x.CategoryName == cboDanhMuc.SelectedValue.ToString()).ToList();
            cboMonAn.DisplayMember = "Name";
            cboMonAn.ValueMember = "ID";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();



            frm.ShowDialog();
        }

       
       
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // tạo bill 
            if(txtSothe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
                showselectedbill(true);
                db.InsertBill(DateTime.Now, int.Parse(txtSothe.Text));
            }
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        { 
            int foodID =int.Parse(cboMonAn.SelectedValue.ToString());
            int count = int.Parse(spsoluong.Value.ToString());

            TongTien = 0;
             
            // lấy ra max ID đề chèn vào billInfo
            var maxID = db.Bills.Where(x => x.ID > 0).Max(x => x.ID);
            id = maxID;
            db.InsertBillInFo(id, foodID, count);
            // gán ds các món vào gridview
            gcBill.DataSource = db.getfoodbyID(id).ToList();

            for (int i = 0; i < gvBill.RowCount; i++)
            {
                TongTien += double.Parse(gvBill.GetRowCellValue(i, gvBill.Columns["totalPrice"]).ToString());
            }
            txbTotalPrice.Text = TongTien.ToString();
            TongChiet = (TongTien * double.Parse(txtchietkhau.Text.ToString()))/100;
            vat = (TongTien * 8) / 100;
            txbTotalVAT.Text = (TongTien - TongChiet + vat).ToString();

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            gcBill.DataSource = null;
            txbTotalPrice.Clear();
            txbTotalVAT.Text = "8";
            showselectedbill(false);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.ShowDialog();
        }
    }
}