namespace Banking_System
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Admin = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ImternationalGB = new System.Windows.Forms.GroupBox();
            this.AEB = new System.Windows.Forms.Button();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.accountUTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PersonalGB = new System.Windows.Forms.GroupBox();
            this.DWB = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DeposittextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EditInformationB = new System.Windows.Forms.Button();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.OKB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Married = new System.Windows.Forms.RadioButton();
            this.Single = new System.Windows.Forms.RadioButton();
            this.ShowFirstNametextBox = new System.Windows.Forms.TextBox();
            this.ShowAgetextBox = new System.Windows.Forms.TextBox();
            this.ShowLastNametextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WithdrawB = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.ImternationalGB.SuspendLayout();
            this.PersonalGB.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.label4);
            this.Admin.Controls.Add(this.label3);
            this.Admin.Controls.Add(this.label2);
            this.Admin.Controls.Add(this.textBox5);
            this.Admin.Controls.Add(this.textBox4);
            this.Admin.Controls.Add(this.textBox3);
            this.Admin.Controls.Add(this.textBox2);
            this.Admin.Controls.Add(this.dataGridView1);
            this.Admin.Controls.Add(this.label1);
            this.Admin.Location = new System.Drawing.Point(4, 25);
            this.Admin.Margin = new System.Windows.Forms.Padding(4);
            this.Admin.Name = "Admin";
            this.Admin.Padding = new System.Windows.Forms.Padding(4);
            this.Admin.Size = new System.Drawing.Size(965, 484);
            this.Admin.TabIndex = 3;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(80, 348);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(132, 22);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(80, 315);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 282);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 249);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(943, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ImternationalGB);
            this.tabPage2.Controls.Add(this.PersonalGB);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(965, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transactions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ImternationalGB
            // 
            this.ImternationalGB.Controls.Add(this.AEB);
            this.ImternationalGB.Controls.Add(this.AmountTB);
            this.ImternationalGB.Controls.Add(this.label11);
            this.ImternationalGB.Controls.Add(this.accountUTB);
            this.ImternationalGB.Controls.Add(this.label10);
            this.ImternationalGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImternationalGB.Location = new System.Drawing.Point(293, 6);
            this.ImternationalGB.Name = "ImternationalGB";
            this.ImternationalGB.Size = new System.Drawing.Size(267, 224);
            this.ImternationalGB.TabIndex = 1;
            this.ImternationalGB.TabStop = false;
            this.ImternationalGB.Text = "International transaction";
            // 
            // AEB
            // 
            this.AEB.Location = new System.Drawing.Point(186, 195);
            this.AEB.Name = "AEB";
            this.AEB.Size = new System.Drawing.Size(75, 23);
            this.AEB.TabIndex = 5;
            this.AEB.Text = "OK";
            this.AEB.UseVisualStyleBackColor = true;
            this.AEB.Click += new System.EventHandler(this.AEB_Click);
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(32, 155);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(100, 22);
            this.AmountTB.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Enter amount";
            // 
            // accountUTB
            // 
            this.accountUTB.Location = new System.Drawing.Point(32, 58);
            this.accountUTB.Name = "accountUTB";
            this.accountUTB.Size = new System.Drawing.Size(100, 22);
            this.accountUTB.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Enter account username";
            // 
            // PersonalGB
            // 
            this.PersonalGB.Controls.Add(this.WithdrawB);
            this.PersonalGB.Controls.Add(this.DWB);
            this.PersonalGB.Controls.Add(this.Withdraw);
            this.PersonalGB.Controls.Add(this.label9);
            this.PersonalGB.Controls.Add(this.DeposittextBox);
            this.PersonalGB.Controls.Add(this.label8);
            this.PersonalGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalGB.Location = new System.Drawing.Point(9, 6);
            this.PersonalGB.Name = "PersonalGB";
            this.PersonalGB.Size = new System.Drawing.Size(267, 224);
            this.PersonalGB.TabIndex = 0;
            this.PersonalGB.TabStop = false;
            this.PersonalGB.Text = "Personal transaction";
            // 
            // DWB
            // 
            this.DWB.Location = new System.Drawing.Point(172, 58);
            this.DWB.Name = "DWB";
            this.DWB.Size = new System.Drawing.Size(89, 23);
            this.DWB.TabIndex = 4;
            this.DWB.Text = "Deposit";
            this.DWB.UseVisualStyleBackColor = true;
            this.DWB.Click += new System.EventHandler(this.DWB_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.Location = new System.Drawing.Point(13, 155);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(100, 22);
            this.Withdraw.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Withdraw";
            // 
            // DeposittextBox
            // 
            this.DeposittextBox.Location = new System.Drawing.Point(10, 58);
            this.DeposittextBox.Name = "DeposittextBox";
            this.DeposittextBox.Size = new System.Drawing.Size(100, 22);
            this.DeposittextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Deposit";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EditInformationB);
            this.tabPage1.Controls.Add(this.InfoGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(965, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Account";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // EditInformationB
            // 
            this.EditInformationB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditInformationB.Location = new System.Drawing.Point(12, 264);
            this.EditInformationB.Name = "EditInformationB";
            this.EditInformationB.Size = new System.Drawing.Size(147, 23);
            this.EditInformationB.TabIndex = 9;
            this.EditInformationB.Text = "Edit Information";
            this.EditInformationB.UseVisualStyleBackColor = true;
            this.EditInformationB.Click += new System.EventHandler(this.EditInformationB_Click);
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.OKB);
            this.InfoGroupBox.Controls.Add(this.label5);
            this.InfoGroupBox.Controls.Add(this.groupBox1);
            this.InfoGroupBox.Controls.Add(this.ShowFirstNametextBox);
            this.InfoGroupBox.Controls.Add(this.ShowAgetextBox);
            this.InfoGroupBox.Controls.Add(this.ShowLastNametextBox);
            this.InfoGroupBox.Controls.Add(this.label6);
            this.InfoGroupBox.Controls.Add(this.label7);
            this.InfoGroupBox.Enabled = false;
            this.InfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoGroupBox.Location = new System.Drawing.Point(3, 5);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(367, 252);
            this.InfoGroupBox.TabIndex = 8;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Edit information";
            // 
            // OKB
            // 
            this.OKB.Location = new System.Drawing.Point(281, 223);
            this.OKB.Name = "OKB";
            this.OKB.Size = new System.Drawing.Size(75, 23);
            this.OKB.TabIndex = 8;
            this.OKB.Text = "OK";
            this.OKB.UseVisualStyleBackColor = true;
            this.OKB.Click += new System.EventHandler(this.OKB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "First name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Married);
            this.groupBox1.Controls.Add(this.Single);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(157, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 65);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maritial Status";
            // 
            // Married
            // 
            this.Married.AutoSize = true;
            this.Married.Location = new System.Drawing.Point(88, 43);
            this.Married.Name = "Married";
            this.Married.Size = new System.Drawing.Size(84, 21);
            this.Married.TabIndex = 1;
            this.Married.TabStop = true;
            this.Married.Text = "Married";
            this.Married.UseVisualStyleBackColor = true;
            // 
            // Single
            // 
            this.Single.AutoSize = true;
            this.Single.Location = new System.Drawing.Point(7, 43);
            this.Single.Name = "Single";
            this.Single.Size = new System.Drawing.Size(74, 21);
            this.Single.TabIndex = 0;
            this.Single.TabStop = true;
            this.Single.Text = "Single";
            this.Single.UseVisualStyleBackColor = true;
            // 
            // ShowFirstNametextBox
            // 
            this.ShowFirstNametextBox.Location = new System.Drawing.Point(6, 45);
            this.ShowFirstNametextBox.Name = "ShowFirstNametextBox";
            this.ShowFirstNametextBox.Size = new System.Drawing.Size(100, 22);
            this.ShowFirstNametextBox.TabIndex = 4;
            // 
            // ShowAgetextBox
            // 
            this.ShowAgetextBox.Location = new System.Drawing.Point(3, 164);
            this.ShowAgetextBox.Name = "ShowAgetextBox";
            this.ShowAgetextBox.Size = new System.Drawing.Size(100, 22);
            this.ShowAgetextBox.TabIndex = 3;
            // 
            // ShowLastNametextBox
            // 
            this.ShowLastNametextBox.Location = new System.Drawing.Point(6, 107);
            this.ShowLastNametextBox.Name = "ShowLastNametextBox";
            this.ShowLastNametextBox.Size = new System.Drawing.Size(100, 22);
            this.ShowLastNametextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Last name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Admin);
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 513);
            this.tabControl1.TabIndex = 0;
            // 
            // WithdrawB
            // 
            this.WithdrawB.Location = new System.Drawing.Point(172, 155);
            this.WithdrawB.Name = "WithdrawB";
            this.WithdrawB.Size = new System.Drawing.Size(95, 23);
            this.WithdrawB.TabIndex = 5;
            this.WithdrawB.Text = "Withdraw";
            this.WithdrawB.UseVisualStyleBackColor = true;
            this.WithdrawB.Click += new System.EventHandler(this.WithdrawB_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 556);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPage";
            this.Text = "Main page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Admin.ResumeLayout(false);
            this.Admin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ImternationalGB.ResumeLayout(false);
            this.ImternationalGB.PerformLayout();
            this.PersonalGB.ResumeLayout(false);
            this.PersonalGB.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TabPage Admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox ShowFirstNametextBox;
        private System.Windows.Forms.TextBox ShowAgetextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ShowLastNametextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EditInformationB;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.Button OKB;
        private System.Windows.Forms.RadioButton Married;
        private System.Windows.Forms.RadioButton Single;
        private System.Windows.Forms.GroupBox ImternationalGB;
        private System.Windows.Forms.Button AEB;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox accountUTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox PersonalGB;
        private System.Windows.Forms.Button DWB;
        private System.Windows.Forms.TextBox Withdraw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DeposittextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button WithdrawB;
    }
}