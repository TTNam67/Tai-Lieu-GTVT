using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra_19_9
{
    public partial class Form1 : Form
    {
        List<CanHo> _listCanHo = new List<CanHo>();
        List<CanHo> _listTimKiemCanHo = new List<CanHo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBxDsCanHo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBxDsCanHo.SelectedIndex;

            if (selectedIndex != -1)
            {
                listBxDsCanHo.Items.RemoveAt(selectedIndex);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Validate() == true)
            {
                string diaChi;
                int soPhongNgu, soNhaVeSinh;
                string huongBanCong;
                float giaTien;
                TinhTrang tinhTrang;

                diaChi = txtDiaChi.Text;
                soPhongNgu = int.Parse(txtSoPhongNgu.Text);
                soNhaVeSinh = int.Parse(txtSoNhaVeSinh.Text);
                huongBanCong = cmbHuongBanCong.SelectedItem.ToString();
                giaTien = float.Parse(txtGiaTien.Text);
                if (rdbDaDatCoc.Checked == true)
                {
                    tinhTrang = TinhTrang.DaDatCoc;
                }
                else if (rdbDaBan.Checked == true)
                {
                    tinhTrang = TinhTrang.DaBan;
                }
                else 
                {
                    tinhTrang = TinhTrang.ConTrong;
                }

                CanHo canHoMoi = new CanHo(diaChi, soPhongNgu, soNhaVeSinh, giaTien, huongBanCong, tinhTrang);
                _listCanHo.Add(canHoMoi);
                listBxDsCanHo.Items.Add(canHoMoi.ToString());
            }
            
        }

        private bool Validate()
        {

            if (txtDiaChi.Text.Trim() == "" ||
                txtSoPhongNgu.Text.Trim() == "" ||
                txtSoNhaVeSinh.Text.Trim() == "" ||
                txtGiaTien.Text.Trim().Length == 0 ||
                (rdbDaDatCoc.Checked == false && rbdConTrong.Checked == false && rdbDaBan.Checked == false) ||
                cmbHuongBanCong.Text == "")
            {
                MessageBox.Show("Nhap du lieu lai di cai thang ngu");
                return false;
            }
            //else if (txtMaKH.Text.Length != 6)
            //{
            //    MessageBox.Show("Mã khách hàng là 1 số có 6 chữ số");re
            //    return false;
            //}
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdbDaDatCoc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoPhongNgu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoNhaVeSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Show a message box asking the user to confirm if they want to exit.
            DialogResult result = MessageBox.Show("Có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Close the form.
                this.Close();
            }
        }

      
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBxDsCanHo.Items.Count; i++)
            {
                listBxDsCanHo.Items.RemoveAt(i);
            }
                
            for (int i  = 0; i < _listCanHo.Count; i++)
            {
                if (txtTimGiaTien.Text.Trim().Length != 0)
                {
                    if (_listCanHo[i].GiaTien < int.Parse(txtTimGiaTien.Text))
                    {
                        _listTimKiemCanHo.Add(_listCanHo[i]);
                        listBxDsCanHo.Items.Add(_listCanHo[i].ToString());
                    }
                }
                else if (cmbTimHuongBanCong.Text != "")
                {
                    if (_listCanHo[i].HuongBanCong == cmbTimHuongBanCong.Text)
                    {
                        _listTimKiemCanHo.Add(_listCanHo[i]);
                        listBxDsCanHo.Items.Add(_listCanHo[i].ToString());
                    }
                }
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //int selectedIndex = listBxDsCanHo.SelectedIndex;

            //if (selectedIndex != -1)
            //{
            //    // Get the text to edit
            //    string textToEdit = listBxDsCanHo.Items[selectedIndex].ToString();

            //    // Instantiate the EditForm
            //    using (Form editForm = new Form())
            //    {
            //        // Set the text to edit in the EditForm
            //        editForm.EditedText = textToEdit;

            //        // Show the EditForm as a dialog
            //        if (editForm.ShowDialog() == DialogResult.OK)
            //        {
            //            // Update the ListBox item with the edited text
            //            listBxDsCanHo.Items[selectedIndex] = editForm.EditedText;
            //        }
            //    }
            //}
        }

        private void btnHienDanhSach_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _listCanHo.Count; i++)
            {
                listBxDsCanHo.Items.Add(_listCanHo[i]);
            }
        }

        private void labDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
