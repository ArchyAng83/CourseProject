using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Caculation
{
     class Calculation
    {
        public double[] Temperatures { get; set; }
        public double[] Zones { get; set; }
        public int Count { get; set; }
        public double ConstA { get; set; }
        public double ConstB { get; set; }
        public double ErrorApprox { get; set; }

        public Calculation(double[] temperatures, double[] zones, int count)
        {
            Temperatures = temperatures;
            Zones = zones;
            Count = count;
            ConstA = GetConstA();
            ConstB = GetConstB();
            ErrorApprox = GetError();
        }

        /// <summary>
        /// Сумма X или Y.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private double Sum1(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        /// <summary>
        /// Сумма (1 / X)^2.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private double Sum2(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += Math.Pow((1 / arr[i]), 2);
            }
            return sum;
        }
        /// <summary>
        /// Сумма (1 / X).
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private double Sum3(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += 1 / arr[i];
            }
            return sum;
        }
        /// <summary>
        /// Сумма X / Y.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private double Sum1(double[] arr, double[] arr2)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr2[i] / arr[i] ;
            }
            return sum;
        }

        /// <summary>
        /// Сумма |Y - (a + b / X)|
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private double Sum4(double[] arr, double[] arr2)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += Math.Abs(arr2[i] - (ConstA + ConstB / arr[i]));
            }
            return sum;
        }

        private double GetConstA()
        {
            ConstA = (Sum1(Zones) * Sum2(Temperatures) - Sum3(Temperatures) * Sum1(Temperatures, Zones))
                     / (Sum2(Temperatures) - Count * (Sum3(Temperatures) * Sum3(Temperatures)));
            return ConstA;
        }

        private double GetConstB()
        {
            ConstB = (Count * Sum1(Temperatures, Zones) - Sum3(Temperatures) * Sum1(Zones))
                     / (Count * Sum2(Temperatures) - (Sum3(Temperatures) * Sum3(Temperatures)));
            return ConstB;
        }

        private double GetError()
        {
            ErrorApprox = Sum4(Temperatures, Zones) / (Count * Sum1(Zones)) * 100;
            return ErrorApprox;
        }
    }
}
