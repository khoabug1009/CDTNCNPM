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
    public partial class frmDiscount : DevExpress.XtraEditors.XtraForm
    {
        public frmDiscount()
        {
            InitializeComponent();
        }
        QLCFEntities db = new QLCFEntities();

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            string path = "output.xlsx";
            gcDiscount.ExportToXlsx(path, new XlsxExportOptionsEx { ExportType = DevExpress.Export.ExportType.WYSIWYG });
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }
        public void loadData()
        {
            gcDiscount.DataSource = db.Discounts.ToList();
            gvDiscount.OptionsBehavior.Editable = false;
        }
        public void loadStatus()
        {
            cboStatus.DataSource = trangthai.getList();
            cboStatus.DisplayMember = "_display";
            cboStatus.ValueMember = "_value";
        }
        
        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            loadData();
            loadStatus();
        }

        private void gcDiscount_Click(object sender, EventArgs e)
        {

        }
    }
}