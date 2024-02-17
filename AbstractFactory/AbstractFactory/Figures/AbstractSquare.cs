using System.Drawing;

namespace AbstractFactory.Figures
{
    public class AbstractSquare
    {
        private int SideSize;
        public Color CurrentColor;
        public AbstractSquare(int sz)
        {

        }
        public Color GetColor() => CurrentColor;
        public bool SetSideSize(int r)
        {
            if (r > 0)
            {
                SideSize = r;
                return true;
            }
            return false;
        }
        public int GetSideSize() => SideSize;
    }
}
