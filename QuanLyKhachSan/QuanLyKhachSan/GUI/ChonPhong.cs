using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan.GUI
{
    public partial class ChonPhong : Form
    {

        private int maKhachHang;

        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }

        public ChonPhong()
        {
            InitializeComponent();
            
        }

        
        public ChonPhong(int maKH)
        {
            this.maKhachHang = maKH;

        }

        private void ChonPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNN_QLKSDataSet1.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.tNN_QLKSDataSet1.Phong);
            //phongDataGrid.DataSource = xemPhong();
            //phongDataGrid.Refresh();

            //phongDataGrid.Columns["MaP"].Visible = false;

            //phongDataGrid.Columns["MaP"].ReadOnly = true;
            //phongDataGrid.Columns["GiaPhongNgay"].ReadOnly = true;
            //phongDataGrid.Columns["GiaPhongGio"].ReadOnly = true;
            //phongDataGrid.Columns["Tang"].ReadOnly = true;
            //phongDataGrid.Columns["Trong"].ReadOnly = true;
            //phongDataGrid.Columns["checkPhong"].ReadOnly = false;

            //phongDataGrid.Columns["GiaPhongNgay"].HeaderText = "Giá theo ngày";
            //phongDataGrid.Columns["GiaPhongGio"].HeaderText = "Giá theo giờ";
            //phongDataGrid.Columns["Tang"].HeaderText = "Tầng";
            //phongDataGrid.Columns["Trong"].HeaderText = "Trống";
        }

        private void HuyBt_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void XacNhanBt_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in phongDataGrid.Rows)
            //{
            //    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
            //    if (chk.Value != chk.FalseValue)
            //    {
            //        //MessageBox.Show(row.Cells[0].Value.ToString());
            //        //MessageBox.Show(row.Cells[2].Value.ToString());
            //        //MessageBox.Show(row.Cells[3].Value.ToString());
            //        //MessageBox.Show(row.Cells[4].Value.ToString());
            //        //MessageBox.Show(row.Cells[5].Value.ToString());
            //        maPhong.Add(new phong(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString()));
            //    }
            //}
            //this.Close();
        }

        private void huyBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += MainForm_FormClosed;
            mainForm.Show();
        }

        

        private void xacNhanBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataGridViewRow currentRow = phongDataGrid.CurrentRow;


            if (bool.Parse(currentRow.Cells[4].Value.ToString()) == false)
            {
                MessageBox.Show("phong da co nguoi");
                MainForm mainForm = new MainForm();
                mainForm.FormClosed += MainForm_FormClosed;
                mainForm.Show();
            }
            else
            {
                if (maKhachHang != 0)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.MaPhong = Convert.ToInt32(currentRow.Cells[0].Value);
                    mainForm.MaKhach = MaKhachHang;
                    MainForm m = new MainForm(mainForm.MaKhach, mainForm.MaPhong);

                    mainForm.FormClosed += MainForm_FormClosed;
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Chua chon khach hang de nhan phong");
                }
                
            }

        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }

}
