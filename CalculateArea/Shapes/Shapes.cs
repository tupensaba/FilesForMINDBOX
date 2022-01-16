using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shapes
{
    public abstract class Shapes
    {
        //fields
        private readonly Lazy<double> area;

        //properties

        public double Area => area.Value;

        protected Shapes()
        {
            area = new Lazy<double>(GetAreaOfShape);
        }
        //methods
        protected abstract double GetAreaOfShape();
    }
}
