using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Preparcial2___Arik
{
    public class AudioLibro : Material, IPrestable
    {
        public void prestar()
        {

        }
        public void devolver() { }
        public bool estaDisponible()
        {
            return true;
        }

    }
}
