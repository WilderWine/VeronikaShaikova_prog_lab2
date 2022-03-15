using System;


namespace Lab2_2
{
  
    public class FuncsToo
    {

        // this function returns:
        // 1 - if the point (x, y) is within given area
        // 2 - if the point (x, y) is on a boarder of given area
        // 3 - if the point (x, y) is somewhere else



       public int positionFind(double x, double y)
        {
            if (y <= 0)
            {
                if (Math.Pow(x, 2) + Math.Pow(y, 2) < 100 && !(x == 0 && y == 0))
                {  
                    return 1;
                }
                else if ((Math.Pow(x, 2) + Math.Pow(y, 2) == 100) || (x == 0 && y == 0))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
            else
            {
                if (Math.Abs(x) < y)
                {   
                    return 3;
                }
                else if (Math.Abs(x) == y && (2 * Math.Pow(y, 2) <= 100))
                {
                    return 2;
                }
                else
                {
                    if (Math.Pow(x, 2) + Math.Pow(y, 2) < 100)
                    {
                        return 1;
                    }
                    else if (Math.Pow(x, 2) + Math.Pow(y, 2) == 100 || (x == 0 && y == 0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            string k = "";

            do
            { 
                Console.WriteLine("Input double coordinate x of the point");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Input double coordinate y of the point");
                double y = double.Parse(Console.ReadLine());

                FuncsToo c = new FuncsToo();

                int cs = c.positionFind(x, y);

                switch (cs)
                {
                    case 1:
                        {
                            Console.WriteLine($"Point ({x}, {y}) is within giving area.");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Point ({x}, {y}) is on the border of the given area");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Point ({x}, {y}) is outside the given area");
                            break;
                        }
                    default: break;
                }
                

                Console.WriteLine("\n\n\nWould you like to continue? \n(type \"yes\" to make one more repeat...\n)");
                k = Console.ReadLine();
                Console.WriteLine("\n\n\n");

            } while (k == "yes");
        }
    }
}
