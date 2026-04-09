namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void OrderButton_Click(object sender, EventArgs e)
        {
            int totalCost = 0; // 총 금액 초기화
            OrderListBox.Items.Clear(); // 리스트박스 초기화 (중복 출력 방지)

            // 1. 메뉴 선택 처리 (RadioButton)
            if (wpRadio.Checked)
            {
                totalCost += 5000;
                OrderListBox.Items.Add("와퍼버거 5,000원");
            }
            else if (cwpRadio.Checked)
            {
                totalCost += 4000;
                OrderListBox.Items.Add("치즈와퍼 4,000원");
            }
            else if (bwpRadio.Checked)
            {
                totalCost += 3000;
                OrderListBox.Items.Add("불고기와퍼 3,000원");
            }

            // 2. 추가 옵션 처리 (CheckBox)
            if (potatoCB.Checked)
            {
                totalCost += 3500;
                OrderListBox.Items.Add("감자튀김 3,500원");
            }
            if (colaCB.Checked)
            {
                totalCost += 2500;
                OrderListBox.Items.Add("콜라 2,500원");
            }
            if (CheeseCB.Checked)
            {
                totalCost += 1500;
                OrderListBox.Items.Add("치즈 추가 1,500원");
            }
            if (sourceCB.Checked)
            {
                totalCost += 500;
                OrderListBox.Items.Add("소스 추가 500원");
            }

            // 3. 총 금액 출력 (Label)
            TotalAmountLabel.Text = "총 금액 : " + totalCost.ToString("#,##0") + "원";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            // RadioButton 선택 해제
            wpRadio.Checked = false;
            cwpRadio.Checked = false;
            bwpRadio.Checked = false;

            // CheckBox 선택 해제
            potatoCB.Checked = false;
            colaCB.Checked = false;
            CheeseCB.Checked = false;
            sourceCB.Checked = false;

            // 출력 화면 초기화
            OrderListBox.Items.Clear();
            TotalAmountLabel.Text = "총 금액 : 0원";
        }

    }
}
