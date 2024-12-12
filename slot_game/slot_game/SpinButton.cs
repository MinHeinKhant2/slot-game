using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace slot_game
{
    internal class SpinButton:Button
    {
        Form1 _form1;
        public SpinButton(Form1 form1,int x,int y,int witdth,int height)
        {
            _form1 = form1;
            Click += OnClick;
            Location=new Point(x,y);
            Size = new Size(witdth,height);
            Text = "Spin";
            BackColor =Color.LightCyan;

        }
        public void OnClick(object sender, EventArgs e)
        {
            _form1.SystemStart();
        }
    }
}
