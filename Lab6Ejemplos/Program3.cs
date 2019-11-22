using System;
namespace Lab6Ejemplos
{
    public class Program3
    {
        /* Modelar clase Customer con los siguientes atributos: id,name,address,phone
         * 1)Crear constructor que reciba como argumentos name, address,phone y que
         * automaticamente le asigne un valor a id, unico y no repetible
         * 2)Crear metodo Imprimir que regrese cadena con los valores de customer separados ,
         * 3)Probar la clase instanciando objetos
         */

        public static void Main3(string[] args)
        {
            Console.WriteLine("Program3");

            Customer c1 = new Customer("Javier Morales","Av. Patriotismo 123","56123411");
            Console.WriteLine(c1.Imprimir());
            Customer c2 = new Customer("Erika Zuniga", "Pino 231", "56273412");
            Console.WriteLine(c2.Imprimir());

            Console.WriteLine(c1.Imprimir());

        }
    }

    class Customer
    {
        //Variable de clase
        public static int contador;

        //Variables instancia
        public int id;
        public string name;
        public string address;
        public string phone;


        //Metodos

        public Customer(string name,string address,string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            id = ++contador;
            
        }

        // Metodo instancia
        public string Imprimir()
        {
            return "id:" + id + ",name:" + name + ",address:" + address + ",phone:" + phone;
        }

    }
}
