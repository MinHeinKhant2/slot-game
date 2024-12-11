using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slot_game
{
    public partial class Form1 : Form
    {
        LabelReel1 _labelreel1;
        LabelReel2 _labelreel2;
        LabelReel3 _labelreel3;
        SpinButton _spinbutton;
        ResultLabel _resultlabel;
        BalanceLabel _balancelabel;
        BetAmount _betamount;
        BetLabel _betlabel;
        Random random = new Random();
        string[] symbols = { "🍒", "🔔", "🍋" };
        int balance = 1000;
        public Form1()
        {  
            InitializeComponent();

               _labelreel1 = new LabelReel1(50,50, 35, 13, "🍒");
                Controls.Add(_labelreel1);
                _labelreel2 = new LabelReel2(150, 50, 35, 13, "🍒");
                Controls.Add(_labelreel2);
                _labelreel3 = new LabelReel3(250, 50, 35, 13, "🍒");
                Controls.Add(_labelreel3);
            _resultlabel = new ResultLabel(100, 200, 200, 23, "GOODLUCK");
            Controls.Add(_resultlabel);
            _balancelabel = new BalanceLabel(0, 0, 145, 13, "Balance = $"+balance);
            Controls.Add(_balancelabel);
            _betamount = new BetAmount(100, 120, 45, 23, "");
            Controls.Add(_betamount);
            _betlabel = new BetLabel(100, 100, 45, 23, "Bet:");
            Controls.Add(_betlabel);
            _spinbutton = new SpinButton(this,100, 150, 45, 23);
            Controls.Add(_spinbutton);
        }
        public void SystemStart()
        {

            int reel1 = random.Next(0,symbols.Length);
            string a=symbols[reel1];
            _labelreel1.TextUpdate(a);

            int reel2 = random.Next(0, symbols.Length);
            string b = symbols[reel2];
            _labelreel2.TextUpdate(b);

            int reel3 = random.Next(0, symbols.Length);
            string c = symbols[reel3];
            _labelreel3.TextUpdate(c);
            string d;
            if (reel1 == reel2 && reel2 == reel3)
            {
                d = "You win";
                balance +=5;
            }else
            {
                d = "Try Again";
                balance -=5;
            }
            _resultlabel.TextUpdate(d);
            _balancelabel.TextUpdate("Balance = $"+balance);
        }

       
    }
}
