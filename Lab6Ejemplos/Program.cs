using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab6Ejemplos
{
    class MainClass
    {

        // Cuando un metodo tiene la palabra static, es un metodo de clase
        // Los metodos de clase no requieren de un objeto para su ejecucion
        public static void Main0(string[] args)
        {
            /* Este un comentario a nivel de bloque
             * Autor: Javier Morales
             */

            // variable local
            int contadorVueltas = 10;  // 10 es una literal
            string nombre = "Javier";
            bool esBisiesto = false;
            char letra = 'a';

            Console.WriteLine("Program1");
            Console.WriteLine("contadorVueltas: " + contadorVueltas);
            Console.WriteLine("nombre: " + nombre);
            Console.WriteLine("esBisiesto: " + esBisiesto);
            Console.WriteLine("letra: " + letra);
            Console.WriteLine("30 pies a pulgadas son: "+PiesPulgadas(30));
            Console.WriteLine("100 pies a pulgadas son: " + PiesPulgadas(100));

            // Expresiones regular
            var textToTest = "MOSJ701006-E79";
            var regularExpression = "^[A-Za-z]{4}\\d{6}[\\-]{0,1}[A-Za-z0-9]{3}$";
            var result = Regex.IsMatch(textToTest,regularExpression,RegexOptions.None);
            if (result)
                Console.WriteLine("Si es un RFC valido");
            else
                Console.WriteLine("No es un RFC valido");

            // Conversiones
            int dato1 = 12345;
            long y = dato1;
            short z = (short)dato1; // casting, conversion explicita

            // Literal
            Console.WriteLine(123.GetType()); //int
            Console.WriteLine(45.10.GetType()); // Double
            Console.WriteLine(0xF00000.GetType()); // int
            Console.WriteLine(0xF0000000.GetType()); // uint
            Console.WriteLine(0xF00000000000.GetType()); // int64
            Console.WriteLine("abc".GetType()); //string

            int diezMil = 10_000;
            var b = 0b1100_1000_0000;
            Console.WriteLine("Numero con separador: " + diezMil);
            Console.WriteLine("Numero en binario:" + b);

            // Operadores de incremento y decremento
            int dato3 = 15;
            int dato4 = 15;
            Console.WriteLine("Suma en prefijo: " + ++dato3); // 16
            Console.WriteLine("Suma en posfijo: " + dato4++); // 15

            // Division enteros
            int dato5 = 20;
            int dato6 = 10;
            Console.WriteLine("Division: " + dato5 / dato6); //2
            Console.WriteLine("Division: " + dato6 / dato5); //0
            //Console.WriteLine("Division: " + dato6 / 0); // System.DivideByZeroException

            // Overflow, no genera ni error de compilacion, ni error de ejecucion
            int dato7 = int.MinValue;
            dato7--;
            Console.WriteLine("Overflow: " + dato7);

            // Operador checked
            // Generar una exception OverflowException

            int dato8 = 1000000;
            int dato9 = 1000000;
            int dato10 = dato8 * dato9;
            Console.WriteLine("dato10 en overflow: " + dato10);

            // int dato11 = checked(dato8 * dato9); // System.OverflowException
            checked
            {
                // int dato12 = dato8 * dato9; // System.OverflowException
            }

            // float y double hay valores especiales
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(1.0/0.0); // Infinity
            Console.WriteLine(-1.0 / 0.0); // -Infinity
            Console.WriteLine(0.0 / 0.0); // NaN

            // \\server1\dir\archivo.txt
            string unc = "\\\\server1\\dir\\archivo.txt";
            Console.WriteLine("unc: " + unc);

            // Formatear una cadena, verbatim
            string unc1 = @"\\server1\dir\archivo.txt";
            Console.WriteLine("unc1: " + unc1);

            // Interpolacion de cadenas
            int lados = 3;
            Console.WriteLine($"El triangulo tiene {lados} caras ");

            var fecha = DateTime.Now;
            String s1 = String.Format("En {0}, la temperatura es {1} grados",fecha.Day+"/"+ fecha.Month+"/"+fecha.Year,18.5);
            Console.WriteLine(s1);

            // string es una cadena inmutable
            // string mutables - StringBuilder

            StringBuilder direccion = new StringBuilder();
            direccion.Append("Av. Patriotismo");
            direccion.Append("123, Col. Napoles");
            Console.WriteLine("Direccion: " + direccion.ToString());


        }

        // Metodo de clase
        public static int PiesPulgadas(int pies)
        {
            // variable local
            int pulgadas = pies * 12;
            return pulgadas;
        }
    }
}
