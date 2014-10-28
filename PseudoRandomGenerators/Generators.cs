using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PseudoRandomGenerators
{
    public static class Generators
    {
        public static int poissonDistribution(double lambda, Random random)
        {
            int x = -1;
            double s = 1, u;
            double q = Math.Exp(-lambda);

            while (s > q)
            {
                u = random.NextDouble();
                s = s * u;
                x++;
            }

            return x;
        }

        public static double normalGaussian(Random random, double mean, double stddev)
        {
            double x1 = 1 - random.NextDouble();
            double x2 = 1 - random.NextDouble();
            double r = Math.Sqrt(-2.0 * Math.Log(x1)) * Math.Cos(2.0 * Math.PI * x2);

            return r * stddev + mean;
        }
    }
}
