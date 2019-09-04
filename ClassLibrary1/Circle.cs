﻿using System;

namespace GeometryLib
{
    /// <summary>
    /// Circle class
    /// </summary>
    public class Circle : Figure
    {
        float r;

        /// <summary>
        /// main constructor
        /// </summary>
        /// <param name="r">float r radius</param>
        public Circle(float r)
            :base(r, r, (float)Math.PI)
        {
            this.r = r;
            Metric1 = r;
            Metric2 = r;
            Koeff = (float)Math.PI;
        }

        /// <summary>
        /// this method is only to show results in concole
        /// </summary>
        public override void ReportFigure()
        {
            Console.WriteLine("This is circle, r = {0}, S = {1}", r, this.CalcS());
        }
    }
}
