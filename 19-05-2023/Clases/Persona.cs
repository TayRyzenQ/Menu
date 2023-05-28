using _19_05_2023.Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_2023.Clases
{
    public class Persona
    {
        // Declarando variables para pedirle los datos al usuario
        public string Nombre { get; set; }          /*Get y Set son para sacar y meter informacion dentro de una base de datos*/
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public int Edad {  get; set; }

        public void PedirDatos()
        {
            Console.WriteLine("Ingrese su nombre: ");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            this.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su carrera: ");
            this.Carrera = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            this.Edad = int.Parse(Console.ReadLine());

            Console.Clear();

            if (Edad >= 18)
            {
                Menu menu= new Menu();
                menu.Opciones();
                Console.WriteLine(this.Nombre);
                Console.WriteLine(this.Apellido);
                Console.WriteLine(this.Carrera);
                Console.WriteLine(this.Edad);
            }
            else
            {
                Console.WriteLine("No puedes acceder !!!!!!");
            }
        }
    }


}
