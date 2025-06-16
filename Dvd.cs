using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Preparcial2___Arik
{
    public class Dvd : Material, IPrestable
    {
        private bool disponible = true;

        public void prestar()
        {
            if (!disponible) throw new MaterialNoDisponibleException("El libro no está disponible.");
            disponible = false;
        }

        public void devolver() => disponible = true;
        public bool estaDisponible() => disponible;
    }

}
