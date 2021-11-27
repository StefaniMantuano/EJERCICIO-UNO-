using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefaniaMantuano.Profesor
{
    public class Empleado: Personas 
    {
        private int añoincorporacion;
        private int numerodespacho;


        public int getañoincorporacion()
        {
            return añoincorporacion;
        }
        public void setañoincorporacion(int añoincorporacion)
        {
            this.añoincorporacion = añoincorporacion;
        }

        public int getnumerodespacho()
        {
            return numerodespacho;
        }
        public void setnumerodespacho(int numerodespacho)
        {
            this.numerodespacho= numerodespacho;
        }


        public void Mostrar ()
        {
            
            Console.WriteLine("Ingrese el año de incorporacion del empleado");
            añoincorporacion = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de despacho del empleado");
            numerodespacho= int.Parse(Console.ReadLine());

            //Reasigancion del despacho del empleado
            int nuevodespacho;

            Console.WriteLine("Ingrese el nuevo numero de despacho del empleado");
            nuevodespacho = int.Parse(Console.ReadLine());

        }

    }
}
