using AlmacenarDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenarDatos
{
    public partial class Form1 : Form
    {
        private PersonaManager personaManager = new PersonaManager();
        public Form1()
        {
            InitializeComponent();
        }

        //Al presionar el boton lee los datos y lo manda a la clase persona 
        public void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;

            Persona persona = new Persona(nombres, apellidos, fechaNacimiento);
            personaManager.AgregarPersona(persona);

            //Para asegurarse que este resiviendo los cogidos de manera correcta
            Debug.WriteLine("Persona agregada: " + persona.Nombres + " " + persona.Apellidos);

            //Limpia los text box
            txtNombres.Clear();
            txtApellidos.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        //Manda a mostrar los datos 
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Use la funcion List por que es mas facil trabajar con ella ademas trae muchas ventajas
            List<Persona> personas = personaManager.ObtenerPersonas();
            listBox1.Items.Clear();
            foreach (Persona persona in personas)
            {
                //Agrega a la listBox y perdon por no asignarle un nombre diferente
                listBox1.Items.Add(persona.ToString());
            }
        }

        //Tube que poner el mismo codigo por que por alguna razon asignaba los datos a las variales y despues de probar mucho timepo con el Breakpoint ligre que complilaara de manera efectiva 
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;

            Persona persona = new Persona(nombres, apellidos, fechaNacimiento);
            personaManager.AgregarPersona(persona);

            Debug.WriteLine("Persona agregada: " + persona.Nombres + " " + persona.Apellidos);

            txtNombres.Clear();
            txtApellidos.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            List<Persona> personas = personaManager.ObtenerPersonas();
            listBox1.Items.Clear();
            foreach (Persona persona in personas)
            {
                listBox1.Items.Add(persona.ToString());
            }
        }
        //Estaba Facil ;)
    }
}
