using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoruvs22
{
    public partial class よけとる2022 : Form
    {
        const bool isDebug = true;

        const int SpeedMax = 10;
        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;
        const int StartTime = 100;

        const string PlayerText= "('m')";
        const string EnemyText = "<・>";
        const string ItemText = "♦";

        static Random rand = new Random();
        
        int itemCount;
        int time;
        int hiscore;

        enum State
        {
            None=-1,
            Title,
            Game,
            Gameover,
            Clear,

        }
        State currentState = State.None;
        State nextState = State.Title;

        [DllImport("user32.dll")]

        public static extern short GetAsyncKeyState(int vKey);

        public よけとる2022()
        {
            InitializeComponent();

            for(int i=0;i<ChrMax;i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if(i==PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if(i<ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                chrs[i].Font = tempLabel.Font;
                Controls.Add(chrs[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           
           
            if (nextState != State.None)
            {
                initProc();
            }

            if (isDebug)
            {
                if(GetAsyncKeyState((int)Keys.O)<0)
                {
                    nextState = State.Gameover;
                }

               else if(GetAsyncKeyState((int)Keys.C)<0)
                {
                    nextState = State.Clear;
                }

            }
            if(currentState==State.Game)
            {
                UpdateGame();
            }

         }

        void UpdateGame()
        {
            time--;
            timeLabel.Text = $"Time{time:000}";
            

            Point mp = PointToClient(MousePosition);
            // TODO: mpがプレイヤーの中心になるように設定
            chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width / 2;
            chrs[PlayerIndex].Left = mp.Y - chrs[PlayerIndex].Height / 2;
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            chrs[PlayerIndex].Left = fpos.X - chrs[PlayerIndex].Width / 2;
            chrs[PlayerIndex].Top = fpos.Y - chrs[PlayerIndex].Height / 2;

            for (int i = EnemyIndex; i < ChrMax; i++)
            {
                if (!chrs[i].Visible) continue;//Visibleはbool型

                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];

                if (chrs[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }

                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }

                if (chrs[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }

                if (chrs[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }

                //当たり判定
                if ((mp.X >= chrs[i].Left) && (mp.X < chrs[i].Right)
                    && (mp.Y >= chrs[i].Top) && (mp.Y < chrs[i].Bottom))
                {
                    //MessageBox.Show("当たった!");
                    //敵か？
                    if (i < ItemIndex)
                    {
                        nextState = State.Gameover;
                    }
                    else
                    {
                        chrs[i].Visible = false;
                        itemCount--;
                        if (itemCount <= 0)
                        {
                            nextState = State.Clear;
                        }
                        leftLabel.Text = $"♦:{itemCount:00}";

                    }
                }
            }    
            
            if ((time <= 0) && (nextState == State.None))
            {
               nextState = State.Gameover;
            }
            
        }
        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    titleLabel.Visible = true;
                    startbutton.Visible = true;
                    CPLabel.Visible = true;
                    hiLabel.Visible = true;
                    GameoverLabel.Visible = false;
                    clearLabel.Visible = false;
                    titileButton.Visible = false;
                    break;

                case State.Game:
                    titleLabel.Visible = false;
                    startbutton.Visible = false;
                    CPLabel.Visible = false;
                    hiLabel.Visible = false;
                    

                    for (int i = EnemyIndex; i<ChrMax;i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        chrs[i].Visible = true;
                        
                    }

                    itemCount = ItemMax;
                    time = StartTime+1;
                    leftLabel.Text = $"♦:{itemCount:00}";
                    break;

                case State.Gameover:
                    GameoverLabel.Visible = true;
                    titileButton.Visible = true;
                    break;

                case State.Clear:
                    clearLabel.Visible = true;
                    titileButton.Visible = true;
                    hiLabel.Visible = true;
                    if(time>hiscore)
                    {
                        hiscore = time;
                        hiLabel.Text = "HighScore" + hiscore;
                    }
                    break;
            }

        }

        

        private void startbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;//ゲーム画面へ
        }

        private void titileButton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;//タイトルへ
        }
    }    
}    


