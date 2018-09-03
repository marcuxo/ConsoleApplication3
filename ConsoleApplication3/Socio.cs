using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Socio
    {
       private string nombre;
       private int antiguedad;

        public Socio(string nombre, int antiguedad) {
            Console.WriteLine("Ingresar nombre del socio... ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresar años de antiguedad del socio...");
            linea = Console.ReadLine(); 
        }

        public void imprimir()
        {
            Console.WriteLine(nombre+ "Es el socio mas antiguo con una antiguedad de " + antiguedad + " años");
        }

    }
}
