namespace DrawMapFengShui.WinApp
{
    partial class frmFS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDraw = new System.Windows.Forms.Button();
            this.txtBegin = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTanA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCenter = new System.Windows.Forms.Button();
            this.txtCenter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDrawCenter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(22, 153);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "画线并计算";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // txtBegin
            // 
            this.txtBegin.Location = new System.Drawing.Point(117, 27);
            this.txtBegin.Name = "txtBegin";
            this.txtBegin.Size = new System.Drawing.Size(100, 21);
            this.txtBegin.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(22, 27);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "捕获开始点";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            this.btnBegin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBegin_KeyDown);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(22, 73);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "捕获结束点";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            this.btnEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEnd_KeyDown);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(117, 73);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 21);
            this.txtEnd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "(x,y)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "(x,y)";
            // 
            // txtTanA
            // 
            this.txtTanA.Location = new System.Drawing.Point(158, 153);
            this.txtTanA.Name = "txtTanA";
            this.txtTanA.Size = new System.Drawing.Size(100, 21);
            this.txtTanA.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "tan(a)=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "角度a=";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(158, 126);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(100, 21);
            this.txtAngle.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "(x,y)";
            // 
            // btnCenter
            // 
            this.btnCenter.Location = new System.Drawing.Point(22, 236);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(75, 23);
            this.btnCenter.TabIndex = 12;
            this.btnCenter.Text = "捕获中心点";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            this.btnCenter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCenter_KeyDown);
            // 
            // txtCenter
            // 
            this.txtCenter.Location = new System.Drawing.Point(117, 236);
            this.txtCenter.Name = "txtCenter";
            this.txtCenter.Size = new System.Drawing.Size(100, 21);
            this.txtCenter.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(21, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 1);
            this.label6.TabIndex = 14;
            // 
            // btnDrawCenter
            // 
            this.btnDrawCenter.Location = new System.Drawing.Point(22, 294);
            this.btnDrawCenter.Name = "btnDrawCenter";
            this.btnDrawCenter.Size = new System.Drawing.Size(75, 23);
            this.btnDrawCenter.TabIndex = 15;
            this.btnDrawCenter.Text = "画线";
            this.btnDrawCenter.UseVisualStyleBackColor = true;
            this.btnDrawCenter.Click += new System.EventHandler(this.btnDrawCenter_Click);
            // 
            // frmFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 465);
            this.Controls.Add(this.btnDrawCenter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.txtCenter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTanA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.txtBegin);
            this.Controls.Add(this.btnDraw);
            this.Name = "frmFS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测风水";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtBegin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTanA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.TextBox txtCenter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDrawCenter;
    }
}

