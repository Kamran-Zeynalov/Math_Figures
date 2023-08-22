namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quadrilateral = GeometryHelper.Area(20, 40);
            int triangular = GeometryHelper.Area(10, 15, 23);
            double circle = GeometryHelper.Area(20);

            Console.WriteLine("DordBucaqlinin Sahesi: " + quadrilateral);
            Console.WriteLine("UcBucaqlinin Sahesi: " + triangular);
            Console.WriteLine("Dairenin Sahesi: " + circle);
        }
    }
}