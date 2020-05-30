using System;

namespace SnakeGame
{
    public class Food
    {
        Random random = new Random();
        int len;
        Cell[] foodCell = new Cell[20];

        public Food()
        {
            len = 1;
            for (int i = 0; i < len; i++)
            {
                foodCell[i] = new Cell();

                foodCell[i].IndexX = setRandomIndexX();
                foodCell[i].IndexY = setRandomIndexY();
            }
        }

        public static int setRandomIndexX()
        {
            Random r = new Random();
            return (r.Next(33) + 1) * 25;
        }

        public static int setRandomIndexY()
        {
            Random r = new Random();
            return (r.Next(24) + 1) * 25;
        }
    }
}
