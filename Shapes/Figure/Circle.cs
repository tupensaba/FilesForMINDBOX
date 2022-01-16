using System;


namespace Shapes
{
    public class Circle : Shapes
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        double radius { get; }


        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentException">Радиус не может равняться нулю. А также, в нашем случае, не может быть отрицательным числом</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус не может равняться нулю. А также, в нашем случае, не может быть отрицательным числом.");
            }
           this.radius = radius;
        }

        /// <summary>
        /// Расчет площади круга
        /// </summary>
        protected sealed override double GetAreaOfShape()
        {
            return Math.PI * Math.Pow(radius,2);
        }

    }
}
