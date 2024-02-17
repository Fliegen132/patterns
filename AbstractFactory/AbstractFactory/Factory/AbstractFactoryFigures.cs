using AbstractFactory.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public abstract class AbstractFactoryFigures
    {
        public abstract AbstractCircle CreateCircle(int rarius);
        public abstract AbstractSquare CreateSquare(int sideSize);
    }
}
