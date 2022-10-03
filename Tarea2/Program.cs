using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------CÁLCULO DEL AGUINALDO----------");

            string[] nombreEmpleado = new string[3];

            nombreEmpleado[0] = "Jose";
            nombreEmpleado[1] = "Carmen";
            nombreEmpleado[2] = "Roberto";

            float[] salarioEmpleados = new float[3];

            salarioEmpleados[0] = 1300;
            salarioEmpleados[1] = 1500;
            salarioEmpleados[2] = 2000;

            Aguinaldo(nombreEmpleado, salarioEmpleados);
            
        }

        static void Aguinaldo(string[] nombre, float[] salario)
        {

            int n = 0;
            foreach (string i in nombre)
            {
                Console.WriteLine(i +" " + salario[n]);
                n++;
         
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("El salario actual de " + nombre[0] + " " + "es de: " + salario[0]);
            Console.WriteLine("El salario actual de " + nombre[1] + " " + "es de: " + salario[1]);
            Console.WriteLine("El salario actual de " + nombre[2] + " " + "es de: " + salario[2]);

            for (int i = 0; i < 3; i++)
            {
                salario[i] *= 12;
                
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("El aguinaldo de " + nombre[0] + " " + "es de: " + salario[0]);
            Console.WriteLine("El aguinaldo de " + nombre[1] + " " + "es de: " + salario[1]);
            Console.WriteLine("El aguinaldo de " + nombre[2] + " " + "es de: " + salario[2]);

            Console.WriteLine("-----------------------------------------");

            Console.ReadKey();
        }

        
        
    }
}
