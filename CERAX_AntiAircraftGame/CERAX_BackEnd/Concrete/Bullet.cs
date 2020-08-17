using CERAX_BackEnd.Abstract;
using System.Drawing;

namespace CERAX_BackEnd.Concrete
{
    internal class Bullet : GameObject
    {
        public Bullet(Size movementAreaSize, int CastleMiddle,Point pointTarget) : base(movementAreaSize)
        {
            SetLocationBullet(CastleMiddle);
            BulletMovementDistanceX = (int)((pointTarget.X - CastleMiddle) / 25 + 1);
            BulletMovementDistanceY = (int)((CastleMiddle - pointTarget.Y) / 25 + 1);                    
        }

        private void SetLocationBullet(int CastleMiddle)
        {
            Bottom = MovementAreaSize.Height;
            Center = CastleMiddle;
        }

        
    }
}
