using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kiosk1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)  //X
        {
        }

        public int sum = 0;   //금액 초기화

        private void btnOrder_Click(object sender, EventArgs e)   //주문하기버튼
        {
            textBox2.Text = sum.ToString() + "원";   //textBox2= 금액을 나타냄
            textBox4.Text = sum.ToString() + "원";   //textBox4= 금액을 나타냄

        }

        private void button1_Click(object sender, EventArgs e)    //스파이시이탈리안
        {
            StringBuilder sb = new StringBuilder();   //인스턴스 생성
            sb.Append(textBox1.Text);                 //Append: 기존 문자열에 추가
            sb.AppendLine("스파이시이탈리안");        //스파이시이탈리안 버튼을 클릭하면 textBox1에 입력하기 위한 것
            textBox1.Text = sb.ToString();            //textBox1에 문자열로 입력
            textBox3.Text = sb.ToString();            //textBox3에 문자열로 입력
            sum += int.Parse(label13.Text);           //금액에 누적되기 위해 금액을 나타내는 라벨을 int형변환 시킨 후 금액에 저장
        }

        private void button2_Click(object sender, EventArgs e)    //써브웨이클럽
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("써브웨이클럽");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label14.Text);
            textBox3.Text = sb.ToString();

        }

        private void button3_Click(object sender, EventArgs e)   //에그마요
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("에그마요");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label15.Text);
            textBox3.Text = sb.ToString();
        }

        private void button4_Click(object sender, EventArgs e)   //이탈리안비엠티
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("이탈리안비엠티");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label16.Text);
            textBox3.Text = sb.ToString();
        }

        private void button5_Click(object sender, EventArgs e)   //치즈베이컨아보카도
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("치즈베이컨아보카도");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label17.Text);
            textBox3.Text = sb.ToString();
        }

        private void button6_Click(object sender, EventArgs e)  //치킨데리야끼
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("치킨데리야끼");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label18.Text);
            textBox3.Text = sb.ToString();
        }

        private void button7_Click(object sender, EventArgs e)   //로스트치킨
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("로스트치킨");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label19.Text);
            textBox3.Text = sb.ToString();
        }

        private void button8_Click(object sender, EventArgs e)  //로티세리바비큐
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("로티세리바비큐");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label20.Text);
            textBox3.Text = sb.ToString();
        }

        private void button9_Click(object sender, EventArgs e)   //베지
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("베지");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label21.Text);
            textBox3.Text = sb.ToString();
        }

        private void button10_Click(object sender, EventArgs e)   //비엘티
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("비엘티");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label22.Text);
            textBox3.Text = sb.ToString();
        }

        private void button11_Click(object sender, EventArgs e)   //스테이크치즈
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("스테이크치즈");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label23.Text);
            textBox3.Text = sb.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)  //X
        {
        }

        private void button12_Click(object sender, EventArgs e)  //풀드포크바비큐
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("풀드포크바비큐");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label24.Text);
            textBox3.Text = sb.ToString();
        }

        private void button13_Click(object sender, EventArgs e)  //추가 에그마요
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("추가 에그마요");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label34.Text);
            textBox3.Text = sb.ToString();
        }

        private void button14_Click(object sender, EventArgs e)  //추가 아보카도
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("추가 아보카도");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label35.Text);
            textBox3.Text = sb.ToString();
        }

        private void button15_Click(object sender, EventArgs e)  //추가 베이컨
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("추가 베이컨");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label36.Text);
            textBox3.Text = sb.ToString();
        }

        private void button16_Click(object sender, EventArgs e)  //추가 오믈렛
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("추가 오믈렛");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label37.Text);
            textBox3.Text = sb.ToString();
        }

        private void button17_Click(object sender, EventArgs e)   //추가 치즈
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("추가 치즈");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label38.Text);
            textBox3.Text = sb.ToString();
        }

        private void button18_Click(object sender, EventArgs e)  //추가 페퍼로니
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("추가 페퍼로니");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label39.Text);
            textBox3.Text = sb.ToString();
        }

        private void button19_Click(object sender, EventArgs e)  //콜라
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("콜라");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label40.Text);
            textBox3.Text = sb.ToString();
        }

        private void button20_Click(object sender, EventArgs e)  //사이다
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("사이다");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label41.Text);
            textBox3.Text = sb.ToString();
        }

        private void button21_Click(object sender, EventArgs e)  //물
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine("물");
            textBox1.Text = sb.ToString();
            sum += int.Parse(label42.Text);
            textBox3.Text = sb.ToString();
        }

        private void btnCancle1_Click(object sender, EventArgs e)  //X
        {
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)  //X
        {
        }

        //샐러드탭에 있는 취소버튼 누르면 샐러드탭과 추가/음료에 있는 모든 텍스트박스 초기화
        private void btnCancle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            sum = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)    //X
        {
        }
        private void btnPay_Click(object sender, EventArgs e)   //X
        {
        }

        private void button22_Click(object sender, EventArgs e)   //결제하기에서 선택그룹의 확인버튼
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("매장 식사를 선택하였습니다.");  //매장식사 라디오버튼선택
            }
            else if (radioButton2.Checked == true)
            { MessageBox.Show("포장을 선택하였습니다."); }   //포장 라디오버튼선택
            else
                MessageBox.Show("선택하십시오.");           //선택 안했을 시

        }

        private void button23_Click(object sender, EventArgs e)  //재료선택탭의 선택버튼
        {
            string strOrder = "";
            lbMenu.Text = "";    //선택메뉴라벨에 체크박스 선택 후 버튼 누르면 내용 알려주기 위한 것-> 그래서 초기화 상태

            //치즈선택
            if (checkBox1.Checked == true)
                strOrder += checkBox1.Text + "\n";   //슈레드치즈
            if (checkBox2.Checked == true)
                strOrder += checkBox2.Text + "\n";   //아메리칸치즈
            if (checkBox3.Checked == true)
                strOrder += checkBox3.Text + "\n";   //모짜렐라치즈

            //야채선택
            if (checkBox4.Checked == true)
                strOrder += checkBox4.Text + "\n";    //양상추
            if (checkBox5.Checked == true)
                strOrder += checkBox5.Text + "\n";    //토마토
            if (checkBox6.Checked == true)
                strOrder += checkBox6.Text + "\n";     //오이
            if (checkBox7.Checked == true)
                strOrder += checkBox7.Text + "\n";    //양파
            if (checkBox8.Checked == true)
                strOrder += checkBox8.Text + "\n";    //피망
            if (checkBox9.Checked == true)
                strOrder += checkBox9.Text + "\n";   //피클
            if (checkBox10.Checked == true)
                strOrder += checkBox10.Text + "\n";   //올리브
            if (checkBox11.Checked == true)
                strOrder += checkBox11.Text + "\n";   //할라피뇨

            //소스선택
            if (checkBox12.Checked == true)
                strOrder += checkBox12.Text + "\n";   //스위트칠리
            if (checkBox13.Checked == true)
                strOrder += checkBox13.Text + "\n";   //마요네즈
            if (checkBox14.Checked == true)
                strOrder += checkBox14.Text + "\n";   //스위트어니언
            if (checkBox15.Checked == true)
                strOrder += checkBox15.Text + "\n";   //스모크바비큐
            if (checkBox16.Checked == true)
                strOrder += checkBox16.Text + "\n";   //머스타드
            if (checkBox17.Checked == true)
                strOrder += checkBox17.Text + "\n";   //후추


            lbMenu.Text = strOrder + "선택하였습니다.";     //체크박스 선택 후 선택버튼 누르면 선택메뉴 라벨에 나타남
        }

        private void label46_Click(object sender, EventArgs e)  //X
        {
        }
        private void checkBox20_CheckedChanged(object sender, EventArgs e)  //X
        {
        }

        private void button24_Click(object sender, EventArgs e)  //결제하기 탭에서 결제박스의 선택버튼
        {
            if (radioButton5.Checked == true)
            {
                MessageBox.Show("신용카드를 선택하였습니다.");   //신용카드 라디오버튼선택
            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show("모바일쿠폰을 선택하였습니다.");   //모바일쿠폰 라디오버튼선택
            }
            else if (radioButton4.Checked == true)
            {
                MessageBox.Show("삼성페이를 선택하였습니다.");   //삼성페이 라디오버튼선택
            }
            else if (radioButton6.Checked == true)
            {
                MessageBox.Show("간편결제를 선택하였습니다.");   //간편결제 라디오버튼선택
            }
            else
                MessageBox.Show("결제수단을 선택하세요.");      //선택 안했을 시
        }

        private void tabPage1_Click(object sender, EventArgs e) //X
        {
        }
        private void btnOrder1_Click(object sender, EventArgs e) //X
        {
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) //X
        {
        }
    }
}
