using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherChallenges
{
    public class BotSavesPrincess
    {
        static void move(int moves, string direction)
        {
            for (int move = 0; move < moves; move++)
            {
                Console.WriteLine(direction);
            }
        }

        static void displayPathtoPrincess(int n, String[] grid)
        {
            int[] positionOfPrincess = new int[2];
            int[] positionOfBot = new int[2];

            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (grid[y][x] == 'p')
                    {
                        positionOfPrincess[0] = x;
                        positionOfPrincess[1] = y;
                    }
                    if (grid[y][x] == 'm')
                    {
                        positionOfBot[0] = x;
                        positionOfBot[1] = y;
                    }

                }
            }

            if (positionOfPrincess[1] > positionOfBot[1])
            {
                move(positionOfPrincess[1] - positionOfBot[1], "DOWN");
            }
            else if (positionOfPrincess[1] < positionOfBot[1])
            {
                move(positionOfBot[1] - positionOfPrincess[1], "UP");
            }

            if (positionOfPrincess[0] > positionOfBot[0])
            {
                move(positionOfPrincess[0] - positionOfBot[0], "RIGHT");
            }
            else if (positionOfPrincess[0] < positionOfBot[0])
            {
                move(positionOfBot[0] - positionOfPrincess[0], "LEFT");
            }
        }

        public static void SaveThePrincess()
        {
            int m;

            m = int.Parse(Console.ReadLine());

            String[] grid = new String[m];
            for (int i = 0; i < m; i++)
            {
                grid[i] = Console.ReadLine();
            }

            displayPathtoPrincess(m, grid);
        }
    }
}
