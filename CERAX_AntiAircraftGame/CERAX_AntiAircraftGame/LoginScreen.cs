using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CERAX_AntiAircraftGame.XMain;

namespace CERAX_AntiAircraftGame
{
    public partial class LoginScreen : UserControl
    {
        XMain xMain;
        public LoginScreen(XMain main)
        {
            InitializeComponent();
            xMain = main;                     
        }

        private void timerPBar_Tick(object sender, EventArgs e)
        {
            if(PBar.Value==100)
            {
                xMain.DashBoardPagesVisible(Pages.GameScreen);
                timerPBar.Stop();
            }
            else
            {
                PBar.Value++;
            }
        }
    }
}
