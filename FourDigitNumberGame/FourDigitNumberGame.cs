using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumberGame
{
    public class FourDigitNumberGame
    {
        public static int FourDigitNumberSum(int number)
        {
            Console.Write("Enter number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            return  a + b + c + d; 
        }
        public static string FourDigitNumberReverse(int number)
        {
            Console.Write("Enter number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            return $"{d}{c}{b}{a}";
        }
        public static string LastDigitFirst(int number)
        {
            Console.Write("Enter number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            return $"{d}{a}{b}{c}";
        }
        public static string SecondDigitThird(int number)
        {
            Console.Write("Enter number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            return $"{d}{c}{b}{d}";
        }

    }
}
