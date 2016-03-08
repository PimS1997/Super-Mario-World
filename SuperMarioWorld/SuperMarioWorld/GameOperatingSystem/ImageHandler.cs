using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarioWorld
{
    public class ImageHandler
    {
        public static Image LoadImageFrom(String path)
        {
            Image img = null;

            return img = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.." + path));
        } 
    }
}
