using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crea un sistema de biblioteca digital, el mismo consiste de elementos digitales
y posibilidad de retiro físico. El sistema debe consistir de:
• Clase abstracta Material con atributos comunes: título, autor, año
• Clases hijas: Libro, Revista, AudioLibro, DVD
• Interfaz: IPrestable con métodos: prestar(), devolver(), estaDisponible()
• Manejar excepciones para: material no disponible, límite de préstamos*/
namespace Practica_Preparcial2___Arik
{
    public abstract class Material
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anio { get; set; }

        public virtual void CargarDatos()
        {
            Console.Write("Título: ");
            Titulo = Console.ReadLine();
            Console.Write("Autor: ");
            Autor = Console.ReadLine();
            Console.Write("Año: ");
            int.TryParse(Console.ReadLine(), out int anio);
            Anio = anio;
        }

        public override string ToString() => $"{Titulo} - {Autor} ({Anio})";

    }
}
