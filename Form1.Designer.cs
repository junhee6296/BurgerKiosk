namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            listBox1 = new ListBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("서울남산체 M", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(152, 21);
            label1.Name = "label1";
            label1.Size = new Size(538, 76);
            label1.TabIndex = 0;
            label1.Text = "버거 주문 키오스크";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("서울알림체 TTF Bold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(12, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 406);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "메뉴 선택";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(191, 217);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(134, 79);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(191, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(134, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(191, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("서울남산 장체 M", 17.9999981F, FontStyle.Bold);
            radioButton3.ForeColor = Color.Black;
            radioButton3.Location = new Point(18, 241);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(131, 32);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "불고기와퍼";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("서울남산 장체 M", 17.9999981F, FontStyle.Bold);
            radioButton2.ForeColor = Color.Black;
            radioButton2.Location = new Point(18, 148);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(111, 32);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "치즈와퍼";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("서울남산 장체 M", 17.9999981F, FontStyle.Bold);
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(18, 59);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(111, 32);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "와퍼버거";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Font = new Font("서울알림체 TTF Bold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(358, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 326);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "추가 옵션";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Font = new Font("서울알림체 TTF Bold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(592, 100);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(293, 326);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "주문 내역";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("서울남산 장체 M", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            checkBox3.ForeColor = Color.Black;
            checkBox3.Location = new Point(16, 43);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(111, 32);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "감자튀김";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("서울남산 장체 M", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            checkBox2.ForeColor = Color.Black;
            checkBox2.Location = new Point(16, 82);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(71, 32);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "콜라";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("서울남산 장체 M", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            checkBox4.ForeColor = Color.Black;
            checkBox4.Location = new Point(16, 120);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(119, 32);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "치즈 추가";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("서울남산 장체 M", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            checkBox5.ForeColor = Color.Black;
            checkBox5.Location = new Point(16, 158);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(119, 32);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "소스 추가";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(281, 228);
            listBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(6, 281);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 4;
            label2.Text = "총 금액 : 0원";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("서울남산체 M", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = Color.FromArgb(64, 0, 64);
            button1.Location = new Point(443, 443);
            button1.Name = "button1";
            button1.Size = new Size(165, 63);
            button1.TabIndex = 4;
            button1.Text = "주문하기";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("서울남산체 M", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.ForeColor = Color.White;
            button2.Location = new Point(614, 443);
            button2.Name = "button2";
            button2.Size = new Size(165, 63);
            button2.TabIndex = 5;
            button2.Text = "초기화";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 518);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "키오스크";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label2;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
    }
}
