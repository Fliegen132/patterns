using System.Drawing;

namespace AbstractFactory.Figures
{
    public class BlackCircle : AbstractCircle
    {
        public BlackCircle(int radius) : base(radius)
        {
            CurrentColor = Color.Black;
            SetRadius(radius);
        }
    }
}
