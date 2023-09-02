using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_2023.Entidades
{
    internal class Atencion
    {
        public Mascota Mascota { get; set; }
        public string Descripcion { get; set; }
        public DateTime fecha { get; set; }

        public Atencion()
        {
            Mascota = new Mascota();
            Descripcion = string.Empty;

        }

        public Atencion(Mascota m, string descripcion)
        {
            Mascota = m;
            Descripcion = descripcion;
        }
    }
}
