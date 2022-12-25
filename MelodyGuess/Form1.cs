using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelodyGuess
{
    public partial class MainForm : Form
    {
        FSettings FS = new FSettings();
        Fgame FG = new Fgame();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            FS.ShowDialog(); //Модальное окно
        }

        private void Play_Click(object sender, EventArgs e)
        {
            FG.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Victorina.ReadSet();
            Victorina.ReadMusic();
        }
    }
}
