using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CERAX_BackEnd.Concrete
{
    internal class Castle : PictureBox
    {
        public Castle(int movementAreaSize) 
        {
            Image = Image.FromFile($@"Images\{GetType().Name}.png");          
            SizeMode = PictureBoxSizeMode.AutoSize;
            Left = (movementAreaSize / 2) - (Width / 2);
        }

        public int Center()
        {
            return (Left + Right) / 2;
        }
    }
}
