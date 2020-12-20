namespace WebBrowser
{
    partial class Form2
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.userIdLabel = new System.Windows.Forms.ToolStripLabel();
            this.userId = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.passwdLabel = new System.Windows.Forms.ToolStripLabel();
            this.passwd = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.timeLabel = new System.Windows.Forms.ToolStripLabel();
            this.hour = new System.Windows.Forms.ToolStripTextBox();
            this.hourLabel = new System.Windows.Forms.ToolStripLabel();
            this.minute = new System.Windows.Forms.ToolStripTextBox();
            this.minuteLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.confirm = new System.Windows.Forms.ToolStripLabel();
            this.cancel = new System.Windows.Forms.ToolStripLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userIdLabel,
            this.userId});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(595, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // userIdLabel
            // 
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(86, 31);
            this.userIdLabel.Text = "用户名";
            this.userIdLabel.Click += new System.EventHandler(this.userIdButton_Click);
            // 
            // userId
            // 
            this.userId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userId.Margin = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(300, 34);
            this.userId.Click += new System.EventHandler(this.userId_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwdLabel,
            this.passwd});
            this.toolStrip2.Location = new System.Drawing.Point(0, 34);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(595, 34);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // passwdLabel
            // 
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(62, 31);
            this.passwdLabel.Text = "密码";
            this.passwdLabel.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // passwd
            // 
            this.passwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwd.Margin = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(300, 34);
            this.passwd.Click += new System.EventHandler(this.passwd_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeLabel,
            this.hour,
            this.hourLabel,
            this.minute,
            this.minuteLabel});
            this.toolStrip3.Location = new System.Drawing.Point(0, 68);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(595, 34);
            this.toolStrip3.TabIndex = 4;
            this.toolStrip3.Text = "toolStrip3";
            this.toolStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip3_ItemClicked);
            // 
            // timeLabel
            // 
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(110, 31);
            this.timeLabel.Text = "打卡时间";
            this.timeLabel.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // hour
            // 
            this.hour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hour.Margin = new System.Windows.Forms.Padding(180, 0, 0, 0);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(50, 34);
            // 
            // hourLabel
            // 
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(38, 31);
            this.hourLabel.Text = "时";
            // 
            // minute
            // 
            this.minute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minute.Margin = new System.Windows.Forms.Padding(0);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(50, 34);
            // 
            // minuteLabel
            // 
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(38, 31);
            this.minuteLabel.Text = "分";
            // 
            // toolStrip4
            // 
            this.toolStrip4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirm,
            this.cancel});
            this.toolStrip4.Location = new System.Drawing.Point(0, 102);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(595, 34);
            this.toolStrip4.TabIndex = 5;
            this.toolStrip4.Text = "toolStrip4";
            this.toolStrip4.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip4_ItemClicked);
            // 
            // confirm
            // 
            this.confirm.Margin = new System.Windows.Forms.Padding(150, 1, 0, 2);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(62, 31);
            this.confirm.Text = "确定";
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(62, 31);
            this.cancel.Text = "取消";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 158);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.toolStrip4);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form2";
            this.Text = "打卡信息输入栏";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel userIdLabel;
        private System.Windows.Forms.ToolStripTextBox userId;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel passwdLabel;
        private System.Windows.Forms.ToolStripTextBox passwd;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel timeLabel;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripLabel confirm;
        private System.Windows.Forms.ToolStripLabel cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripTextBox hour;
        private System.Windows.Forms.ToolStripLabel hourLabel;
        private System.Windows.Forms.ToolStripTextBox minute;
        private System.Windows.Forms.ToolStripLabel minuteLabel;
    }
}