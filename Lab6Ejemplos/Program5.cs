using System;
using System.Text;

namespace Lab6Ejemplos
{
    public class Program5
    {
        public static void Main(string[] args) {
            Console.WriteLine("Program5");
            // Paso por valor con una literal
            Foo(10);
            // Paso por valor con una variable que no es un objeto
            int x = 12;
            Foo(x);
            Console.WriteLine("Valor x: " + x); // 12

            // Paso por referencia
            Console.WriteLine("Paso por referencia usando un objeto");
            StringBuilder sb = new StringBuilder();
            Foo1(sb);
            Console.WriteLine(sb); // prueba

            // Paso por referencia con una variable que no es un objeto
            int y = 12;
            Foo3(ref y);
            Console.WriteLine("Valor y: " + y); // 13

            // Swap(c1,c2)
            string a = "Hola";
            string b = "Adios";
            Swap(ref a,ref b);
            Console.WriteLine("Valor a: " + a + ", Valor b: " + b);

            // Parametros de salida
            string n1, n2;
            Split("Javier Morales",out n1,out n2);
            Console.WriteLine("Nombre: " + n1);
            Console.WriteLine("Apellido: " + n2);

            // Crear las variables out al momento de invocar al metodo
            Split("Erika Zuniga", out string n3, out string n4);
            Console.WriteLine("Nombre: " + n3);
            Console.WriteLine("Apellido: " + n4);

            // Descartar una variable out
            Split("Natalia Huitron", out string n5, out _);
            Console.WriteLine("Nombre: " + n5);

            // Aceptar multiples parametros
            int total = Sumar(10,20,5,4);
            Console.WriteLine("total1: " + total);
            total = Sumar(14,23,11,19,89,15,22,11);
            Console.WriteLine("total2: " + total);

            // Parametros opcionales
            Foo4();
            Foo4(43);

            Foo5(10, 20);
            Foo5(10, 20,50);
            Foo5(10, 20, z:50);

            //Ref locals
            int[] datos = {0,1,2,3,4};
            int numRef = datos[2];
            numRef++;
            Console.WriteLine("Segunda celda: "+datos[2]); // 2

            ref int numRef1 = ref datos[2];
            numRef1++;
            Console.WriteLine("Segunda celda: " + datos[2]); // 3
            Console.WriteLine("Fin");









        }

        static void Foo(int p)
        {
            p = p + 1;
            Console.WriteLine(p);
        }

        static void Foo1(StringBuilder sbp)
        {
            sbp.Append(" prueba");
            sbp = null;
        }

        static void Foo3(ref int p)
        {
            p = p + 1;
            Console.WriteLine(p);
        }

        static void Swap(ref string x, ref string y)
        {
            string temp = x;
            x = y;
            y = temp;

        }

        static void Split(string fullName,out string name,out string lastname)
        {
            int espacio = fullName.LastIndexOf(' ');
            name = fullName.Substring(0, espacio);
            lastname = fullName.Substring(espacio + 1);

        }

        static int Sumar(params int[] enteros)
        {
            int acumular = 0;

            for (int i = 0; i < enteros.Length; i++)
                acumular += enteros[i];

            return acumular;
        }

        static void Foo4(int y = 23)
        {
            Console.WriteLine("y: " + y);
        }

        // Parametros obligatorios antes que los opcionales
        static void Foo5(int x, int y, int w = 30, int z = 40)
        {
            Console.WriteLine("Foo4:" +x + "," + y + "," +w +","+ z);
        }



    }
}
