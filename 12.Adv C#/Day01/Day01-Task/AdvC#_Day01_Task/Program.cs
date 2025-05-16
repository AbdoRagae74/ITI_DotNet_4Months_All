namespace AdvC__Day01_Task
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Task 2
            Point3D point = new Point3D(10,10,10);
            
            Console.WriteLine(point.X);
            Console.WriteLine(point.ToString());

            //Task 3
            Point3D p1 = new Point3D();
            Point3D p2 = new Point3D();

            Console.WriteLine("Enter value for X in point1");
            p1.X = int.Parse (Console.ReadLine());
            Console.WriteLine("Enter value for Y in point1");
            p1.Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Z in point1");
            p1.Z = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for X in point2");
            p2.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for Y in point2");
            p2.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for Z in point2");
            p2.Z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{p1}");
            Console.WriteLine($"{p2.ToString()}");

            if (p1 == p2)
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not equals");
            }

            //Won't work as expected before override equals
            if (p1.Equals(p2))
            {
                Console.WriteLine("Points are equal");
            }
            else
            {
                Console.WriteLine("Points aren't the same");
            }

            //Task 5 
            Point3D[] arrPoints = new Point3D[5];  
            for(int i = 0; i < arrPoints.Length; i++)
            {
                arrPoints[i] = new Point3D(i,i+1,i+2);
                Console.WriteLine(arrPoints[i].ToString());
            }



        }
    }
}
