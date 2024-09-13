using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenarDatos.Models
{
    internal class PersonaManager
    {
        private List<Persona> listaPersonas = new List<Persona>();

        public void AgregarPersona(Persona persona)
        {
            listaPersonas.Add(persona);
        }

        public List<Persona> ObtenerPersonas()
        {
            return listaPersonas;
        }
    }
}
