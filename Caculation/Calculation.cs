using System;

namespace CourseProject.Caculation
{
     class Calculation
    {
        public double[] Temperatures { get; private set; }
        public double[] Zones { get; private set; }
        public int Count { get; private set; }
        public double ConstA { get; private set; }
        public double ConstB { get; private set; }
        public double ErrorApprox { get; private set; }

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
        /// Сумма 1 / (X^2).
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private double Sum2(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {                
                sum += 1 / Math.Pow(arr[i], 2);
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
        /// Сумма Y / X.
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
        /// Сумма |Y - (a  / X + b)|
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private double Sum4(double[] arr, double[] arr2)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {                
                sum += Math.Abs((arr2[i] - (ConstA / arr[i] + ConstB )) / arr2[i]);
            }
            return sum;
        }

        private double GetConstA()
        {            
            ConstA = (Count * Sum1(Temperatures, Zones) - Sum3(Temperatures) * Sum1(Zones))
                       / (Count * Sum2(Temperatures) - Math.Pow(Sum3(Temperatures), 2));
            return ConstA;
        }

        private double GetConstB()
        {           
            ConstB = Sum1(Zones) / Count - (ConstA * Sum3(Temperatures)) / Count;
            return ConstB;
        }

        private double GetError()
        {
            ErrorApprox = Sum4(Temperatures, Zones) / Count * 100;
            return ErrorApprox;
        }
    }
}
