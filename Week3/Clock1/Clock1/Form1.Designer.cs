﻿
namespace Clock1
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dtboxTimer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.dtboxTime = new System.Windows.Forms.DateTimePicker();
            this.lstList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtboxTimer
            // 
            this.dtboxTimer.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.dtboxTimer.Name = "dtboxTimer";
            this.dtboxTimer.Size = new System.Drawing.Size(61, 4);
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(259, 115);
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(335, 28);
            this.txtmsg.TabIndex = 3;
            // 
            // dtboxTime
            // 
            this.dtboxTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtboxTime.Location = new System.Drawing.Point(53, 115);
            this.dtboxTime.Name = "dtboxTime";
            this.dtboxTime.ShowUpDown = true;
            this.dtboxTime.Size = new System.Drawing.Size(200, 28);
            this.dtboxTime.TabIndex = 4;
            // 
            // lstList
            // 
            this.lstList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstList.FullRowSelect = true;
            this.lstList.HideSelection = false;
            this.lstList.Location = new System.Drawing.Point(53, 177);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(696, 206);
            this.lstList.TabIndex = 5;
            this.lstList.UseCompatibleStateImageBehavior = false;
            this.lstList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "时间";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "内容";
            this.columnHeader2.Width = 461;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "是否已提醒";
            this.columnHeader3.Width = 117;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.dtboxTime);
            this.Controls.Add(this.txtmsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip dtboxTimer;
        private System.Windows.Forms.TextBox txtmsg;
        private System.Windows.Forms.DateTimePicker dtboxTime;
        private System.Windows.Forms.ListView lstList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Timer timer2;
    }
}

