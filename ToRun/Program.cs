using GeometryLib;

namespace ToRun
{
    class Program
    {
        /// <summary>
        /// Method to run geometry lib
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Triangle tri = new Triangle(1, 2, 3);
            Triangle tri1 = new Triangle(4, 5, 3);
            Circle crc = new GeometryLib.Circle(2);
            Figure[] figs = { tri, tri1, crc };

            foreach (Figure f in figs)
                   f.ReportFigure();
        }
    }


}
