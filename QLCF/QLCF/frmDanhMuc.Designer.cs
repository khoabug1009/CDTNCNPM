namespace QLCF
{
    partial class frmDanhMuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMuc));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaMon = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaMon = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMon = new DevExpress.XtraEditors.SimpleButton();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.spGia = new DevExpress.XtraEditors.SpinEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCategoryFood = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CboUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameFood = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDFood = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gcMonAn = new DevExpress.XtraGrid.GridControl();
            this.gvMonan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Path = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-8, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1263, 673);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnxoa);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.gcDanhSach);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1255, 644);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh Mục";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(1048, 267);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(94, 29);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(914, 267);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(767, 267);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(914, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(914, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(181, 23);
            this.txtID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(787, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Danh Mục:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Location = new System.Drawing.Point(3, 3);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(740, 550);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Name});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // ID
            // 
            this.ID.Caption = "Mã";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // Name
            // 
            this.Name.Caption = "Tên Danh Mục";
            this.Name.FieldName = "Name";
            this.Name.Name = "Name";
            this.Name.Visible = true;
            this.Name.VisibleIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.simpleButton2);
            this.tabPage2.Controls.Add(this.simpleButton1);
            this.tabPage2.Controls.Add(this.btnXoaMon);
            this.tabPage2.Controls.Add(this.btnSuaMon);
            this.tabPage2.Controls.Add(this.btnThemMon);
            this.tabPage2.Controls.Add(this.txtPath);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.spGia);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cboCategoryFood);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.CboUnit);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtNameFood);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtIDFood);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.gcMonAn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1255, 644);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Món ăn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(877, 597);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(289, 29);
            this.simpleButton2.TabIndex = 18;
            this.simpleButton2.Text = "Xem các món bán chạy ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(877, 522);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 55);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Xuất Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaMon.ImageOptions.Image")));
            this.btnXoaMon.Location = new System.Drawing.Point(1072, 522);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(94, 55);
            this.btnXoaMon.TabIndex = 16;
            this.btnXoaMon.Text = "Xóa";
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaMon.ImageOptions.Image")));
            this.btnSuaMon.Location = new System.Drawing.Point(1072, 416);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(94, 60);
            this.btnSuaMon.TabIndex = 15;
            this.btnSuaMon.Text = "Sửa";
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMon.ImageOptions.Image")));
            this.btnThemMon.Location = new System.Drawing.Point(877, 416);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(85, 60);
            this.btnThemMon.TabIndex = 14;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(975, 148);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(191, 23);
            this.txtPath.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(852, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Đường dẫn ảnh:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // spGia
            // 
            this.spGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spGia.Location = new System.Drawing.Point(1035, 198);
            this.spGia.Name = "spGia";
            this.spGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spGia.Size = new System.Drawing.Size(131, 22);
            this.spGia.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(852, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Thuộc Nhóm:";
            // 
            // cboCategoryFood
            // 
            this.cboCategoryFood.FormattingEnabled = true;
            this.cboCategoryFood.Location = new System.Drawing.Point(988, 311);
            this.cboCategoryFood.Name = "cboCategoryFood";
            this.cboCategoryFood.Size = new System.Drawing.Size(178, 24);
            this.cboCategoryFood.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(864, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 8;
            // 
            // CboUnit
            // 
            this.CboUnit.FormattingEnabled = true;
            this.CboUnit.Location = new System.Drawing.Point(988, 252);
            this.CboUnit.Name = "CboUnit";
            this.CboUnit.Size = new System.Drawing.Size(178, 24);
            this.CboUnit.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(852, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Đơn vị tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(852, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giá:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNameFood
            // 
            this.txtNameFood.Location = new System.Drawing.Point(944, 93);
            this.txtNameFood.Name = "txtNameFood";
            this.txtNameFood.Size = new System.Drawing.Size(222, 23);
            this.txtNameFood.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(852, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Món:";
            // 
            // txtIDFood
            // 
            this.txtIDFood.Location = new System.Drawing.Point(944, 37);
            this.txtIDFood.Name = "txtIDFood";
            this.txtIDFood.Size = new System.Drawing.Size(222, 23);
            this.txtIDFood.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(852, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID:";
            // 
            // gcMonAn
            // 
            this.gcMonAn.Location = new System.Drawing.Point(8, 6);
            this.gcMonAn.MainView = this.gvMonan;
            this.gcMonAn.Name = "gcMonAn";
            this.gcMonAn.Size = new System.Drawing.Size(819, 638);
            this.gcMonAn.TabIndex = 0;
            this.gcMonAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMonan});
            // 
            // gvMonan
            // 
            this.gvMonan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.Path,
            this.gridColumn5});
            this.gvMonan.GridControl = this.gcMonAn;
            this.gvMonan.Name = "gvMonan";
            this.gvMonan.OptionsBehavior.Editable = false;
            this.gvMonan.Click += new System.EventHandler(this.gvMonan_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Món";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giá";
            this.gridColumn3.FieldName = "Price";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đơn vị tính";
            this.gridColumn4.FieldName = "Unit";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // Path
            // 
            this.Path.Caption = "Đường dẫn ảnh";
            this.Path.FieldName = "Path";
            this.Path.Name = "Path";
            this.Path.Visible = true;
            this.Path.VisibleIndex = 4;
            this.Path.Width = 159;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Thuộc nhóm";
            this.gridColumn5.FieldName = "CategoryName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // frmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 676);
            this.Controls.Add(this.tabControl1);
            //this.Name = "frmDanhMuc";
            this.Text = "Mặt Hàng";
            this.Load += new System.EventHandler(this.frmDanhMuc_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Name;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcMonAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMonan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDFood;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn Path;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCategoryFood;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SpinEdit spGia;
        private DevExpress.XtraEditors.SimpleButton btnThemMon;
        private DevExpress.XtraEditors.SimpleButton btnXoaMon;
        private DevExpress.XtraEditors.SimpleButton btnSuaMon;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}