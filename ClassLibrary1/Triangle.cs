using System;

namespace GeometryLib
{
    /// <summary>
    /// Triangle class
    /// </summary>
    public class Triangle : Figure
    {
        float a;
        float b;
        float c;
        bool Rect;

        /// <summary>
        /// Main constructor
        /// </summary>
        /// <param name="a">side a</param>
        /// <param name="b">side b</param>
        /// <param name="c">side c</param>
        public Triangle(float a, float b, float c)
            : base(0, 0, 0)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.Rect = IsRect();
        }

        /// <summary>
        /// area calculation according to Herone formula
        /// </summary>
        /// <returns> float value of area</returns>
        public override float CalcS()
        {
            double S = 0;
            float p = 0;
            if (this.Rect)
                S = base.CalcS();
            else
            {
                p = a + b + c;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return (float)S;
        }

        /// <summary>
        /// method to check if triangle is rectangular
        /// if it is rectangular - updates metrics of base class
        /// </summary>
        /// <returns>bool true if rectangular, elde false </returns>
        public bool IsRect()
        {
            bool IsRect;
            float[] abc = { a, b, c };
            Array.Sort(abc);
            IsRect =  Math.Pow(abc[0], 2) + Math.Pow(abc[1], 2) == Math.Pow(abc[2], 2);
            if (IsRect)
            {
                Metric1 = abc[0];
                Metric2 = abc[1];
                Koeff = 0.5f;
            }
            return IsRect;
        }

        /// <summary>
        /// this method is only to show results in concole
        /// </summary>
        public override void ReportFigure()
        {
            Console.WriteLine("This is Triangle a = {0}, b = {1}, c = {2}, S = {3}", a, b, c, this.CalcS());
            if (this.Rect)
                Console.WriteLine("It is Square");
            else
                Console.WriteLine("It is NOT Square");
        }
    }
}
