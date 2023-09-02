using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_2023.Entidades
{
    internal class Mascota
    {
        public int IdMascota { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Tipo { get; set; }
        public Duenio Duenio { get; set; }
        public CarpetaMedica Carpeta { get; set; }

        public Mascota()
        {
            IdMascota = 0;
            Nombre = string.Empty;
            Edad = 0;
            Sexo = string.Empty;
            Tipo = string.Empty;
        }

        public Mascota(int id, string nombre, int edad,string sexo, string tipo, Duenio duenio, CarpetaMedica carpeta)
        {
            IdMascota = id;
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Tipo = tipo;
            Duenio = duenio;
            Carpeta = carpeta;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
