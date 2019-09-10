using System;

namespace GeometryLib
{
    /// <summary>
    /// Circle class
    /// </summary>
    public class Circle : Figure
    {
        public float Radius { get; set; }

        /// <summary>
        /// main constructor
        /// </summary>
        /// <param name="r">float r radius</param>
        public Circle(float r)
        {
            this.Radius = r;
        }
        /// <summary>
        /// method to calcualate area of a circle
        /// </summary>
        /// <returns>area value</returns>
        public override float CalcS()
        {
            return (float)(Math.PI * Math.Pow(this.Radius, 2));
        }

        /// <summary>
        /// this method is only to show results in concole
        /// </summary>
        public override void ReportFigure()
        {
            Console.WriteLine("This is circle, r = {0}, S = {1}", Radius, this.CalcS());
        }
    }
}
