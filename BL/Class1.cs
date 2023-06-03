using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Class1
    {
        //Define un arreglo de números enteros con al menos 10 elementos.
        //Inicializa una variable contador con valor 0 para llevar la cuenta de los números pares.
        //Utiliza un ciclo for para recorrer cada elemento del arreglo.
        //Dentro del ciclo, verifica si el número actual es par.
        //Si el número es par, incrementa el valor de contador en 1.
        //Al finalizar el ciclo, muestra en la consola el valor de contador.
        public static void cadena()
        {
            string resultado = "";
            int result = 0;
            int valor = 0;

            Console.WriteLine("Engrese la cadena de digitos");
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
                Console.WriteLine("los pares son {1}", valor);
            }

            Console.ReadKey();
        }
    }
}
