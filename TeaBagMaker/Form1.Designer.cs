namespace TeaBagMaker
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
            this.components = new System.ComponentModel.Container();
            this.TList = new System.Windows.Forms.ComboBox();
            this.push = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timecount = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TList
            // 
            this.TList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TList.FormattingEnabled = true;
            this.TList.Location = new System.Drawing.Point(13, 13);
            this.TList.Name = "TList";
            this.TList.Size = new System.Drawing.Size(218, 20);
            this.TList.TabIndex = 0;
            // 
            // push
            // 
            this.push.Location = new System.Drawing.Point(10, 119);
            this.push.Name = "push";
            this.push.Size = new System.Drawing.Size(218, 60);
            this.push.TabIndex = 1;
            this.push.Text = "담그기!";
            this.push.UseVisualStyleBackColor = true;
            this.push.Click += new System.EventHandler(this.Push_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // timecount
            // 
            this.timecount.AutoSize = true;
            this.timecount.Location = new System.Drawing.Point(12, 53);
            this.timecount.Name = "timecount";
            this.timecount.Size = new System.Drawing.Size(95, 48);
            this.timecount.TabIndex = 2;
            this.timecount.Text = "홍차 : 2분\r\n녹차 : 3분\r\n루이보스차 : 5분\r\n국화차 : 2분";
            // 
            // countdown
            // 
            this.countdown.Font = new System.Drawing.Font("굴림", 20F);
            this.countdown.Location = new System.Drawing.Point(10, 206);
            this.countdown.Name = "countdown";
            this.countdown.ReadOnly = true;
            this.countdown.Size = new System.Drawing.Size(100, 38);
            this.countdown.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "2019-05-24 3204 김수민";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.timecount);
            this.Controls.Add(this.push);
            this.Controls.Add(this.TList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "티백메이커";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TList;
        private System.Windows.Forms.Button push;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timecount;
        private System.Windows.Forms.TextBox countdown;
        private System.Windows.Forms.Label label1;
    }
}

