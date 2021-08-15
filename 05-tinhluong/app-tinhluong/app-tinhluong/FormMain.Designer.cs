
namespace app_tinhluong
{
    partial class frmMain
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSalaryNormalDay = new System.Windows.Forms.Label();
            this.lblSalaryWeekendDay = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTotalDayNormal = new System.Windows.Forms.Label();
            this.lblTotalSalaryNormal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalDayWeekend = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalSalaryWeekend = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkWeekend = new System.Windows.Forms.CheckBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.chkWeekend);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian làm việc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblSalaryWeekendDay);
            this.groupBox2.Controls.Add(this.lblSalaryNormalDay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 101);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin lương";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblTotalSalary);
            this.groupBox3.Controls.Add(this.lblTotalSalaryWeekend);
            this.groupBox3.Controls.Add(this.lblTotalSalaryNormal);
            this.groupBox3.Controls.Add(this.lblTotalDayWeekend);
            this.groupBox3.Controls.Add(this.lblTotalDayNormal);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(677, 176);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày thường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày cuối tuần";
            // 
            // lblSalaryNormalDay
            // 
            this.lblSalaryNormalDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSalaryNormalDay.Location = new System.Drawing.Point(146, 44);
            this.lblSalaryNormalDay.Name = "lblSalaryNormalDay";
            this.lblSalaryNormalDay.Size = new System.Drawing.Size(154, 33);
            this.lblSalaryNormalDay.TabIndex = 0;
            // 
            // lblSalaryWeekendDay
            // 
            this.lblSalaryWeekendDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSalaryWeekendDay.Location = new System.Drawing.Point(500, 43);
            this.lblSalaryWeekendDay.Name = "lblSalaryWeekendDay";
            this.lblSalaryWeekendDay.Size = new System.Drawing.Size(154, 33);
            this.lblSalaryWeekendDay.TabIndex = 0;
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(155, 257);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(161, 42);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "Tính Lương";
            this.btnResult.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(376, 257);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 42);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // lblTotalDayNormal
            // 
            this.lblTotalDayNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalDayNormal.Location = new System.Drawing.Point(141, 41);
            this.lblTotalDayNormal.Name = "lblTotalDayNormal";
            this.lblTotalDayNormal.Size = new System.Drawing.Size(48, 33);
            this.lblTotalDayNormal.TabIndex = 0;
            this.lblTotalDayNormal.Text = "0";
            this.lblTotalDayNormal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalSalaryNormal
            // 
            this.lblTotalSalaryNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalSalaryNormal.Location = new System.Drawing.Point(442, 41);
            this.lblTotalSalaryNormal.Name = "lblTotalSalaryNormal";
            this.lblTotalSalaryNormal.Size = new System.Drawing.Size(212, 33);
            this.lblTotalSalaryNormal.TabIndex = 0;
            this.lblTotalSalaryNormal.Text = "0đ";
            this.lblTotalSalaryNormal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(194, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "ngày công thường, nhận";
            // 
            // lblTotalDayWeekend
            // 
            this.lblTotalDayWeekend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalDayWeekend.Location = new System.Drawing.Point(50, 81);
            this.lblTotalDayWeekend.Name = "lblTotalDayWeekend";
            this.lblTotalDayWeekend.Size = new System.Drawing.Size(48, 33);
            this.lblTotalDayWeekend.TabIndex = 0;
            this.lblTotalDayWeekend.Text = "0";
            this.lblTotalDayWeekend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(104, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "ngày công làm việc cuối tuần, nhận";
            // 
            // lblTotalSalaryWeekend
            // 
            this.lblTotalSalaryWeekend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalSalaryWeekend.Location = new System.Drawing.Point(442, 81);
            this.lblTotalSalaryWeekend.Name = "lblTotalSalaryWeekend";
            this.lblTotalSalaryWeekend.Size = new System.Drawing.Size(212, 33);
            this.lblTotalSalaryWeekend.TabIndex = 0;
            this.lblTotalSalaryWeekend.Text = "0đ";
            this.lblTotalSalaryWeekend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(221, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng lương thực lãnh";
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalSalary.ForeColor = System.Drawing.Color.Red;
            this.lblTotalSalary.Location = new System.Drawing.Point(442, 121);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(212, 33);
            this.lblTotalSalary.TabIndex = 0;
            this.lblTotalSalary.Text = "0đ";
            this.lblTotalSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày kết thúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Làm việc ngày cuối tuần";
            // 
            // chkWeekend
            // 
            this.chkWeekend.AutoSize = true;
            this.chkWeekend.Location = new System.Drawing.Point(237, 72);
            this.chkWeekend.Name = "chkWeekend";
            this.chkWeekend.Size = new System.Drawing.Size(53, 28);
            this.chkWeekend.TabIndex = 1;
            this.chkWeekend.Text = "Có";
            this.chkWeekend.UseVisualStyleBackColor = true;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(144, 34);
            this.dtpStart.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(136, 29);
            this.dtpStart.TabIndex = 2;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(518, 34);
            this.dtpEnd.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(136, 29);
            this.dtpEnd.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(713, 492);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "App Tính Lương";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSalaryWeekendDay;
        private System.Windows.Forms.Label lblSalaryNormalDay;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTotalDayNormal;
        private System.Windows.Forms.Label lblTotalSalaryNormal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalDayWeekend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalSalaryWeekend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalSalary;
        private System.Windows.Forms.CheckBox chkWeekend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
    }
}

