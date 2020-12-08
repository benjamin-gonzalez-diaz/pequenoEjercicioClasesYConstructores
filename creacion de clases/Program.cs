using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creacion_de_clases
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            bool sex = true;
            Console.WriteLine("hola");
            Console.WriteLine("ingrese un nombre: ");
            string name = Console.ReadLine();
            string valorvalido = "no";
            while (valorvalido == "no")
            {
                Console.WriteLine("Ingrese la edad ");
                try
                {
                    age = int.Parse(Console.ReadLine());
                    valorvalido = "si";

                }
                catch
                {
                    Console.WriteLine("INGRESE UN VALOR VALIDO");
                }
            }
            string valorvalido1 = "no";
            while (valorvalido1 == "no")
            {
                Console.WriteLine("Ingrese el sexo [M] o [F] ");
                try
                {
                    string sEx = Console.ReadLine();
                    sEx.ToUpper();
                    if (sEx == "M" || sEx == "m")
                    {
                        Console.WriteLine("es masculino");
                        sex = true;
                        valorvalido1 = "si";
                    }
                    else if (sEx == "F" || sEx == "f")
                    {
                        Console.WriteLine("es Femenino");
                        sex = false;
                        valorvalido1 = "si";
                    }
                    else
                    {
                        Console.WriteLine("ingrese un valor para el sexo");
                    }
                    

                }
                catch
                {
                    Console.WriteLine("INGRESE UN VALOR VALIDO");
                }
            }
            Alumno estudiante = new Alumno(name, age, sex);
            estudiante.Imprimir();
            estudiante.GetSexo();
            estudiante.EsMayorEdad();
            Console.ReadKey();
        }
    }
    /*
    class circulo
    {
        double pi = 3.1416; // propiedad de la clase circulo. campo de clase

        double calculoR(int radio)
        {
            return pi * radio * radio;
        }
    }
    */
}
