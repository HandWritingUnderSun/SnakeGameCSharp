namespace SnakeGame
{
    public class Snake:IMove
    {
        int Len;
        Cell[] cells;

        public Snake()
        {
            Len = 3;
            cells = new Cell[600];

            for (int i = 0; i < Len; i++)
            {
                cells[i] = new Cell();
            }
            this.cells[0].IndexX=75;
            this.cells[0].IndexY=75;
            this.cells[1].IndexX=50;
            this.cells[1].IndexY=75;
            this.cells[2].IndexX=25;
            this.cells[2].IndexY=75;
        }

        Snake(int len, int indexx, int indexy, SnakeDirection fx)
        {
            this.Len = len;
            for (int i = 0; i < Len; i++)
            {
                cells[i] = new Cell();
            }

            this.cells[0].IndexX = indexx;
            this.cells[0].IndexY = indexy;

            if (SnakeDirection.Down == fx)
            {
                for (int i = 1; i < len; i++)
                {
                    this.cells[i].IndexX=cells[0].IndexX;
                    this.cells[i].IndexY=cells[0].IndexY - 25;
                }
            }
            else if (SnakeDirection.Up == fx)
            {
                for (int i = 1; i < len; i++)
                {
                    this.cells[i].IndexX=cells[0].IndexX;
                    this.cells[i].IndexY=cells[0].IndexY + 25;
                }
            }
            else if (SnakeDirection.Left == fx)
            {
                for (int i = 1; i < len; i++)
                {
                    this.cells[i].IndexX=cells[0].IndexX - 25;
                    this.cells[i].IndexY=cells[0].IndexY;
                }
            }
            else if (SnakeDirection.Right == fx)
            {
                for (int i = 1; i < len; i++)
                {
                    this.cells[i].IndexX=cells[0].IndexX + 25;
                    this.cells[i].IndexY=cells[0].IndexY;
                }
            }
        }

        public void Move()
        { }

    }

}
