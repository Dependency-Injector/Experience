using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class Dice
    {
        private static Random random;

        static Dice()
        {
            random = new Random();
        }

        /// <summary>
        /// Returns multiplier, 
        ///     for 8 and 11 returns number between 0,8 and 1,1
        ///     for 5 and 32 returns number between 0,5 and 32
        /// </summary>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <returns></returns>
        public static double Roll(int minimum, int maximum)
        {
            if (minimum > maximum)
            {
                int temp = minimum;
                minimum = maximum;
                maximum = temp;
            }

            int randomNumber = random.Next(minimum, maximum);
            return (double) randomNumber/10;
        }
    }
}
