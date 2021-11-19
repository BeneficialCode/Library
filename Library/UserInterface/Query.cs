using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Library.UserInterface;
using Library.DataLevel;

namespace Library
{
	/// <summary>
	/// Query ��ժҪ˵����
	/// </summary>
	public class Query : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnFuzzyQuery;
		public string SqlString;
		public string OrderString;
		public string QueryString;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand4;
        private Button btnQuery2;
        private TextBox textValue;
        private DataGridView dataGridView1;
        private Label lblResult;

        /// <summary>
        /// ����������������
        /// </summary>
        private System.ComponentModel.Container components = null;

		public Query()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

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
				if(components != null)
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFuzzyQuery = new System.Windows.Forms.Button();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sqlInsertCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.textValue = new System.Windows.Forms.TextBox();
            this.btnQuery2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(578, 26);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 24);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "����";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(578, 71);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 24);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "�˳�";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFuzzyQuery
            // 
            this.btnFuzzyQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuzzyQuery.Location = new System.Drawing.Point(44, 64);
            this.btnFuzzyQuery.Name = "btnFuzzyQuery";
            this.btnFuzzyQuery.Size = new System.Drawing.Size(114, 23);
            this.btnFuzzyQuery.TabIndex = 11;
            this.btnFuzzyQuery.Text = "ģ����ѯ";
            this.btnFuzzyQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuery2);
            this.groupBox1.Controls.Add(this.textValue);
            this.groupBox1.Controls.Add(this.btnFuzzyQuery);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 96);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "��ѯ����";
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(18, 21);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(383, 21);
            this.textValue.TabIndex = 7;
            // 
            // btnQuery2
            // 
            this.btnQuery2.Location = new System.Drawing.Point(220, 64);
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Size = new System.Drawing.Size(127, 23);
            this.btnQuery2.TabIndex = 12;
            this.btnQuery2.Text = "��ȷ����";
            this.btnQuery2.UseVisualStyleBackColor = true;
            this.btnQuery2.Click += new System.EventHandler(this.btnQuery2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(630, 230);
            this.dataGridView1.TabIndex = 14;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 107);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(41, 12);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "label1";
            // 
            // Query
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(649, 373);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Query";
            this.Text = "ͼ���ѯ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion


        //static void Main()
        //{
        //    Application.Run(new Query());
        //}



        private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		private void btnClear_Click(object sender, System.EventArgs e)
		{
			this.textValue.Text="";
		}

		private void btnQuery_Click(object sender, System.EventArgs e)
		{
            string sql = @"Select BookID as �鼮���,BookName as �鼮����, BookWriter as ����,
BookPublish as ������, BookPublishDate as ����ʱ��, BookPrice as ͼ��۸�,BookSort as ͼ�����, BookAmount as ͼ����,BookRemain as �������Ŀ 
from Book where BookName Like '%"+ textValue.Text+ "%'";
            DataTable dt;
            dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text, null);
            if (dt.Rows.Count > 0)
            {
                this.dataGridView1.DataSource = dt;
                this.lblResult.Text = "���ҳɹ�!";
            }
            else
            {
                this.dataGridView1.DataSource = dt;
                this.lblResult.Text = "ʲôҲû�ҵ�!";
            }
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            string sql = @"Select BookID as �鼮���,BookName as �鼮����, BookWriter as ����,
BookPublish as ������, BookPublishDate as ����ʱ��, BookPrice as ͼ��۸�,BookSort as ͼ�����, BookAmount as ͼ����,BookRemain as �������Ŀ
from Book where BookName = @BookName";
            SqlParameter pms = new SqlParameter("@BookName", SqlDbType.Char, 20) { Value = textValue.Text };
            DataTable dt;
            dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text, pms);
            if (dt.Rows.Count > 0)
            {
                this.dataGridView1.DataSource = dt;
                this.lblResult.Text = "���ҳɹ�!";
            }
            else
            {
                this.dataGridView1.DataSource = dt;
                this.lblResult.Text = "ʲôҲû�ҵ�!";
            }
        }
    }
}
