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
    public partial class Form_Login : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=WINDOWS-10;Initial Catalog=QLKTXSV;Integrated Security=True");
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txt_account.Text;
            password = txt_password.Text;
            try
            {
                string querry = "SELECT * FROM Account WHERE UserName = '" + txt_account.Text + "' AND PassWord = '" + txt_password.Text + "' ";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dta = new DataTable();
                adapter.Fill(dta);

                if (dta.Rows.Count > 0)
                {
                    username = txt_account.Text;
                    username = txt_password.Text;

                    Form2 form = new Form2();
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_account.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi đăng nhập!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Notice;
            Notice = MessageBox.Show("Do you want to exit ?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Notice == DialogResult.Yes)
                Application.Exit();
        }
    }
}
