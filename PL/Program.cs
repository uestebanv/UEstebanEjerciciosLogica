using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        //PL.Ejercicio1.cadena();
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int num = int.Parse(Console.ReadLine());

            for (int c = num; c >= num; c--)
            {
                string l = new string(' ', c);

                for (int a = 1; a <= num; a++)
                {
                    string d = new string('*', a);
                    Console.Write(d);

                    //for (int i = a; i == a; i++)
                    //{
                    //    Console.Write("\n");
                    //}
                    if (a != 0)
                    {
                        Console.Write("\n");
                    }
                    Console.WriteLine();
                }
                Console.Write(l);
            }

            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadKey();
        }
    }
}
