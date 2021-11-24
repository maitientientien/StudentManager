
namespace QLSinhVien
{
    partial class SVtheoLop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SVtheoLop));
            this.danhsachsinhvientheolopDataGridView = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãSinhViênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênSinhViênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.địaChỉDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lớpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dssinhvientheolopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlsvDataSet_SVtheoLop = new QLSinhVien.QLSVDataSet_SVtheoLop();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dssinhvientheolopTableAdapter = new QLSinhVien.QLSVDataSet_SVtheoLopTableAdapters.dssinhvientheolopTableAdapter();
            this.tableAdapterManager = new QLSinhVien.QLSVDataSet_SVtheoLopTableAdapters.TableAdapterManager();
            this.qLSVDataSetSVtheoLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnXuatRaExcel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientheolopDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvientheolopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet_SVtheoLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetSVtheoLopBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // danhsachsinhvientheolopDataGridView
            // 
            this.danhsachsinhvientheolopDataGridView.AutoGenerateColumns = false;
            this.danhsachsinhvientheolopDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhsachsinhvientheolopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachsinhvientheolopDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mãSinhViênDataGridViewTextBoxColumn,
            this.tênSinhViênDataGridViewTextBoxColumn,
            this.địaChỉDataGridViewTextBoxColumn,
            this.lớpDataGridViewTextBoxColumn,
            this.khoaDataGridViewTextBoxColumn});
            this.danhsachsinhvientheolopDataGridView.DataSource = this.dssinhvientheolopBindingSource;
            this.danhsachsinhvientheolopDataGridView.Location = new System.Drawing.Point(19, 189);
            this.danhsachsinhvientheolopDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.danhsachsinhvientheolopDataGridView.Name = "danhsachsinhvientheolopDataGridView";
            this.danhsachsinhvientheolopDataGridView.RowHeadersWidth = 51;
            this.danhsachsinhvientheolopDataGridView.Size = new System.Drawing.Size(899, 272);
            this.danhsachsinhvientheolopDataGridView.TabIndex = 78;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mãSinhViênDataGridViewTextBoxColumn
            // 
            this.mãSinhViênDataGridViewTextBoxColumn.DataPropertyName = "Mã Sinh Viên";
            this.mãSinhViênDataGridViewTextBoxColumn.HeaderText = "Mã Sinh Viên";
            this.mãSinhViênDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mãSinhViênDataGridViewTextBoxColumn.Name = "mãSinhViênDataGridViewTextBoxColumn";
            // 
            // tênSinhViênDataGridViewTextBoxColumn
            // 
            this.tênSinhViênDataGridViewTextBoxColumn.DataPropertyName = "Tên sinh viên";
            this.tênSinhViênDataGridViewTextBoxColumn.HeaderText = "Tên sinh viên";
            this.tênSinhViênDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tênSinhViênDataGridViewTextBoxColumn.Name = "tênSinhViênDataGridViewTextBoxColumn";
            // 
            // địaChỉDataGridViewTextBoxColumn
            // 
            this.địaChỉDataGridViewTextBoxColumn.DataPropertyName = "Địa Chỉ";
            this.địaChỉDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.địaChỉDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.địaChỉDataGridViewTextBoxColumn.Name = "địaChỉDataGridViewTextBoxColumn";
            // 
            // lớpDataGridViewTextBoxColumn
            // 
            this.lớpDataGridViewTextBoxColumn.DataPropertyName = "lớp";
            this.lớpDataGridViewTextBoxColumn.HeaderText = "Lớp";
            this.lớpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lớpDataGridViewTextBoxColumn.Name = "lớpDataGridViewTextBoxColumn";
            // 
            // khoaDataGridViewTextBoxColumn
            // 
            this.khoaDataGridViewTextBoxColumn.DataPropertyName = "khoa";
            this.khoaDataGridViewTextBoxColumn.HeaderText = "Khoa";
            this.khoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.khoaDataGridViewTextBoxColumn.Name = "khoaDataGridViewTextBoxColumn";
            // 
            // dssinhvientheolopBindingSource
            // 
            this.dssinhvientheolopBindingSource.DataMember = "dssinhvientheolop";
            this.dssinhvientheolopBindingSource.DataSource = this.qlsvDataSet_SVtheoLop;
            // 
            // qlsvDataSet_SVtheoLop
            // 
            this.qlsvDataSet_SVtheoLop.DataSetName = "QLSVDataSet_SVtheoLop";
            this.qlsvDataSet_SVtheoLop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(99, 44);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(236, 22);
            this.txtMaLop.TabIndex = 77;
            this.txtMaLop.TextChanged += new System.EventHandler(this.txtMaLop_TextChanged);
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(36, 44);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(55, 17);
            this.lblMaLop.TabIndex = 76;
            this.lblMaLop.Text = "Mã Lớp";
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(822, 482);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 37);
            this.btnThoat.TabIndex = 79;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dssinhvientheolopTableAdapter
            // 
            this.dssinhvientheolopTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLSinhVien.QLSVDataSet_SVtheoLopTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qLSVDataSetSVtheoLopBindingSource
            // 
            this.qLSVDataSetSVtheoLopBindingSource.DataSource = this.qlsvDataSet_SVtheoLop;
            this.qLSVDataSetSVtheoLopBindingSource.Position = 0;
            // 
            // btnXuatRaExcel
            // 
            this.btnXuatRaExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatRaExcel.BackgroundImage")));
            this.btnXuatRaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXuatRaExcel.Location = new System.Drawing.Point(19, 482);
            this.btnXuatRaExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(96, 37);
            this.btnXuatRaExcel.TabIndex = 81;
            this.btnXuatRaExcel.Text = "       In File";
            this.btnXuatRaExcel.UseVisualStyleBackColor = true;
            this.btnXuatRaExcel.Click += new System.EventHandler(this.btnXuatRaExcel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaLop);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Location = new System.Drawing.Point(128, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 100);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Theo Lớp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSinhVien.Properties.Resources._860620;
            this.pictureBox1.Location = new System.Drawing.Point(583, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // SVtheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXuatRaExcel);
            this.Controls.Add(this.danhsachsinhvientheolopDataGridView);
            this.Controls.Add(this.btnThoat);
            this.Name = "SVtheoLop";
            this.Text = "Danh Sách Sinh Viên Theo Lớp";
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientheolopDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvientheolopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet_SVtheoLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetSVtheoLopBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView danhsachsinhvientheolopDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãSinhViênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênSinhViênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn địaChỉDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lớpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dssinhvientheolopBindingSource;
        private QLSVDataSet_SVtheoLop qlsvDataSet_SVtheoLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Button btnThoat;
        private QLSVDataSet_SVtheoLopTableAdapters.dssinhvientheolopTableAdapter dssinhvientheolopTableAdapter;
        private QLSVDataSet_SVtheoLopTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource qLSVDataSetSVtheoLopBindingSource;
        private System.Windows.Forms.Button btnXuatRaExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}