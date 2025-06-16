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
    public interface IPrestable
    {
        public void prestar();
        public void devolver();
        public bool estaDisponible();
    }
}
