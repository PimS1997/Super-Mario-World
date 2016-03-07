using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarioWorld
{
    class GameLoop
    {
        private bool running;

        private int tps;
        private int fps;

        private int width;
        private int height;

        public Graphics graphics;
        private BufferedGraphics img;

        public static double currentFPS = 120D;

        public GameLoop(int width, int height)
        {
            this.width = width;
            this.height = height;

            
        }

        public void run()
        {
            init();

            long lastTime = DateTime.Now.Ticks;
            double nsPerTick = 1000000000D / currentFPS;
            int frames = 0;
            int ticks = 0;
            long lastTimer = DateTime.Now.Millisecond;
            double deltaTime = 0;

            while (running)
            {
                long now = DateTime.Now.Ticks;
                deltaTime += (now - lastTime) / nsPerTick;
                lastTime = now;
                bool shouldRender = false;

                while (deltaTime >= 1)
                {
                    ticks++;
                    //TICK + DeltaTIme
                    tick(deltaTime);
                    deltaTime -= 1;
                    shouldRender = true;
                }

                if (shouldRender == true)
                {
                    frames++;
                    //RENDER
                    render();
                }

                if (DateTime.Now.Millisecond - lastTimer >= 1000)
                {
                    lastTimer += 1000;
                    //tps = frames;
                    fps = ticks;
                    frames = 0;
                    ticks = 0;
                }


            }
        }

        private void render()
        {
            throw new NotImplementedException();
        }

        private void tick(double deltaTime)
        {
            throw new NotImplementedException();
        }

        private void init()
        {
            throw new NotImplementedException();
        }
    }
}
