using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoPlayerDCEU
{
    public partial class Form1 : Form
    {

        int vl = 50;
        int play = 0;
        public OpenFileDialog archivo = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BarVolumen.Visible = true;
        }

        private void BarVolumen_MouseLeave(object sender, EventArgs e)
        {
            BarVolumen.Visible = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(play == 1)
            {
                AbrirMusica();
                play = 2;
            }
            else if(play == 2)
            {
                MediaPlayer1.Ctlcontrols.pause();
                tmSlider.Stop();

                btnPlay.BackgroundImage = Properties.Resources.tocar;
                play = 3;
            }
            else if(play == 3)
            {
                MediaPlayer1.Ctlcontrols.play();
                tmSlider.Start();

                btnPlay.BackgroundImage = Properties.Resources.pausa;
                play = 2;
            }
        }

        String ruta;
        public void AbrirMusica()
        {
            try
            {
                MediaPlayer1.URL = @"" + ruta;
                MediaPlayer1.Ctlcontrols.play();

                this.Visible = true;
                tmSlider.Start();

                BarDuracion.Enabled = true;

                btnPlay.BackgroundImage = Properties.Resources.pausa;
            }
            catch { }
        }

        private void BarDuracion_ValueChanged(object sender, decimal value)
        {
            BarDuracion.Maximum = (int)MediaPlayer1.currentMedia.duration;

            if (BarDuracion.Value == (int)MediaPlayer1.Ctlcontrols.currentPosition)
            {

            }
            else
            {
                MediaPlayer1.Ctlcontrols.currentPosition = BarDuracion.Value;
            }
        }

        private void tmSlider_Tick(object sender, EventArgs e)
        {
            try
            {
                BarDuracion.Value = (int)MediaPlayer1.Ctlcontrols.currentPosition;
                label1.Text = MediaPlayer1.Ctlcontrols.currentPositionString;
                label2.Text = MediaPlayer1.currentMedia.durationString;
            }
            catch { }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if((BarDuracion.Value = BarDuracion.Value - 15) < 0)
            {
                BarDuracion.Value = 0;
            }
            else
            {
                BarDuracion.Value = BarDuracion.Value - 15;
            }
        }

        public void AbrirArchivo()
        {
            archivo.Filter = "Archivo files|*.mp3;*.mp4;.*;";
            DialogResult dres1 = archivo.ShowDialog();

            if(dres1 == DialogResult.Abort)
            {
                return;
            }

            if(dres1 == DialogResult.Cancel)
            {
                return;
            }

            ruta = archivo.FileName;
            labelTitle.Text = archivo.SafeFileName;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirArchivo();

                if(ruta != "")
                {
                    play = 2;
                    AbrirMusica();
                }
                else { }
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void BarVolumen_ValueChanged(object sender, decimal value)
        {
            MediaPlayer1.settings.volume = BarVolumen.Value;

            label3.Text = MediaPlayer1.settings.volume.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarDuracion.Value = BarDuracion.Value + 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = (BarVolumen.Value = MediaPlayer1.settings.volume = vl).ToString();
            this.MediaPlayer1.uiMode = "none";
        }
    }
}
