using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Library.UserInterface
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;		
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button btnBook;
		private System.Windows.Forms.Button btnBorrow;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Button btnQuery;
		private System.Windows.Forms.Button btnExit;
		private string userName;        // ��¼�û�ID
		private string userSort;        // �û�����

		public MainForm(string username,string usersort)
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			this.userName=username;			
			userSort=usersort;
			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnBook = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(360, 160);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(80, 41);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "ͼ����Ϣ";
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.ForeColor = System.Drawing.Color.White;
            this.btnBorrow.Location = new System.Drawing.Point(234, 290);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(86, 39);
            this.btnBorrow.TabIndex = 12;
            this.btnBorrow.Text = "���߽軹��";
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnUser
            // 
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(234, 160);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(86, 41);
            this.btnUser.TabIndex = 13;
            this.btnUser.Text = "�û���Ϣ";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(360, 290);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 39);
            this.btnQuery.TabIndex = 15;
            this.btnQuery.Text = "ͼ���ѯ";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Navy;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(297, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 38);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "�˳�ϵͳ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 47);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(470, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 60);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(521, 449);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ͼ�������Ϣϵͳ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		/*static void Main() 
		{
			Application.Run(new MainForm("andy","andy"));
		}*/

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
            // ���ô��ڱ���
			this.Text="ͼ��ݹ���ϵͳ "+userName;
			if(this.userSort=="system")
			{
                this.btnUser.Show();
				this.btnUser.Enabled=true;
			}			
			else
			{
				this.btnUser.Enabled=false;
                this.btnUser.Hide();
			}
		}


		private void btnQuery_Click(object sender, System.EventArgs e)
		{
			Form QueryForm=new Query();
			QueryForm.Show();		// ShowDialogģʽ�Ի��򣬽������ͣ��������ʾ�Ĵ�����,���Ը���Show
		}



		private void btnUser_Click(object sender, System.EventArgs e)
		{
			Form UserForm=new User();			
			UserForm.Show();
		}

		private void btnBook_Click(object sender, System.EventArgs e)
		{
			Form bookForm=new Book();			
			bookForm.Show();
		}

		private void btnBorrow_Click(object sender, System.EventArgs e)
		{
			Form bookForm=new BorrowReturn();			
			bookForm.Show();
		}


	}
}
