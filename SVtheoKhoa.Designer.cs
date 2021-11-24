
namespace QLSinhVien
{
    partial class SVtheoKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SVtheoKhoa));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatRaExcel = new System.Windows.Forms.Button();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.danhsachsinhvientheokhoaDataGridView = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãSinhViênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênSinhViênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngàySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãLớpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dssinhvientheokhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._QLSVDataset_TheoKhoa = new QLSinhVien._QLSVDataset_TheoKhoa();
            this.danhsachsinhvientheokhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dssinhvientheokhoaTableAdapter = new QLSinhVien._QLSVDataset_TheoKhoaTableAdapters.dssinhvientheokhoaTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientheokhoaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvientheokhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._QLSVDataset_TheoKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientheokhoaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(795, 444);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 37);
            this.btnThoat.TabIndex = 68;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXuatRaExcel
            // 
            this.btnXuatRaExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatRaExcel.BackgroundImage")));
            this.btnXuatRaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXuatRaExcel.Location = new System.Drawing.Point(13, 444);
            this.btnXuatRaExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(96, 37);
            this.btnXuatRaExcel.TabIndex = 67;
            this.btnXuatRaExcel.Text = "       In File";
            this.btnXuatRaExcel.UseVisualStyleBackColor = true;
            this.btnXuatRaExcel.Click += new System.EventHandler(this.btnXuatRaExcel_Click);
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(132, 42);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(160, 22);
            this.txtMaKhoa.TabIndex = 66;
            this.txtMaKhoa.TextChanged += new System.EventHandler(this.txtMaKhoa_TextChanged);
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(60, 45);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(64, 17);
            this.lblMaLop.TabIndex = 65;
            this.lblMaLop.Text = "Mã Khoa";
            // 
            // danhsachsinhvientheokhoaDataGridView
            // 
            this.danhsachsinhvientheokhoaDataGridView.AutoGenerateColumns = false;
            this.danhsachsinhvientheokhoaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhsachsinhvientheokhoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachsinhvientheokhoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mãSinhViênDataGridViewTextBoxColumn,
            this.tênSinhViênDataGridViewTextBoxColumn,
            this.ngàySinhDataGridViewTextBoxColumn,
            this.mãLớpDataGridViewTextBoxColumn,
            this.mãKhoaDataGridViewTextBoxColumn});
            this.danhsachsinhvientheokhoaDataGridView.DataSource = this.dssinhvientheokhoaBindingSource;
            this.danhsachsinhvientheokhoaDataGridView.Location = new System.Drawing.Point(13, 178);
            this.danhsachsinhvientheokhoaDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.danhsachsinhvientheokhoaDataGridView.Name = "danhsachsinhvientheokhoaDataGridView";
            this.danhsachsinhvientheokhoaDataGridView.RowHeadersWidth = 51;
            this.danhsachsinhvientheokhoaDataGridView.Size = new System.Drawing.Size(878, 246);
            this.danhsachsinhvientheokhoaDataGridView.TabIndex = 69;
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
            // ngàySinhDataGridViewTextBoxColumn
            // 
            this.ngàySinhDataGridViewTextBoxColumn.DataPropertyName = "Ngày sinh";
            this.ngàySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngàySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngàySinhDataGridViewTextBoxColumn.Name = "ngàySinhDataGridViewTextBoxColumn";
            // 
            // mãLớpDataGridViewTextBoxColumn
            // 
            this.mãLớpDataGridViewTextBoxColumn.DataPropertyName = "Mã lớp";
            this.mãLớpDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.mãLớpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mãLớpDataGridViewTextBoxColumn.Name = "mãLớpDataGridViewTextBoxColumn";
            // 
            // mãKhoaDataGridViewTextBoxColumn
            // 
            this.mãKhoaDataGridViewTextBoxColumn.DataPropertyName = "Mã khoa";
            this.mãKhoaDataGridViewTextBoxColumn.HeaderText = "Mã khoa";
            this.mãKhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mãKhoaDataGridViewTextBoxColumn.Name = "mãKhoaDataGridViewTextBoxColumn";
            // 
            // dssinhvientheokhoaBindingSource
            // 
            this.dssinhvientheokhoaBindingSource.DataMember = "dssinhvientheokhoa";
            this.dssinhvientheokhoaBindingSource.DataSource = this._QLSVDataset_TheoKhoa;
            // 
            // _QLSVDataset_TheoKhoa
            // 
            this._QLSVDataset_TheoKhoa.DataSetName = "QLSVDataset-TheoKhoa";
            this._QLSVDataset_TheoKhoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danhsachsinhvientheokhoaBindingSource
            // 
            this.danhsachsinhvientheokhoaBindingSource.DataSource = this._QLSVDataset_TheoKhoa;
            this.danhsachsinhvientheokhoaBindingSource.Position = 0;
            // 
            // dssinhvientheokhoaTableAdapter
            // 
            this.dssinhvientheokhoaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Controls.Add(this.lblMaLop);
            this.groupBox1.Location = new System.Drawing.Point(130, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 100);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Theo Khoa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSinhVien.Properties.Resources._2231649;
            this.pictureBox1.Location = new System.Drawing.Point(577, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // SVtheoKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.danhsachsinhvientheokhoaDataGridView);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatRaExcel);
            this.Name = "SVtheoKhoa";
            this.Text = "Danh Sách Sinh Viên Theo Khoa";
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientheokhoaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvientheokhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._QLSVDataset_TheoKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientheokhoaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuatRaExcel;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.DataGridView danhsachsinhvientheokhoaDataGridView;
        private System.Windows.Forms.BindingSource dssinhvientheokhoaBindingSource;
        private _QLSVDataset_TheoKhoa _QLSVDataset_TheoKhoa;
        private System.Windows.Forms.BindingSource danhsachsinhvientheokhoaBindingSource;
        private _QLSVDataset_TheoKhoaTableAdapters.dssinhvientheokhoaTableAdapter dssinhvientheokhoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãSinhViênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênSinhViênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãLớpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}