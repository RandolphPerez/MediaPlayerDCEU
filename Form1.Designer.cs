namespace VideoPlayerDCEU
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproducirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BarVolumen = new XComponent.SliderBar.MACTrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.BarDuracion = new XComponent.SliderBar.MACTrackBar();
            this.tmSlider = new System.Windows.Forms.Timer(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reproductorToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // reproductorToolStripMenuItem
            // 
            this.reproductorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reproducirToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.detenerToolStripMenuItem});
            this.reproductorToolStripMenuItem.Name = "reproductorToolStripMenuItem";
            this.reproductorToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.reproductorToolStripMenuItem.Text = "Reproductor";
            // 
            // reproducirToolStripMenuItem
            // 
            this.reproducirToolStripMenuItem.Name = "reproducirToolStripMenuItem";
            this.reproducirToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.reproducirToolStripMenuItem.Text = "Reproducir";
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.pausarToolStripMenuItem.Text = "Pausar";
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.detenerToolStripMenuItem.Text = "Detener";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // MediaPlayer1
            // 
            this.MediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaPlayer1.Enabled = true;
            this.MediaPlayer1.Location = new System.Drawing.Point(0, 30);
            this.MediaPlayer1.Name = "MediaPlayer1";
            this.MediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer1.OcxState")));
            this.MediaPlayer1.Size = new System.Drawing.Size(1144, 532);
            this.MediaPlayer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BarVolumen);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.BarDuracion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 562);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 97);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::VideoPlayerDCEU.Properties.Resources.angulo_derecho;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(591, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BarVolumen
            // 
            this.BarVolumen.BackColor = System.Drawing.Color.Transparent;
            this.BarVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BarVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.BarVolumen.IndentHeight = 6;
            this.BarVolumen.Location = new System.Drawing.Point(1028, -68);
            this.BarVolumen.Maximum = 100;
            this.BarVolumen.Minimum = 0;
            this.BarVolumen.Name = "BarVolumen";
            this.BarVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BarVolumen.Size = new System.Drawing.Size(28, 131);
            this.BarVolumen.TabIndex = 5;
            this.BarVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.BarVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.BarVolumen.TickHeight = 1;
            this.BarVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BarVolumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.BarVolumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.BarVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.BarVolumen.TrackLineHeight = 3;
            this.BarVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.BarVolumen.Value = 0;
            this.BarVolumen.Visible = false;
            this.BarVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.BarVolumen_ValueChanged);
            this.BarVolumen.MouseLeave += new System.EventHandler(this.BarVolumen_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1036, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1089, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "0:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "0:00";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::VideoPlayerDCEU.Properties.Resources.volumen;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1000, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = ".";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::VideoPlayerDCEU.Properties.Resources.tocar;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(532, 37);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(53, 48);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = ".";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::VideoPlayerDCEU.Properties.Resources.angulo_izquierdo;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(451, 41);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 40);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = ".";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // BarDuracion
            // 
            this.BarDuracion.BackColor = System.Drawing.Color.Transparent;
            this.BarDuracion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BarDuracion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.BarDuracion.IndentHeight = 6;
            this.BarDuracion.Location = new System.Drawing.Point(12, 3);
            this.BarDuracion.Maximum = 100;
            this.BarDuracion.Minimum = 0;
            this.BarDuracion.Name = "BarDuracion";
            this.BarDuracion.Size = new System.Drawing.Size(1120, 28);
            this.BarDuracion.TabIndex = 4;
            this.BarDuracion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.BarDuracion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.BarDuracion.TickHeight = 1;
            this.BarDuracion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BarDuracion.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.BarDuracion.TrackerSize = new System.Drawing.Size(16, 16);
            this.BarDuracion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.BarDuracion.TrackLineHeight = 3;
            this.BarDuracion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.BarDuracion.Value = 0;
            this.BarDuracion.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.BarDuracion_ValueChanged);
            // 
            // tmSlider
            // 
            this.tmSlider.Tick += new System.EventHandler(this.tmSlider_Tick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(541, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 16);
            this.labelTitle.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 659);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.MediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproductorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproducirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnAtras;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer1;
        private XComponent.SliderBar.MACTrackBar BarVolumen;
        private XComponent.SliderBar.MACTrackBar BarDuracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmSlider;
        private System.Windows.Forms.Label labelTitle;
    }
}

