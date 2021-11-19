using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Library.UserInterface;
using System.Data.SqlClient;
using System.Data;
using Library.DataLevel;

namespace Library
{
	/// <summary>
	/// User 的摘要说明。
	/// </summary>
	public class User : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblDatasetInfo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textSort;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.TextBox textPassword;
        private Button btn_Query;

        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.Container components = null;

		public User()
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
            this.lblDatasetInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textSort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btn_Query = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatasetInfo
            // 
            this.lblDatasetInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDatasetInfo.BackColor = System.Drawing.Color.White;
            this.lblDatasetInfo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDatasetInfo.Location = new System.Drawing.Point(6, 24);
            this.lblDatasetInfo.Name = "lblDatasetInfo";
            this.lblDatasetInfo.Size = new System.Drawing.Size(130, 24);
            this.lblDatasetInfo.TabIndex = 25;
            this.lblDatasetInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Query);
            this.groupBox1.Controls.Add(this.lblDatasetInfo);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.textSort);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(8, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 176);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息维护";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(104, 88);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(128, 23);
            this.textPassword.TabIndex = 14;
            // 
            // textSort
            // 
            this.textSort.Location = new System.Drawing.Point(104, 120);
            this.textSort.Name = "textSort";
            this.textSort.Size = new System.Drawing.Size(128, 23);
            this.textSort.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(24, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "用户类别";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(104, 56);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(130, 23);
            this.textId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户密码";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(320, 176);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 32);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnModify);
            this.groupBox3.Location = new System.Drawing.Point(280, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 120);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "编辑记录";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(40, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 24);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(40, 67);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(56, 24);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "修改";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(159, 24);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 26;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // User
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(448, 237);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User";
            this.Text = "用户信息维护";
            this.Load += new System.EventHandler(this.User_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion


		private void btnAdd_Click(object sender, System.EventArgs e)
		{
            string sql = @"INSERT INTO [UserSet] Values (@UserName, @UserPassword,@UserSort)";
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@UserName",SqlDbType.Char,10){Value=textId.Text},
                new SqlParameter("@UserPassword",SqlDbType.Char,10){Value=textPassword.Text},
                new SqlParameter("@UserSort",SqlDbType.Char,10){Value=textSort.Text}
            };
            int w = SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);
            if (w > 0)
                lblDatasetInfo.Text = "添加成功!";
            else
                lblDatasetInfo.Text = "添加失败!";
        }

		
		private void btnModify_Click(object sender, System.EventArgs e)
		{
            string sql = "UPDATE [UserSet] SET UserPwd = @UserPassword where UserId = @UserId";
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@UserId",SqlDbType.Char,10){Value=textId.Text},
                new SqlParameter("@UserPassword",SqlDbType.Char,10){Value=textPassword.Text}
            };
            int w = SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);
            if (w > 0)
                lblDatasetInfo.Text = "修改成功!";
            else
                lblDatasetInfo.Text = "修改失败!";
            btnModify.Enabled = false;
        }


		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

        private void User_Load(object sender, EventArgs e)
        {
            textSort.Text = "User";
            textSort.Enabled = false;
            btnModify.Enabled = false;
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            string sql = "Select UserSort from UserSet where UserID=@uid and UserPwd=@pwd";
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@uid",SqlDbType.Char,10){Value=textId.Text.Trim()},
                new SqlParameter("@pwd",SqlDbType.Char,10){Value=textPassword.Text}
            };
            string r = (string)SqlHelper.ExecuteScalar(sql, CommandType.Text, pms);
            if (r != null)
            {
                btnModify.Enabled = true;
                textId.Enabled = false;
            }
            else
            {
                lblDatasetInfo.Text = "用户不存在";
            }
        }
    }
}
