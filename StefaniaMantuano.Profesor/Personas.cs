using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefaniaMantuano.Profesor
{
    public class Personas
    {
        private string Nombres;
        private string Apellidos;
        private int  NumeroIdentificacion;
        private string EstadoCivil;

       
        public string getNombres()
        {
            return Nombres;
        }
        public void setNombres(string Nombres )
        {
            this.Nombres = Nombres;
        }

        public string getApellidos()
        {
            return Apellidos;
        }
        public void setApellidos(string Apellidos)
        {
            this.Apellidos = Apellidos;
        }


        public int getNumeroIdentificacion()
        {
            return NumeroIdentificacion;
        }
        public void setNumeroIdentificacion (int NumeroIdentificacion)
        {
            this.NumeroIdentificacion = NumeroIdentificacion;
        }

        public string getEstadoCivil()
        {
            return EstadoCivil;
        }  
        public void setEstadocivil(string EstadoCivil)
        {
            this.EstadoCivil = EstadoCivil;
        }

        public void Mostrar()
        {
            
            Console.WriteLine("Ingrese los nombres :  ");
            Nombres = Console.ReadLine();

            Console.WriteLine("Ingrese los apellidos :  ");
            Apellidos = Console.ReadLine();

            Console.WriteLine("Ingrese el numero de identificación :  ");
            NumeroIdentificacion = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese el estado civil:  ");
            EstadoCivil = Console.ReadLine();

           
            int nuevoestadocivil;
            int estado;

            Console.WriteLine("Elija si desea cambiar su estado civil: \nSi----1 \nNo-----2");
            nuevoestadocivil = int.Parse(Console.ReadLine());

            if (nuevoestadocivil ==1)
            {
                Console.WriteLine("Ingrese nuevamente su estado civil");
                
                Console.WriteLine("Estado civil: \nSoltero----1 \nCasado-----2 \nDivorciado-----3 ");
                estado = int.Parse(Console.ReadLine());
                if ( estado == 1)
                {
                    Console.WriteLine("Ha cambiado su estado civil a soltero");
                }
                else if (estado == 2)
                {
                    Console.WriteLine("Ha cambiado su estado civil a casado");
                }
                else if (estado == 3)
                {
                    Console.WriteLine("Ha cambiado su estado civil a divorciado");
                }
            }
            else
            {
                   Console.WriteLine("Usted no desea realizar el cambio");
            }
        }
        public void Escoger()

             {
                int persona1;
                Console.WriteLine("Elija su ocupación : \nEstudiantes----1 \nEmpleado-----2\nPersonal de servicio----3\nProfesores----4");
                persona1 = int.Parse(Console.ReadLine());

                if (persona1 == 1)
                {
                    Console.WriteLine("Ha escogido Estudiantes");
                    Estudiantes estudiantes = new Estudiantes();
                    estudiantes.Mostrar();

                }

                else if (persona1 == 2)
                {
                    Console.WriteLine("Ha escogido empleado");
                    Empleado empleado = new Empleado();
                    empleado.Mostrar();
                }


                else if (persona1== 3)
                {
                    Console.WriteLine("Ha escogido personal de servicio");
                    PersonalServicio personal = new PersonalServicio();
                    personal.Mostrar();
                }

                 else if (persona1== 4)
                {
                    Console.WriteLine("Ha escogido profesores");
                    Profesores profesores = new Profesores();
                    profesores.Mostrar();
                    profesores.Escoger();
                }

            }
        } 
    }

