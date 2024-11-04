using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace myProjectOnCool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write some nunber");
            float first_Nunber = float.Parse(Console.ReadLine());

            Console.WriteLine("Write other nunber");
            float second_Nunber = float.Parse(Console.ReadLine());

            Console.Write("Which oparation gonna be \n1-plus\n2-less\n3-multiplication\n4-division\n");
            float calculo = float.Parse(Console.ReadLine());

            float equal;

            if (calculo == 1)
            {
                equal = first_Nunber + second_Nunber;
            }
            else if (calculo == 2)
            {
                equal = first_Nunber - second_Nunber;
            }
            else if (calculo == 3)
            {
                equal = first_Nunber * second_Nunber;
            }
            else if (calculo == 4)
            {
                equal = first_Nunber / second_Nunber;
            }
            else
            {
                Console.WriteLine("set a valibe oparation");
                return;
            }
            Console.WriteLine("The result is " + equal);
            
            Console.ReadKey();

        }
    }
}
