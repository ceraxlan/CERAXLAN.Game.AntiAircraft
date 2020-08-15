using CERAX_BackEnd.Enum;
using CERAX_BackEnd.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CERAX_BackEnd.Concrete
{
    public class Game : IGame
    {

        #region Alanlar

       
        private readonly Timer _movementTimer = new Timer { Interval = 50 };
        private readonly Timer _createJetTimer = new Timer { Interval = 3000 };
      
        private readonly Panel _gameAreaPanel;
       
        private readonly List<Bullet> _bullets = new List<Bullet>();
        private readonly List<Jet> _jets = new List<Jet>();

        private int _heartCount = 3;

        #endregion


        #region Özellikler

        public bool IsContinue { get; private set; }


        #endregion

        #region Metotlar

        public Game(Panel gameAreaPanel)
        {
           
            _gameAreaPanel = gameAreaPanel;

           
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
                    _heartCount--;
                    if (_heartCount == 0)
                    {
                        Finish();
                        break;
                    }
                }
                
                
            }
        }

        private void CreateJetTimer_Tick(object sender, EventArgs e)
        {
            CreateJet();
        }

        private void MoveBullets()
        {
            for (int i = _bullets.Count - 1; i >= 0; i--)
            {
                var bullet = _bullets[i];
                var collision = bullet.MoveIt(Direction.Up);
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
           // _gameAreaPanel.Controls.Clear();
            _heartCount = 3;
            StartTimers();
           
            CreateJet();
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

        public void Fire()
        {
            if (!IsContinue) return;

           // var bullet = new Bullet(_gameAreaPanel.Size, _ucaksavar.Center);
           // _bullets.Add(bullet);
           // _gameAreaPanel.Controls.Add(bullet);
        }

       
        #endregion
    }
}
