using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CERAX_AntiAircraftGame
{
    public partial class XMain : Form
    {
       
        public XMain()
        {
            InitializeComponent();

            activePage = new Control();
            activePage = null;
            lastPage = null;

            loginScreen = new LoginScreen(this);
            loginScreen.Visible = true;
            panelMain.Controls.Add(loginScreen);

            gameScreen = new GameScreen(this);
            gameScreen.Visible = true;
            panelMain.Controls.Add(gameScreen);
            isBoard = true;
            DashBoardPagesVisible(Pages.LoginScreen);

        }

        GameScreen gameScreen;
        LoginScreen loginScreen;
        public enum Pages
        {
            LoginScreen,
            GameScreen
        }
        Pages? lastPage = null;
        Control activePage;
        bool isBoard = false;
        private void AddPanelControl()
        {
            activePage.Dock = DockStyle.Fill;
            activePage.Visible = true;

        }


        public void DashBoardPagesVisible(Pages page)
        {
            if (!isBoard)
            {
                return;
            }
            if (page == lastPage)
            {
                return;
            }

            loginScreen.Visible = false;
            gameScreen.Visible = false;
            switch (page)
            {
                case Pages.LoginScreen:
                    activePage = loginScreen;
                    lastPage = page;
                    AddPanelControl();
                    break;
                case Pages.GameScreen:
                    activePage = gameScreen;
                    lastPage = page;
                    AddPanelControl();
                    break;

            }

        }
    }
}
