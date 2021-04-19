using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamlingsProgram
{
    class Calculations
    {

        public int[] SolutionOne(int length)
        {
            int[] calc = new int[length];
            int[] fCalc = new int[length];
            for (int i = 0; i < length; i++)
            {
                calc[i] = i + 1;
                if (calc[i] % 3 == 0 || calc[i] % 5 == 0)
                {
                    fCalc[i] = calc[i];
                }
            }
            return fCalc;
        }
        public int[] SolutionTwo(int length)
        {
            int n1 = 0, n2 = 1, n3;
            int[] fCalc = new int[length];
            for (int i = 1; i < length; i++)
            {
                n3 = n1 + n2;
                fCalc[i] = n3;
                n1 = n2;
                n2 = n3;
            }
                return fCalc;
        }
    }
}
