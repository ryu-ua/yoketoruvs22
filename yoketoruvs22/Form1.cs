using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoketoruvs22
{
    public partial class よけとる2022 : Form
    {
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



        public よけとる2022()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState!=State.None)
            {
                initProc();
            }

            void initProc()
            {
                currentState = nextState;
                nextState = State.None;
            }


            switch (currentState)
            {
                case State.Title:
                    titleLabel.Visible=true;
                    startbutton.Visible = true;
                    CPLabel.Visible = true;
                    hiLabel.Visible=true;
                    label1.Visible=false;
                    clearLabel.Visible=false;
                    titileButton.Visible=false;
                    break;

                case State.Game:
                    titleLabel.Visible = false;
                    startbutton.Visible = false;
                    CPLabel.Visible = false;
                    hiLabel.Visible = false;
                    break;
            }
        
            

        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }    
}    


