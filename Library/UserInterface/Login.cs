using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Library.UserInterface;
using Library.DataLevel;

namespace Library
{
	/// <summary>
	/// Login 的摘要说明。
	/// </summary>
	public class Login : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.TextBox textUserID;
		private System.Windows.Forms.TextBox textUserPassword;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lbltitle;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Login()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.textUserID = new System.Windows.Forms.TextBox();
            this.textUserPassword = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUser.Location = new System.Drawing.Point(72, 88);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(56, 23);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "用户";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassword.Location = new System.Drawing.Point(72, 136);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 23);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "密码";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(147, 192);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 24);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "注册\\修改密码";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // textUserID
            // 
            this.textUserID.Location = new System.Drawing.Point(124, 88);
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(140, 21);
            this.textUserID.TabIndex = 0;
            // 
            // textUserPassword
            // 
            this.textUserPassword.Location = new System.Drawing.Point(124, 136);
            this.textUserPassword.Name = "textUserPassword";
            this.textUserPassword.PasswordChar = '*';
            this.textUserPassword.Size = new System.Drawing.Size(140, 21);
            this.textUserPassword.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(46, 192);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 24);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "登录";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltitle.Location = new System.Drawing.Point(120, 48);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(96, 23);
            this.lbltitle.TabIndex = 8;
            this.lbltitle.Text = "登录系统";
            // 
            // Login
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(320, 253);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textUserPassword);
            this.Controls.Add(this.textUserID);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "图书馆管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion

        static void Main()
        {
            Application.Run(new Login());
        }



		private void btnOk_Click(object sender, System.EventArgs e)
		{
            string usersort;
            usersort = UserCheck(this.textUserID.Text, this.textUserPassword.Text);

            if (usersort =="admin")
			{
				
				this.Visible=false;
				Form mainform=new MainForm(this.textUserID.Text,"system");
				mainform.ShowDialog();
				this.Close();
			}
			else if(usersort =="user")
			{
				this.Visible=false;
				Form mainform=new MainForm(this.textUserID.Text,"user");
				mainform.ShowDialog();				
				this.Close();
			}
			else
			{
				if(MessageBox.Show("输入用户密码有误，是否重新登陆","输入有误",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
				{
					this.textUserID.Clear();
					this.textUserPassword.Clear();
					//this.textUserID.();
				}
				else
				{
					this.Close();
				}
			}
		}
		
		string UserCheck(string username,string userpassword)
		{
			string usersort;	
			usersort="nobody";
            string sql = "Select UserSort from UserSet where UserID=@uid and UserPwd=@pwd";
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@uid",SqlDbType.Char,10){Value=textUserID.Text.Trim()},
                new SqlParameter("@pwd",SqlDbType.Char,10){Value=textUserPassword.Text}
            };
            string r = (string)SqlHelper.ExecuteScalar(sql,CommandType.Text, pms);
            if(r!=null)
            {
                usersort = r;
            }
            return usersort;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form UserForm = new User();
            UserForm.Show();
        }
    }
}
