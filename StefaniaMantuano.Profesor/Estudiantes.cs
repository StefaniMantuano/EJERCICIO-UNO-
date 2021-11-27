using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefaniaMantuano.Profesor
{
    public class Estudiantes: Personas
    {
        private string Cursomatriculado;


        public string getCursomatriculado()
        {
            return Cursomatriculado;
        }
        public void setCursomatriculado (string Cursomatriculado)
        {
            this.Cursomatriculado = Cursomatriculado;
        }


        public void Mostrar()
        {
            Console.WriteLine("Ingrese el curso matriculado del estudiante: ");
            Cursomatriculado  = Console.ReadLine();

            
            string nuevocurso; 
            Console.WriteLine("Ingrese el nuevo curso del estudiante: ");
            nuevocurso = Console.ReadLine();

            Console.WriteLine("Su matricula ha sido realizada");
        }
    }
}

