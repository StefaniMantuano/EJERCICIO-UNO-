using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefaniaMantuano.Profesor
{
    public class Profesores: Personas
    {
        private string Departamento;

        
        public string getDepartamento()
        {
            return Departamento;
        }
        public void setDepartamento(string Departamento)
        {
            this.Departamento = Departamento;
        }

        public void Mostrar()
        {

            Console.WriteLine("Ingrese a que departamento pertene:    ");
            Departamento = Console.ReadLine();


            int nuevodepa;
            int depa;

            Console.WriteLine("Elija si desea cambiar su departamento: \nSi----1 \nNo-----2");
            nuevodepa = int.Parse(Console.ReadLine());

            if (nuevodepa == 1)
            {
                
                Console.WriteLine("Departamento: \nArquitectura----1 \nLenguaje-----2 \nMatemáticas-----3 ");
                depa = int.Parse(Console.ReadLine());
                if (depa == 1)
                {
                    Console.WriteLine("Su nuevo departamento es Arquitectura");
                }
                else if (depa == 2)
                {
                    Console.WriteLine("Su nuevo departamento es lenguaje");
                }
                else if (depa == 3)
                {
                    Console.WriteLine("Su nuevo departamento es Matemáticas");
                }
            }
            else
            {
                Console.WriteLine("No hay ningun cambio");
            }
        }
        public void Escoger()

            {
            int personal;
            Console.WriteLine("Elija: \nProfesor por Contrato----1 \nProfesor por Nombramiento-----2");
            personal = int.Parse(Console.ReadLine());

            if (personal == 1)
            {
                Console.WriteLine("Ha escogido Profesor por Contrato");
                ProfesoresContrato contrato = new ProfesoresContrato();
                contrato.Mostrar();

            }

            else if (personal == 2)
            {
                Console.WriteLine("Ha escogido Profesor por Nombramiento");
                ProfesoresNombramiento nombramiento = new ProfesoresNombramiento();
                nombramiento.Mostrar();
            }

        }
    }
}

