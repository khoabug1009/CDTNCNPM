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
    public partial class frmFoodsell : DevExpress.XtraEditors.XtraForm
    {
        public frmFoodsell()
        {
            InitializeComponent();
        }
        QLCFEntities db = new QLCFEntities();
        private void frmFoodsell_Load(object sender, EventArgs e)
        {
            gcReport.DataSource = db.USP_GetListfoodsell().ToList();
        }
    }
}