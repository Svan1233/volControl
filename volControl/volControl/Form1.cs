using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioSwitcher.AudioApi.CoreAudio;


namespace volControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

        private void btnVU_Click(object sender, EventArgs e)
        {
            defaultPlaybackDevice.Volume = defaultPlaybackDevice.Volume + 10.0;
        }

        private void btnVD_Click(object sender, EventArgs e)
        {
            defaultPlaybackDevice.Volume = defaultPlaybackDevice.Volume - 10.0;
        }

        private void slider_Scroll(object sender, EventArgs e)
        {
            defaultPlaybackDevice.Volume = slider.Value;
        }
    }
}
