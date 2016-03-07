using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SuperMarioWorld.GameOperatingSystem
{
    public class SpriteSheet
    {
        private Bitmap spriteSheet;
        private Rectangle _tile;

        public SpriteSheet()
        {

        }

        public void setSpriteSheet(Bitmap spriteSheet)
        {
            this.spriteSheet = spriteSheet;
        }

        public Bitmap getTile(int xTile, int yTile, int width, int height)
        {
            _tile = new Rectangle(xTile, yTile, width, height);
            Bitmap sprite = spriteSheet.Clone(_tile, spriteSheet.PixelFormat);
            return sprite;
        }
    }
}
