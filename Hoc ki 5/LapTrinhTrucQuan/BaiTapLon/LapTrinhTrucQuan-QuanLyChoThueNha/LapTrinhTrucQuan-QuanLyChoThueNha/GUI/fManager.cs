using Bunifu.UI.WinForms;
using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI
{
    
    public partial class fManager : Form
    {
        ProcessDatabase pd = new ProcessDatabase();
        string _tblDanhMucNha = "DanhMucNha";
        string _tblKhachThue = "KhachThue";
        string _tblNhaTaiSan = "Nha_TaiSan";
        string _tblThueNha = "ThueNha";

        //private TaiKhoanDTO _taiKhoanLogin;

        private CoQuanBUS _coQuanBUS = new CoQuanBUS();
        private DanhMucNhaBUS _danhMucNhaBUS = new DanhMucNhaBUS();
        private DoiTuongSuDungBUS _doiTuongSuDungBUS = new DoiTuongSuDungBUS();
        private HinhThucThanhToanBUS _hinhThucThanhToanBUS = new HinhThucThanhToanBUS();
        private KhachThueBUS _khachThueBUS = new KhachThueBUS();
        private LoaiNhaBUS _loaiNhaBUS = new LoaiNhaBUS();
        private MucDichSuDungBUS _mucDichSuDungBUS = new MucDichSuDungBUS();
        private NgheNghiepBUS _ngheNghiepBUS = new NgheNghiepBUS();
        private Nha_TaiSanBUS _nha_TaiSanBUS = new Nha_TaiSanBUS();
        private TaiKhoanBUS _taiKhoanBUS = new TaiKhoanBUS();
        private TaiSanBUS _taiSanBUS = new TaiSanBUS();
        private ThueNhaBUS _thueNhaBUS = new ThueNhaBUS();
        private ThuTienNhaBUS _thuTienNhaBUS = new ThuTienNhaBUS();
        private TraNha_MatTaiSanBUS _traNha_MatTaiSanBUS = new TraNha_MatTaiSanBUS();
        private TraNhaBUS _traNhaBUS = new TraNhaBUS();

        BindingSource _listDanhMucNha = new BindingSource();
        BindingSource _listThueNha = new BindingSource();
        

        
        string tentk, mk, tenht;

        //string thueNhaAttributeList
        public fManager(TaiKhoanDTO taiKhoanDTO, string tentk, string tenht, string mk)
        {
            this.tentk = tentk;
            this.mk = mk;
            this.tenht = tenht;

            InitializeComponent();

            bunifuFormDock1.SubscribeControlToDragEvents(panel1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage3);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage4);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage5);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage6);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage7);

            this.WindowState = FormWindowState.Maximized;

            bunifuDGVDanhMucNha.DataSource = pd.DocBang($"select * from {_tblDanhMucNha}");
            
            
        }



        private bool isValidatedForm(List<BunifuTextBox> ltb)
        {
            foreach (BunifuTextBox item in ltb)
            {
                if (item.Text == "")
                {
                    MessageBox.Show("Không được phép để trống thông tin");
                    item.Focus();
                    return false;
                }
            }
            return true;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);

        }

        
        
       

        

        
        

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(5);

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(6);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Close the form.
                this.Close();
            }


        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        //Start Code for DanhMucNha
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            //DanhMucNha
            bunifuPages1.SetPage(1);
            //bunifuDGVDanhMucNha.DataSource = pd.DocBang($"select * from {_tblDanhMucNha}");
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuDGVDanhMucNha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DanhMucNha_ResetTextBoxValue();

            txtDanhMucNha_MaNha.Text = bunifuDGVDanhMucNha.SelectedRows[0].Cells["MaNha"].Value.ToString();
            txtDanhMucNha_TenChuNha.Text = bunifuDGVDanhMucNha.SelectedRows[0].Cells["TenChuNha"].Value.ToString();
            txtDanhMucNha_DienThoai.Text = bunifuDGVDanhMucNha.SelectedRows[0].Cells["DienThoai"].Value.ToString();
            txtDanhMucNha_MaLoai.Text = bunifuDGVDanhMucNha.SelectedRows[0].Cells["MaLoai"].Value.ToString();
            txtDanhMucNha_MaDTSD.Text = bunifuDGVDanhMucNha.SelectedRows[0].Cells["MaDTSD"].Value.ToString();
            txtDanhMucNha_DiaChi.Text = bunifuDGVDanhMucNha.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            txtDanhMucNha_DonGiaThue.Text = bunifuDGVDanhMucNha.SelectedRows[0].Cells["DonGiaThue"].Value.ToString();
            txtDanhMucNha_TinhTrang.Text = bunifuDGVDanhMucNha.SelectedRows[0].Cells["TinhTrang"].Value.ToString();

            if (bunifuDGVDanhMucNha.SelectedRows[0].Cells["DaThue"].Value != null)
            {
                int val = (int) bunifuDGVDanhMucNha.SelectedRows[0].Cells["DaThue"].Value;

                if (val == 1)
                {
                    rdbDanhMucNha_DaThue.Checked = true;
                }
                else
                {
                    rdbDanhMucNha_Trong.Checked = true;
                }
            }
            txtDanhMucNha_GhiChu.Text = bunifuDGVDanhMucNha.SelectedRows[0].Cells["GhiChu"].Value.ToString();

        }

        public void DanhMucNha_ResetTextBoxValue()
        {
            rdbDanhMucNha_DaThue.Checked = false;
            rdbDanhMucNha_Trong.Checked = false;
        }

        private void btnDanhMucNha_Them_Click(object sender, EventArgs e)
        {
            if (isValidatedForm_DanhMucNha() == false)
            {
                return;
            }

            int daThue = 0;
            if (rdbDanhMucNha_DaThue.Checked == true)
                daThue = 1;

            if (!_danhMucNhaBUS.InsertDanhMucNha(txtDanhMucNha_MaNha.Text, txtDanhMucNha_TenChuNha.Text, txtDanhMucNha_DienThoai.Text, txtDanhMucNha_MaLoai.Text, txtDanhMucNha_MaDTSD.Text, txtDanhMucNha_DiaChi.Text, decimal.Parse(txtDanhMucNha_DonGiaThue.Text), txtDanhMucNha_TinhTrang.Text, daThue, txtDanhMucNha_GhiChu.Text))
            {
                MessageBox.Show("Danh mục nhà này đã tồn tại trên hệ thống");
                return;
            }
        
            MessageBox.Show("Thêm mới thành công");
            bunifuDGVDanhMucNha.DataSource = _danhMucNhaBUS.GetListDanhMucNha();
        }

        private bool isValidatedForm_DanhMucNha()
        {
            List <BunifuTextBox> list = new List <BunifuTextBox>()
            {
                txtDanhMucNha_MaNha, txtDanhMucNha_TenChuNha,
                txtDanhMucNha_DienThoai, txtDanhMucNha_MaLoai,
                txtDanhMucNha_MaDTSD, txtDanhMucNha_DiaChi,
                txtDanhMucNha_DonGiaThue, txtDanhMucNha_TinhTrang,
                txtDanhMucNha_GhiChu
            };

            if (!isValidatedForm(list))
            {
                return false;
            }

            if (rdbDanhMucNha_DaThue.Checked == false 
                && rdbDanhMucNha_Trong.Checked == false)
            {  return false; }

            if (rdbDanhMucNha_DaThue.Checked == true
                && rdbDanhMucNha_Trong.Checked == true)
            { return false; }

            return true;
        }

        private void btnDanhMucNha_XemTatCa_Click(object sender, EventArgs e)
        {
            bunifuDGVDanhMucNha.DataSource = _danhMucNhaBUS.GetListDanhMucNha();
            txtDanhMucNha_TimTheoLoaiNha.Text = "";
            txtDanhMucNha_TimTheoLoaiDTSD.Text = "";
            txtDanhMucNha_TimTheoDiaChi.Text = "";
        }

        private void btnDanhMucNha_TimKiem_Click(object sender, EventArgs e)
        {
            bunifuDGVDanhMucNha.DataSource = _danhMucNhaBUS.FindingDanhMucNha(txtDanhMucNha_TimTheoLoaiNha.Text, txtDanhMucNha_TimTheoLoaiDTSD.Text, txtDanhMucNha_TimTheoDiaChi.Text);
        }

        private void btnDanhMucNha_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thông tin của nhà có mã: {txtDanhMucNha_MaNha.Text}?", "Xác nhận cập nhật", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            _danhMucNhaBUS.DeleteDanhMucNha(txtDanhMucNha_MaNha.Text);
            bunifuDGVDanhMucNha.DataSource = _danhMucNhaBUS.GetListDanhMucNha();

        }

        private void btnDanhMucNha_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật phần dữ liệu này không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }


            if (isValidatedForm_DanhMucNha() == false)
            {
                return;
            }

            int daThue = 0;
            if (rdbDanhMucNha_DaThue.Checked == true)
                daThue = 1;

            if (!_danhMucNhaBUS.UpdateDanhMucNha(txtDanhMucNha_MaNha.Text, txtDanhMucNha_TenChuNha.Text, txtDanhMucNha_DienThoai.Text, txtDanhMucNha_MaLoai.Text, txtDanhMucNha_MaDTSD.Text, txtDanhMucNha_DiaChi.Text, decimal.Parse(txtDanhMucNha_DonGiaThue.Text), txtDanhMucNha_TinhTrang.Text, daThue, txtDanhMucNha_GhiChu.Text))
            {
                MessageBox.Show("Cập nhật danh mục nhà không thành công");
                return;
            }

            MessageBox.Show("Sửa thành công");
            bunifuDGVDanhMucNha.DataSource = _danhMucNhaBUS.GetListDanhMucNha();

        }
        //Finished code for DanhMucNha

        //Start code for KhachThue
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            //Khách thuê
            bunifuPages1.SetPage(2);
            bunifuDGVKhachThue.DataSource = _khachThueBUS.GetListKhachThue();
            //bunifuDGVKhachThue.DataSource = pd.DocBang($"select * from {_tblKhachThue}");

            
        }



        private void bunifuDGVKhachThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KhachThue_ResetTextBoxValue();
            txtKhachThue_MaKhach.Text = bunifuDGVKhachThue.SelectedRows[0].Cells["MaKhach"].Value.ToString();
            txtKhachThue_TenKhach.Text = bunifuDGVKhachThue.SelectedRows[0].Cells["TenKhach"].Value.ToString();
            txtKhachThue_NgaySinh.Text = bunifuDGVKhachThue.SelectedRows[0].Cells["NgaySinh"].Value.ToString();

            int gender = (int) bunifuDGVKhachThue.SelectedRows[0].Cells["GioiTinh"].Value;
            if (gender == 1)
            {
                txtKhachThue_GioiTinh.Text = "Nam";
            }
            else
                txtKhachThue_GioiTinh.Text = "Nữ";

            txtKhachThue_SoCMND.Text = bunifuDGVKhachThue.SelectedRows[0].Cells["SoCMND"].Value.ToString();
            txtKhachThue_DiaChiThuongTru.Text = bunifuDGVKhachThue.SelectedRows[0].Cells["DiaChiThuongTru"].Value.ToString();
            txtKhachThue_MaNghe.Text = bunifuDGVKhachThue.SelectedRows[0].Cells["MaNghe"].Value.ToString();
            txtKhachThue_MaCQ.Text = bunifuDGVKhachThue.SelectedRows[0].Cells["MaCQ"].Value.ToString();

        }

        public void KhachThue_ResetTextBoxValue()
        {

        }

        //Them_button
        private void bunifuButton17_Click(object sender, EventArgs e)
        {
            if (isValidatedForm_KhachThue() == false)
            {
                return;
            }

            // In the database, gender is stored as 1 - 0
            int gender = 0;
            if (txtKhachThue_GioiTinh.Text == "Nam") gender = 1;
            

        

            if (!_khachThueBUS.InsertKhachThue(txtKhachThue_MaKhach.Text, txtKhachThue_TenKhach.Text, Convert.ToDateTime(txtKhachThue_NgaySinh.Text), gender, txtKhachThue_SoCMND.Text, txtKhachThue_DiaChiThuongTru.Text, txtKhachThue_MaNghe.Text, txtKhachThue_MaCQ.Text))
            {
                MessageBox.Show("Khách thuê đã tồn tại trên hệ thống");
                return;
            }

            MessageBox.Show("Thêm mới khách thuê thành công");
        }

        private bool isValidatedForm_KhachThue()
        {
            List<BunifuTextBox> list = new List<BunifuTextBox>()
            {
                txtKhachThue_MaKhach, txtKhachThue_TenKhach,
                txtKhachThue_NgaySinh, txtKhachThue_GioiTinh, 
                txtKhachThue_SoCMND, txtKhachThue_DiaChiThuongTru, 
                txtKhachThue_MaNghe, txtKhachThue_MaCQ
            };

            if (!isValidatedForm(list))
            {
                return false;
            }

            return true;
        }

        private void btnKhachThue_TimKiem_Click(object sender, EventArgs e)
        {
            bunifuDGVKhachThue.DataSource = _khachThueBUS.FindingKhachThue(txtKhachThue_TimTheoTenKhack.Text, txtKhachThue_TimTheoDiaChiThuongTru.Text, txtKhachThue_TimTheoNgheNghiep.Text);
        }

        private void btnKhachThue_XemTatCa_Click(object sender, EventArgs e)
        {
            bunifuDGVKhachThue.DataSource = _khachThueBUS.GetListKhachThue();
        }

        private void btnKhachThue_Xoa_Click(object sender, EventArgs e)
        {
            _khachThueBUS.DeleteKhachThue(txtKhachThue_MaKhach.Text);
            bunifuDGVKhachThue.DataSource = _khachThueBUS.GetListKhachThue();
        }

        private void btnKhachThue_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn cập nhật dữ liệu cho khách có mã: {txtKhachThue_MaKhach}?", "Xác nhận cập nhật", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }


            if (isValidatedForm_KhachThue() == false)
            {
                return;
            }

            // In the database, gender is stored as 1 - 0
            int gender = 0;
            if (txtKhachThue_GioiTinh.Text == "Nam") gender = 1;




            if (!_khachThueBUS.UpdateKhachThue(txtKhachThue_MaKhach.Text, txtKhachThue_TenKhach.Text, Convert.ToDateTime(txtKhachThue_NgaySinh.Text), gender, txtKhachThue_SoCMND.Text, txtKhachThue_DiaChiThuongTru.Text, txtKhachThue_MaNghe.Text, txtKhachThue_MaCQ.Text))
            {
                MessageBox.Show("Cập nhật thông tin khách thuê không thành công");
                
                return;
            }

            MessageBox.Show("Cập nhật thành công");
            bunifuDGVKhachThue.DataSource = _khachThueBUS.GetListKhachThue();
        }
        //Finish code for KhachThue


        //Start code for NhaTaiSan
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            //Tài sản
            bunifuPages1.SetPage(3);
            bunifuDGVNhaTaiSan.DataSource = _traNhaBUS.GetListTraNha_ChuaTra();
        }

        private void bunifuDGVNhaTaiSan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             NhaTaiSan_ResetTextBoxValue();

            txtNhaTaiSan_MaNha.Text = bunifuDGVNhaTaiSan.SelectedRows[0].Cells["MaNha"].Value.ToString();
            txtNhaTaiSan_MaTaiSan.Text = bunifuDGVNhaTaiSan.SelectedRows[0].Cells["MaTaiSan"].Value.ToString();
            txtNhaTaiSan_SoLuong.Text = bunifuDGVNhaTaiSan.SelectedRows[0].Cells["SoLuong"].Value.ToString();
            txtNhaTaiSan_GiaTri.Text = bunifuDGVNhaTaiSan.SelectedRows[0].Cells["GiaTri"].Value.ToString();
            txtNhaTaiSan_TinhTrang.Text = bunifuDGVNhaTaiSan.SelectedRows[0].Cells["TinhTrang"].Value.ToString();
             */
        }

        public void NhaTaiSan_ResetTextBoxValue()
        {

        }

        private void btnNhaTaiSan_Them_Click(object sender, EventArgs e)
        {
            /*
             if (isValidatedForm_NhaTaiSan() == false)
            {
                return;
            }

            if (!_nha_TaiSanBUS.InsertNha_TaiSan(txtNhaTaiSan_MaNha.Text, txtNhaTaiSan_MaTaiSan.Text, int.Parse(txtNhaTaiSan_SoLuong.Text), decimal.Parse(txtNhaTaiSan_GiaTri.Text), txtNhaTaiSan_TinhTrang.Text))
            {
                MessageBox.Show("Tài sản này đã tồn tại trên hệ thống");
                return;
            }

            MessageBox.Show("Thêm mới tài sản thành công");*/

        }

        private bool isValidatedForm_NhaTaiSan()
        {
            /*
              List<BunifuTextBox> list = new List<BunifuTextBox> ()
            {
                txtNhaTaiSan_MaNha, txtNhaTaiSan_MaTaiSan, txtNhaTaiSan_SoLuong,
                txtNhaTaiSan_GiaTri, txtNhaTaiSan_TinhTrang
            };

            if (!isValidatedForm(list))
            {
                return false;
            }

            return true;*/
            return true;
        }

        private void btnNhaTaiSan_XemTatCa_Click(object sender, EventArgs e)
        {
            bunifuDGVNhaTaiSan.DataSource = _traNhaBUS.GetListTraNha_ChuaTra();
            txtTraNha_TimTheoMaSoThue.Text = "";
        }

        private void btnTraNha_TimKiem_Click(object sender, EventArgs e)
        {
            bunifuDGVNhaTaiSan.DataSource = _traNhaBUS.FindingTraNha(txtTraNha_TimTheoMaSoThue.Text);
        }



        //Finish code for NhaTaiSan


        //Start code for ThueNha
        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            //Thuê nhà
            bunifuPages1.SetPage(4);
            bunifuDGVThueNha.DataSource = _thueNhaBUS.GetListThueNha_ChuaTra();
        }
        private void bunifuDGVThueNha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ThueNha_ResetTextBoxValue();

            txtThueNha_MaSoThue.Text = bunifuDGVThueNha.SelectedRows[0].Cells["MaSoThue"].Value.ToString();
            txtThueNha_MaKhach.Text = bunifuDGVThueNha.SelectedRows[0].Cells["MaKhach"].Value.ToString();
            txtThueNha_MaNha.Text = bunifuDGVThueNha.SelectedRows[0].Cells["MaNha"].Value.ToString();

            txtThueNha_MaMucDichSD.Text = bunifuDGVThueNha.SelectedRows[0].Cells["MaMucDichSD"].Value.ToString();
            dTPThueNha_NgayBatDau.Value = Convert.ToDateTime(bunifuDGVThueNha.SelectedRows[0].Cells["NgayBD"].Value);
            dTPThueNha_NgayKetThuc.Value = Convert.ToDateTime(bunifuDGVThueNha.SelectedRows[0].Cells["NgayKT"].Value);

            txtThueNha_TienDatCoc.Text = bunifuDGVThueNha.SelectedRows[0].Cells["TienDatCoc"].Value.ToString();
            txtThueNha_MaHinhThucTT.Text = bunifuDGVThueNha.SelectedRows[0].Cells["MaHinhThucTT"].Value.ToString();
        }

        public void ThueNha_ResetTextBoxValue()
        {

        }

        private void bunifuButton27_Click(object sender, EventArgs e)
        {
                
        }

        private bool isValidatedForm_ThueNha()
        {
            List<BunifuTextBox> list = new List<BunifuTextBox>()
            {txtThueNha_MaSoThue, txtThueNha_MaKhach, txtThueNha_MaNha,
            txtThueNha_MaMucDichSD, txtThueNha_TienDatCoc, txtThueNha_MaHinhThucTT};

            if (!isValidatedForm(list))
            {
                return false;
            }

            return true;
        }

        private void btnThueNha_Them_Click(object sender, EventArgs e)
        {
            if (isValidatedForm_ThueNha() == false)
            {
                return;
            }


        }


        //Finish code for ThueNha

        private void bunifuTextBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox36_TextChanged(object sender, EventArgs e)
        {
            //txtKhachThue_MaNghe
        }

        private void rdbDanhMucNha_Trong_CheckedChanged2(object sender, BunifuRadioButton.CheckedChangedEventArgs e)
        {

        }

        private void txtDanhMucNha_MaLoai_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void loadTK()

        {

            txtTaiKhoan_TenTaiKhoan.Text = tentk;
            txtTaiKhoan_TenHienThi.Text = tenht;

            txtTaiKhoan_MatKhau.Text = mk;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fManager_Load(object sender, EventArgs e)
        {
            loadTK();
        }

       

        //Start code for Doanh Thu
        private void btnDoanhThu_ThongKe_Click(object sender, EventArgs e)
        {
            
            //Tổng tiền thu theo từng mã nhà
            //if (cmbTinhDoanhThu.SelectedIndex == 0)
            if (cmbTinhDoanhThu.SelectedItem.ToString() == "Tổng tiền thu theo từng mã nhà")
            {
                dgvDoanhThu.DataSource = _listThueNha;
                _listThueNha.DataSource = _thueNhaBUS.TinhTongTien();
            }
            else
            {
                dgvDoanhThu.DataSource = _listThueNha;
                _listThueNha.DataSource = _thueNhaBUS.TienThueChuaThanhToan();
            }
        }

        private void cmbTinhDoanhThu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void btnDoanhThu_XuatBaoCao_Click(object sender, EventArgs e)
        {
            if (dgvDoanhThu.Rows.Count > 0)
            {
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

                //Định dạng chung
                Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
                tenCuaHang.Font.Size = 12;
                tenCuaHang.Font.Bold = true;
                tenCuaHang.Font.Color = Color.Black;
                tenCuaHang.Value = "Quản lý phòng trọ";


                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
                dtCuaHang.Font.Size = 12;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Color = Color.Black;
                dtCuaHang.Value = "Điện thoại: 0971627398";

                Excel.Range header = (Excel.Range)exSheet.Cells[5, 5];
                header.Font.Size = 15;
                header.Font.Bold = true;
                header.Font.Color = Color.Black;
                header.Value = "Báo cáo thống kê";

                Excel.Range ngaylap = (Excel.Range)exSheet.Cells[5, 1];
                ngaylap.Font.Size = 12;
                ngaylap.Value = "Ngày lập: " + DateTime.Now.ToShortDateString();



                for (int i = 0; i < dgvDoanhThu.ColumnCount; i++)
                {
                    exSheet.Cells[7, i + 1] = dgvDoanhThu.Columns[i].HeaderText;
                    exSheet.Cells[7, i + 1].Font.Bold = true;
                }

                for (int i = 0; i < dgvDoanhThu.RowCount; i++)
                {
                    for (int j = 0; j < dgvDoanhThu.ColumnCount; j++)
                    {
                        if (dgvDoanhThu.Rows[i].Cells[j].Value != null)
                        {
                            if (dgvDoanhThu.Rows[i].Cells[j].Value is DateTime)
                            {
                                exSheet.Cells[i + 8, j + 1] = ((DateTime)dgvDoanhThu.Rows[i].Cells[j].Value).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                exSheet.Cells[i + 8, j + 1] = dgvDoanhThu.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        else
                        {
                            exSheet.Cells[i + 8, j + 1] = "";
                        }
                    }
                }

                exSheet.Name = "Hang";
                exBook.Activate();

                saveFileDialog1.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc) | *.doc | All files(*.*) | *.* ";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.DefaultExt = ".xlxs";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    exBook.SaveAs(saveFileDialog1.FileName.ToString());//Lưu file Excel
                exApp.Quit();
                MessageBox.Show("Đã xuất ra file excel thành công !");
            }
            else
                MessageBox.Show("Không có danh sách hàng để in");

        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fLogin fDangNhap = new fLogin();
                this.Hide();
                fDangNhap.ShowDialog();
            }
        }

        private void bunifuGroupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuGroupBox11_Enter(object sender, EventArgs e)
        {

        }

       












        //Finish code for DoanhThu


        //Start code for TaiKhoan

        private void btnTaiKhoan_LuuThayDoi_Click(object sender, EventArgs e)
        {
            string tenhienthi = txtTaiKhoan_TenHienThi.Text;
            string matkhau = txtTaiKhoan_MatKhau.Text;
            if (MessageBox.Show("Bạn có chắn chắn muốn thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _taiKhoanBUS.UpdateTK(tentk, matkhau, tenhienthi, 1);
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn đã hủy thay đổi !", "Thông báo");
                txtTaiKhoan_TenTaiKhoan.Text = tentk;
                txtTaiKhoan_TenHienThi.Text = tenht;
                txtTaiKhoan_MatKhau.Text = mk;
            }
        }


        private void btnTaiKhoan_DangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fLogin fDangNhap = new fLogin();
                this.Hide();
                fDangNhap.ShowDialog();
            }
        }


        //Finish code for TaiKhoan
    }
}
