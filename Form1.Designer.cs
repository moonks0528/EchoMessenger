namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend1 = new System.Windows.Forms.Button();
            this.lblMessenger = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lstMyMessage = new System.Windows.Forms.ListBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend1
            // 
            this.btnSend1.BackColor = System.Drawing.Color.Yellow;
            this.btnSend1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSend1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSend1.Location = new System.Drawing.Point(721, 576);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(215, 76);
            this.btnSend1.TabIndex = 0;
            this.btnSend1.Text = "전송";
            this.btnSend1.UseVisualStyleBackColor = false;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            // 
            // lblMessenger
            // 
            this.lblMessenger.AutoSize = true;
            this.lblMessenger.Font = new System.Drawing.Font("굴림", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMessenger.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMessenger.Location = new System.Drawing.Point(77, 25);
            this.lblMessenger.Name = "lblMessenger";
            this.lblMessenger.Size = new System.Drawing.Size(623, 75);
            this.lblMessenger.TabIndex = 1;
            this.lblMessenger.Text = "Echo Messenger";
            this.lblMessenger.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMessage.Location = new System.Drawing.Point(76, 593);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(626, 44);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // lstMyMessage
            // 
            this.lstMyMessage.Font = new System.Drawing.Font("굴림", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lstMyMessage.FormattingEnabled = true;
            this.lstMyMessage.ItemHeight = 37;
            this.lstMyMessage.Location = new System.Drawing.Point(76, 127);
            this.lstMyMessage.Name = "lstMyMessage";
            this.lstMyMessage.Size = new System.Drawing.Size(860, 411);
            this.lstMyMessage.TabIndex = 3;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("굴림", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCount.Location = new System.Drawing.Point(745, 71);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(149, 29);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "현재 대화:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(955, 522);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 53);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "선택항목삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(955, 582);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 55);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 682);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lstMyMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessenger);
            this.Controls.Add(this.btnSend1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Label lblMessenger;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListBox lstMyMessage;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}

