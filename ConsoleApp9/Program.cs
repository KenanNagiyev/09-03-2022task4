using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sahe(5,3,2, "Ucbucaqilinin daxiline cekilmis cevre"));
        }
        static int Sahe(int a, int b, int c,  string figure)
        {


            
            int result = 0;
            if (figure == "cevre")
            {
                result = a * a * 3;
            }
            else if (figure == "kvadrat")
            {
                result = a * a;
            }
            else if (figure == "duzbucaqli")
            {
                result = a * b;
            }
            else if (figure == "Duzbucaqli paralepiped")
            {
                result = 2 * (a * b + a * c + b * c);
            }
            else if (figure == "Ucbucaqilinin daxiline cekilmis cevre")
            {
                int p = (a + b + c) / 2;
                result = p * a;
            }
            else
            {
                return -1;
            }
            return result;
        }
    }
}
