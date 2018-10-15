namespace Library_management_system
{
    partial class dzjylb
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lbxh = new System.Windows.Forms.Label();
            this.lbxm = new System.Windows.Forms.Label();
            this.lbjymx = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbdh = new System.Windows.Forms.Label();
            this.lbzy = new System.Windows.Forms.Label();
            this.lbyx = new System.Windows.Forms.Label();
            this.lbxb = new System.Windows.Forms.Label();
            this.lbbj = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 83;
            this.label7.Text = "姓名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 82;
            this.label6.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 81;
            this.label5.Text = "院系";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 80;
            this.label4.Text = "专业";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 79;
            this.label3.Text = "班级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 78;
            this.label2.Text = "联系电话";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 77;
            this.label1.Text = "学号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStudent);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 168);
            this.groupBox1.TabIndex = 75;
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
            this.dgvStudent.Location = new System.Drawing.Point(6, 12);
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
            // lbxh
            // 
            this.lbxh.AutoSize = true;
            this.lbxh.Location = new System.Drawing.Point(113, 206);
            this.lbxh.Name = "lbxh";
            this.lbxh.Size = new System.Drawing.Size(23, 12);
            this.lbxh.TabIndex = 84;
            this.lbxh.Text = "*-*";
            // 
            // lbxm
            // 
            this.lbxm.AutoSize = true;
            this.lbxm.Location = new System.Drawing.Point(321, 206);
            this.lbxm.Name = "lbxm";
            this.lbxm.Size = new System.Drawing.Size(23, 12);
            this.lbxm.TabIndex = 85;
            this.lbxm.Text = "*-*";
            // 
            // lbjymx
            // 
            this.lbjymx.AutoSize = true;
            this.lbjymx.Location = new System.Drawing.Point(324, 427);
            this.lbjymx.Name = "lbjymx";
            this.lbjymx.Size = new System.Drawing.Size(23, 12);
            this.lbjymx.TabIndex = 86;
            this.lbjymx.Text = "*_*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 87;
            this.label11.Text = "借阅明细：";
            // 
            // lbdh
            // 
            this.lbdh.AutoSize = true;
            this.lbdh.Location = new System.Drawing.Point(107, 329);
            this.lbdh.Name = "lbdh";
            this.lbdh.Size = new System.Drawing.Size(23, 12);
            this.lbdh.TabIndex = 88;
            this.lbdh.Text = "*-*";
            // 
            // lbzy
            // 
            this.lbzy.AutoSize = true;
            this.lbzy.Location = new System.Drawing.Point(107, 289);
            this.lbzy.Name = "lbzy";
            this.lbzy.Size = new System.Drawing.Size(23, 12);
            this.lbzy.TabIndex = 89;
            this.lbzy.Text = "*-*";
            // 
            // lbyx
            // 
            this.lbyx.AutoSize = true;
            this.lbyx.Location = new System.Drawing.Point(315, 248);
            this.lbyx.Name = "lbyx";
            this.lbyx.Size = new System.Drawing.Size(23, 12);
            this.lbyx.TabIndex = 90;
            this.lbyx.Text = "*-*";
            // 
            // lbxb
            // 
            this.lbxb.AutoSize = true;
            this.lbxb.Location = new System.Drawing.Point(107, 248);
            this.lbxb.Name = "lbxb";
            this.lbxb.Size = new System.Drawing.Size(23, 12);
            this.lbxb.TabIndex = 91;
            this.lbxb.Text = "*-*";
            // 
            // lbbj
            // 
            this.lbbj.AutoSize = true;
            this.lbbj.Location = new System.Drawing.Point(315, 289);
            this.lbbj.Name = "lbbj";
            this.lbbj.Size = new System.Drawing.Size(23, 12);
            this.lbbj.TabIndex = 92;
            this.lbbj.Text = "*-*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 93;
            this.button1.Text = "借阅排名";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dzjylb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbbj);
            this.Controls.Add(this.lbxb);
            this.Controls.Add(this.lbyx);
            this.Controls.Add(this.lbzy);
            this.Controls.Add(this.lbdh);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbjymx);
            this.Controls.Add(this.lbxm);
            this.Controls.Add(this.lbxh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "dzjylb";
            this.Text = "dzjylb";
            this.Load += new System.EventHandler(this.dzjylb_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn s;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label lbxh;
        private System.Windows.Forms.Label lbxm;
        private System.Windows.Forms.Label lbjymx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbdh;
        private System.Windows.Forms.Label lbzy;
        private System.Windows.Forms.Label lbyx;
        private System.Windows.Forms.Label lbxb;
        private System.Windows.Forms.Label lbbj;
        private System.Windows.Forms.Button button1;
    }
}