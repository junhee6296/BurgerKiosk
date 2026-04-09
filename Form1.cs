namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            wpRadio.Checked = false;
            cwpRadio.Checked = false;
            bwpRadio.Checked = false;

            ActiveControl = null;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            int totalCost = 0; // 총 금액 초기화
            OrderListBox.Items.Clear(); // 리스트박스 초기화 (중복 출력 방지)

            // --- [과제 2: 에러 메시지 표시 로직 추가] ---
            // 라디오 버튼 3개 중 아무것도 체크되어 있지 않다면 (! 연산자 사용)
            if (!wpRadio.Checked && !cwpRadio.Checked && !bwpRadio.Checked)
            {
                ErrorLabel.Text = "메뉴를 선택해 주세요."; // 화면에 에러 표시
                return; // 아래의 가격 계산 로직을 실행하지 않고 여기서 메서드 즉시 종료
            }

            // 정상적으로 메뉴를 선택했다면, 혹시 남아있을지 모를 에러 메시지를 지워줌
            ErrorLabel.Text = "";

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

            //선택 재허용
            wpRadio.TabStop = true;

            // 출력 화면 초기화
            OrderListBox.Items.Clear();
            TotalAmountLabel.Text = "총 금액 : 0원";

            ErrorLabel.Text = "";
        }

        private void UpdateOrderInfo(object sender, EventArgs e)
        {
            int totalCost = 0; // 가격 누적을 위해 0으로 초기화
            OrderListBox.Items.Clear(); // 이전 내역 삭제

            // 1. 메뉴 선택 확인 (RadioButton)
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

            // 2. 추가 옵션 확인 (CheckBox)
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

            // 3. 결과 출력 (Label)
            TotalAmountLabel.Text = "총 금액 : " + totalCost.ToString("#,##0") + "원";

            // 항목이 하나라도 선택되어 금액이 오르면 에러 메시지(과제2)를 지워줍니다.
            if (totalCost > 0)
            {
                ErrorLabel.Text = "";
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // 체크박스 선택 강제해제
            wpRadio.Checked = false;
            cwpRadio.Checked = false;
            bwpRadio.Checked = false;

            //탭 버그 수정
            wpRadio.TabStop = true;

            // 포커스 변경
            ActiveControl = OrderButton;
        }
    }
}
