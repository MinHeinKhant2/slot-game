using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace slot_game
{
    internal class LabelReel1:Label
    {
        public LabelReel1(int x, int y, int witdh, int height,string str)
        {
            Location = new Point(x, y);
            Size = new Size(witdh, height);
            Text = str;
        }
        public void TextUpdate(string a)
        {
            Text = a;
        }

    }
}
