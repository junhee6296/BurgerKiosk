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
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("서울남산체 M", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(302, 42);
            label1.TabIndex = 0;
            label1.Text = "버거 주문 키오스크";
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("서울알림체 TTF Bold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 375);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "메뉴 선택";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("서울알림체 TTF Bold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(265, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 375);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "추가 옵션";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("서울알림체 TTF Bold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(515, 63);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(228, 375);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "주문 내역";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "키오스크";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
