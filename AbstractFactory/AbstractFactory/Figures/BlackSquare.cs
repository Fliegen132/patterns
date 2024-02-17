using System.Drawing;

namespace AbstractFactory.Figures
{
    internal class BlackSquare : AbstractSquare
    {
        public BlackSquare(int sz) : base(sz)
        {
            CurrentColor = Color.Black;
            SetSideSize(sz);
        }
    }
}
