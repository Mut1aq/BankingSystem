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
using System.Data.SQLite;

namespace Banking_System
{
    public partial class MainPage : Form
    {
        public MainPage(string n,string n2)
        {
            na = n;
            np = n2;
           
            InitializeComponent();
        }
        string na, np,ge;
        int age;
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void detailsAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"UserName : {na} and PassWord {np}");
        }

        private void deleteAccoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void showNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void updateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showGenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show($"Gender {ge}");
        }

        private void showAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MessageBox.Show($"Age {age}");
        }

        private void showBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alimu\Desktop\Banking System\Banking System\Banking System\PersonalDB.mdf;Integrated Security=True");

            if (na!="admin" || np!="admin")
            {
                //  tabControl1.ControlAdded("ali")
                // tabControl1.Controls.Remove(tabControl1);
              //  tabControl1.TabPages[0].Controls.RemoveAt(0);
                
              //  tabControl1.TabPages.RemoveAt(3);
               // DataGridView dataGridView = new DataGridView();
               // tabControl1.Controls.AddRange(dataGridView, "Admin");
            }
            else if(na == "admin" && np == "admin")
            {
                try
                {
                    DataTable dt = new DataTable();
                    var sql = "SELECT Id,FirstName,LastName,Gender," +
                        "MaritialStatus,Age,InitialBalance,Password,Username,Picture FROM Personal";
                    da = new SqlDataAdapter(sql, con);
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.GetType().ToString());
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                if (char.IsLetter(textBox2.Text[i]) || char.IsPunctuation(textBox2.Text[i]))
                {
                    textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
                    MessageBox.Show("Id in Number", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT FirstName,LastName,Gender," +
                        "MaritialStatus,Age,InitialBalance,Password,Username," +
                        " FROM Personal WHERE Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox2.Text));
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                textBox3.Text = reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells["Id"].Value.ToString();
                string strn = row.Cells["FirstName"].Value.ToString();
                    string strl= " " + row.Cells["LastName"].Value.ToString();
                textBox3.Text = strn + strl;
                textBox4.Text= row.Cells["Age"].Value.ToString();
                textBox5.Text= row.Cells["Password"].Value.ToString();
               

            }
        }

        private void EditInformationB_Click(object sender, EventArgs e)
        {
            InfoGroupBox.Enabled = true;
        }

        private void OKB_Click(object sender, EventArgs e)
        {
            /*
               SqlCommand cmd = new SqlCommand();
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alimu\Desktop\Banking System\Banking System\Banking System\PersonalDB.mdf;Integrated Security=True");
                    
                                cmd.CommandText = "UPDATE Personal SET FirstName = @FirstName,LastName = @LastName" +
                        "MaritialStatus = @MaritialStatus,Age = @age";
                        
                    
                    cmd.Parameters.AddWithValue("@FirstName", ShowFirstNametextBox.Text);
                    cmd.Parameters.AddWithValue("@LastName", ShowLastNametextBox.Text);
                    
                    if(Married.Checked)
                    {
                        cmd.Parameters.AddWithValue("@MaritialStatus", "Married");
                    }
                    else if(Single.Checked)
                        cmd.Parameters.AddWithValue("@MaritialStatus", "Single");
                    cmd.Parameters.AddWithValue("@Age", int.Parse(ShowAgetextBox.Text));
                    cmd.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                   //MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    
            
                        MessageBox.Show("Account information updated successesfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                    
                }
            }
        }
             */
        }

        private void DWB_Click(object sender, EventArgs e)
        {
            if (DeposittextBox.Text != "") 
            {
                con.Open();
                string comm = "SELECT InitialBalance FROM Personal WHERE Username = '"+na+"';";
                SqlCommand cmd = new SqlCommand(comm, con);
                SqlDataReader reader = cmd.ExecuteReader();
                int value = int.Parse(reader[0].ToString()) + int.Parse(DeposittextBox.Text); 
                cmd.CommandText = "UPDATE Personal SET InitialBalance=" + value + " WHERE Username = '" + na + "';";

                cmd = new SqlCommand(comm, con);

                cmd.ExecuteNonQuery();
                con.Close();


            }
            

            /*
             SqlCommand cmd = new SqlCommand();
             con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alimu\Desktop\Banking System\Banking System\Banking System\PersonalDB.mdf;Integrated Security=True");
             con.Open();
             cmd.Connection = con;
             cmd.CommandText = "UPDATE Personal SET InitialBalance=@InitialBalance;
             cmd.Parameters.AddWithValue("@InitialBalance", int.Parse(InitialBalanceTextBox.Text));
             cmd.ExecuteNonQuery();
             con.Close();

             */
        }

        private void WithdrawB_Click(object sender, EventArgs e)
        {
            if (WithdrawB.Text != "")
            {
                con.Open();
                string comm = "SELECT InitialBalance FROM Personal WHERE Username = '" + na + "';";
                SqlCommand cmd = new SqlCommand(comm, con);
                SqlDataReader reader = cmd.ExecuteReader();
                int value = int.Parse(reader[0].ToString()) - int.Parse(DeposittextBox.Text);
                cmd.CommandText = "UPDATE Personal SET InitialBalance=" + value + " WHERE Username = '" + na + "';";

                cmd = new SqlCommand(comm, con);

                cmd.ExecuteNonQuery();
                con.Close();


            }
        }

        private void AEB_Click(object sender, EventArgs e)
        {
            if (AmountTB.Text != "" && accountUTB.Text != "")
            {
                con.Open();
                string comm = "SELECT InitialBalance FROM Personal WHERE Username = '" + accountUTB.Text + "';";
                SqlCommand cmd = new SqlCommand(comm, con);
                SqlDataReader reader = cmd.ExecuteReader();
                int value = int.Parse(reader[0].ToString()) + int.Parse(AmountTB.Text);
                cmd.CommandText = "UPDATE Personal SET InitialBalance=" + value + " WHERE Username = '" + accountUTB.Text + "';";

                cmd = new SqlCommand(comm, con);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //try
            //{
            //    con.Open();

            //    string sql = "UPDATE Personal SET username = '"+textBox1.Text+ "' WHERE username = @username";
            //    SqlCommand command = new SqlCommand(sql, con);
            //    //int affectedRecords = " + affectedRecords +"
            //    int affectedRecords = command.ExecuteNonQuery();
            //    MessageBox.Show("It seems that " + affectedRecords + " record(s) was(were) updated successfully", "Database Operation Result");
            //}
            //catch (Exception ex)
            //{
            //    string theCap = "";
            //    MessageBox.Show(ex.GetType().ToString(), theCap, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

       

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by Ali \"20180772\" And Mutlaq \"20180361\"","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
