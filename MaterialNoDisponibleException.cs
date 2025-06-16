using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Preparcial2___Arik
{
    public class MaterialNoDisponibleException : Exception
    {
        public MaterialNoDisponibleException(string mensaje) : base(mensaje) { }
    }
}
