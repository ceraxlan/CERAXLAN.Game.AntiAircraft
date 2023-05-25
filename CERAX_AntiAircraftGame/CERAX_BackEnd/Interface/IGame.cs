
using System.Drawing;

namespace CERAX_BackEnd.Interface
{
    internal interface IGame
    {
        bool IsContinue { get; }      
        void Start();
        void Fire(Point pointTarget);       
    }
}
