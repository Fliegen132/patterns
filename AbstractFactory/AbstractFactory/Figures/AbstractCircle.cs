using System.Drawing;

namespace AbstractFactory.Figures
{
    public abstract class AbstractCircle
    {
        private int Radius;
        public Color CurrentColor;
        public AbstractCircle(int radius)
        { 
            
        }
        public Color GetColor() => CurrentColor;
        public bool SetRadius(int r)
        {
            if (r > 0)
            {
                Radius = r;
                return true;
            }
            return false;
        }
        public int GetRadius() => Radius;
    }
}
