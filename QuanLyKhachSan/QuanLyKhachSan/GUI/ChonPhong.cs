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
