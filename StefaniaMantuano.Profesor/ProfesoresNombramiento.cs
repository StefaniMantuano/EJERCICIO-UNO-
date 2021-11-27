using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefaniaMantuano.Profesor
{
    public class ProfesoresNombramiento:Personas
    {
        private int sueldomensual;
        private int horasextras;

       
        public int getsueldomensual()
        {
            return sueldomensual;
        }
        public void setsueldomensual(int sueldomensual)
        {
            this.sueldomensual = sueldomensual;
        }

        public int gethorasextras()
        {
            return horasextras;
        }
        public void sethorasextras (int horasextras)
        {
            this.horasextras = horasextras;
        }


        public void Mostrar()
        {
            int valorhoraextra = 3;
            int valor;
            int sueldototal;
            sueldomensual = 400;

            Console.WriteLine("Ingrese las horas extras trabajadas");
            horasextras = int.Parse(Console.ReadLine());

            valor = valorhoraextra * horasextras;
            sueldototal = sueldomensual + valor;

            Console.WriteLine("El sueldo de un profesor con nombramiento es:   $" + sueldototal);
        }

    }
}
