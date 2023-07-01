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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLKTXSV
{
    public partial class Form_Hop_dong : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=WINDOWS-10;Initial Catalog=QLKTXSV;Integrated Security=True");

        public Form_Hop_dong()
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

        private void điệnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DienNuoc form = new Form_DienNuoc();
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
                "SELECT ContractID as N'Mã Đăng Ký', "
                + "RoomID as N'Mã Phòng', "
                + "StudentID as N'Mã Sinh Viên',"
                + "CheckInDay as N'Ngày Đăng Ký',"
                + "CheckOutDay as N'Ngày Hết Hạn'"
                + "FROM Contract";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataTable dta = new DataTable();
            adapter.Fill(dta);
            dgv_DKP.DataSource = dta;
        }

        public void Load_cbb_roomID()
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select RoomID From Room where Number NOT LIKE '0/4'", conn);
            da.Fill(dt);
            conn.Close();
            cbb1.DataSource = dt.Copy();
            cbb1.DisplayMember = "RoomID";
            cbb1.ValueMember = "RoomID";
        }

        public void Load_cbb_StudentID()
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select StudentID From Student", conn);
            da.Fill(dt);
            conn.Close();
            cbb2.DataSource = dt.Copy();
            cbb2.DisplayMember = "StudentID";
            cbb2.ValueMember = "StudentID";
        }

        public void Load_cbb_StudentID2()
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select StudentID From Student Where RoomID = '"+ cbb1.Text +"'", conn);
            da.Fill(dt);
            conn.Close();
            cbb2.DataSource = dt.Copy();
            cbb2.DisplayMember = "StudentID";
            cbb2.ValueMember = "StudentID";
        }

        private void Form_Hop_dong_Load(object sender, EventArgs e)
        {
            load();
            Load_cbb_roomID();
            Load_cbb_StudentID();
        }

        private void dtP2_ValueChanged(object sender, EventArgs e)
        {
            dtP2.MinDate = dtP1.Value.AddDays(30);
        }

        private void cbb1_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cbb2_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            load();
            Load_cbb_roomID();
            Load_cbb_StudentID();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string querry =
                "SELECT ContractID as N'Mã Đăng Ký', " +
                "RoomID as N'Mã Phòng', " +
                "StudentID as N'Mã Sinh Viên'," +
                "CheckInDay as N'Ngày Đăng Ký'," +
                "CheckOutDay as N'Ngày Hết Hạn'" +
                "FROM Contract where ContractID = N'" + txt1.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dta = new DataTable();
                adapter.Fill(dta);
                dgv_DKP.DataSource = dta;
            }
            catch (Exception)
            {
                MessageBox.Show("Tìm thất bại", "Thông báo");
            }

            conn.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt2.Text != "" && cbb1.Text != "" && cbb2.Text != "" && dtP1.Text != "" && dtP2.Text != "")
            {
                try
                {
                    string querry = "INSERT INTO Contract "
                        + "VALUES (N'" + txt2.Text
                        + "', N'" + cbb1.SelectedValue.ToString()
                        + "', N'" + cbb2.SelectedValue.ToString() 
                        + "', N'" + dtP1.Text
                        + "', N'" + dtP2.Text + "')";
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                    DataTable dta = new DataTable();
                    adapter.Fill(dta);
                }
                catch
                {
                    MessageBox.Show("Add thất bại", "Thông báo");
                }
                conn.Close();
                load();
            }
            else if (txt2.Text == "" && cbb1.Text != "" && cbb2.Text != "" && dtP1.Text != "" && dtP2.Text != "")
            {
                MessageBox.Show("Vui lòng nhập mã đăng ký", "Thông báo");
            }
            else if (txt2.Text != "" && cbb1.Text == "" && cbb2.Text != "" && dtP1.Text != "" && dtP2.Text != "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng", "Thông báo");
            }
            else if (txt2.Text != "" && cbb1.Text != "" && cbb2.Text == "" && dtP1.Text != "" && dtP2.Text != "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Thông báo");
            }
            else if (txt2.Text != "" && cbb1.Text != "" && cbb2.Text != "" && dtP1.Text == "" && dtP2.Text != "")
            {
                MessageBox.Show("Vui lòng nhập ngày đăng ký", "Thông báo");
            }
            else if (txt2.Text != "" && cbb1.Text != "" && cbb2.Text != "" && dtP1.Text != "" && dtP2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày hết hạn", "Thông báo");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string querry =
                    "UPDATE Contract SET ContractID = N'" + txt2.Text
                               + "', RoomID = N'" + cbb1.Text
                               + "', StudentID = N'" + cbb2.Text
                               + "', CheckInDay = N'" + dtP1.Text
                               + "', CheckOutDay = N'" + dtP2.Text
                               + "' where ContractID = N'" + txt2.Text + "'";

                Console.WriteLine(querry);
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

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                string querry =
                    "DELETE FROM Contract WHERE ContractID = N'" + txt2.Text + "';";
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

        private void dgv_DKP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_DKP.CurrentRow.Index;
            txt2.Text = dgv_DKP.Rows[i].Cells[0].Value.ToString();
            cbb1.Text = dgv_DKP.Rows[i].Cells[1].Value.ToString();
            cbb2.Text = dgv_DKP.Rows[i].Cells[2].Value.ToString();
            dtP1.Text = dgv_DKP.Rows[i].Cells[3].Value.ToString();
            dtP2.Text = dgv_DKP.Rows[i].Cells[4].Value.ToString();
        }

        private void cbb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
