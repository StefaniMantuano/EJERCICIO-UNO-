using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefaniaMantuano.Profesor
{
    public class PersonalServicio: Personas
    {
        private string secciontrabajo;

       
        public string getsecciontrabajo()
        {
            return secciontrabajo;
        }
        public void setsecciontrabajo(string secciontrabajo)
        {
            this.secciontrabajo = secciontrabajo;
        }


        public void Mostrar()
        {
            Console.WriteLine("Ingrese la seccion de trabajo");
            secciontrabajo = Console.ReadLine();

            int cambioseccion;
            int seccion;

            Console.WriteLine("Elija si desea cambiar la seccion de su trabajo: \nSi----1 \nNo-----2");
            cambioseccion = int.Parse(Console.ReadLine());

            if (cambioseccion == 1)
            {
                Console.WriteLine("Ingrese la seccion a cambiar:  ");
                seccion = int.Parse(Console.ReadLine());


                Console.WriteLine("Estado civil: \nBiblioteca----1 \nDecanato-----2 \n Secretaria-----3 ");
                seccion = int.Parse(Console.ReadLine());
                if (seccion == 1)
                {
                    Console.WriteLine("Ha cambiado su seccion de trabajo a biblioteca");
                }
                else if (seccion == 2)
                {
                    Console.WriteLine("Ha cambiado su seccion de trabajo a biblioteca");
                }
                else if (seccion == 3)
                {
                    Console.WriteLine("Ha cambiado su seccion de trabajo a secretaria");
                }
            }
            else
            {
                Console.WriteLine("Usted no desea realizar el cambio");
            }

        }
    }

}
