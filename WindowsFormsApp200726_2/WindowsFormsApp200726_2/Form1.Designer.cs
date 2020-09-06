namespace WindowsFormsApp200726_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tBox_main = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tBox_input = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tBox_main);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 561);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "채팅";
            // 
            // tBox_main
            // 
            this.tBox_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBox_main.Location = new System.Drawing.Point(3, 17);
            this.tBox_main.Multiline = true;
            this.tBox_main.Name = "tBox_main";
            this.tBox_main.ReadOnly = true;
            this.tBox_main.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBox_main.Size = new System.Drawing.Size(778, 510);
            this.tBox_main.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_input);
            this.panel1.Controls.Add(this.tBox_input);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 527);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 31);
            this.panel1.TabIndex = 1;
            // 
            // tBox_input
            // 
            this.tBox_input.Dock = System.Windows.Forms.DockStyle.Left;
            this.tBox_input.Location = new System.Drawing.Point(0, 0);
            this.tBox_input.Multiline = true;
            this.tBox_input.Name = "tBox_input";
            this.tBox_input.Size = new System.Drawing.Size(700, 31);
            this.tBox_input.TabIndex = 2;
            // 
            // btn_input
            // 
            this.btn_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_input.Location = new System.Drawing.Point(700, 0);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(78, 31);
            this.btn_input.TabIndex = 3;
            this.btn_input.Text = "Enter";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.TextBox tBox_input;
        private System.Windows.Forms.TextBox tBox_main;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

