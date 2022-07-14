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
                    break;

                case State.Gameover:
                    GameoverLabel.Visible = true;
                    titileButton.Visible = true;
                    break;

                case State.Clear:
                    clearLabel.Visible = true;
                    titileButton.Visible = true;
                    hiLabel.Visible = true;
                    break;
            }

        }

        

        private void startbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void titileButton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }    
}    


