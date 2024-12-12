using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slot_game
{
    internal class BalanceLabel:Label
    {
        public BalanceLabel(int x, int y, int witdh, int height, string str)
        {
            Location = new Point(x, y);
            Size = new Size(witdh, height);
            Text = str;
            ForeColor = Color.DarkRed;

        }
        public void TextUpdate(string balance)
        {
            Text = balance;
        }
    }
}
