namespace Timer
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btncount = new System.Windows.Forms.Button();
            this.txtCountdown = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(21, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(189, 21);
            this.txtNum.TabIndex = 0;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btncount
            // 
            this.btncount.Location = new System.Drawing.Point(21, 49);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(189, 77);
            this.btncount.TabIndex = 1;
            this.btncount.Text = "카운트다운";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // txtCountdown
            // 
            this.txtCountdown.Font = new System.Drawing.Font("굴림", 20F);
            this.txtCountdown.Location = new System.Drawing.Point(21, 141);
            this.txtCountdown.Name = "txtCountdown";
            this.txtCountdown.ReadOnly = true;
            this.txtCountdown.Size = new System.Drawing.Size(189, 38);
            this.txtCountdown.TabIndex = 2;
            this.txtCountdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 194);
            this.Controls.Add(this.txtCountdown);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.txtNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "타이머";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.TextBox txtCountdown;
        private System.Windows.Forms.Timer Timer;
    }
}

