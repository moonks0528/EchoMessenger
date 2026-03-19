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

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSend1_Click(object sender, EventArgs e)
        {
            string typed_msg = txtMessage.Text;

            // 공백 제거
            typed_msg = typed_msg.Trim();

            // 공백 입력 방지
            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                return;
            }

            // 현재 시간 추가
            string time = DateTime.Now.ToString("HH:mm:ss");
            string result = $"[{time}] {typed_msg}";

            // ListBox에 추가
            lstMyMessage.Items.Add(result);

            // 메시지 개수 표시
            lblCount.Text = $"현재 대화: {lstMyMessage.Items.Count}개";

            // 입력창 초기화 + 포커스
            txtMessage.Clear();
            txtMessage.Focus();
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend1_Click(sender, e); // 버튼 클릭과 동일하게 실행
                e.SuppressKeyPress = true; // 엔터 소리/줄바꿈 방지
            }
        }
    }
}
