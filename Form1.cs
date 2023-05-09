using System.Diagnostics;
using System.DirectoryServices;

namespace HitMouse
{
	public partial class Form1 : Form
	{
		int time_left;
		int score = 0;
		Button[] btnlist;
		bool[] btnStatus = new bool[9];
		public Form1()
		{
			InitializeComponent();
			Difficulty.Items.Add("Easy");
			Difficulty.Items.Add("Normal");
			Difficulty.Items.Add("Hard");
			//Difficulty.Items.Add("亞洲");
			EventTime.Interval = 500;
			GameTime.Interval = 1000;
			btnlist = new Button[9]
			{
				GM1, GM2, GM3, GM4, GM5, GM6, GM7, GM8, GM9
			};
		}

		private void btn_clicked(object sender, EventArgs e)
		{
			int index = ((Button)sender).Name.ToString()[2] - '0' - 1;
			if (btnStatus[index] == true)
			{
				btnStatus[index] = false;
				score++;
				Score.Text = "分數： " + score.ToString();
			}
			Debug.WriteLine("Clicked button: " + index + " from btn_clicked");
		}

		private void EventTime_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < btnStatus.Length; i++)
			{
				btnStatus[i] = false;
				//btnlist[i].Text = "";
				btnlist[i].Image = null;
			}
			switch (Difficulty.SelectedItem.ToString())
			{
				case "Easy":
					Random rnd = new Random();
					if (rnd.Next(3) != 0) //66% 機率出現地鼠
					{
						MouseAppear(rnd.Next(9));
					}
					break;

				default:
					Debug.WriteLine("ERROR INDEX");
					break;
			}
		}

		private void MouseAppear(int location)
		{
			btnStatus[location] = true;
			//btnlist[location].Text = "地鼠";
			btnlist[location].Image = new Bitmap(Properties.Resources.mouse, GM1.Size);
		}

		private void StartBtn_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 9; i++)
			{
				btnlist[i].Text = "";
				btnStatus[i] = false;
			}
			time_left = 10; //sec
			EventTime.Start();
			GameTime.Start();
			if (Difficulty.SelectedItem == null)
				Difficulty.SelectedIndex = 0;
		}

		private void GameStop()
		{
			EventTime.Stop();
			GameTime.Stop();
		}

		private void GameTime_Tick(object sender, EventArgs e)
		{
			TimeLeft.Text = "剩餘時間： " + time_left.ToString();
			if (time_left <= 0)
			{
				TimeLeft.Text = "時間結束！！";
				GameStop();
			}
			time_left--;
			Debug.WriteLine("Time left: " + time_left);
		}

		private void StopBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}