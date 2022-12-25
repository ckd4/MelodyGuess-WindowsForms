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
    public partial class Fgame : Form
    {
        //int a = 0;
        FSettings FS = new FSettings();
        Random rnd = new Random();
        int durationMusic = Victorina.musicduration;
        bool[] players = new bool[2];

        public Fgame()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                MakeMusic();
            }
            catch
            {
                MessageBox.Show("The song list is empty", "Error!");
            }
        }

        void MakeMusic()
        {
            if (Victorina.list.Count == 0) EndGame();
            else
            {
                durationMusic = Victorina.musicduration;
                int n = rnd.Next(0, Victorina.list.Count);
                WMP.URL = Victorina.list[n];
                Victorina.Answer = System.IO.Path.GetFileNameWithoutExtension(WMP.URL);
                WMP.Ctlcontrols.play();
                Victorina.list.RemoveAt(n);
                lblMelodyCount.Text = Victorina.list.Count.ToString();
                players[0] = false;
                players[1] = false;
            }
        }

        private void Fgame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void Fgame_Load(object sender, EventArgs e)
        {
            MD.Text = durationMusic.ToString();
            lblMelodyCount.Text = Victorina.list.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.gameduration;
        }

        void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
            progressBar1.Value++;
            durationMusic--;
            MD.Text = durationMusic.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if (durationMusic == 0)
                MakeMusic();
            }
            catch
            {
                Close();
                MessageBox.Show("Progress bar is stuck due to overflow max value!", "Error");
                return;
            }

        }

        private void Pause_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        void GamePlay()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        private void Fgame_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == false) return;
            if (players[0] == false && e.KeyData == Keys.Q)
            {
                GamePause();
                FMessage FM = new FMessage();
                FM.LBLmes.Text = "Игрок 1";
                SoundPlayer sp = new SoundPlayer("C:/Users/Ckd4/source/repos/MelodyGuess/Resources/new_message_notice.wav");
                sp.PlaySync();
                players[0] = true;
                if (FM.ShowDialog() == DialogResult.Yes)
                {
                    Player1.Text = Convert.ToString(Convert.ToInt32(Player1.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
            if (players[1] == false && e.KeyData == Keys.P)
            {
                GamePause();
                FMessage FM = new FMessage();
                FM.LBLmes.Text = "Игрок 2";
                SoundPlayer sp = new SoundPlayer("C:/Users/Ckd4/source/repos/MelodyGuess/Resources/new_message_notice.wav");
                sp.PlaySync();
                players[1] = true;
                if (FM.ShowDialog() == DialogResult.Yes)
                {
                    Player2.Text = Convert.ToString(Convert.ToInt32(Player2.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart==true)
                if (WMP.openState==WMPLib.WMPOpenState.wmposMediaOpen)
                {
                    WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)WMP.currentMedia.duration / 2);
                }
        }

        private void Player1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                (sender as Label).Text = Convert.ToString(Convert.ToInt32(Player1.Text) + 1);
            if (e.Button == MouseButtons.Right)
                (sender as Label).Text = Convert.ToString(Convert.ToInt32(Player1.Text) - 1);
        }

        private void Player2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                (sender as Label).Text = Convert.ToString(Convert.ToInt32(Player2.Text) + 1);
            if (e.Button == MouseButtons.Right)
                (sender as Label).Text = Convert.ToString(Convert.ToInt32(Player2.Text) - 1);
        }
    }
}
