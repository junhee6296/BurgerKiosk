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
            MainLabel = new Label();
            MenuGroupBox = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            bwpRadio = new RadioButton();
            cwpRadio = new RadioButton();
            wpRadio = new RadioButton();
            AddOptionBox = new GroupBox();
            sourceCB = new CheckBox();
            CheeseCB = new CheckBox();
            colaCB = new CheckBox();
            potatoCB = new CheckBox();
            OrderListGroupBox = new GroupBox();
            TotalAmountLabel = new Label();
            OrderListBox = new ListBox();
            OrderButton = new Button();
            ResetButton = new Button();
            ErrorLabel = new Label();
            MenuGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            AddOptionBox.SuspendLayout();
            OrderListGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.Font = new Font("서울남산체 M", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            MainLabel.Location = new Point(152, 21);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(538, 76);
            MainLabel.TabIndex = 4;
            MainLabel.Text = "버거 주문 키오스크";
            // 
            // MenuGroupBox
            // 
            MenuGroupBox.Controls.Add(pictureBox3);
            MenuGroupBox.Controls.Add(pictureBox2);
            MenuGroupBox.Controls.Add(pictureBox1);
            MenuGroupBox.Controls.Add(bwpRadio);
            MenuGroupBox.Controls.Add(cwpRadio);
            MenuGroupBox.Controls.Add(wpRadio);
            MenuGroupBox.Font = new Font("서울알림체 TTF Bold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            MenuGroupBox.ForeColor = Color.Red;
            MenuGroupBox.Location = new Point(12, 100);
            MenuGroupBox.Name = "MenuGroupBox";
            MenuGroupBox.Size = new Size(340, 406);
            MenuGroupBox.TabIndex = 1;
            MenuGroupBox.TabStop = false;
            MenuGroupBox.Text = "메뉴 선택";
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
            // bwpRadio
            // 
            bwpRadio.AutoSize = true;
            bwpRadio.Font = new Font("서울남산 장체 M", 17.9999981F, FontStyle.Bold);
            bwpRadio.ForeColor = Color.Black;
            bwpRadio.Location = new Point(18, 241);
            bwpRadio.Name = "bwpRadio";
            bwpRadio.Size = new Size(131, 32);
            bwpRadio.TabIndex = 2;
            bwpRadio.TabStop = true;
            bwpRadio.Text = "불고기와퍼";
            bwpRadio.UseVisualStyleBackColor = true;
            bwpRadio.CheckedChanged += UpdateOrderInfo;
            // 
            // cwpRadio
            // 
            cwpRadio.AutoSize = true;
            cwpRadio.Font = new Font("서울남산 장체 M", 17.9999981F, FontStyle.Bold);
            cwpRadio.ForeColor = Color.Black;
            cwpRadio.Location = new Point(18, 148);
            cwpRadio.Name = "cwpRadio";
            cwpRadio.Size = new Size(111, 32);
            cwpRadio.TabIndex = 1;
            cwpRadio.TabStop = true;
            cwpRadio.Text = "치즈와퍼";
            cwpRadio.UseVisualStyleBackColor = true;
            cwpRadio.CheckedChanged += UpdateOrderInfo;
            // 
            // wpRadio
            // 
            wpRadio.AutoSize = true;
            wpRadio.Font = new Font("서울남산 장체 M", 17.9999981F, FontStyle.Bold);
            wpRadio.ForeColor = Color.Black;
            wpRadio.Location = new Point(18, 59);
            wpRadio.Name = "wpRadio";
            wpRadio.Size = new Size(111, 32);
            wpRadio.TabIndex = 0;
            wpRadio.TabStop = true;
            wpRadio.Text = "와퍼버거";
            wpRadio.UseVisualStyleBackColor = true;
            wpRadio.CheckedChanged += UpdateOrderInfo;
            // 
            // AddOptionBox
            // 
            AddOptionBox.Controls.Add(sourceCB);
            AddOptionBox.Controls.Add(CheeseCB);
            AddOptionBox.Controls.Add(colaCB);
            AddOptionBox.Controls.Add(potatoCB);
            AddOptionBox.Font = new Font("서울알림체 TTF Bold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            AddOptionBox.ForeColor = Color.Red;
            AddOptionBox.Location = new Point(358, 100);
            AddOptionBox.Name = "AddOptionBox";
            AddOptionBox.Size = new Size(228, 326);
            AddOptionBox.TabIndex = 2;
            AddOptionBox.TabStop = false;
            AddOptionBox.Text = "추가 옵션";
            // 
            // sourceCB
            // 
            sourceCB.AutoSize = true;
            sourceCB.Font = new Font("서울남산 장체 M", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            sourceCB.ForeColor = Color.Black;
            sourceCB.Location = new Point(16, 158);
            sourceCB.Name = "sourceCB";
            sourceCB.Size = new Size(119, 32);
            sourceCB.TabIndex = 3;
            sourceCB.Text = "소스 추가";
            sourceCB.UseVisualStyleBackColor = true;
            sourceCB.CheckedChanged += UpdateOrderInfo;
            // 
            // CheeseCB
            // 
            CheeseCB.AutoSize = true;
            CheeseCB.Font = new Font("서울남산 장체 M", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            CheeseCB.ForeColor = Color.Black;
            CheeseCB.Location = new Point(16, 120);
            CheeseCB.Name = "CheeseCB";
            CheeseCB.Size = new Size(119, 32);
            CheeseCB.TabIndex = 2;
            CheeseCB.Text = "치즈 추가";
            CheeseCB.UseVisualStyleBackColor = true;
            CheeseCB.CheckedChanged += UpdateOrderInfo;
            // 
            // colaCB
            // 
            colaCB.AutoSize = true;
            colaCB.Font = new Font("서울남산 장체 M", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            colaCB.ForeColor = Color.Black;
            colaCB.Location = new Point(16, 82);
            colaCB.Name = "colaCB";
            colaCB.Size = new Size(71, 32);
            colaCB.TabIndex = 1;
            colaCB.Text = "콜라";
            colaCB.UseVisualStyleBackColor = true;
            colaCB.CheckedChanged += UpdateOrderInfo;
            // 
            // potatoCB
            // 
            potatoCB.AutoSize = true;
            potatoCB.Font = new Font("서울남산 장체 M", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            potatoCB.ForeColor = Color.Black;
            potatoCB.Location = new Point(16, 43);
            potatoCB.Name = "potatoCB";
            potatoCB.Size = new Size(111, 32);
            potatoCB.TabIndex = 0;
            potatoCB.Text = "감자튀김";
            potatoCB.UseVisualStyleBackColor = true;
            potatoCB.CheckedChanged += UpdateOrderInfo;
            // 
            // OrderListGroupBox
            // 
            OrderListGroupBox.Controls.Add(TotalAmountLabel);
            OrderListGroupBox.Controls.Add(OrderListBox);
            OrderListGroupBox.Font = new Font("서울알림체 TTF Bold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            OrderListGroupBox.ForeColor = Color.Red;
            OrderListGroupBox.Location = new Point(592, 100);
            OrderListGroupBox.Name = "OrderListGroupBox";
            OrderListGroupBox.Size = new Size(293, 326);
            OrderListGroupBox.TabIndex = 4;
            OrderListGroupBox.TabStop = false;
            OrderListGroupBox.Text = "주문 내역";
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.ForeColor = Color.Blue;
            TotalAmountLabel.Location = new Point(6, 281);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(142, 28);
            TotalAmountLabel.TabIndex = 4;
            TotalAmountLabel.Text = "총 금액 : 0원";
            // 
            // OrderListBox
            // 
            OrderListBox.Font = new Font("서울알림체 TTF Bold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            OrderListBox.FormattingEnabled = true;
            OrderListBox.Location = new Point(6, 43);
            OrderListBox.Name = "OrderListBox";
            OrderListBox.Size = new Size(281, 224);
            OrderListBox.TabIndex = 0;
            OrderListBox.TabStop = false;
            // 
            // OrderButton
            // 
            OrderButton.BackColor = Color.Lime;
            OrderButton.Font = new Font("서울남산체 M", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            OrderButton.ForeColor = Color.FromArgb(64, 0, 64);
            OrderButton.Location = new Point(443, 434);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(165, 49);
            OrderButton.TabIndex = 3;
            OrderButton.Text = "주문하기";
            OrderButton.UseVisualStyleBackColor = false;
            OrderButton.Click += OrderButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.Red;
            ResetButton.Font = new Font("서울남산체 M", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ResetButton.ForeColor = Color.White;
            ResetButton.Location = new Point(614, 434);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(165, 49);
            ResetButton.TabIndex = 4;
            ResetButton.Text = "초기화";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("서울남산 장체 M", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(611, 489);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 23);
            ErrorLabel.TabIndex = 6;
            ErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AcceptButton = OrderButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 518);
            Controls.Add(ErrorLabel);
            Controls.Add(ResetButton);
            Controls.Add(OrderButton);
            Controls.Add(OrderListGroupBox);
            Controls.Add(AddOptionBox);
            Controls.Add(MenuGroupBox);
            Controls.Add(MainLabel);
            Name = "Form1";
            Text = "키오스크";
            Shown += Form1_Shown;
            MenuGroupBox.ResumeLayout(false);
            MenuGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            AddOptionBox.ResumeLayout(false);
            AddOptionBox.PerformLayout();
            OrderListGroupBox.ResumeLayout(false);
            OrderListGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainLabel;
        private GroupBox MenuGroupBox;
        private GroupBox AddOptionBox;
        private GroupBox OrderListGroupBox;
        private RadioButton bwpRadio;
        private RadioButton cwpRadio;
        private RadioButton wpRadio;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CheckBox sourceCB;
        private CheckBox CheeseCB;
        private CheckBox colaCB;
        private CheckBox potatoCB;
        private Label TotalAmountLabel;
        private ListBox OrderListBox;
        private Button OrderButton;
        private Button ResetButton;
        private Label ErrorLabel;
    }
}
