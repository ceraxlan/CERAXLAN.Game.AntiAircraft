using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CERAX_BackEnd.Concrete;

namespace CERAX_AntiAircraftGame
{
    public partial class GameScreen : UserControl
    {
        XMain xMain;
        private readonly Game _game;
        public GameScreen(XMain main)
        {
            xMain = main;
            InitializeComponent();
            _game = new Game(pGameArea);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _game.Start();
        }
    }
}
