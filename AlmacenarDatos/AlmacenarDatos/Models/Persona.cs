using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenarDatos.Models
{
    internal class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona(string nombres, string apellidos, DateTime fechaNacimiento)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
        }
        public int Edad
        {
            get
            {
                int edad = DateTime.Today.Year - FechaNacimiento.Year;
                if (DateTime.Today < FechaNacimiento.AddYears(edad))
                    edad--;
                return edad;
            }
        }

        public override string ToString()
        {
            return ($"{Nombres} {Apellidos} - Edad: {Edad} años");
        }
    }
}
