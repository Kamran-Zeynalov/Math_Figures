namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quadrilateral = GeometryHelper.Quadrilateral(20, 40);
            int triangular = GeometryHelper.Triangular(10, 15);
            double circle = GeometryHelper.Circle(20);

            Console.WriteLine("DordBucaqlinin Sahesi: " + quadrilateral);
            Console.WriteLine("UcBucaqlinin Sahesi: " + triangular);
            Console.WriteLine("Dairenin Sahesi: " + circle);
        }
    }
}