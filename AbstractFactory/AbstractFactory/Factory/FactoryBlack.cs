using AbstractFactory.Figures;
using System;

namespace AbstractFactory.Factory
{
    public class FactoryBlack : AbstractFactoryFigures
    {
        public override AbstractCircle CreateCircle(int rarius)
        {
            return new BlackCircle(rarius);
        }

        public override AbstractSquare CreateSquare(int sideSize)
        {
            return new BlackSquare(sideSize);
        }
    }
}
