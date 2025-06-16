using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_Preparcial2___Arik;

namespace Practica_Preparcial2___Arik
{
        public class Libro : Material, IPrestable
        {
            private bool disponible = true;

            public override void CargarDatos()
            {
                Console.Write("Ingrese el título del libro: ");
                Titulo = Console.ReadLine();

                Console.Write("Ingrese el autor: ");
                Autor = Console.ReadLine();

                Console.Write("Ingrese el año: ");
                Anio = int.Parse(Console.ReadLine());
            }

            public void prestar()
            {
                if (!disponible)
                    throw new MaterialNoDisponibleException("El libro ya está prestado.");

                disponible = false;
            }

            public void devolver()
            {
                disponible = true;
            }

            public bool estaDisponible()
            {
                return disponible;
            }
        }
}
