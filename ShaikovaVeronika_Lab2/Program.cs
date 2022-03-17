using System;


namespace ShaikovaVeronika_Lab2
{

    static public class Funcs
    {
      static  public int returnRes(int val, int div)
        {

            return val % div;
        }

      static public int parseInFunc(string sval)
        {
            return int.Parse(sval);
        }
    }

    class Program
    {

        

        static void Main(string[] args)
        {

            string k = "yes";
            string sdivider;
            string sval;

            while (k == "yes")
            {
                do
                {
                    Console.WriteLine("input correct integer value 10 to 99");
                    sval = Console.ReadLine();
                } while (sval.Length != 2 || sval[0] > 57 || sval[1] > 57 || sval[0] < 48 || sval[0] > 57);


                //Funcs a = new Funcs();


                int ival = Funcs.parseInFunc(sval.Substring(0, 1)) + Funcs.parseInFunc(sval.Substring(1, 1));
                
                do
                {
                    Console.WriteLine("input correct integer value");
                    sdivider = Console.ReadLine();
                } while (Funcs.parseInFunc(sdivider) == 0);

                int idivider = Funcs.parseInFunc(sdivider);


                if (Funcs.returnRes(ival, idivider) == 0)
                {
                    Console.WriteLine($"value {idivider} is a divider of {sval}'s digits' sum");
                }
                else Console.WriteLine($"{sval}'s digits' sum can not be divided by {idivider}");

                Console.WriteLine("\n\n\nWould you like to continue? \n(type \"yes\" to make one more repeat...\n)");
                k = Console.ReadLine();
                Console.WriteLine("\n\n\n");
            }
            Console.ReadKey();

        }
    }
}
