using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAX_BackEnd.Interface
{
    internal interface IGame
    {
        bool IsContinue { get; }
       
        void Start();
        void Fire(Point pointTarget);
       
    }
}
