using System;
namespace Lab6Ejemplos
{
    public class Program2
    {
        public static void Main2(string[] args)
        {
            Console.WriteLine("Program2");
            // Acceso a la variable de clase
            Console.WriteLine("Poblacion inicial: "+Panda.poblacion);
            
            //Crear objeto o instanciar
            Panda p1 = new Panda("Tohui");
            Panda p2 = new Panda("Ying Ying");
            Panda p3 = new Panda("Pepe");

            // Nombre de los pandas
            Console.WriteLine("Nombre del primer panda: "+p1.nombre);
            Console.WriteLine("Nombre del segundo panda: " + p2.nombre);
            Console.WriteLine("Poblacion: " + Panda.poblacion);

            // Eliminar un objeto
            p1 = null;
            //p1.reducirPoblacion(); // System.NullReferenceException

            // reducirPolacion es un metodo de instancia
            // Un metodo de instancia no se puede invocar desde la clase
            // Un metodo de instancia se puede invocar desde un objeto y que no sea null
            // Panda.reducirPoblacion();

            Panda.reducirPoblacion();
            p2 = null;
            //Metodo reducirPoblacion es de clase
            Panda.reducirPoblacion();
            Console.WriteLine("Poblacion: " + Panda.poblacion);

            //Convertir pies a pulgadas
            // Enviamos factor de conversion al constructor
            UnitConverter piesPulgadas = new UnitConverter(12);
            // Convertir 30 pies a pulgadas
            int pulgadas = piesPulgadas.convert(30);
            Console.WriteLine($"30 pies son {pulgadas} pulgadas");


        }
    }

    class Panda
    {
        // Variable de instancia
        public string nombre;
        // Variable de clase
        public static int poblacion = 0;

        // Metodo constructor
        public Panda(string nombrepanda)
        {
            nombre = nombrepanda;
            poblacion++;
        }

        /*
        // Metodo de instancia
        public void reducirPoblacion()
        {
            poblacion--;
        }
        */

        // Metodo de clase
        public static void reducirPoblacion()
        {
            poblacion--;
        }


    }

    class UnitConverter
    {
        public int ratio;

        public UnitConverter(int unit)
        {
            ratio = unit;
        }

        public int convert(int dato)
        {
            return dato * ratio;
        }
        
    }


}
