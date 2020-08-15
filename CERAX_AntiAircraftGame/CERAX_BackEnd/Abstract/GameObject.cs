using CERAX_BackEnd.Enum;
using CERAX_BackEnd.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CERAX_BackEnd.Abstract
{
    internal abstract class GameObject : PictureBox, IMoving
    {
        public Size MovementAreaSize { get; }

        public int MovementDistance { get; protected set; }

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

        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;
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
                case Direction.Up:
                    return MoveUp();
                case Direction.Right:
                    return MoveRight();
                case Direction.Down:
                    return MoveDown();
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }

        private bool MoveRight()
        {
            if (Right == MovementAreaSize.Width) return true;

            var yeniRight = Right + MovementDistance;
            var tasacakMi = yeniRight > MovementAreaSize.Width;

            Right = tasacakMi ? MovementAreaSize.Width : yeniRight;

            return Right == MovementAreaSize.Width;
        }

        private bool MoveUp()
        {
            if (Top == 0) return true;

            var yeniTop = Top - MovementDistance;
            var tasacakMi = yeniTop < 0;
            Top = tasacakMi ? 0 : yeniTop;

            return Top == 0;
        }

        private bool MoveDown()
        {
            if (Bottom == MovementAreaSize.Height) return true;

            var yeniBottom = Bottom + MovementDistance;
            var tasacakMi = yeniBottom > MovementAreaSize.Height;

            Bottom = tasacakMi ? MovementAreaSize.Height : yeniBottom;

            return Bottom == MovementAreaSize.Height;
        }

    }
}
