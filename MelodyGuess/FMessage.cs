using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MelodyGuess
{
    public partial class FMessage : Form
    {
        int timerAnswer = 10;
        public FMessage()
        {
            InitializeComponent();
        }

        private void FMessage_Load(object sender, EventArgs e)
        {
            timerAnswer = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerAnswer--;
            Timer2.Text = timerAnswer.ToString();
            if (timerAnswer == 0)
            {
                timer1.Stop();
                SoundPlayer sp = new SoundPlayer("C:/Users/Ckd4/source/repos/MelodyGuess/Resources/new_message_notice.wav");
                sp.Play();
            }

        }

        private void FMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void lblShowAnswer_Click(object sender, EventArgs e)
        {
            lblShowAnswer.Text = Victorina.Answer;
        }
    }
}
