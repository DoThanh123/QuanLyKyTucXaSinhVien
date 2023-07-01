using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTXSV
{
    public partial class Form_DienNuoc : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=WINDOWS-10;Initial Catalog=QLKTXSV;Integrated Security=True");

        public Form_DienNuoc()
        {
            InitializeComponent();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.ShowDialog();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SV form = new Form_SV();
            this.Hide();
            form.ShowDialog();
        }

        private void thuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Hop_dong form = new Form_Hop_dong();
            this.Hide();
            form.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Notice;
            Notice = MessageBox.Show("Do you want to exit ?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Notice == DialogResult.Yes)
                Application.Exit();
        }

        public void load()
        {
            string querry =
                "SELECT DNID as 'Mã Đơn', " +
                "RoomID as N'Mã Phòng', " +
                "Dien as N'Chỉ Số Điện'," +
                "Nuoc as N'Chỉ Số Nước'," +
                "DateMake as N'Ngày Làm Đơn'," +
                "Sum as N'Tổng Tiền'," +
                "Paid as N'Đã Đóng'," +
                "Owed as N'Còn Thiếu'" +
                "FROM DienNuoc";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataTable dta = new DataTable();
            adapter.Fill(dta);
            dgv_diennuoc.DataSource = dta;
        }

        public void Load_cbb_roomID()
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select RoomID From Room where Number NOT LIKE '0/4'", conn);
            da.Fill(dt);
            conn.Close();
            cbb_RoomID.DataSource = dt.Copy();
            cbb_RoomID.DisplayMember = "RoomID";
            cbb_RoomID.ValueMember = "RoomID";
            cbb_RoomID2.DataSource = dt.Copy();
            cbb_RoomID2.DisplayMember = "RoomID";
            cbb_RoomID2.ValueMember = "RoomID";
        }
        private void Form_DienNuoc_Load(object sender, EventArgs e)
        {
            load();
            Load_cbb_roomID();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {

            load();
            Load_cbb_roomID();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string querry =
                "SELECT DNID as N'Mã Đơn', " +
                "RoomID as N'Mã Phòng', " +
                "Dien as N'Chỉ Số Điện'," +
                "Nuoc as N'Chỉ Số Nước'," +
                "DateMake as N'Ngày Làm Đơn'," +
                "Sum as N'Tổng Tiền'," +
                "Paid as N'Đã Đóng'," +
                "Owed as N'Còn Thiếu'" +
                "FROM DienNuoc Where RoomID = N'" + cbb_RoomID + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dta = new DataTable();
                adapter.Fill(dta);
                dgv_diennuoc.DataSource = dta;
            }
            catch (Exception)
            {
                MessageBox.Show("Tìm thất bại", "Thông báo");
            }

            conn.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "" && cbb_RoomID2.Text != "" && txt2.Text != "" && txt3.Text != "" && dtP1.Text != "" && txt4.Text != "")
            {
                try
                {
                    int Dien = Convert.ToInt32(txt2.Text);
                    int Nuoc = Convert.ToInt32(txt3.Text);
                    int Sum = Dien * 1000 + Nuoc * 1000;
                    int Paid = Convert.ToInt32(txt4.Text);
                    int Owed = Sum - Paid;
                    string querry = "INSERT INTO DienNuoc "
                        + "VALUES (N'" + txt1.Text
                        + "', N'" + cbb_RoomID2.Text
                        + "', N'" + txt2.Text
                        + "', N'" + txt3.Text
                        + "', N'" + dtP1.Text
                        + "', N'" + Sum
                        + "', N'" + txt4.Text
                        + "', N'" + Owed + "')";
                    Console.WriteLine(querry);
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                    DataTable dta = new DataTable();
                    adapter.Fill(dta);
                }
                catch (Exception)
                {
                    MessageBox.Show("Add thất bại", "Thông báo");
                }
                conn.Close();
                load();
            }
            else if (txt1.Text == "" && cbb_RoomID2.Text != "" && txt2.Text != "" && txt3.Text != "" && dtP1.Text != "" && txt4.Text != "")
            {
                MessageBox.Show("Vui lòng nhập mã đơn", "Thông báo");
                txt1.Focus();
            }
            else if (txt1.Text != "" && cbb_RoomID2.Text == "" && txt2.Text != "" && txt3.Text != "" && dtP1.Text != "" && txt4.Text != "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng", "Thông báo");
            }
            else if (txt1.Text != "" && cbb_RoomID2.Text != "" && txt2.Text == "" && txt3.Text != "" && dtP1.Text != "" && txt4.Text != "")
            {
                MessageBox.Show("Vui lòng nhập chỉ số điện", "Thông báo");
                txt2.Focus();
            }
            else if (txt1.Text != "" && cbb_RoomID2.Text != "" && txt2.Text != "" && txt3.Text == "" && dtP1.Text != "" && txt4.Text != "")
            {
                MessageBox.Show("Vui lòng nhập chỉ số nước", "Thông báo");
                txt1.Focus();
            }
            else if (txt1.Text != "" && cbb_RoomID2.Text != "" && txt2.Text != "" && txt3.Text != "" && dtP1.Text == "" && txt4.Text != "")
            {
                MessageBox.Show("Vui lòng nhập ngày làm đơn", "Thông báo");
            }
            else if (txt1.Text != "" && cbb_RoomID2.Text != "" && txt2.Text != "" && txt3.Text != "" && dtP1.Text != "" && txt4.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền đã trả", "Thông báo");
                txt4.Focus();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "" && cbb_RoomID2.Text != "" && txt2.Text != "" && txt3.Text != "" && dtP1.Text != "" && txt4.Text != "")
            {
                try
                {
                    int Dien = Convert.ToInt32(txt2.Text);
                    int Nuoc = Convert.ToInt32(txt3.Text);
                    int Sum = Dien * 1000 + Nuoc * 1000;
                    int Paid = Convert.ToInt32(txt4.Text);
                    int Owed = Sum - Paid;
                    string querry =
                        "UPDATE DienNuoc SET "
                                   + "   DNID = N'" + txt1.Text
                                   + "', RoomID = N'" + cbb_RoomID2.Text
                                   + "', Dien = N'" + txt2.Text
                                   + "', Nuoc = N'" + txt3.Text
                                   + "', DateMake = N'" + dtP1.Text
                                   + "', Sum = N'" + Sum
                                   + "', Paid = N'" + txt4.Text
                                   + "', Owed = N'" + Owed
                                   + "' where DNID = N'" + txt1.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                    DataTable dta = new DataTable();
                    adapter.Fill(dta);
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại", "thông báo");
                }
                conn.Close();
                load();
            }
            else if (txt1.Text == "" && cbb_RoomID2.Text != "" && txt2.Text != "" && txt3.Text != "" && dtP1.Text != "" && txt4.Text != "")
            {
                MessageBox.Show("Vui lòng nhập mã đơn", "Thông báo");
                txt1.Focus();
            }
            else if (txt1.Text != "" && cbb_RoomID2.Text == "" && txt2.Text != "" && txt3.Text != "" && dtP1.Text != "" && txt4.Text != "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng", "Thông báo");
            }
            else if (txt1.Text != "" && cbb_RoomID2.Text != "" && txt2.Text == "" && txt3.Text != "" && dtP1.Text != "" && txt4.Text != "")
            {
                MessageBox.Show("Vui lòng nhập chỉ số điện", "Thông báo");
                txt2.Focus();
            }
            else if (txt1.Text != "" && cbb_RoomID2.Text != "" && txt2.Text != "" && txt3.Text == "" && dtP1.Text != "" && txt4.Text != "")
            {
                MessageBox.Show("Vui lòng nhập chỉ số nước", "Thông báo");
                txt1.Focus();
            }
            else if (txt1.Text != "" && cbb_RoomID2.Text != "" && txt2.Text != "" && txt3.Text != "" && dtP1.Text == "" && txt4.Text != "")
            {
                MessageBox.Show("Vui lòng nhập ngày làm đơn", "Thông báo");
            }
            else if (txt1.Text != "" && cbb_RoomID2.Text != "" && txt2.Text != "" && txt3.Text != "" && dtP1.Text != "" && txt4.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền đã trả", "Thông báo");
                txt4.Focus();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                string querry =
                    "DELETE FROM DienNuoc WHERE DNID = N'" + txt1.Text + "';";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dta = new DataTable();
                adapter.Fill(dta);
            }
            catch
            {
                MessageBox.Show("Xóa thất bại", "thông báo");
            }
            conn.Close();
            load();
        }

        private void dgv_diennuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_diennuoc.CurrentRow.Index;
            txt1.Text = dgv_diennuoc.Rows[i].Cells[0].Value.ToString();
            cbb_RoomID2.Text = dgv_diennuoc.Rows[i].Cells[1].Value.ToString();
            txt2.Text = dgv_diennuoc.Rows[i].Cells[2].Value.ToString();
            txt3.Text = dgv_diennuoc.Rows[i].Cells[3].Value.ToString();
            dtP1.Text = dgv_diennuoc.Rows[i].Cells[4].Value.ToString();
            txt4.Text = dgv_diennuoc.Rows[i].Cells[6].Value.ToString();
        }
    }
}