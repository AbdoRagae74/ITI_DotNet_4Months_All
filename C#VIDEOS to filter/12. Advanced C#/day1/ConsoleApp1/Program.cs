namespace ConsoleApp1
{
    internal class Program
    {
        public class Point3D
        {
            public double X;
            public double Y;
            public double Z;
            public Point3D()
            {
                X = 0.0;
                Y = 0.0;
                Z = 0.0;
            }
            public Point3D(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }
            public override string ToString()
            {
                return $"Point Coordinates: ({X}, {Y}, {Z})";
            }
            public override bool Equals(object? obj)
            {
                Point3D point = (Point3D)obj;
                return (this.X == point.X && this.Y == point.Y && this.Z == point.Z);
            }
        }

        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(3, 4, 5);
            Point3D p2 = new Point3D(3, 4, 5);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.Equals(p2));

            Point3D[] pointsArray = new Point3D[3];
            pointsArray[0] = p1;
            pointsArray[1] = p2;
            pointsArray[2] = new Point3D(10,10,10);

            for (int i = 0; i < pointsArray.Length; i++)
            {
                Console.WriteLine(pointsArray[i]); //compiler goes to toString which i already overriden
            }

            Console.ReadKey();
        }
    }
}
