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
    public partial class frmReport : DevExpress.XtraEditors.XtraForm
    {
        public frmReport()
        {
            InitializeComponent();
        }
        QLCFEntities db = new QLCFEntities();
        private void gcReport_Click(object sender, EventArgs e)
        {

        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            gcReport.DataSource = db.USP_GetListBillByDate(dtpkFromDate.Value, dtpkToDate.Value).ToList();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            string path = "output.xlsx";
            gcReport.ExportToXlsx(path, new DevExpress.XtraPrinting.XlsxExportOptionsEx { ExportType = DevExpress.Export.ExportType.WYSIWYG });
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }
    }
}