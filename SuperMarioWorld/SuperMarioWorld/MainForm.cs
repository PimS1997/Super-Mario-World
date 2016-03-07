using System;
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
        GameLoop gameloop = new GameLoop(500, 500);
        public MainForm()
        {
            InitializeComponent();
            
        }
    }
}
