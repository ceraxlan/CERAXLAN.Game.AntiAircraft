using CERAX_BackEnd.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAX_BackEnd.Concrete
{
    internal class Jet : GameObject
    {
        private static readonly Random Random = new Random();

        public Jet(Size movementAreaSize) : base(movementAreaSize)
        {
            //MovementDistance = (int)(Width * .2);
            MovementDistance = (int)((Random.Next(1,3)* Width) /10);
            Top = Random.Next(movementAreaSize.Height - Height + 1);
        }

        public Bullet IsCrash(List<Bullet> bullets)
        {
            foreach (var bullet in bullets)
            {
                var isCrash = bullet.Top < Bottom && bullet.Right > Left && bullet.Left < Right;
                if (isCrash) return bullet;
            }

            return null;
        }

    }
}
