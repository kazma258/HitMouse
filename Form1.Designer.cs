namespace HitMouse
{
	partial class Form1
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
			label1 = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			GM1 = new Button();
			GM2 = new Button();
			GM3 = new Button();
			GM4 = new Button();
			GM5 = new Button();
			GM6 = new Button();
			GM7 = new Button();
			GM8 = new Button();
			GM9 = new Button();
			StartBtn = new Button();
			TimeLeft = new TextBox();
			Difficulty = new ComboBox();
			StopBtn = new Button();
			EventTime = new System.Windows.Forms.Timer(components);
			GameTime = new System.Windows.Forms.Timer(components);
			Score = new Label();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(328, 3);
			label1.Name = "label1";
			label1.Size = new Size(117, 26);
			label1.TabIndex = 0;
			label1.Text = "打地鼠遊戲";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.Controls.Add(label1, 1, 0);
			tableLayoutPanel1.Location = new Point(12, 9);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(776, 33);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// GM1
			// 
			GM1.Location = new Point(32, 76);
			GM1.Name = "GM1";
			GM1.Size = new Size(100, 100);
			GM1.TabIndex = 2;
			GM1.UseVisualStyleBackColor = true;
			GM1.Click += btn_clicked;
			// 
			// GM2
			// 
			GM2.Location = new Point(138, 76);
			GM2.Name = "GM2";
			GM2.Size = new Size(100, 100);
			GM2.TabIndex = 2;
			GM2.UseVisualStyleBackColor = true;
			GM2.Click += btn_clicked;
			// 
			// GM3
			// 
			GM3.Location = new Point(244, 76);
			GM3.Name = "GM3";
			GM3.Size = new Size(100, 100);
			GM3.TabIndex = 2;
			GM3.UseVisualStyleBackColor = true;
			GM3.Click += btn_clicked;
			// 
			// GM4
			// 
			GM4.Location = new Point(32, 182);
			GM4.Name = "GM4";
			GM4.Size = new Size(100, 100);
			GM4.TabIndex = 2;
			GM4.UseVisualStyleBackColor = true;
			GM4.Click += btn_clicked;
			// 
			// GM5
			// 
			GM5.Location = new Point(138, 182);
			GM5.Name = "GM5";
			GM5.Size = new Size(100, 100);
			GM5.TabIndex = 2;
			GM5.UseVisualStyleBackColor = true;
			GM5.Click += btn_clicked;
			// 
			// GM6
			// 
			GM6.Location = new Point(244, 182);
			GM6.Name = "GM6";
			GM6.Size = new Size(100, 100);
			GM6.TabIndex = 2;
			GM6.UseVisualStyleBackColor = true;
			GM6.Click += btn_clicked;
			// 
			// GM7
			// 
			GM7.Location = new Point(32, 288);
			GM7.Name = "GM7";
			GM7.Size = new Size(100, 100);
			GM7.TabIndex = 2;
			GM7.UseVisualStyleBackColor = true;
			GM7.Click += btn_clicked;
			// 
			// GM8
			// 
			GM8.Location = new Point(138, 288);
			GM8.Name = "GM8";
			GM8.Size = new Size(100, 100);
			GM8.TabIndex = 2;
			GM8.UseVisualStyleBackColor = true;
			GM8.Click += btn_clicked;
			// 
			// GM9
			// 
			GM9.Location = new Point(244, 288);
			GM9.Name = "GM9";
			GM9.Size = new Size(100, 100);
			GM9.TabIndex = 2;
			GM9.UseVisualStyleBackColor = true;
			GM9.Click += btn_clicked;
			// 
			// StartBtn
			// 
			StartBtn.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			StartBtn.Location = new Point(582, 182);
			StartBtn.Name = "StartBtn";
			StartBtn.Size = new Size(185, 42);
			StartBtn.TabIndex = 1;
			StartBtn.Text = "開始遊戲";
			StartBtn.UseVisualStyleBackColor = true;
			StartBtn.Click += StartBtn_Click;
			// 
			// TimeLeft
			// 
			TimeLeft.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			TimeLeft.Location = new Point(388, 190);
			TimeLeft.Name = "TimeLeft";
			TimeLeft.Size = new Size(162, 28);
			TimeLeft.TabIndex = 3;
			TimeLeft.Text = "剩餘時間";
			// 
			// Difficulty
			// 
			Difficulty.FormattingEnabled = true;
			Difficulty.Location = new Point(388, 288);
			Difficulty.Name = "Difficulty";
			Difficulty.Size = new Size(121, 23);
			Difficulty.TabIndex = 4;
			// 
			// StopBtn
			// 
			StopBtn.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			StopBtn.Location = new Point(582, 276);
			StopBtn.Name = "StopBtn";
			StopBtn.Size = new Size(185, 42);
			StopBtn.TabIndex = 1;
			StopBtn.Text = "結束遊戲";
			StopBtn.UseVisualStyleBackColor = true;
			StopBtn.Click += StopBtn_Click;
			// 
			// EventTime
			// 
			EventTime.Tick += EventTime_Tick;
			// 
			// GameTime
			// 
			GameTime.Tick += GameTime_Tick;
			// 
			// Score
			// 
			Score.AutoSize = true;
			Score.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			Score.Location = new Point(388, 95);
			Score.Name = "Score";
			Score.Size = new Size(85, 30);
			Score.TabIndex = 5;
			Score.Text = "分數：";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(802, 450);
			Controls.Add(Score);
			Controls.Add(Difficulty);
			Controls.Add(TimeLeft);
			Controls.Add(GM9);
			Controls.Add(StopBtn);
			Controls.Add(StartBtn);
			Controls.Add(GM6);
			Controls.Add(GM3);
			Controls.Add(GM8);
			Controls.Add(GM5);
			Controls.Add(GM2);
			Controls.Add(GM7);
			Controls.Add(GM4);
			Controls.Add(GM1);
			Controls.Add(tableLayoutPanel1);
			Name = "Form1";
			Text = "Form1";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TableLayoutPanel tableLayoutPanel1;
		private Button GM1;
		private Button GM2;
		private Button GM3;
		private Button GM4;
		private Button GM5;
		private Button GM6;
		private Button GM7;
		private Button GM8;
		private Button GM9;
		private Button StartBtn;
		private TextBox TimeLeft;
		private ComboBox Difficulty;
		private Button StopBtn;
		private System.Windows.Forms.Timer EventTime;
		private System.Windows.Forms.Timer GameTime;
		private Label Score;
	}
}