using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTXSV
{
    public partial class Form_SV : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=WINDOWS-10;Initial Catalog=QLKTXSV;Integrated Security=True");

        public Form_SV()
        {
            InitializeComponent();
            txt7.Text = "vd: thanh123@gmail.com";
            txt8.Text = "vd: 0987654321";
            txt7.GotFocus += new EventHandler(txt7Gotfocus);
            txt7.LostFocus += new EventHandler(txt7Lostfocus);
            txt8.GotFocus += new EventHandler(txt8Gotfocus);
            txt8.LostFocus += new EventHandler(txt8Lostfocus);
        }

        private void txt8Lostfocus(object sender, EventArgs e)
        {
            if (txt8.Text == "")
            {
                txt8.Text = "vd: 0987654321";
            }
        }

        private void txt8Gotfocus(object sender, EventArgs e)
        {
            if (txt8.Text != "")
            {
                txt8.Text = "";
            }
        }

        private void txt7Lostfocus(object sender, EventArgs e)
        {
            if (txt7.Text == "")
            {
                txt7.Text = "vd: thanh123 @gmail.com";
            }
        }

        private void txt7Gotfocus(object sender, EventArgs e)
        {
            if (txt7.Text != "")
            {
                txt7.Text = "";
            }
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
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

        public void Load_cbb_roomID()
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select RoomID From Room Where Number NOT LIKE '4/4'", conn);
            da.Fill(dt);
            conn.Close();
            cbb.DataSource = dt.Copy();
            cbb.DisplayMember = "RoomID";
            cbb.ValueMember = "RoomID";
        }

        public void loadStudent()
        {
            string querry = 
                "SELECT StudentID as N'Mã SV', " +
                "StudentName as N'Tên SV', " +
                "RoomID as N'Mã Phòng', " +
                "DateOfBirth as N'Ngày Sinh'," +
                "Gender as N'Giới Tính'," +
                "Class as N'Lớp'," +
                "Department as N'Khoa'," +
                "address as N'Địa Chỉ'," +
                "Email," +
                "PhoneNumber as N'SĐT' FROM Student";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataTable dta = new DataTable();
            adapter.Fill(dta);
            dgv_SV.DataSource = dta;
        }

        string b;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            b = "Nam";
            checkBox1.Checked = true; 
            checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            b = "Nữ";
            checkBox1.Checked = false;
            checkBox2.Checked = true;
        }
      

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string querry = "SELECT StudentID as N'Mã SV', " +
                "StudentName as N'Tên SV', " +
                "RoomID as N'Mã Phòng', " +
                "DateOfBirth as N'Ngày Sinh'," +
                "Gender as N'Giới Tính'," +
                "Class as N'Lớp'," +
                "Department as N'Khoa'," +
                "address as N'Địa Chỉ'," +
                "Email," +
                "PhoneNumber as N'SĐT' FROM Student where StudentID = ' "+ txt1.Text + " '";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dta = new DataTable();
                adapter.Fill(dta);
                dgv_SV.DataSource = dta;
            }
            catch (Exception)
            {
                MessageBox.Show("Tìm thất bại", "Thông báo");
            }

            conn.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string email = txt7.Text;
            bool isValidEmail = Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            string phonenumber = txt8.Text;
            bool isValidPN = Regex.IsMatch(phonenumber, @"^\+?(?:84|0)(?:\d){8,9}$");
            if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                try
                {
                    string querry =
                        "INSERT INTO Student VALUES "
                        + "(  N'" + txt2.Text
                        + "', N'" + txt3.Text
                        + "', N'" + cbb.SelectedValue.ToString()
                        + "', N'" + dtP.Text
                        + "', N'" + b
                        + "', N'" + txt4.Text
                        + "', N'" + txt5.Text
                        + "', N'" + txt6.Text
                        + "', N'" + txt7.Text
                        + "', N'" + txt8.Text + "')";
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                    DataTable dta = new DataTable();
                    adapter.Fill(dta);
                    //string querry1 = "UPDATE Room IF Number = '0/4' SET Number = '1/4'," +
                    //    "";
                }
                catch
                {
                    MessageBox.Show("Add thất bại", "Thông báo");
                }
                conn.Close();
                loadStudent();
            }
            else if (txt2.Text == "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên","Thông báo");
                txt2.Focus();
            }
            else if (txt2.Text != "" && txt3.Text == "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên", "Thông báo");
                txt3.Focus();
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text == "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng nhập mã phòng", "Thông báo");
                cbb.Focus();
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text == "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng nhập ngày sinh", "Thông báo");
                dtP.Focus();
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b == "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo");
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text == "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng nhập tên lớp", "Thông báo");
                txt4.Focus();
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text == "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng nhập tên ngành", "Thông báo");
                txt5.Focus();
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text == "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng nhập mđịa chỉ", "Thông báo");
                txt6.Focus();
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail == false && isValidPN)
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo");
                txt7.Focus();
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo");
                txt8.Focus();
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            string email = txt7.Text;
            bool isValidEmail = Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            string phonenumber = txt8.Text;
            bool isValidPN = Regex.IsMatch(phonenumber, @"^\+?(?:84|0)(?:\d){8,9}$");
            if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                try
                {
                    string querry =
                        "UPDATE Student SET StudentID = N'" + txt2.Text
                                   + "', StudentName = N'" + txt3.Text
                                   + "', RoomID = N'" + cbb.SelectedValue.ToString()
                                   + "', DateOfBirth = N'" + dtP.Text
                                   + "', Gender = N'" + b
                                   + "', Class = N'" + txt4.Text
                                   + "', Department = N'" + txt5.Text
                                   + "', Address = N'" + txt6.Text
                                   + "', Email = N'" + txt7.Text
                                   + "', PhoneNumber = N'" + txt8.Text
                                   + "' where StudentID = N'" + txt2.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                    DataTable dta = new DataTable();
                    adapter.Fill(dta);
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại", "thông báo");
                }
                conn.Close();
                loadStudent();
            }
            else if (txt2.Text == "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Thông báo");
                txt2.Focus();
            }
            else if (txt2.Text != "" && txt3.Text == "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên", "Thông báo");
                txt3.Focus();
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text == "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng nhập mã phòng", "Thông báo");
                cbb.Focus();
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text == "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng nhập ngày sinh", "Thông báo");
                dtP.Focus();
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b == "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo");
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text == "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng nhập tên lớp", "Thông báo");
                txt4.Focus();
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text == "" && txt6.Text != "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng nhập tên ngành", "Thông báo");
                txt5.Focus();
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text == "" && isValidEmail && isValidPN)
            {
                MessageBox.Show("Vui lòng nhập mđịa chỉ", "Thông báo");
                txt6.Focus();
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail == false && isValidPN)
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo");
                txt7.Focus();
            }
            else if (txt2.Text != "" && txt3.Text != "" && cbb.Text != "" && dtP.Text != "" && b != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && isValidEmail && isValidPN == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo");
                txt8.Focus();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                string querry =
                    "DELETE FROM Student WHERE StudentID = " + txt2.Text + ";";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dta = new DataTable();
                adapter.Fill(dta);
            }
            catch
            {
                MessageBox.Show("Xóa thất bại", "thông báo");
            }
            conn.Close();
            loadStudent();
        }

        private void dgv_SV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_SV.CurrentRow.Index;
            txt2.Text = dgv_SV.Rows[i].Cells[0].Value.ToString();
            txt3.Text = dgv_SV.Rows[i].Cells[1].Value.ToString();
            cbb.Text = dgv_SV.Rows[i].Cells[2].Value.ToString();
            dtP.Text = dgv_SV.Rows[i].Cells[3].Value.ToString();
            if (dgv_SV.Rows[i].Cells[4].Value.ToString() == "Nam")
                checkBox1.Checked = true;
            else
                checkBox2.Checked = true;
            txt4.Text = dgv_SV.Rows[i].Cells[5].Value.ToString();
            txt5.Text = dgv_SV.Rows[i].Cells[6].Value.ToString();
            txt6.Text = dgv_SV.Rows[i].Cells[7].Value.ToString();
            txt7.Text = dgv_SV.Rows[i].Cells[8].Value.ToString();
            txt8.Text = dgv_SV.Rows[i].Cells[9].Value.ToString();
        }

        private void Form_SV_Load(object sender, EventArgs e)
        {
            loadStudent();
            Load_cbb_roomID();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            loadStudent();
            Load_cbb_roomID();
        }
    }
}
