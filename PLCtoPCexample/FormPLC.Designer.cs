namespace PLCtoPCexample
{
    partial class FormPLC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Timer = new System.Windows.Forms.Timer(components);
            Connect = new Label();
            Disconnect = new Label();
            Exe = new Label();
            ReadData = new Label();
            DataReset = new Label();
            label4 = new Label();
            D0 = new TextBox();
            D1 = new TextBox();
            label5 = new Label();
            D2 = new TextBox();
            label6 = new Label();
            D5 = new TextBox();
            label7 = new Label();
            D4 = new TextBox();
            label8 = new Label();
            D3 = new TextBox();
            label9 = new Label();
            EventMemo = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // Connect
            // 
            Connect.BorderStyle = BorderStyle.FixedSingle;
            Connect.Font = new Font("맑은 고딕", 9F);
            Connect.Location = new Point(62, 40);
            Connect.Name = "Connect";
            Connect.Size = new Size(123, 47);
            Connect.TabIndex = 0;
            Connect.Text = "Connect";
            Connect.TextAlign = ContentAlignment.MiddleCenter;
            Connect.Click += Connect_Click;
            // 
            // Disconnect
            // 
            Disconnect.BorderStyle = BorderStyle.FixedSingle;
            Disconnect.Font = new Font("맑은 고딕", 9F);
            Disconnect.Location = new Point(216, 40);
            Disconnect.Name = "Disconnect";
            Disconnect.Size = new Size(123, 47);
            Disconnect.TabIndex = 0;
            Disconnect.Text = "Disconnect";
            Disconnect.TextAlign = ContentAlignment.MiddleCenter;
            Disconnect.Click += Disconnect_Click;
            // 
            // Exe
            // 
            Exe.BorderStyle = BorderStyle.FixedSingle;
            Exe.Font = new Font("맑은 고딕", 9F);
            Exe.Location = new Point(305, 106);
            Exe.Name = "Exe";
            Exe.Size = new Size(91, 37);
            Exe.TabIndex = 1;
            Exe.Text = "실행";
            Exe.TextAlign = ContentAlignment.MiddleCenter;
            Exe.Click += Exe_Click;
            // 
            // ReadData
            // 
            ReadData.BorderStyle = BorderStyle.FixedSingle;
            ReadData.Font = new Font("맑은 고딕", 9F);
            ReadData.Location = new Point(305, 152);
            ReadData.Name = "ReadData";
            ReadData.Size = new Size(91, 37);
            ReadData.TabIndex = 1;
            ReadData.Text = "현재값 읽기";
            ReadData.TextAlign = ContentAlignment.MiddleCenter;
            ReadData.Click += ReadData_Click;
            // 
            // DataReset
            // 
            DataReset.BorderStyle = BorderStyle.FixedSingle;
            DataReset.Font = new Font("맑은 고딕", 9F);
            DataReset.Location = new Point(305, 198);
            DataReset.Name = "DataReset";
            DataReset.Size = new Size(91, 37);
            DataReset.TabIndex = 1;
            DataReset.Text = "데이터 리셋";
            DataReset.TextAlign = ContentAlignment.MiddleCenter;
            DataReset.Click += DataReset_Click;
            // 
            // label4
            // 
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.Location = new Point(28, 112);
            label4.Name = "label4";
            label4.Size = new Size(35, 25);
            label4.TabIndex = 2;
            label4.Text = "D0";
            // 
            // D0
            // 
            D0.Location = new Point(62, 112);
            D0.Name = "D0";
            D0.ReadOnly = true;
            D0.Size = new Size(67, 23);
            D0.TabIndex = 3;
            // 
            // D1
            // 
            D1.Location = new Point(62, 140);
            D1.Name = "D1";
            D1.ReadOnly = true;
            D1.Size = new Size(67, 23);
            D1.TabIndex = 5;
            // 
            // label5
            // 
            label5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.Location = new Point(28, 140);
            label5.Name = "label5";
            label5.Size = new Size(35, 25);
            label5.TabIndex = 4;
            label5.Text = "D1";
            // 
            // D2
            // 
            D2.Location = new Point(62, 168);
            D2.Name = "D2";
            D2.ReadOnly = true;
            D2.Size = new Size(67, 23);
            D2.TabIndex = 7;
            // 
            // label6
            // 
            label6.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label6.Location = new Point(28, 168);
            label6.Name = "label6";
            label6.Size = new Size(35, 25);
            label6.TabIndex = 6;
            label6.Text = "D2";
            // 
            // D5
            // 
            D5.Location = new Point(169, 168);
            D5.Name = "D5";
            D5.ReadOnly = true;
            D5.Size = new Size(67, 23);
            D5.TabIndex = 13;
            // 
            // label7
            // 
            label7.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label7.Location = new Point(135, 168);
            label7.Name = "label7";
            label7.Size = new Size(35, 25);
            label7.TabIndex = 12;
            label7.Text = "D5";
            // 
            // D4
            // 
            D4.Location = new Point(169, 140);
            D4.Name = "D4";
            D4.ReadOnly = true;
            D4.Size = new Size(67, 23);
            D4.TabIndex = 11;
            // 
            // label8
            // 
            label8.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label8.Location = new Point(135, 140);
            label8.Name = "label8";
            label8.Size = new Size(35, 25);
            label8.TabIndex = 10;
            label8.Text = "D4";
            // 
            // D3
            // 
            D3.Location = new Point(169, 112);
            D3.Name = "D3";
            D3.ReadOnly = true;
            D3.Size = new Size(67, 23);
            D3.TabIndex = 9;
            // 
            // label9
            // 
            label9.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label9.Location = new Point(135, 112);
            label9.Name = "label9";
            label9.Size = new Size(35, 25);
            label9.TabIndex = 8;
            label9.Text = "D3";
            // 
            // EventMemo
            // 
            EventMemo.Location = new Point(13, 294);
            EventMemo.Name = "EventMemo";
            EventMemo.ReadOnly = true;
            EventMemo.Size = new Size(400, 23);
            EventMemo.TabIndex = 13;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 15);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 19);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "현재값 연속 읽기";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(166, 15);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 19);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "현재값 클릭 읽기";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(62, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 40);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // FormPLC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 327);
            Controls.Add(EventMemo);
            Controls.Add(groupBox1);
            Controls.Add(D5);
            Controls.Add(label7);
            Controls.Add(D4);
            Controls.Add(label8);
            Controls.Add(D3);
            Controls.Add(label9);
            Controls.Add(D2);
            Controls.Add(label6);
            Controls.Add(D1);
            Controls.Add(label5);
            Controls.Add(D0);
            Controls.Add(label4);
            Controls.Add(DataReset);
            Controls.Add(ReadData);
            Controls.Add(Exe);
            Controls.Add(Disconnect);
            Controls.Add(Connect);
            Name = "FormPLC";
            Text = "Form1";
            Load += FormPLC_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private Label Connect;
        private Label Disconnect;
        private Label Exe;
        private Label ReadData;
        private Label DataReset;
        private Label label4;
        private TextBox D0;
        private TextBox D1;
        private Label label5;
        private TextBox D2;
        private Label label6;
        private TextBox D5;
        private Label label7;
        private TextBox D4;
        private Label label8;
        private TextBox D3;
        private Label label9;
        private TextBox EventMemo;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
    }
}
