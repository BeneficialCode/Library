using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Library.UserInterface;
using System.Data.SqlClient;
using System.Data;
using Library.DataLevel;

namespace Library.UserInterface
{
	/// <summary>
	/// Book 的摘要说明。
	/// </summary>
	public class Book : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textId;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;		
		private System.Windows.Forms.TextBox textWriter;
		private System.Windows.Forms.TextBox textPublish;
		private System.Windows.Forms.TextBox textPublishDate;
		private System.Windows.Forms.TextBox textSort;
		private System.Windows.Forms.TextBox textRemain;
		private System.Windows.Forms.TextBox textPrice;
		private System.Windows.Forms.TextBox textAmount;
        private Label lblInfo;
        private Button btnQuery;
        private Label label10;
        private Label label11;


        //private Library.DataSetBook objDataSetBook;
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.Container components = null;

		public Book()
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
        /// 
        //static void Main()
        //{
        //    Application.Run(new Book());
        //}
        private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textRemain = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textWriter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textPublish = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPublishDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textSort = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(218, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 24);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textAmount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textPrice);
            this.groupBox1.Controls.Add(this.textRemain);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textWriter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textPublish);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textPublishDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textSort);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 216);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书信息维护";
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(336, 144);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(104, 23);
            this.textAmount.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(272, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "总册数";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(96, 174);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(82, 23);
            this.textPrice.TabIndex = 29;
            // 
            // textRemain
            // 
            this.textRemain.Location = new System.Drawing.Point(336, 176);
            this.textRemain.Name = "textRemain";
            this.textRemain.Size = new System.Drawing.Size(104, 23);
            this.textRemain.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(24, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "图书价钱";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(272, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "库存量";
            // 
            // textWriter
            // 
            this.textWriter.Location = new System.Drawing.Point(96, 140);
            this.textWriter.Name = "textWriter";
            this.textWriter.Size = new System.Drawing.Size(117, 23);
            this.textWriter.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(24, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "图书作者";
            // 
            // textPublish
            // 
            this.textPublish.Location = new System.Drawing.Point(259, 40);
            this.textPublish.Name = "textPublish";
            this.textPublish.Size = new System.Drawing.Size(181, 23);
            this.textPublish.TabIndex = 10;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(96, 106);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(146, 23);
            this.textName.TabIndex = 8;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(96, 72);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(104, 23);
            this.textId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(256, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "图书分类";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "图书名称";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书号码";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(186, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "出版社";
            // 
            // textPublishDate
            // 
            this.textPublishDate.Location = new System.Drawing.Point(336, 72);
            this.textPublishDate.Name = "textPublishDate";
            this.textPublishDate.Size = new System.Drawing.Size(80, 23);
            this.textPublishDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(256, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "出版时间";
            // 
            // textSort
            // 
            this.textSort.Location = new System.Drawing.Point(336, 112);
            this.textSort.Name = "textSort";
            this.textSort.Size = new System.Drawing.Size(104, 23);
            this.textSort.TabIndex = 11;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.Location = new System.Drawing.Point(72, 39);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(96, 24);
            this.lblInfo.TabIndex = 25;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(157, 63);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 32);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQuery);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnModify);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Location = new System.Drawing.Point(24, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 105);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "编辑记录";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(318, 24);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 24);
            this.btnQuery.TabIndex = 29;
            this.btnQuery.Text = "检索";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(24, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 24);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(122, 24);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(56, 24);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "修改";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 14);
            this.label10.TabIndex = 32;
            this.label10.Text = "(通过图书号码先检索，后进行增删改操作）";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 33;
            this.label11.Text = "Result:";
            // 
            // Book
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(512, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Book";
            this.Text = "图书信息维护";
            this.Load += new System.EventHandler(this.Book_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            string sql = "INSERT INTO Book Values(@BookID, @BookName, @BookWriter, @BookPublish, @BookPublishDate, @BookPrice, @BookSort, @BookAmount, @BookRemain);";
            SqlParameter[] pms = new SqlParameter[]
           {
                new SqlParameter("@BookID",SqlDbType.VarChar,10){Value=textId.Text},
                new SqlParameter("@BookName",SqlDbType.VarChar,30){Value=textName.Text},
                new SqlParameter("@BookWriter",SqlDbType.VarChar,20){Value = textWriter.Text},
                new SqlParameter("@BookPublish",SqlDbType.VarChar,50){Value = textPublish.Text},
                new SqlParameter("@BookPublishDate",SqlDbType.DateTime,8){Value = textPublishDate.Text},
                new SqlParameter("@BookPrice",SqlDbType.Float,8){Value = textPrice.Text},
                new SqlParameter("@BookSort",SqlDbType.VarChar,20){Value = textSort.Text},
                new SqlParameter("@BookAmount",SqlDbType.Int,4){Value = textAmount.Text},
                new SqlParameter("@BookRemain",SqlDbType.Int,4){Value = textRemain.Text }
           };
            int w = SqlHelper.ExecuteNonQuery(sql,CommandType.Text, pms);
            if (w > 0)
                lblInfo.Text = "添加成功!";
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            
            lblInfo.Text = "";
            string sql = @"UPDATE Book SET BookID = @BookID, BookName = @BookName, BookWriter = @BookWriter, BookPublish = @BookPublish, BookPublishDate = @BookPublishDate, BookPrice = @BookPrice, BookSort = @BookSort, BookAmount = @BookAmount, BookRemain = @BookRemain 
where (@Original_BookID = BookID);";
          
            if(MessageBox.Show("确定要修改吗？","确定修改",MessageBoxButtons.OKCancel,MessageBoxIcon.Question).Equals(DialogResult.OK))
            {
                SqlParameter[] pms = new SqlParameter[]
                {
                    new SqlParameter("@Original_BookID",SqlDbType.VarChar,10){Value =           OrignalBookInfo.Orignal_BookID                 },
                    new SqlParameter("BookID",SqlDbType.VarChar,10){Value =           textId.Text           },
                    new SqlParameter("BookName",SqlDbType.VarChar,30){Value=          textName.Text         },
                    new SqlParameter("BookWriter",SqlDbType.VarChar,20){Value =       textWriter.Text       },
                    new SqlParameter("BookPublish",SqlDbType.VarChar,50){Value =      textPublish.Text      },
                    new SqlParameter("BookPublishDate",SqlDbType.DateTime,8){Value =  textPublishDate.Text  },
                    new SqlParameter("BookPrice",SqlDbType.Float,8){Value =           Double.Parse(textPrice.Text)        },
                    new SqlParameter("BookSort",SqlDbType.VarChar,20){Value =         textSort.Text         },
                    new SqlParameter("BookAmount",SqlDbType.Int,4){Value =            Int32.Parse(textAmount.Text)       },
                    new SqlParameter("BookRemain",SqlDbType.Int,4){   Value =         Int32.Parse(textRemain.Text)       }
                };

                int w = SqlHelper.ExecuteNonQuery(sql,CommandType.Text, pms);
                if (w > 0)
                    lblInfo.Text = "修改成功";
                btnModify.Enabled = false;
                return;
            }
            else
            {
                btnModify.Enabled = false;
                return;
            }

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sql = "SELECT BookID, BookName, BookWriter, BookPublish, BookPublishDate, BookPrice, Boo" +
                "kSort, BookAmount, BookRemain FROM Book where BookID=@BookID";
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("BookID",SqlDbType.VarChar,10){Value = textId.Text}
            };
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql,CommandType.Text, pms))
            {
                if (reader.HasRows)
                {
                    lblInfo.Text = "查询成功!";
                    while (reader.Read())
                    {
                       textId.Text          = reader.GetString(0);
                       textName.Text        = reader.GetString(1);
                       textWriter.Text      = reader.GetString(2);
                       textPublish.Text     = reader.GetString(3);
                       textPublishDate.Text = reader.GetDateTime(4).ToString();
                       textPrice.Text       = reader.GetDouble(5).ToString();
                       textSort.Text        = reader.GetString(6);
                       textAmount.Text      = reader.GetInt32(7).ToString();
                       textRemain.Text      = reader.GetInt32(8).ToString();
                       OrignalBookInfo.Orignal_BookID          = textId.Text;
        
                    }
                    btnDelete.Enabled = true;
                    btnAdd.Enabled = true;
                    btnModify.Enabled = true;
                }
               else
               {
                    lblInfo.Text = "查询失败!";
               }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM Book WHERE (BookID = @Original_BookID)";
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@Original_BookID",SqlDbType.VarChar,10){Value = OrignalBookInfo.Orignal_BookID  }
            };
            SqlHelper.ExecuteNonQuery(sql, CommandType.Text,pms);
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
        }
        private void Book_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }      
}          
           
           
           
           
           