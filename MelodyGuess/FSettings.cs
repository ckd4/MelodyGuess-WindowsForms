using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MelodyGuess
{
    public partial class FSettings : Form
    {
        public FSettings()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Victorina.AllDir = Subfolders.Checked;
            Victorina.gameduration = Convert.ToInt32(CBDurationGame.Text);
            Victorina.musicduration = Convert.ToInt32(CBResponsetime.Text);
            Victorina.randomStart = cbRandomPlace.Checked;
            Victorina.WriteSet();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Set();
            Hide();
        }
        
        void Set()
        {
            Subfolders.Checked = Victorina.AllDir;
            CBDurationGame.Text = Victorina.gameduration.ToString();
            CBResponsetime.Text = Victorina.musicduration.ToString();
            cbRandomPlace.Checked = Victorina.randomStart;
        }

        private void Download_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string[] musiclist = Directory.GetFiles(FBD.SelectedPath, "*.mp3", Subfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                Victorina.LastFolder = FBD.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(musiclist);

                Victorina.list.Clear();
                Victorina.list.AddRange(musiclist);
            }
        }

        private void FSettings_Load(object sender, EventArgs e)
        {
            Set();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Victorina.list.ToArray());
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
