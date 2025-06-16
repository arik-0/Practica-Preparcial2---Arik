using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Preparcial2___Arik
{
    public class repoMaterial
    {
        public List<Material> materiales = new List<Material>(); 
        public void Agregar(Material m) => materiales.Add(m);

        public List<Material> ObtenerTodos() => materiales;

        public List<T> FiltrarPorTipo<T>() where T : Material
            => materiales.OfType<T>().ToList();
    }
}
