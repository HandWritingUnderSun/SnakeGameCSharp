using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Food
    {
        Random random = new Random();
        int len;
        Cell[] foodCell = new Cell[20];

        Food()
        {
            len = 1;
            for (int i = 0; i < len; i++)
            {
                foodCell[i] = new Cell();

                foodCell[i].setIndexX(setRandomIndexX());
                foodCell[i].setIndexY(setRandomIndexY());
            }
        }

        public static int setRandomIndexX()
        {
            Random r = new Random();
            return (r.nextInt(33) + 1) * 25;
        }

        public static int setRandomIndexY()
        {
            Random r = new Random();
            return (r.nextInt(24) + 1) * 25;
        }
    }
}
