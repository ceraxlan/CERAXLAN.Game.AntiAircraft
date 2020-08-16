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
        private int _highScore = 0;
        public GameScreen(XMain main)
        {
            xMain = main;
            InitializeComponent();
            _game = new Game(pGameArea, pCastleArea);
            _game.UpdateScore += UpdateScore;
            _game.GameOver += GameOver;
            _game.HeartCounter += HeartCounter;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_game.IsContinue) return;
            btnStart.Text = "Started";
            btnMark.Text = "X";
            _game.Start();           
        }

       

        private void pGameArea_Click(object sender, EventArgs e)
        {           
            Point target = pGameArea.PointToClient(Cursor.Position);
            _game.Fire(target);
        }

        private void UpdateScore(object sender, EventArgs e)
        {
            int score = _game.Score;
            lblScore.Text = score.ToString();
            if(score > _highScore) 
            { 
                _highScore = score; 
                lblHighScore.Text = _highScore.ToString();
            }
                      
        }
        private void GameOver(object sender,EventArgs e)
        {
            btnMark.Text = "Game Over";
            btnStart.Text = "Restart";
        }
       
        private void HeartCounter(object sender, EventArgs e)
        {
            switch (_game.HeartCount)
            {
                case 3:
                    btnMark.Text = "X X X";
                    break;
                case 2:
                    btnMark.Text = "X X";
                    break;
                case 1:
                    btnMark.Text = "X";
                    break;
            }

        }
    }
}
