using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Library.UserInterface;
using Library.DataLevel;

namespace Library.UserInterface
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class BorrowReturn : System.Windows.Forms.Form
	{
		private DataSet dataSet1=new DataSet();
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnBorrow;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.TextBox textInformation;
		private System.Windows.Forms.Label lblReaderID;
		private System.Windows.Forms.Label lblBookID;
		private System.Windows.Forms.Label lblInfomation;		
		private System.Windows.Forms.TextBox textReaderID;
		private System.Windows.Forms.TextBox textBookID;
        private DataGridView dataGridView1;

        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.Container components = null;		

		public BorrowReturn()
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
				if (components != null) 
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
            this.btnExit = new System.Windows.Forms.Button();
            this.textReaderID = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.textBookID = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.textInformation = new System.Windows.Forms.TextBox();
            this.lblReaderID = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblInfomation = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(533, 32);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出窗口";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textReaderID
            // 
            this.textReaderID.Location = new System.Drawing.Point(80, 16);
            this.textReaderID.Name = "textReaderID";
            this.textReaderID.Size = new System.Drawing.Size(96, 21);
            this.textReaderID.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(192, 32);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 32);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "借阅记录";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(399, 32);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 32);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "借阅图书";
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // textBookID
            // 
            this.textBookID.Location = new System.Drawing.Point(80, 56);
            this.textBookID.Name = "textBookID";
            this.textBookID.Size = new System.Drawing.Size(96, 21);
            this.textBookID.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(295, 32);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 32);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "归还图书";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // textInformation
            // 
            this.textInformation.Enabled = false;
            this.textInformation.Location = new System.Drawing.Point(8, 160);
            this.textInformation.Multiline = true;
            this.textInformation.Name = "textInformation";
            this.textInformation.Size = new System.Drawing.Size(130, 139);
            this.textInformation.TabIndex = 7;
            // 
            // lblReaderID
            // 
            this.lblReaderID.Location = new System.Drawing.Point(8, 24);
            this.lblReaderID.Name = "lblReaderID";
            this.lblReaderID.Size = new System.Drawing.Size(56, 16);
            this.lblReaderID.TabIndex = 8;
            this.lblReaderID.Text = "读者号码";
            // 
            // lblBookID
            // 
            this.lblBookID.Location = new System.Drawing.Point(8, 56);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(56, 16);
            this.lblBookID.TabIndex = 9;
            this.lblBookID.Text = "图书号码";
            // 
            // lblInfomation
            // 
            this.lblInfomation.Location = new System.Drawing.Point(40, 128);
            this.lblInfomation.Name = "lblInfomation";
            this.lblInfomation.Size = new System.Drawing.Size(56, 16);
            this.lblInfomation.TabIndex = 10;
            this.lblInfomation.Text = "信息提示";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(157, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(612, 254);
            this.dataGridView1.TabIndex = 11;
            // 
            // BorrowReturn
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(814, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblInfomation);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblReaderID);
            this.Controls.Add(this.textInformation);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.textBookID);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.textReaderID);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BorrowReturn";
            this.Text = "读者借还书";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion

     
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
		
		public void ErrorHandle(System.Exception E)
		{
			MessageBox.Show(E.ToString());
		}	

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnBorrow_Click(object sender, System.EventArgs e)
		{
           
            if(BorrowBookNumber(this.textBookID.Text)==0)
            {
                this.textInformation.Text = "库存不足，借阅失败";
                return;
            }
            if(ReaderBrrowedNumber(this.textReaderID.Text)>=7)
            {
                this.textInformation.Text = "达到借阅上限,借阅失败";
                return;
            }
            BorrowBook(this.textBookID.Text);
            BorrowReader(this.textReaderID.Text);
            string sql = @"insert into BorrowBook values(@ReaderID,@BookID,@BorrowDate,@ReturnDate,NULL)";
            SqlParameter[] pms = new SqlParameter[]
           {
                new SqlParameter("@ReaderID",SqlDbType.Char,6){Value = textReaderID.Text},
                new SqlParameter("@BookID",SqlDbType.Char,10){Value = textBookID.Text},
                new SqlParameter("@BorrowDate",SqlDbType.DateTime,8){Value = System.DateTime.Today},
                new SqlParameter("@ReturnDate",SqlDbType.DateTime,8){Value = DateTime.Today.AddMonths(1)}
           };
            int w = SqlHelper.ExecuteNonQuery(sql,CommandType.Text, pms);
            if(w>0)
                this.textInformation.Text = this.textReaderID.Text + "借阅图书" + this.textBookID.Text + "成功";
        }

       

        private void BorrowReader(string ReaderID)
        {
            SqlParameter[] pms = new SqlParameter[]
           {
                new SqlParameter("@ReaderID",SqlDbType.Char,10){Value = ReaderID}
           };
            SqlHelper.ExecuteNonQuery("StoredProcBorrowReader", CommandType.StoredProcedure, pms);
        }

        private void BorrowBook(string BookID)
        {
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@BookID",SqlDbType.Char,10){Value = BookID}
            };
            SqlHelper.ExecuteNonQuery("StoredProcBorrowBook", CommandType.StoredProcedure, pms);  
        }

        private int ReaderBrrowedNumber(string ReadID)
        {
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@ReaderID",SqlDbType.Char,10){Value = ReadID},
                new SqlParameter("@BorrowedNumber",SqlDbType.Int){Direction=ParameterDirection.Output}
            };
            SqlHelper.ExecuteNonQuery("StoredProcReaderBrrowedNumber", CommandType.StoredProcedure, pms);
            return Convert.ToInt32(pms[1].Value);
        }

        private int BorrowBookNumber(string BookID)
        {
            SqlParameter[] pms = new SqlParameter[]
              {
                    new SqlParameter("@BookID",SqlDbType.Char,6){Value = BookID},
                    new SqlParameter("@BookNumber",SqlDbType.Int){Direction=ParameterDirection.Output}
               };


            SqlHelper.ExecuteNonQuery("StoredProcBookNumber", CommandType.StoredProcedure, pms);
            return Convert.ToInt32(pms[1].Value);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string sql = "select ReaderID,BookID,BorrowDate,ReturnDate,FactReturnDate from BorrowBook where ReaderID=@ReaderID";
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@ReaderID",SqlDbType.Char,6){Value = textReaderID.Text}
            };
            DataTable dt;
            dt = SqlHelper.ExecuteDataTable(sql,CommandType.Text, pms);
            if(dt.Rows.Count>0)
            {
                this.dataGridView1.DataSource = dt;
                this.textInformation.Text = "查询读者: " + this.textReaderID.Text + "记录" + "成功";
            }
            else
            {
                this.dataGridView1.DataSource = dt;
                this.textInformation.Text = "无借阅记录";
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnBook(this.textBookID.Text);
            ReturnReader(textReaderID.Text);
            string sql = @"update BorrowBook
SET FactReturnDate = GETDATE() Where ReaderID = @ReaderID AND BookID = @BookID";
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@ReaderID",SqlDbType.Char,6){Value = textReaderID.Text},
                new SqlParameter("@BookID",SqlDbType.Char,10){Value = textBookID.Text}
            };
            SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);
            this.textInformation.Text = "还书成功!";

        }

        private void ReturnReader(string ReaderID)
        {
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@ReaderID",SqlDbType.Char,10){Value = ReaderID}
            };
            SqlHelper.ExecuteNonQuery("StoredProcReturnReader", CommandType.StoredProcedure, pms);
        }

        private void ReturnBook(string BookID)
        {
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@BookID",SqlDbType.Char,10){Value = BookID}
            };
            SqlHelper.ExecuteNonQuery("StoredProcReturnBook", CommandType.StoredProcedure, pms);
        }
    }
}
