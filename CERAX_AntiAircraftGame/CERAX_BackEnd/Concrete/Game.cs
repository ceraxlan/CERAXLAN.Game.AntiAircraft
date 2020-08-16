using CERAX_BackEnd.Enum;
using CERAX_BackEnd.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CERAX_BackEnd.Concrete
{
    public class Game : IGame
    {

        #region Fields

       
        private readonly Timer _movementTimer = new Timer { Interval = 50 };
        private readonly Timer _createJetTimer = new Timer { Interval = 2000 };
      
        private readonly Panel _gameAreaPanel;
        private readonly Panel _castleAreaPanel;     
        private int _score = 0;

        private Castle _castle;
        private bool _isContinue = false;
        private readonly List<Bullet> _bullets = new List<Bullet>();
        private readonly List<Jet> _jets = new List<Jet>();

        private int _heartCount = 3;

        #endregion

        #region Specifications

        public int HeartCount
        {
            get => _heartCount;
            private set
            {
                _heartCount = value;
                HeartCounter?.Invoke(this, EventArgs.Empty); 
            }
        }
        public bool IsContinue
        { 
            get => _isContinue;
            private set
            {
                _isContinue = value;
                if (!_isContinue) { GameOver?.Invoke(this, EventArgs.Empty); }
            }
        }

        public int Score
        {
            get => _score;
            private set
            {
                _score = value;
                UpdateScore?.Invoke(this, EventArgs.Empty);
            }
             

        }

        #endregion

        #region Methods
        public event EventHandler UpdateScore;
        public event EventHandler GameOver;
        public event EventHandler HeartCounter;

        public Game(Panel gameAreaPanel,Panel castleAreaPanel)
        {
           
            _gameAreaPanel = gameAreaPanel;
            _castleAreaPanel = castleAreaPanel;

           
            _movementTimer.Tick += MovementTimer_Tick;
            _createJetTimer.Tick += CreateJetTimer_Tick;
        }

      

        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            MoveBullets();
            MoveJets();
            RemoveCrashJets();
        }

        private void RemoveCrashJets()
        {
            for (var i = _jets.Count - 1; i >= 0; i--)
            {
                var jet = _jets[i];

                var hittingBullet = jet.IsCrash(_bullets);
                if (hittingBullet is null) continue;

                Score++;
                _jets.Remove(jet);
                _bullets.Remove(hittingBullet);
                _gameAreaPanel.Controls.Remove(jet);
                _gameAreaPanel.Controls.Remove(hittingBullet);
            }
        }

        private void MoveJets()
        {
            for (var i = _jets.Count - 1; i >= 0; i--)
            {
                var jet = _jets[i];
                var collision = jet.MoveIt(Direction.Right);
                if (!collision) { continue; }
                else
                {
                    _jets.Remove(jet);
                    _gameAreaPanel.Controls.Remove(jet);
                    HeartCount--;
                    if (HeartCount == 0)
                    {
                        Finish();
                        break;
                    }
                }
                
                
            }
        }

        private void CreateJetTimer_Tick(object sender, EventArgs e)
        {
           if(_jets.Count<10) CreateJet();
        }

        private void MoveBullets()
        {
            for (int i = _bullets.Count - 1; i >= 0; i--)
            {
                var bullet = _bullets[i];
                var collision = bullet.MoveIt(Direction.ToTarget);
                if (collision)
                {
                    _bullets.Remove(bullet);
                    _gameAreaPanel.Controls.Remove(bullet);
                }
            }
        }

        
        public void Start()
        {
            if (IsContinue) return;

            IsContinue = true;
            ClearGame();
            StartTimers();
            CreateCastle();
            CreateJet();
        }

        private void ClearGame()
        {
            _gameAreaPanel.Controls.Clear();
            _bullets.Clear();
            _jets.Clear();
            Score = 0;
            HeartCount = 3;
        }

        private void CreateCastle()
        {
            _castle = new Castle(_castleAreaPanel.Width);
            _castleAreaPanel.Controls.Add(_castle);
        }

        private void CreateJet()
        {
            var jet = new Jet(_gameAreaPanel.Size);
            _jets.Add(jet);
            _gameAreaPanel.Controls.Add(jet);
        }

        private void StartTimers()
        {           
            _movementTimer.Start();
            _createJetTimer.Start();
        }

       

        private void Finish()
        {
            if (!IsContinue) return;

            IsContinue = false;
            StopTimers();
        }

        private void StopTimers()
        {         
            _movementTimer.Stop();
            _createJetTimer.Stop();
        }

        public void Fire(Point pointTarget)
        {
            if (!IsContinue) return;

            var bullet = new Bullet(_gameAreaPanel.Size, _castle.Center(), pointTarget);
            _bullets.Add(bullet);
            _gameAreaPanel.Controls.Add(bullet);
        }

       
        #endregion
    }
}
