using System;
using System.Linq;

namespace Shapes
{
    public class Triangle : Shapes
    {
        private readonly Lazy<bool> isRightAngle;

        /// <summary>
        /// Сторона A
        /// </summary>
        public double sideA {get;}

        /// <summary>
        /// Сторона B
        /// </summary>
        public double sideB {get;}

        /// <summary>
        /// Сторона C
        /// </summary>
        public double sideC { get;}

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightAngle => isRightAngle.Value;

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="sideA">Сторона A</param>
        /// <param name="sideB">Сторона B</param>
        /// <param name="sideC">Сторона C</param>
        /// <exception cref="ArgumentOutOfRangeException">Одна или несколько сторон не объявлены, либо отрицательные</exception>
        /// <exception cref="ArgumentException">Значения не подходят под свойства треугольника</exception>
        public Triangle (double sideA, double sideB, double sideC)
        { if (sideA <= 0 || sideB <= 0 || sideC <= 0) 
            {
                throw new ArgumentOutOfRangeException("Одна или несколько сторон не объявлены, либо отрицательные");
            }
            if (sideA + sideB <= sideC || sideB + sideC <= sideA || sideC + sideA <= sideB)
            {
                throw new ArgumentException("Значения не подходят под свойства треугольника");
            }


            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;

            isRightAngle = new Lazy<bool>(CheckIsRightAngel); 
          
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        private bool CheckIsRightAngel()
        {
            double[] sides = new double[] { sideA, sideB, sideC };
            var sortedArray = sides.OrderBy(x => x).ToArray();
           
            double maxSidePow = Math.Pow(sortedArray.Max() , 2);
           
            double firstAndSecondSidesSqrt = Math.Pow(sortedArray[0],2) + Math.Pow(sortedArray[1],2);
           

            if (maxSidePow == firstAndSecondSidesSqrt)
            {
                return true;
            }
            return false;

             
        }

        /// <summary>
        /// Расчет площади треугольника
        /// </summary>
        /// <param name="hλlfPerimeter">Половина периметра</param>
        protected sealed override double GetAreaOfShape()
        {
            double hλlfPerimeter = (sideA + sideB + sideC) / 2;

           
            return Math.Sqrt(hλlfPerimeter * (hλlfPerimeter - sideA) * (hλlfPerimeter - sideB) * (hλlfPerimeter - sideC));
        }

    }
}
