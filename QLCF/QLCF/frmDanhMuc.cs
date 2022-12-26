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
using System.Data.Entity;
using DevExpress.XtraPrinting;
using System.Diagnostics;

namespace QLCF
{
    public partial class frmDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }
        QLCFEntities db = new QLCFEntities();
        int _ID;
        int _IDFood;
        CategoryFood newCategoryFood = new CategoryFood();
        Food newFood = new Food();
        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            load();
            LoadCategoryFood();
            loadFood();
            loadUnit();
            txtID.Enabled = false;
            txtIDFood.Enabled = false;
        }
        public void load()
        {
            gcDanhSach.DataSource = db.CategoryFoods.ToList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        public void loadFood()
        {
            gcMonAn.DataSource = db.Foods.ToList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _ID = Int32.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                txtID.Text = gvDanhSach.GetFocusedRowCellValue("ID").ToString();
                txtName.Text = gvDanhSach.GetFocusedRowCellValue("Name").ToString();
            } 
        }
        public void loadUnit()
        {
            CboUnit.DataSource = Unit.getList();
            CboUnit.DisplayMember = "_display";
            CboUnit.ValueMember = "_display";
        }
        public void LoadCategoryFood()
        {
            cboCategoryFood.DataSource = db.CategoryFoods.ToList();
            cboCategoryFood.DisplayMember = "Name";
            cboCategoryFood.ValueMember = "Name";
        }
        public void reset()
        {
            txtID.Clear();
            txtName.Clear();
        }
        public bool checkname(string name)
        {
            if(name.Length < 3 && name.Length > 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checknamefood(string name)
        {
            if (name.Length < 4 && name.Length > 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục");
            }
            else if (checkname(txtName.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Tên có độ dài từ 3 - 50 kí tự", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                newCategoryFood.Name = txtName.Text;
                db.CategoryFoods.Add(newCategoryFood);
                db.SaveChanges();
                reset();
                load();
            }
        }
        public void update(CategoryFood xx)
        {
            CategoryFood _xx = db.CategoryFoods.FirstOrDefault(x => x.ID == xx.ID);
            _xx.Name = xx.Name;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);
            }
        }
        public void update(Food xx)
        {
            Food _xx = db.Foods.FirstOrDefault(x => x.ID == xx.ID);
            _xx.Name = xx.Name;
            _xx.Path = xx.Path;
            _xx.Price = xx.Price;
            _xx.Unit = xx.Unit;
            _xx.CategoryName = xx.CategoryName;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục");
            }
            else if (checkname(txtName.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Tên có độ dài từ 3 - 50 kí tự", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CategoryFood xx = db.CategoryFoods.FirstOrDefault(x => x.ID == _ID);
                xx.Name = txtName.Text;
                update(xx);
                //db.SaveChanges();
                load();
            }
        
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("bạn có chắc muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CategoryFood xx = db.CategoryFoods.FirstOrDefault(x => x.ID == _ID);
                db.CategoryFoods.Remove(xx);
                db.SaveChanges();
                load();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (txtNameFood.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên Món");
            }
            else if (checknamefood(txtNameFood.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Tên có độ dài từ  4 - 50 kí tự", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                newFood.Name = txtNameFood.Text;
                newFood.Path = txtPath.Text;
                newFood.Price = double.Parse(spGia.Text);
                newFood.Unit = CboUnit.SelectedValue.ToString();
                newFood.CategoryName = cboCategoryFood.SelectedValue.ToString();
                db.Foods.Add(newFood);
                db.SaveChanges();
                loadFood();
                reset();
            }
        }

        private void gvMonan_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _IDFood = Int32.Parse(gvMonan.GetFocusedRowCellValue("ID").ToString());
                txtIDFood.Text = gvMonan.GetFocusedRowCellValue("ID").ToString();
                txtNameFood.Text = gvMonan.GetFocusedRowCellValue("Name").ToString();
                txtPath.Text = gvMonan.GetFocusedRowCellValue("Path").ToString();
                CboUnit.Text = gvMonan.GetFocusedRowCellValue("Unit").ToString();
                spGia.Text = gvMonan.GetFocusedRowCellValue("Price").ToString();
                cboCategoryFood.Text = gvMonan.GetFocusedRowCellValue("CategoryName").ToString();
            }
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            if (txtNameFood.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên Món");
            }
            else if (checknamefood(txtNameFood.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Tên có độ dài từ  4 - 50 kí tự", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Food xx = db.Foods.FirstOrDefault(x => x.ID == _IDFood);
                xx.Name = txtNameFood.Text;
                xx.Path = txtPath.Text;
                xx.Price = double.Parse(spGia.Text);
                xx.Unit = CboUnit.SelectedValue.ToString();
                xx.CategoryName = cboCategoryFood.SelectedValue.ToString();
                update(xx);
                //db.SaveChanges();
                load();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string path = "output.xlsx";
            gvMonan.ExportToXlsx(path, new XlsxExportOptionsEx { ExportType = DevExpress.Export.ExportType.WYSIWYG });
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmFoodsell frm = new frmFoodsell();
            frm.ShowDialog();
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (txtIDFood.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("bạn có chắc muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Food xx = db.Foods.FirstOrDefault(x => x.ID == _IDFood);
                db.Foods.Remove(xx);
                db.SaveChanges();
                load();
            }
        }
    }  
}