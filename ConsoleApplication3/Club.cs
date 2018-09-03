using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Club
    {
        private Socio socio1;
        private Socio socio2;
        private Socio socio3;


        public Club()
        {
            this.socio1 = new Socio("nombre",33);
            this.socio2 = new Socio("nombre",33);
            this.socio3 = new Socio("nombre",33);
        }

        public string socioAntiguo(Socio socio1,Socio socio2,Socio socio3){


            if (socio1.antiguedad() > socio2.antiguedad() && socio1.antiguedad() > socio3.antiguedad()) { socio1.imprimir(); }
            if (socio2.antiguedad() > socio3.antiguedad() && socio2.antiguedad() > socio1.antiguedad()) { socio2.imprimir(); } 
            if (socio3.antiguedad() > socio1.antiguedad() && socio3.antiguedad() > socio2.antiguedad()) { socio3.imprimir();}
            return antiguo;
        }

        public void socios()
        {
            Console.WriteLine("El socio" + socio1.Nombre() + "posee una antiguedad de " + socio1.Antiguedad()+"años");
            Console.WriteLine("El socio" + socio2.Nombre() + "posee una antiguedad de " + socio2.Antiguedad()+"años");
            Console.WriteLine("El socio" + socio3.Nombre() + "posee una antiguedad de " + socio3.Antiguedad()+"años");
        }
} 
}
