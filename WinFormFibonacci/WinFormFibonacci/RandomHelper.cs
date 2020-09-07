using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormFibonacci {

    /// <summary>
    /// Singleton class for generate random number
    /// </summary>
    public class RandomHelper {

        private static RandomHelper instance = null;

        private Random rand;

        private RandomHelper()
        {
            rand = new Random();
        }

        public static RandomHelper Instance()
        {
            if (instance == null)
            {
                instance = new RandomHelper();
            }

            return instance;
        }

        public int Next(int max, int min)
        {
            return rand.Next(max, min);
        }

        public int Next(int maxValue)
        {
            return rand.Next(maxValue);
        }
    }
}
