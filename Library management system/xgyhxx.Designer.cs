namespace Library_management_system
{
    partial class xgyhxx
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxg = new System.Windows.Forms.Button();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtyx = new System.Windows.Forms.TextBox();
            this.txtzy = new System.Windows.Forms.TextBox();
            this.txtiPhone = new System.Windows.Forms.TextBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtyj = new System.Windows.Forms.TextBox();
            this.txtwj = new System.Windows.Forms.TextBox();
            this.wei = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStudent);
            this.groupBox1.Location = new System.Drawing.Point(9, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 168);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.s,
            this.Column8});
            this.dgvStudent.Location = new System.Drawing.Point(6, 20);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowTemplate.Height = 23;
            this.dgvStudent.Size = new System.Drawing.Size(380, 150);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ReadID";
            this.id.HeaderText = "学号";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ReadName";
            this.Column1.HeaderText = "姓名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Gender";
            this.Column2.HeaderText = "性别";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Readschool";
            this.Column3.HeaderText = "院系";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ReadPrgram";
            this.Column4.HeaderText = "专业";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ReadClass";
            this.Column5.HeaderText = "班级";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ReadIphone";
            this.Column6.HeaderText = "联系电话";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // s
            // 
            this.s.DataPropertyName = "CBBooks";
            this.s.HeaderText = "已借图书";
            this.s.Name = "s";
            this.s.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NBBooks";
            this.Column8.HeaderText = "未借图书";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnxg
            // 
            this.btnxg.Location = new System.Drawing.Point(301, 552);
            this.btnxg.Name = "btnxg";
            this.btnxg.Size = new System.Drawing.Size(75, 23);
            this.btnxg.TabIndex = 55;
            this.btnxg.Text = "信息修改";
            this.btnxg.UseVisualStyleBackColor = true;
            this.btnxg.Click += new System.EventHandler(this.btnxg_Click);
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbgender.Location = new System.Drawing.Point(122, 308);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(100, 20);
            this.cbgender.TabIndex = 70;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(122, 266);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 69;
            // 
            // txtyx
            // 
            this.txtyx.Location = new System.Drawing.Point(122, 359);
            this.txtyx.Name = "txtyx";
            this.txtyx.Size = new System.Drawing.Size(100, 21);
            this.txtyx.TabIndex = 68;
            // 
            // txtzy
            // 
            this.txtzy.Location = new System.Drawing.Point(122, 403);
            this.txtzy.Name = "txtzy";
            this.txtzy.Size = new System.Drawing.Size(100, 21);
            this.txtzy.TabIndex = 67;
            // 
            // txtiPhone
            // 
            this.txtiPhone.Location = new System.Drawing.Point(122, 491);
            this.txtiPhone.Name = "txtiPhone";
            this.txtiPhone.Size = new System.Drawing.Size(100, 21);
            this.txtiPhone.TabIndex = 66;
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(122, 445);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(100, 21);
            this.txtclass.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 64;
            this.label7.Text = "姓名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 63;
            this.label6.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 62;
            this.label5.Text = "院系";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 61;
            this.label4.Text = "专业";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "班级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 59;
            this.label2.Text = "联系电话";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 58;
            this.label1.Text = "学号";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(122, 225);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 21);
            this.txtid.TabIndex = 57;
            // 
            // txtyj
            // 
            this.txtyj.Location = new System.Drawing.Point(122, 528);
            this.txtyj.Name = "txtyj";
            this.txtyj.Size = new System.Drawing.Size(100, 21);
            this.txtyj.TabIndex = 71;
            // 
            // txtwj
            // 
            this.txtwj.Location = new System.Drawing.Point(122, 574);
            this.txtwj.Name = "txtwj";
            this.txtwj.Size = new System.Drawing.Size(100, 21);
            this.txtwj.TabIndex = 72;
            // 
            // wei
            // 
            this.wei.AutoSize = true;
            this.wei.Location = new System.Drawing.Point(31, 577);
            this.wei.Name = "wei";
            this.wei.Size = new System.Drawing.Size(77, 12);
            this.wei.TabIndex = 73;
            this.wei.Text = "可借书本数量";
            this.wei.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 528);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 74;
            this.label9.Text = "已借书本数量";
            // 
            // xgyhxx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 607);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.wei);
            this.Controls.Add(this.txtwj);
            this.Controls.Add(this.txtyj);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtyx);
            this.Controls.Add(this.txtzy);
            this.Controls.Add(this.txtiPhone);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnxg);
            this.Name = "xgyhxx";
            this.Text = "---修改学生信息";
            this.Load += new System.EventHandler(this.xgyhxx_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnxg;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtyx;
        private System.Windows.Forms.TextBox txtzy;
        private System.Windows.Forms.TextBox txtiPhone;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn s;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txtyj;
        private System.Windows.Forms.TextBox txtwj;
        private System.Windows.Forms.Label wei;
        private System.Windows.Forms.Label label9;
    }
}