namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int totalCost = 0; // 계산 전 항상 총 금액을 누적할 변수를 0으로 초기화
        OrderListBox.Items.Clear(); // 중복 출력을 방지

        if (wpRadio.Checked) {
            totalCost += 5000; 
            OrderListBox.Items.Add("와퍼버거 5,000원"); 
        }
        else if (rdoBulgogiBurger.Checked) {
            totalCost += 4000; // [cite: 501]
            OrderListBox.Items.Add("치즈와퍼 4,000원");
        }
        else if (rdoChickenBurger.Checked)
        {
            totalCost += 3000; // [cite: 508]
            OrderListBox.Items.Add(" 3,000원");
        }
    }
}
