using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using formDangNhapDangKy;

namespace Quản_lý_bán_hàng
{
    public partial class frmNhaCC : Form
    {
        public frmNhaCC()
        {
            InitializeComponent();
        }
        cla_crud connect = new cla_crud();// khai báo đối tượng class
        private void btnNhap_Click(object sender, EventArgs e) //chức năng nút Nhập
        {
            string ten = txtten.Text;

            if ( txtma.Text.Length !=0 && txtten.Text.Length!=0 && txtdth.Text.Length !=0 && txtdc.Text.Length!=0 && connect.exedata("INSERT INTO NhaCC (MaNhaCC) VALUES (N'" + txtma.Text + "')"))
            {
                
                MessageBox.Show("Đã thêm dữ liệu");
            }
            else
            {
                MessageBox.Show("Không thể thêm dữ liệu hoặc dữ liệu đã tồn tại");
            }

            
        }

        private void txtma_TextChanged(object sender, EventArgs e)
        {
            if(txtma.Text.Length > 0)
            {
                btnNhap.Enabled = true;
            }
            else 
            { 
                btnNhap.Enabled = false; 
            }

        }

        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            btnNhap.Enabled = false;
            loaddata();

            
        }



        private void txtdth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtten_KeyPress(object sender, KeyPressEventArgs e)
        {
             if(char.IsSymbol(e.KeyChar)||char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtten_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtten.Text))
            {
               
                txtten.Focus();
                errorProvider1.SetError(txtten, "Vui lòng nhập tên");

            }
            else
            {
               
                errorProvider1.SetError(txtten, null);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
            this.Close();
        }










        private void loaddata()
        {
           
            
            DataTable dt = connect.readdata("SELECT * FROM NhaCC");
            if (dt != null)
            {
                grvdata.DataSource = dt;
                grvdata.Show();
            }
        }

    }
    }

