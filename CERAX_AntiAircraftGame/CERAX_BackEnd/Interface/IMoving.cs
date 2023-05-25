using CERAX_BackEnd.Enum;
using System.Drawing;


namespace CERAX_BackEnd.Interface
{
    internal interface IMoving
    {
        Size MovementAreaSize { get; }
        int MovementDistance { get; }       
        bool MoveIt(Direction direction);
    }
}
