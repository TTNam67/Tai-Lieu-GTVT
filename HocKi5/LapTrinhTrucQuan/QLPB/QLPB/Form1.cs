using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLPB
{
    public partial class Form1 : Form
    {
        List<CanHo> ch = new List<CanHo>();
        public Form1()
        {
            InitializeComponent();
            cmbHuong.Text = "Tây";
            this.ch.Add(new CanHo("Hà Nội",10,100,"Bắc",100000,10,"Đã bán"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ktra())
            {
                ListViewItem item = new ListViewItem();
                item.Text = txtDC.Text;
                item.SubItems.Add(txtPN.Text);
                item.SubItems.Add(txtWc.Text);
                item.SubItems.Add(cmbHuong.Text);
                item.SubItems.Add(txtGia.Text);
                item.SubItems.Add(txtCk.Text);
                item.SubItems.Add(laytich());
                listView.Items.Add(item);
                CanHo a = new CanHo(txtDC.Text, int.Parse(txtPN.Text), int.Parse(txtWc.Text), cmbHuong.Text, int.Parse(txtGia.Text), int.Parse(txtCk.Text),laytich());
                ch.Add(a);
            }
            else
            {
                MessageBox.Show("hãy nhập đủ thông tin");
            }
            
        }

        private bool ktra()
        {
            if(txtCk.Text.Trim().Length == 0||
                txtDC.Text.Trim().Length == 0||
                txtGia.Text.Trim().Length == 0||
                txtPN.Text.Trim().Length == 0||
                txtWc.Text.Trim().Length == 0 ||
                cmbHuong.Text.Trim().Length == 0||
                rdbBan.Checked == false&&
                rdbCoc.Checked == false&&
                rdbEm.Checked == false)
            { return false; }
            else { return true; }
        }

        public string laytich()
        {
            if (rdbBan.Checked == true) return rdbBan.Text;
            else if (rdbCoc.Checked == true) return rdbCoc.Text;
            else if (rdbEm.Checked == true) return rdbEm.Text;
            return rdbBan.Text; ;
        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc muốn thoát", "Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                this.Close();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {

            if (listView.SelectedItems.Count > 0)
            {
                int i = listView.SelectedItems[0].Index;
                listView.Items[i].SubItems[0].Text = txtDC.Text;
                listView.Items[i].SubItems[1].Text = txtPN.Text;
                listView.Items[i].SubItems[2].Text = txtWc.Text;
                listView.Items[i].SubItems[3].Text = cmbHuong.Text;
                listView.Items[i].SubItems[4].Text = txtGia.Text;
                listView.Items[i].SubItems[5].Text = txtCk.Text;
                listView.Items[i].SubItems[6].Text = laytich();
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count > 0)
            {
                txtDC.Text = "";
                txtPN.Text = "";
                txtWc.Text = "";
                cmbHuong.Text = "";
                txtGia.Text = "";
                txtCk.Text = "";
                rdbCoc.Checked = true;

                if (listView.SelectedItems.Count > 0)
                {
                    if (DialogResult.OK == MessageBox.Show("Ban co muon xoa ", "tb", MessageBoxButtons.OKCancel))
                    {
                        int i = listView.SelectedItems[0].Index;
                        listView.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void btnSe_Click(object sender, EventArgs e)
        {

            if (cmbHuong.Text.Trim().Length > 0 && txtGia.Text.Trim().Length > 0)
            {
                string gia = txtGia.Text; // Lấy giá trị từ TextBox và chuyển thành chữ thường
                string hbc = cmbHuong.Text;
                // Duyệt qua từng mục trong ListView
                foreach (ListViewItem item in listView.Items)
                {
                    // So sánh giá trị nhập với giá trị của mục (chuyển thành chữ thường để so sánh không phân biệt hoa thường)
                    if (item.SubItems[4].Text == gia && item.SubItems[3].Text == hbc)
                    {
                        // Tìm thấy mục, làm điều gì đó với nó
                        item.Selected = true; // Chọn mục để nó hiển thị bằng màu nền khác (tùy chọn)
                        listView.EnsureVisible(item.Index); // Cuộn đến mục nếu nó không nằm trong tầm nhìn (tùy chọn)
                        break; // Thoát khỏi vòng lặp sau khi tìm thấy một mục phù hợp
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập giá và hướng để tìm kiếm ");
                cmbHuong.Focus();
            }


        }
    }
}
