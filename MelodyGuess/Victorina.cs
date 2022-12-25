using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace MelodyGuess
{
    static class Victorina
    {
        static public List<string> list = new List<string>();
        static public int gameduration = 60;
        static public int musicduration = 10;
        static public bool randomStart = false;
        static public bool AllDir = false;
        static public string LastFolder = "";
        static public string Answer = "";

        static public void ReadMusic()
        {
            try
            {
                string[] musiclist = Directory.GetFiles(LastFolder, "*.mp3", AllDir ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                list.Clear();
                list.AddRange(musiclist);
            }
            catch
            {

            }
        }

        static string regKeyName = "Software\\MyCompany\\MelodyGuess";

        public static void WriteSet()
        {
            RegistryKey RK = null;
            try
            {
                RK = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (RK == null) 
                    return;

                RK.SetValue("LastFolder", LastFolder);
                RK.SetValue("RandomStart", randomStart);
                RK.SetValue("GameDuration", gameduration);
                RK.SetValue("MusicDuration", musicduration);
                RK.SetValue("AllDirectories", AllDir);

            }
            finally
            {
                if (RK != null)
                    RK.Close();
            }
        }
        public static void ReadSet()
        {
            RegistryKey RK = null;
            try
            {
                RK = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (RK == null)
                    return;

                LastFolder = (string)RK.GetValue("LastFolder");
                randomStart = Convert.ToBoolean(RK.GetValue("RandomStart", false));
                gameduration = (int)RK.GetValue("GameDuration");
                musicduration = (int)RK.GetValue("MusicDuration");
                AllDir = Convert.ToBoolean(RK.GetValue("AllDirectories", false));
            }
            finally
            {
                if (RK != null)
                    RK.Close();
            }
        }
    }
}
