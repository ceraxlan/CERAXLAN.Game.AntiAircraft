using CERAX_BackEnd.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAX_BackEnd.Interface
{
    internal interface IMoving
    {
        Size MovementAreaSize { get; }

        int MovementDistance { get; }

        /// <summary>
        /// Cismi istenilen yönde hareket ettirir
        /// </summary>
        /// <param name="yon">Hangi yöne hareket edileceği</param>
        /// <returns>Cisim duvara çaparsa true döndürür.</returns>
        bool MoveIt(Direction direction);
    }
}
