using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creacion_de_clases
{
    class Alumno
    {
        private string nombre { get; set; }
        private int edad { get; set; }
        private bool sexo { get; set; }

        public Alumno(string Nomre, int Ead, bool Sxo)
        {
            this.nombre = Nomre;
            this.edad = Ead;
            this.sexo = Sxo;
        }
        public Alumno()
        {

            Console.Write("Ingrese nombre:");
            nombre = Console.ReadLine();
            Console.Write("Ingrese edad:");
            string linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
        }

        public void GetSexo()
        {
            if (sexo == false)
            {
                Console.WriteLine("sexo: femenino");
            }
            else if (sexo == true)
            {
                Console.WriteLine("sexo: masculino");
            }
        }
        public void EsMayorEdad()
        {
            if (edad >= 18)
            {
                Console.Write(nombre + " es mayor de edad.");
            }
            else
            {
                Console.Write(nombre + " no es mayor de edad.");
            }
        }
    }
}
