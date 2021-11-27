using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefaniaMantuano.Profesor
{
    public class ProfesoresContrato:Personas
    {
        private int horastrabajadas;
        private int preciohora;

       
        public int gethorastrabajadas()
        {
            return horastrabajadas;
        }
        public void sethorastrabjadas(int horastrabajadas)
        {
            this.horastrabajadas = horastrabajadas;
        }

        public int getpreciohora()
        {
            return preciohora;
        }
        public void setpreciohora(int preciohora)
        {
            this.preciohora = preciohora;
        }


        public void Mostrar()
        {
            preciohora = 4;
            int sueldoprofesor;

            Console.WriteLine("Ingrese las horas trabajadas durante el mes");
            horastrabajadas = int.Parse(Console.ReadLine());

            sueldoprofesor = horastrabajadas * preciohora;

            Console.WriteLine("El sueldo del profesor por contrato es :  $"+sueldoprofesor);


        }


    }
}
