namespace Library_management_system
{
    partial class lms
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lms));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsjshsxt = new System.Windows.Forms.ToolStripMenuItem();
            this.tshs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsjs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsdzgl = new System.Windows.Forms.ToolStripMenuItem();
            this.tszjdz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsxgdzxx = new System.Windows.Forms.ToolStripMenuItem();
            this.tscxdzjylb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsdzjypm = new System.Windows.Forms.ToolStripMenuItem();
            this.tstsgl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsxsrk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsjstt = new System.Windows.Forms.ToolStripMenuItem();
            this.tssbxg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsgy = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsjshsxt,
            this.tsdzgl,
            this.tstsgl,
            this.tsgy});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsjshsxt
            // 
            this.tsjshsxt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tshs,
            this.tsjs});
            this.tsjshsxt.Name = "tsjshsxt";
            this.tsjshsxt.Size = new System.Drawing.Size(126, 21);
            this.tsjshsxt.Text = "借书还书管理（&Q）";
            // 
            // tshs
            // 
            this.tshs.Name = "tshs";
            this.tshs.Size = new System.Drawing.Size(133, 22);
            this.tshs.Text = "还书（&w）";
            this.tshs.Click += new System.EventHandler(this.tshs_Click);
            // 
            // tsjs
            // 
            this.tsjs.Name = "tsjs";
            this.tsjs.Size = new System.Drawing.Size(133, 22);
            this.tsjs.Text = "借书（&E）";
            this.tsjs.Click += new System.EventHandler(this.tsjs_Click);
            // 
            // tsdzgl
            // 
            this.tsdzgl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tszjdz,
            this.tsxgdzxx,
            this.tscxdzjylb,
            this.tsdzjypm});
            this.tsdzgl.Name = "tsdzgl";
            this.tsdzgl.Size = new System.Drawing.Size(100, 21);
            this.tsdzgl.Text = "读者管理（&R）";
            // 
            // tszjdz
            // 
            this.tszjdz.Name = "tszjdz";
            this.tszjdz.Size = new System.Drawing.Size(229, 22);
            this.tszjdz.Text = "增加读者（&t）";
            this.tszjdz.Click += new System.EventHandler(this.tszjdz_Click);
            // 
            // tsxgdzxx
            // 
            this.tsxgdzxx.Name = "tsxgdzxx";
            this.tsxgdzxx.Size = new System.Drawing.Size(229, 22);
            this.tsxgdzxx.Text = "修改读者信息（&Y）";
            this.tsxgdzxx.Click += new System.EventHandler(this.tsxgdzxx_Click);
            // 
            // tscxdzjylb
            // 
            this.tscxdzjylb.Name = "tscxdzjylb";
            this.tscxdzjylb.Size = new System.Drawing.Size(229, 22);
            this.tscxdzjylb.Text = "查询某读者的借阅列表（&U）";
            this.tscxdzjylb.Click += new System.EventHandler(this.tscxdzjylb_Click);
            // 
            // tsdzjypm
            // 
            this.tsdzjypm.Name = "tsdzjypm";
            this.tsdzjypm.Size = new System.Drawing.Size(229, 22);
            this.tsdzjypm.Text = "读者借阅排名（&I）";
            this.tsdzjypm.Click += new System.EventHandler(this.tsdzjypm_Click);
            // 
            // tstsgl
            // 
            this.tstsgl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsxsrk,
            this.tsjstt,
            this.tssbxg});
            this.tstsgl.Name = "tstsgl";
            this.tstsgl.Size = new System.Drawing.Size(102, 21);
            this.tstsgl.Text = "图书管理（&O）";
            // 
            // tsxsrk
            // 
            this.tsxsrk.Name = "tsxsrk";
            this.tsxsrk.Size = new System.Drawing.Size(140, 22);
            this.tsxsrk.Text = "新书入库(&P)";
            this.tsxsrk.Click += new System.EventHandler(this.tsxsrk_Click);
            // 
            // tsjstt
            // 
            this.tsjstt.Name = "tsjstt";
            this.tsjstt.Size = new System.Drawing.Size(140, 22);
            this.tsjstt.Text = "旧书淘汰(&A)";
            this.tsjstt.Click += new System.EventHandler(this.tsjstt_Click);
            // 
            // tssbxg
            // 
            this.tssbxg.Name = "tssbxg";
            this.tssbxg.Size = new System.Drawing.Size(140, 22);
            this.tssbxg.Text = "书本修改(&S)";
            this.tssbxg.Click += new System.EventHandler(this.tssbxg_Click);
            // 
            // tsgy
            // 
            this.tsgy.Name = "tsgy";
            this.tsgy.Size = new System.Drawing.Size(57, 21);
            this.tsgy.Text = "关于(&J)";
            this.tsgy.Click += new System.EventHandler(this.tsgy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("仿宋", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 97);
            this.label1.TabIndex = 1;
            this.label1.Text = "图书管理系统";
            // 
            // lms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 392);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "lms";
            this.Text = "---图书管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsjshsxt;
        private System.Windows.Forms.ToolStripMenuItem tshs;
        private System.Windows.Forms.ToolStripMenuItem tsjs;
        private System.Windows.Forms.ToolStripMenuItem tsdzgl;
        private System.Windows.Forms.ToolStripMenuItem tszjdz;
        private System.Windows.Forms.ToolStripMenuItem tsxgdzxx;
        private System.Windows.Forms.ToolStripMenuItem tscxdzjylb;
        private System.Windows.Forms.ToolStripMenuItem tsdzjypm;
        private System.Windows.Forms.ToolStripMenuItem tstsgl;
        private System.Windows.Forms.ToolStripMenuItem tsxsrk;
        private System.Windows.Forms.ToolStripMenuItem tsjstt;
        private System.Windows.Forms.ToolStripMenuItem tssbxg;
        private System.Windows.Forms.ToolStripMenuItem tsgy;
        private System.Windows.Forms.Label label1;
    }
}

