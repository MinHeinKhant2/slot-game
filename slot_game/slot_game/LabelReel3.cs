using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slot_game
{
    internal class LabelReel3:Label
    {
        public LabelReel3(int x, int y, int witdh, int height, string str)
        {
            Location = new Point(x, y);
            Size = new Size(witdh, height);
            Text = str;
            ForeColor = Color.Blue;
            Font = new Font(Font.FontFamily, 16);


        }
        public void TextUpdate(string c)
        {
            Text = c;
        }
    }
}
