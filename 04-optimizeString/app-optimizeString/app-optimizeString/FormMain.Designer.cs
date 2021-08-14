
namespace app_optimizeString
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.radTypeDefault = new System.Windows.Forms.RadioButton();
            this.radTypeNoAccent = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTypeSlug = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radTextDefault = new System.Windows.Forms.RadioButton();
            this.radTextLower = new System.Windows.Forms.RadioButton();
            this.radTextUpper = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkRemoveSpace = new System.Windows.Forms.CheckBox();
            this.chkRemoveSpecial = new System.Windows.Forms.CheckBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageListIconButton = new System.Windows.Forms.ImageList(this.components);
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radTypeDefault
            // 
            this.radTypeDefault.AutoSize = true;
            this.radTypeDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTypeDefault.Location = new System.Drawing.Point(16, 34);
            this.radTypeDefault.Name = "radTypeDefault";
            this.radTypeDefault.Size = new System.Drawing.Size(91, 24);
            this.radTypeDefault.TabIndex = 0;
            this.radTypeDefault.TabStop = true;
            this.radTypeDefault.Text = "Mặc định";
            this.radTypeDefault.UseVisualStyleBackColor = true;
            // 
            // radTypeNoAccent
            // 
            this.radTypeNoAccent.AutoSize = true;
            this.radTypeNoAccent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTypeNoAccent.Location = new System.Drawing.Point(16, 64);
            this.radTypeNoAccent.Name = "radTypeNoAccent";
            this.radTypeNoAccent.Size = new System.Drawing.Size(99, 24);
            this.radTypeNoAccent.TabIndex = 0;
            this.radTypeNoAccent.TabStop = true;
            this.radTypeNoAccent.Text = "Tiếng Anh";
            this.radTypeNoAccent.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.radTypeDefault);
            this.groupBox1.Controls.Add(this.radTypeSlug);
            this.groupBox1.Controls.Add(this.radTypeNoAccent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại văn bản";
            // 
            // radTypeSlug
            // 
            this.radTypeSlug.AutoSize = true;
            this.radTypeSlug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTypeSlug.Location = new System.Drawing.Point(16, 94);
            this.radTypeSlug.Name = "radTypeSlug";
            this.radTypeSlug.Size = new System.Drawing.Size(59, 24);
            this.radTypeSlug.TabIndex = 0;
            this.radTypeSlug.TabStop = true;
            this.radTypeSlug.Text = "Slug";
            this.radTypeSlug.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.radTextDefault);
            this.groupBox3.Controls.Add(this.radTextLower);
            this.groupBox3.Controls.Add(this.radTextUpper);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 130);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kiểu chữ";
            // 
            // radTextDefault
            // 
            this.radTextDefault.AutoSize = true;
            this.radTextDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextDefault.Location = new System.Drawing.Point(15, 37);
            this.radTextDefault.Name = "radTextDefault";
            this.radTextDefault.Size = new System.Drawing.Size(124, 24);
            this.radTextDefault.TabIndex = 0;
            this.radTextDefault.TabStop = true;
            this.radTextDefault.Text = "Chữ mặc định";
            this.radTextDefault.UseVisualStyleBackColor = true;
            // 
            // radTextLower
            // 
            this.radTextLower.AutoSize = true;
            this.radTextLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextLower.Location = new System.Drawing.Point(15, 97);
            this.radTextLower.Name = "radTextLower";
            this.radTextLower.Size = new System.Drawing.Size(110, 24);
            this.radTextLower.TabIndex = 0;
            this.radTextLower.TabStop = true;
            this.radTextLower.Text = "Chữ thường";
            this.radTextLower.UseVisualStyleBackColor = true;
            // 
            // radTextUpper
            // 
            this.radTextUpper.AutoSize = true;
            this.radTextUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextUpper.Location = new System.Drawing.Point(15, 67);
            this.radTextUpper.Name = "radTextUpper";
            this.radTextUpper.Size = new System.Drawing.Size(103, 24);
            this.radTextUpper.TabIndex = 0;
            this.radTextUpper.TabStop = true;
            this.radTextUpper.Text = "Chữ in hoa";
            this.radTextUpper.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.chkRemoveSpace);
            this.groupBox2.Controls.Add(this.chkRemoveSpecial);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuẩn hóa";
            // 
            // chkRemoveSpace
            // 
            this.chkRemoveSpace.AutoSize = true;
            this.chkRemoveSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemoveSpace.Location = new System.Drawing.Point(16, 71);
            this.chkRemoveSpace.Name = "chkRemoveSpace";
            this.chkRemoveSpace.Size = new System.Drawing.Size(236, 24);
            this.chkRemoveSpace.TabIndex = 1;
            this.chkRemoveSpace.Text = "Loại bỏ khoảng trắng dư thừa";
            this.chkRemoveSpace.UseVisualStyleBackColor = true;
            // 
            // chkRemoveSpecial
            // 
            this.chkRemoveSpecial.AutoSize = true;
            this.chkRemoveSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemoveSpecial.Location = new System.Drawing.Point(16, 36);
            this.chkRemoveSpecial.Name = "chkRemoveSpecial";
            this.chkRemoveSpecial.Size = new System.Drawing.Size(177, 24);
            this.chkRemoveSpecial.TabIndex = 0;
            this.chkRemoveSpecial.Text = "Loại bỏ ký tự đặc biệt";
            this.chkRemoveSpecial.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(305, 53);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(309, 141);
            this.txtInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(305, 254);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(309, 141);
            this.textBox1.TabIndex = 2;
            // 
            // imageListIconButton
            // 
            this.imageListIconButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIconButton.ImageStream")));
            this.imageListIconButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIconButton.Images.SetKeyName(0, "convert.png");
            this.imageListIconButton.Images.SetKeyName(1, "copy.png");
            this.imageListIconButton.Images.SetKeyName(2, "delete.png");
            this.imageListIconButton.Images.SetKeyName(3, "exit.png");
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.White;
            this.btnConvert.ImageKey = "convert.png";
            this.btnConvert.ImageList = this.imageListIconButton;
            this.btnConvert.Location = new System.Drawing.Point(635, 27);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 80);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.UseVisualStyleBackColor = false;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.White;
            this.btnCopy.ImageKey = "copy.png";
            this.btnCopy.ImageList = this.imageListIconButton;
            this.btnCopy.Location = new System.Drawing.Point(635, 132);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(100, 80);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.ImageKey = "delete.png";
            this.btnReset.ImageList = this.imageListIconButton;
            this.btnReset.Location = new System.Drawing.Point(635, 237);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 80);
            this.btnReset.TabIndex = 4;
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.ImageKey = "exit.png";
            this.btnExit.ImageList = this.imageListIconButton;
            this.btnExit.Location = new System.Drawing.Point(635, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 80);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 448);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "App Optimize String";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radTypeDefault;
        private System.Windows.Forms.RadioButton radTypeNoAccent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTypeSlug;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radTextDefault;
        private System.Windows.Forms.RadioButton radTextLower;
        private System.Windows.Forms.RadioButton radTextUpper;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkRemoveSpace;
        private System.Windows.Forms.CheckBox chkRemoveSpecial;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList imageListIconButton;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

