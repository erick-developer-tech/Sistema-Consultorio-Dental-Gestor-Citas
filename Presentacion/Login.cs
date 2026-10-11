using AccesoDatos.DTOs;
using AccesoDatos.Models;
using Presentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ProcesarLogin() 
        {
            try
            {
                string usuario = textBoxUsuario.Text.Trim();
                string contraseña = textBoxContraseña.Text.Trim();

                DTOUsuario dto = new DTOUsuario(Program._cadenaConexion);
                UHash hash = new UHash();

                MUsuario mu = dto.ValidarCredenciales(usuario).FirstOrDefault();

                // Si el objeto es diferente de null y la comparación devuelve true
                if (mu != null && hash.CompararHash(contraseña, mu.Contraseña))
                {
                    MenuNavegacion menu = new MenuNavegacion(mu.Nombre, mu.Apellidos, mu.Rol);

                    MessageBox.Show(
                    $"Bienvenido al sistema {mu.Nombre} {mu.Apellidos}.",
                    "Acceso Permitido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                    menu.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show(
                    $"Credenciales no validas.",
                    "Acceso Denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                    );
                }
            }
            catch 
            {
                MessageBox.Show(
                    "Error al conectar con el sistema.", 
                    "Error de la aplicación", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ProcesarLogin();
        }
    }
}
