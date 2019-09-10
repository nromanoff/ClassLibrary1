using System;

namespace GeometryLib
{
    /// <summary>
    /// All figures parent class
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Constructor with 3 metrics, 
        /// which can be used for area calculation
        /// for triangle S = a * h * 1/2
        /// for rectangle S = a * b
        /// etc
        /// </summary>
        public Figure()
        {}
        /// <summary>
        /// method to calculate the area
        /// </summary>
        /// <returns> float value of area </returns>
        public virtual float CalcS()
        {
            return 0;
        }

        /// <summary>
        /// this method is only to show results in concole
        /// </summary>
        public virtual void ReportFigure()
        {
            Console.WriteLine("This is some Figure\n");
            Console.WriteLine("Square is {0}", this.CalcS());
        }
    }
}
