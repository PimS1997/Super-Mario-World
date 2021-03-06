﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarioWorld
{
    public partial class MainForm : Form
    {
        //GameLoop gameloop = new GameLoop(500, 500);
        Bitmap _backbuffer;
        Point _position;
        Pen pen = new Pen(Color.Aqua);
        Image img = ImageHandler.LoadImageFrom(@"\res\thing.png");

        Player player = new Player();

        public static int width = 1024;
        public static int height = 768;


        public MainForm()
        {
            InitializeComponent();

            _backbuffer = new Bitmap(mainPB.Width, mainPB.Height);
            _position = new Point(10, 10);
            Application.Idle += Application_Idle;
        }
        void Application_Idle(Object sender, EventArgs e)
        {
            Invalidate();
            Render();
        }

        void Render()
        {

            Graphics graphics = Graphics.FromImage(_backbuffer);
            graphics.Clear(Color.Blue);
            mainPB.Image = _backbuffer;
            player.render(graphics);
            //_position.X += 1;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            _position.X += 5;
        }
    }
}
