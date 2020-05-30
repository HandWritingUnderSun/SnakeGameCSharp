using System.Drawing;

namespace SnakeGame
{
    public class Cell
    {
        int indexX;
        int indexY;
        int indexOrder;
        Color color;
        int width;
        int heigth;

        public Cell()
        {
            IndexX = 0;
            IndexY = 0;
        }

        public int IndexX { get => indexX; set => indexX = value; }
        public int IndexY { get => indexY; set => indexY = value; }
        public int IndexOrder { get => indexOrder; set => indexOrder = value; }

        public bool equals(Cell cell)
        {
            if (this.IndexX == cell.IndexX && this.IndexY == cell.IndexY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
