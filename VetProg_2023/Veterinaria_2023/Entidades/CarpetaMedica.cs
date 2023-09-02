using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_2023.Entidades
{
    internal class CarpetaMedica
    {
        public int CarpetaNro { get; set; }
        public List<Atencion> Atenciones { get; set; }

        public CarpetaMedica()
        {
            Atenciones = new List<Atencion>();
        }

        public void AgregarAtencion(Atencion atencion)
        {
            Atenciones.Add(atencion);
        }

        public void QuitarAtencion(int posicion)
        {
            Atenciones.RemoveAt(posicion);
        }
    }
}
