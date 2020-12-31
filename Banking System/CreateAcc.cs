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
using System.IO;
namespace Banking_System
{
    public partial class CreateAcc : Form
    {
        public CreateAcc()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        private void CreateAccButton_Click(object sender, EventArgs e)
        {

            if (FirstNameTextBox.Text == "" || LastNameTextBox.Text == "" || AgeTextBox.Text == "" || G == 0 || M == 0 || InitialBalanceTextBox.Text == "")
            {
                MessageBox.Show("Please enter all of the information first", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (NUsernameTextBox.Text == "" || NPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please enter username and password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            else 
            {
                MemoryStream memoryStream = new MemoryStream();
                pictureBox1.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                var image = memoryStream.ToArray();
                string ge = "";
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alimu\Desktop\Banking System\Banking System\Banking System\PersonalDB.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO Personal (FirstName,LastName,Gender," +
                        "MaritialStatus,Age,InitialBalance,Password,Username,Picture)" +
                        " VALUES (@FirstName,@LastName,@Gender,@MaritialStatus,@Age" +
                        ",@InitialBalance,@Password,@Username,@Picture)";
                    
                    cmd.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@LastName", LastNameTextBox.Text);
                    if(MaleRB.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Gender", "Male");
                        ge = "Male";
                    }
                    else if(FemaleRB.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Gender", "Female");
                        ge = "FeMale";
                    }
                    if(MarriedRB.Checked)
                    {
                        cmd.Parameters.AddWithValue("@MaritialStatus", "Married");
                    }
                    else if(SingleRB.Checked)
                        cmd.Parameters.AddWithValue("@MaritialStatus", "Single");
                    cmd.Parameters.AddWithValue("@Age", int.Parse(AgeTextBox.Text));
                    cmd.Parameters.AddWithValue("@InitialBalance", int.Parse(InitialBalanceTextBox.Text));
                    cmd.Parameters.AddWithValue("@Password", NPasswordTextBox.Text);
                    cmd.Parameters.AddWithValue("@Username", NUsernameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Picture", image);
                    cmd.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                   //MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    
            
                        MessageBox.Show("Account created successesfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        MainPage main = new MainPage(NUsernameTextBox.Text, NPasswordTextBox.Text);
                        main.Show();
                    
                }
            }
        }
        
        int M = 0;
        private void MarriedRB_CheckedChanged(object sender, EventArgs e)
        {
            M = 1;
        }

        private void SingleRB_CheckedChanged(object sender, EventArgs e)
        {
            M = 2;
        }
        int G = 0;
        private void MaleRB_CheckedChanged(object sender, EventArgs e)
        {
            G = 1;
        }

        private void FemaleRB_CheckedChanged(object sender, EventArgs e)
        {
            G = 2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dia = new OpenFileDialog();
            var result = dia.ShowDialog();
            if(result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dia.FileName);
            }
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string s = FirstNameTextBox.Text;
            if(s.Length>11)
            {
                
                 FirstNameTextBox.Text = FirstNameTextBox.Text.Substring(0, (FirstNameTextBox.TextLength - 1));
                MessageBox.Show("you can not add more than 11 characters");
            }
            for (int i = 0; i < FirstNameTextBox.Text.Length; i++)
            {
                if (char.IsDigit(FirstNameTextBox.Text[i])||char.IsPunctuation(FirstNameTextBox.Text[i]))
                {
                    FirstNameTextBox.Text = FirstNameTextBox.Text.Substring(0, (FirstNameTextBox.TextLength - 1));
                    MessageBox.Show("you can not add number or symbol to your name","Error",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            
        }

        private void CreateAcc_Activated(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
                         C:\Users\alimu\Desktop\Banking System\Banking System\Banking System\PersonalDB.mdf;Integrated Security=True");
                var sql = "SELECT FirstName, LastName, Age, Gender,MaritialStatus,InitialBalance," +
                    "Password,Username,Picture FROM Personal";
                da = new SqlDataAdapter(sql, con);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //MessageBox.Show("Success");
            }
            
        }

        private void CreateAcc_Load(object sender, EventArgs e)
        {

        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            for(int i=0;i<AgeTextBox.Text.Length;i++)
            {
              if(char.IsLetter(AgeTextBox.Text[i]) || char.IsPunctuation(AgeTextBox.Text[i]))
                {
                    AgeTextBox.Text = AgeTextBox.Text.Substring(0, (AgeTextBox.TextLength - 1));
                    MessageBox.Show("you can not add characters to your age", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string s = LastNameTextBox.Text;
            if (s.Length > 11)
            {               
                LastNameTextBox.Text = LastNameTextBox.Text.Substring(0, (LastNameTextBox.TextLength - 1));
                MessageBox.Show("you can not add more than 11 characters");
            }
            for (int i = 0; i < LastNameTextBox.Text.Length; i++)
            {
                if (char.IsDigit(LastNameTextBox.Text[i]) || char.IsPunctuation(LastNameTextBox.Text[i]))
                {
                    LastNameTextBox.Text = LastNameTextBox.Text.Substring(0, (LastNameTextBox.TextLength - 1));
                    MessageBox.Show("you can not add number or symbol to your name", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void InitialBalanceTextBox_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < InitialBalanceTextBox.Text.Length; i++)
            {
                if (char.IsLetter(InitialBalanceTextBox.Text[i])||
                    char.IsPunctuation(InitialBalanceTextBox.Text[i]))
                {
                    InitialBalanceTextBox.Text = InitialBalanceTextBox.Text.Substring
                        (0, (InitialBalanceTextBox.TextLength - 1));
                    MessageBox.Show("you can not add characters to your Balance", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
