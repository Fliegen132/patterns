using System.Drawing;

namespace AbstractFactory.Figures
{
    internal class OrangeCircle : AbstractCircle
    {
        public OrangeCircle(int radius) : base(radius)
        {
            CurrentColor = Color.Orange;
            SetRadius(radius);
        }
    }
}
