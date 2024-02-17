using AbstractFactory.Figures;

namespace AbstractFactory.Factory
{
    public class FactoryOrange : AbstractFactoryFigures
    {
        public override AbstractCircle CreateCircle(int rarius)
        {
            return new OrangeCircle(rarius);
        }

        public override AbstractSquare CreateSquare(int sideSize)
        {
            return new OrangeSquare(sideSize);
        }
    }
}
