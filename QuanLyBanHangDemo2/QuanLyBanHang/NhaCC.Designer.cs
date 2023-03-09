namespace Quản_lý_bán_hàng
{
    partial class frmNhaCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtdth = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grvdata = new System.Windows.Forms.DataGridView();
            this.MaNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanLyBanHangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quan_Ly_Ban_HangDataSet = new formDangNhapDangKy.Quan_Ly_Ban_HangDataSet();
            this.quanLyBanHangDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(222, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(84, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhà cung cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(84, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nhà cung cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(84, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(84, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điện thoại:";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(288, 113);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(113, 22);
            this.txtma.TabIndex = 0;
            this.txtma.TextChanged += new System.EventHandler(this.txtma_TextChanged);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(288, 172);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(208, 22);
            this.txtten.TabIndex = 1;
            this.txtten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtten_KeyPress);
            this.txtten.Validating += new System.ComponentModel.CancelEventHandler(this.txtten_Validating);
            // 
            // txtdc
            // 
            this.txtdc.ForeColor = System.Drawing.Color.Black;
            this.txtdc.Location = new System.Drawing.Point(288, 285);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(268, 22);
            this.txtdc.TabIndex = 3;
            // 
            // txtdth
            // 
            this.txtdth.Location = new System.Drawing.Point(288, 229);
            this.txtdth.Name = "txtdth";
            this.txtdth.Size = new System.Drawing.Size(186, 22);
            this.txtdth.TabIndex = 2;
            this.txtdth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdth_KeyPress);
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.Color.Black;
            this.btnNhap.Location = new System.Drawing.Point(113, 362);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(93, 33);
            this.btnNhap.TabIndex = 4;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Black;
            this.btnback.Location = new System.Drawing.Point(379, 362);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(95, 33);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Quay lại";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grvdata
            // 
            this.grvdata.AutoGenerateColumns = false;
            this.grvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhaCC,
            this.TenNhaCC,
            this.DiaChi,
            this.DienThoai});
            this.grvdata.DataSource = this.quanLyBanHangDataSetBindingSource;
            this.grvdata.Location = new System.Drawing.Point(595, 91);
            this.grvdata.Name = "grvdata";
            this.grvdata.RowHeadersWidth = 51;
            this.grvdata.RowTemplate.Height = 24;
            this.grvdata.Size = new System.Drawing.Size(472, 304);
            this.grvdata.TabIndex = 6;
            // 
            // MaNhaCC
            // 
            this.MaNhaCC.HeaderText = "mã";
            this.MaNhaCC.MinimumWidth = 6;
            this.MaNhaCC.Name = "MaNhaCC";
            this.MaNhaCC.Width = 125;
            // 
            // TenNhaCC
            // 
            this.TenNhaCC.HeaderText = "Tên";
            this.TenNhaCC.MinimumWidth = 6;
            this.TenNhaCC.Name = "TenNhaCC";
            this.TenNhaCC.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // DienThoai
            // 
            this.DienThoai.HeaderText = "Tel";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Width = 125;
            // 
            // quanLyBanHangDataSetBindingSource
            // 
            this.quanLyBanHangDataSetBindingSource.DataSource = this.quan_Ly_Ban_HangDataSet;
            this.quanLyBanHangDataSetBindingSource.Position = 0;
            // 
            // quan_Ly_Ban_HangDataSet
            // 
            this.quan_Ly_Ban_HangDataSet.DataSetName = "Quan_Ly_Ban_HangDataSet";
            this.quan_Ly_Ban_HangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyBanHangDataSetBindingSource1
            // 
            this.quanLyBanHangDataSetBindingSource1.DataSource = this.quan_Ly_Ban_HangDataSet;
            this.quanLyBanHangDataSetBindingSource1.Position = 0;
            // 
            // frmNhaCC
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1079, 427);
            this.Controls.Add(this.grvdata);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtdth);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhaCC";
            this.Text = "Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.frmNhaCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtdth;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView grvdata;
        private System.Windows.Forms.BindingSource quanLyBanHangDataSetBindingSource;
        private formDangNhapDangKy.Quan_Ly_Ban_HangDataSet quan_Ly_Ban_HangDataSet;
        private System.Windows.Forms.BindingSource quanLyBanHangDataSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
    }
}

