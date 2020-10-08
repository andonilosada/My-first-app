using System;

namespace My_first_app
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Introduce edad:");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 18) 
            {
                Console.WriteLine("Eres un niño");
            }
            else if (edad < 30)
            {
                Console.WriteLine("Eres joven");
            }
            else if (edad < 60)
            {
                Console.WriteLine("Eres un maduro");
            }
            else
                Console.WriteLine("Eres un anciano");

        }
    }
}

