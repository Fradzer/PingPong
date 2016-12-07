using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PingPong
{
    public partial class PlayForm : Form
    {
        private Form1 form1;
        private Platform leftPlatform;
        private Platform rightPlatform;

        private int lastFirstCoord;
        private int lastSecondCoord;
        private System.Timers.Timer checkTimer;
        private System.Timers.Timer speedUpTimer;
        private int epsPlatform = 5;
        private int speedUpTime = 10;

        private int leftWins = 0;
        private int rightWins = 0;

        public PlayForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            Ball.CoordX = PlayPictureBox.Width / 2;
            Ball.CoordY = PlayPictureBox.Height / 2;

            setCheckTimer();
            setSpeedUpTimer(speedUpTime);
        }

        private void setCheckTimer()
        {
            checkTimer = new System.Timers.Timer(100);
            checkTimer.Elapsed += new ElapsedEventHandler(checkCoord);
            checkTimer.Elapsed += new ElapsedEventHandler(checkBallCoord);
            checkTimer.Start();
        }


        private void setSpeedUpTimer(int time)
        {
            speedUpTimer = new System.Timers.Timer(1000 * time);
            speedUpTimer.Elapsed += new ElapsedEventHandler(speedUp);
            speedUpTimer.Start();

        }
        

        private void checkCoord(object sender, ElapsedEventArgs eventArgs)
        {
            try
            {
                Graphics g = PlayPictureBox.CreateGraphics();
                g.Clear(Color.White);

                DrawRects(g);
                DrawBall(g);
                //PlayPictureBox.Refresh();
            }
            catch
            {

            }
        }

        private void DrawBall(Graphics g)
        {
            using (Pen pen = new Pen(Color.Green, Ball.Size))
            {
                g.DrawEllipse(pen, Ball.CoordX, Ball.CoordY, Ball.Size, Ball.Size);
            }
        }

        private void DrawRects(Graphics g)
        {
            setTrueCoord();
            List<Rectangle> rectangles = new List<Rectangle>() { leftPlatform.Figure, rightPlatform.Figure };

            using (Pen pen = new Pen(Color.Red, Platform.Width))
            {
                g.DrawRectangles(pen, rectangles.ToArray());
            }
        }

        private void setTrueCoord()
        {
            if (form1.FirstR.Y != 0)
            {
                lastFirstCoord = form1.FirstR.Y * 2;
            }
            leftPlatform = new Platform(50, lastFirstCoord);

            if (form1.SecondR.Y != 0)
            {
                lastSecondCoord = form1.SecondR.Y * 2;
            }
            rightPlatform = new Platform(PlayPictureBox.Width - 50, lastSecondCoord);

        }

        private void checkBallCoord(object sender, ElapsedEventArgs eventArgs)
        {
            try
            {
                if (lastFirstCoord != 0 && lastSecondCoord != 0)
                {
                    if (Ball.CoordY >= PlayPictureBox.Height || Ball.CoordY <= 0)
                    {
                        Ball.SpeedY = -Ball.SpeedY;
                    }
                    if (Ball.CoordX < leftPlatform.Figure.X || Ball.CoordX > rightPlatform.Figure.X)
                    {
                        checkTimer.Stop();
                        speedUpTimer.Stop();
                        if (Ball.CoordX < leftPlatform.Figure.X)
                        {
                            rightWins += 1;
                        }
                        else
                        {
                            leftWins += 1;
                        }
                        LeftWinsLabel.Invoke(new Action(() => LeftWinsLabel.Text = leftWins.ToString()));
                        RightWinsLabel.Invoke(new Action(() => RightWinsLabel.Text = rightWins.ToString()));

                    }

                    //check on ping leftPlatform
                    if (((Ball.CoordX - Ball.Size * 2) < (leftPlatform.Figure.X + Platform.Width) &&
                        (Ball.CoordY <= (leftPlatform.Figure.Y + Platform.Height + epsPlatform) && Ball.CoordY >= (leftPlatform.Figure.Y - epsPlatform))))
                    {
                        if ((Ball.CoordY > leftPlatform.Figure.Y + Platform.Height / 2 && Ball.SpeedY < 0) ||
                            Ball.CoordY <= leftPlatform.Figure.Y + Platform.Height / 2 && Ball.SpeedY > 0)
                        {
                            Ball.SpeedY = -Ball.SpeedY;
                        }
                        Ball.SpeedX = -Ball.SpeedX;
                    }

                    //check on ping rightPlatform
                    if (((Ball.CoordX + Ball.Size * 2) > (rightPlatform.Figure.X - Platform.Width) &&
                        (Ball.CoordY <= (rightPlatform.Figure.Y + Platform.Height + epsPlatform) && Ball.CoordY >= (rightPlatform.Figure.Y - epsPlatform))))    //check on ping rightPlatform
                    {
                        if ((Ball.CoordY > rightPlatform.Figure.Y + Platform.Height / 2 && Ball.SpeedY < 0) ||
                            Ball.CoordY <= rightPlatform.Figure.Y + Platform.Height / 2 && Ball.SpeedY > 0)
                        {
                            Ball.SpeedY = -Ball.SpeedY;
                        }

                        Ball.SpeedX = -Ball.SpeedX;
                    }
                    Ball.MoveByX();
                    Ball.MoveByY();
                }
            }
            catch
            {
                checkTimer.Stop();
                speedUpTimer.Stop();
            }
        }

        private void speedUp(object sender, ElapsedEventArgs e)
        {
            Ball.SpeedX += Ball.SpeedX > 0 ? 5 : -5;
            Ball.SpeedY += Ball.SpeedY > 0 ? 5 : -5;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            checkTimer.Stop();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Ball.SetParams(10, 10, PlayPictureBox.Width / 2, PlayPictureBox.Height / 2);
            speedUpTimer.Start();
            checkTimer.Start();
        }

        private void setScore()
        {
            LeftWinsLabel.Text = Convert.ToString(leftWins);
            RightWinsLabel.Text = Convert.ToString(RightWinsLabel);
        }


    }
}
