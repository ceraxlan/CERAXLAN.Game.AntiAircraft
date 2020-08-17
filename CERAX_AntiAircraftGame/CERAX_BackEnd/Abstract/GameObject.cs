using CERAX_BackEnd.Enum;
using CERAX_BackEnd.Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CERAX_BackEnd.Abstract
{
    internal abstract class GameObject : PictureBox, IMoving
    {
        public Size MovementAreaSize { get; }
        public int MovementDistance { get; protected set; }
        public int BulletMovementDistanceX { get; protected set; }
        public int BulletMovementDistanceY { get; protected set; }

        public new int Right
        {
            get => base.Right;
            set => Left = value - Width;
        }

        public new int Bottom
        {
            get => base.Bottom;
            set => Top = value - Height;
        }

        public int Center
        {
            get => Left + Width / 2;
            set => Left = value - Width / 2;
        }
       
        protected GameObject(Size movementAreaSize)
        {
            Image = Image.FromFile($@"Images\{GetType().Name}.png");
            MovementAreaSize = movementAreaSize;
            SizeMode = PictureBoxSizeMode.AutoSize;
            BackColor = Color.Transparent;
        }

        public bool MoveIt(Direction direction)
        {
            switch (direction)
            {                
                case Direction.Right:
                    return MoveRight();
                case Direction.ToTarget:
                    return MoveToTarget();
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }

        
        private bool MoveRight()
        {
            if (Right == MovementAreaSize.Width) return true;

            var newRight = Right + MovementDistance;
            var overflow = newRight > MovementAreaSize.Width;
            Right = overflow ? MovementAreaSize.Width : newRight;

            return Right == MovementAreaSize.Width;
        }


        private bool MoveToTarget()
        {
            if ((Top == 0) || (Center == MovementAreaSize.Width) || (Center == 0)) return true;

                var newTop = Top - BulletMovementDistanceY;
                var overflowTop = newTop < 0;
                Top = overflowTop ? 0 : newTop;

                var newCenter = Center + BulletMovementDistanceX;
                var overflowSide = newCenter > MovementAreaSize.Width || newCenter < 0;
                Center = overflowSide ? MovementAreaSize.Width : newCenter;

                return (Top == 0) || (Center == MovementAreaSize.Width) || (Center == 0);          
        }

    }
}
