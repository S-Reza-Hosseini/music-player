using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Media;

namespace az_payegahDadeh
{
    class Mp3Player
    {
        [System.Runtime.InteropServices.DllImport("winmm.dll")]

        private static extern long mciSendString(String lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdCallBack);

        public void open(String File)
        {
            String Format = @"open""{0}""type MPEGVideo alias MediaFile";
            String command = String.Format(Format, File);

        }

        public void play()
        {
            String command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public void stop()
        {
            String command = "Stop MediaFile";
            mciSendString(command, null, 0, 0);

        }
       

        /*string musicFilePath = Path.Combine(Application.StartupPath, "music.wav");
        SoundPlayer soundPlayer = new SoundPlayer('C:/);
        soundPlayer.Play();*/


    }
}
