using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();

        private void LoginButton_Click(object sender, EventArgs e)
        {

            if (UsernameTextBox.Text.Trim() == "" || PasswordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alimu\Desktop\Banking System\Banking System\Banking System\PersonalDB.mdf;Integrated Security=True");
                con.Open();
                var sql = "SELECT * FROM Personal WHERE Username= @Username AND Password= @Password";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //
                    con.Close();
                    this.Hide();
                    MainPage main = new MainPage(UsernameTextBox.Text, PasswordTextBox.Text);

                    main.Show();
                }
                else
                {
                    con.Close();
                    label3.ForeColor = Color.Red;
                    label3.Text = "There is no data for this user.";
                }
            }

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAcc acc = new CreateAcc();
            acc.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
                         C:\Users\alimu\Desktop\Banking System\Banking System\Banking System\PersonalDB.mdf;Integrated Security=True");
                var sql = "SELECT " +
                    "Password,Username FROM Personal";

                da = new SqlDataAdapter(sql, con);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connection");
            }
        }
        int z = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (z)
            {
                case 1:
                    BackColor = Color.Aqua;
                    
                    z++;
                    break;
                case 2:
                    BackColor = Color.Gray;
                   
                    z++;
                    break;
                case 3:
                    BackColor = Color.Blue;
                    
                    z++;
                    break;
                case 4:
                    BackColor = Color.Yellow;
                    
                    z++;

                    break;
                case 5:
                    BackColor = Color.ForestGreen;

                    z++;

                    break;
                case 6:
                    BackColor = Color.Linen;

                    z++;

                    break;
                default:
                    BackColor = Color.SandyBrown;

                    z = 1;
                    break;
            }
        }
    }
}
