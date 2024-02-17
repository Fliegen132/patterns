using System.Drawing;

namespace AbstractFactory.Figures
{
    internal class OrangeSquare : AbstractSquare
    {
        public OrangeSquare(int sz) : base(sz)
        {
            CurrentColor = Color.Orange;
            SetSideSize(sz);
        }
    }
}
