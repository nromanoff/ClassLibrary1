using System;

namespace GeometryLib
{
    /// <summary>
    /// All figures parent class
    /// </summary>
    public abstract class Figure
    {
        public float Metric1 { get; set; }
        public float Metric2 { get; set; }
        public float Koeff { get; set; }

        /// <summary>
        /// Constructor with 3 metrics, 
        /// which can be used for area calculation
        /// for triangle S = a * h * 1/2
        /// for rectangle S = a * b
        /// etc
        /// </summary>
        /// <param name="Metric1">first metric</param>
        /// <param name="Metric2">second metric</param>
        /// <param name="Koeff">numeric coefficient</param>
        public Figure(float Metric1, float Metric2, float Koeff)
        {
            this.Metric1 = Metric1;
            this.Metric2 = Metric2;
            this.Koeff = Koeff;
        }
        /// <summary>
        /// method to calculate the area
        /// </summary>
        /// <returns> float value of area </returns>
        public virtual float CalcS()
        {
            return this.Metric1 * this.Metric2 * this.Koeff;
        }

        /// <summary>
        /// this method is only to show results in concole
        /// </summary>
        public virtual void ReportFigure()
        {
            Console.WriteLine("This is some Figure\n");
            Console.WriteLine("Its square may be calculated as Metric1 * Metric2 * Koeff\n");
            Console.WriteLine("Square is {0}", this.CalcS());
        }
    }
}
