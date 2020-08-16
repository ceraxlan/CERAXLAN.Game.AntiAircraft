using CERAX_BackEnd.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAX_BackEnd.Concrete
{
    internal class Bullet : GameObject
    {
        public Bullet(Size movementAreaSize, int CastleMiddle,Point pointTarget) : base(movementAreaSize)
        {
            SetLocationBullet(CastleMiddle);
            BulletMovementDistanceX = (int)((pointTarget.X - CastleMiddle) / 25);
            BulletMovementDistanceY = (int)((CastleMiddle - pointTarget.Y) / 25);                    
        }

        private void SetLocationBullet(int CastleMiddle)
        {
            Bottom = MovementAreaSize.Height;
            Center = CastleMiddle;
        }

        
    }
}
