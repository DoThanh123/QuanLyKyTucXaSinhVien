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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLKTXSV
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=WINDOWS-10;Initial Catalog=QLKTXSV;Integrated Security=True");
        
        public Form2()
        {
            InitializeComponent();
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

        void loadroom()
        {
            string querry = "SELECT RoomID as N'Mã Phòng',RoomName as N'Tên Phòng',Number as 'Số Chỗ',RoomDevice as 'Thiết Bị'  FROM Room";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataTable dta = new DataTable();
            adapter.Fill(dta);
            dgv_room.DataSource = dta;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string querry = "SELECT RoomID as N'Mã Phòng',RoomName as N'Tên Phòng',Number as 'Số Chỗ',RoomDevice as 'Thiết Bị'  FROM Room where RoomID = ' "
                                                + cbb_RoomID1.Text + " '";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dta = new DataTable();
                adapter.Fill(dta);
                dgv_room.DataSource = dta;
            }
            catch (Exception)
            {
                MessageBox.Show("Tìm thất bại", "Thông báo");
            }

            conn.Close();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            loadroom();
            Load_cbb_roomID();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (cbb_RoomID2.Text != "" && txt_RoomName.Text != "" && cbb_seat.Text != "" && txt.Text != "")
            {
                try
                {
                    string querry =
                        "UPDATE Room SET RoomName = N'" + txt_RoomName.Text
                                   + "', Number = N'" + cbb_seat.Text
                                   + "', RoomDevice = N'" + txt.Text
                                   + "' where RoomID = N'" + cbb_RoomID2.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                    DataTable dta = new DataTable();
                    adapter.Fill(dta);
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại", "thông báo");
                }
                conn.Close();
                loadroom();
            }
            else if (cbb_RoomID2.Text == "" && txt_RoomName.Text != "" && cbb_seat.Text != "" && txt.Text != "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng", "thông báo");
                cbb_RoomID2.Focus();
            }
            else if (cbb_RoomID2.Text != "" && txt_RoomName.Text == "" && cbb_seat.Text != "" && txt.Text != "")
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "thông báo");
                txt_RoomName.Focus();
            }
            else if (cbb_RoomID2.Text != "" && txt_RoomName.Text != "" && cbb_seat.Text == "" && txt.Text != "")
            {
                MessageBox.Show("Vui lòng nhập  số chỗ", "thông báo");
                cbb_seat.Focus();
            }
            else if (cbb_RoomID2.Text != "" && txt_RoomName.Text != "" && cbb_seat.Text != "" && txt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tình trạng thiết bị", "thông báo");
                txt.Focus();
            }
        }

        public void Load_cbb_roomID()
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select RoomID From Room", conn);
            da.Fill(dt);
            conn.Close();
            cbb_RoomID1.DataSource = dt.Copy();
            cbb_RoomID1.DisplayMember = "RoomID";
            cbb_RoomID1.ValueMember = "RoomID";
            cbb_RoomID2.DataSource = dt.Copy();
            cbb_RoomID2.DisplayMember = "RoomID";
            cbb_RoomID2.ValueMember = "RoomID";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadroom();
            Load_cbb_roomID();
        }

        private void dgv_room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_room.CurrentRow.Index;
            cbb_RoomID2.Text = dgv_room.Rows[i].Cells[0].Value.ToString();
            txt_RoomName.Text = dgv_room.Rows[i].Cells[1].Value.ToString();
            cbb_seat.Text = dgv_room.Rows[i].Cells[2].Value.ToString();
            txt.Text = dgv_room.Rows[i].Cells[3].Value.ToString();
        }
    }
}
