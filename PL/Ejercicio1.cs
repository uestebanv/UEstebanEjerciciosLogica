using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Ejercicio1
    {
        
        public static void cadena()
        {
            string resultado = "";
            int result = 0;
            int valor = 0;

            Console.WriteLine("Ingrese la cadena de digitos");
            string cadena = Console.ReadLine();

            char[] charArray = cadena.ToCharArray();



            for (int a = 0; a < charArray.Length; a++)
            {
                int num = int.Parse(charArray[a].ToString());

                result = num % 2;

                if (result == 0)
                {
                    resultado = "Par";
                    valor += 1;

                }
                else
                {
                    resultado = "Impar";
                }

            }
            Console.WriteLine("los pares son {0}", valor);
            Console.ReadKey();
        }
    }
}
