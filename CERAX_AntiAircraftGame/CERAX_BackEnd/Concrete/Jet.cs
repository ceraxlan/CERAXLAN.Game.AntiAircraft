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
            MovementDistance = (int)((Random.Next(1,3)* Width) /15);
            Top = Random.Next(1, movementAreaSize.Height - 150);
        }

        public Bullet IsCrash(List<Bullet> bullets)
        {
            foreach (var bullet in bullets)
            {              
               var strike = bullet.Top > Top && bullet.Bottom < Bottom && bullet.Left > Left && bullet.Right < Right;                 
               if (strike) return bullet;
            }          
            return null;
        }

    }
}
