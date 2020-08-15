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
        public Bullet(Size movementAreaSize, int CastleMiddle) : base(movementAreaSize)
        {
            SetLocationBullet(CastleMiddle);
            MovementDistance = (int)(Height * 0.5);
        }

        private void SetLocationBullet(int CastleMiddle)
        {
            Bottom = MovementAreaSize.Height;
            Center = CastleMiddle;
        }
    }
}
