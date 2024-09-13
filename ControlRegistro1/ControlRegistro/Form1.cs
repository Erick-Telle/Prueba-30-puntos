using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlRegistro
{
    public partial class Form1 : Form
    {
        private List<User> usuariosRegistrados = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }
        //Funcion de boton regristo
        private void btnRegistro_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string nick = txtNick.Text;
            string contraseña = txtContraseña.Text;

            //Se encarga de verificar que no falten datos requeridos 
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(nick) && !string.IsNullOrEmpty(contraseña))
            {
                //Verifica que el programa no exeda el limite de registro
                if (usuariosRegistrados.Count < 100)
                {
                    // Verificar si el usuario ya existe en la lista
                    bool usuarioExiste = usuariosRegistrados.Any(u => u.Nick == nick);

                    //Conpruva si el usuario ya existe o no.
                    if (!usuarioExiste)
                    {
                        User usuario = new User { Nombre = nombre, Nick = nick, Contraseña = contraseña };
                        usuariosRegistrados.Add(usuario);
                        MessageBox.Show("Usuario registrado con éxito!");
                        txtNombre.Clear();
                        txtNick.Clear();
                        txtContraseña.Clear();
                    }
                    else
                    {
                        MessageBox.Show("El nick ya está en uso. Por favor, elija otro.");
                    }
                }
                else
                {
                    MessageBox.Show("Límite de usuarios alcanzado. No se pueden registrar más usuarios.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }
    }
    //Clase, por que se me hiso mas facil haci.
    public class User
    {
        public string Nombre { get; set; }
        public string Nick { get; set; }
        public string Contraseña { get; set; }
    }
}
