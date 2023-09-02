using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_2023.Entidades
{
    internal class Duenio
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public Mascota Mascota { get; set; }

        public Duenio()
        {
            Codigo = 0;
            Nombre = string.Empty;
        }
        public Duenio(int codigo, string nombre, string sexo, Mascota mascota)
        {
            Codigo = codigo;
            Nombre = nombre;            
            Mascota = mascota;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
