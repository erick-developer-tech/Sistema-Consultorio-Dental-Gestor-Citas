using AccesoDatos.DTOs;
using AccesoDatos.Models;
using Presentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Usuarios
{
    public partial class FrmUsuarios : Form
    {
        private bool isNuevo = false;
        private bool isEditar = false;
        private bool isContraseña = false;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        #region MÉTODOS INTERNOS
        private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxApellidos.Clear();
            textBoxTelefono.Clear();
            textBoxEmail.Clear();
            textBoxHorario.Clear();
            textBoxUsuario.Clear();
            textBoxContraseña.Clear();
            comboBoxRol.SelectedIndex = -1;
            textBoxBuscar.Clear();
        }

        private void HabilitarControles()
        {
            if (isNuevo)
            {
                textBoxNombre.Enabled = true;
                textBoxApellidos.Enabled = true;
                textBoxTelefono.Enabled = true;
                textBoxEmail.Enabled = true;
                textBoxHorario.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBoxContraseña.Enabled = true;
                comboBoxRol.Enabled = true;

                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
                buttonEliminar.Enabled = false;
                buttonActualizarUC.Enabled = false;
            }
            else if (isEditar)
            {
                textBoxNombre.Enabled = true;
                textBoxApellidos.Enabled = true;
                textBoxTelefono.Enabled = true;
                textBoxEmail.Enabled = true;
                textBoxHorario.Enabled = true;
                textBoxUsuario.Enabled = false;
                textBoxContraseña.Enabled = false;
                comboBoxRol.Enabled = true;

                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
                buttonEliminar.Enabled = false;
                buttonActualizarUC.Enabled = false;
            }
            else if (isContraseña)
            {
                textBoxNombre.Enabled = false;
                textBoxApellidos.Enabled = false;
                textBoxTelefono.Enabled = false;
                textBoxEmail.Enabled = false;
                textBoxHorario.Enabled = false;
                textBoxUsuario.Enabled = true;
                textBoxContraseña.Enabled = true;
                comboBoxRol.Enabled = false;

                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
                buttonEliminar.Enabled = false;
                buttonActualizarUC.Enabled = false;
            }
            else
            {
                textBoxNombre.Enabled = false;
                textBoxApellidos.Enabled = false;
                textBoxTelefono.Enabled = false;
                textBoxEmail.Enabled = false;
                textBoxHorario.Enabled = false;
                textBoxUsuario.Enabled = false;
                textBoxContraseña.Enabled = false;
                comboBoxRol.Enabled = false;

                buttonNuevo.Enabled = true;
                buttonGuardar.Enabled = false;
                buttonCancelar.Enabled = false;
                buttonEliminar.Enabled = true;
                buttonActualizarUC.Enabled = true;
            }
        }

        private void CargarDatos()
        {
            try
            {
                dataGridViewLista.DataSource = null;

                DTOUsuario usuario = new DTOUsuario(Program._cadenaConexion);
                var lista = usuario.ObtenerUsuarios().ToList();
                dataGridViewLista.DataSource = lista;

                if (dataGridViewLista.Columns["Contraseña"] != null || 
                    dataGridViewLista.Columns["Activo"] != null ||
                    dataGridViewLista.Columns["InfoUsuario"] != null) 
                {
                    dataGridViewLista.Columns["Contraseña"].Visible = false;
                    dataGridViewLista.Columns["Activo"].Visible = false;
                    dataGridViewLista.Columns["InfoUsuario"].Visible = false;
                }

                labelTotal.Text = $"Total de usuarios: {lista.Count}";
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Error al cargar los datos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BuscarDatos()
        {
            try
            {
                dataGridViewLista.DataSource = null;

                DTOUsuario usuario = new DTOUsuario(Program._cadenaConexion);
                var lista = usuario.BuscarUsuarios(textBoxBuscar.Text.Trim()).ToList();
                dataGridViewLista.DataSource = lista;

                if (dataGridViewLista.Columns["Contraseña"] != null || dataGridViewLista.Columns["Activo"] != null)
                {
                    dataGridViewLista.Columns["Contraseña"].Visible = false;
                    dataGridViewLista.Columns["Activo"].Visible = false;
                }

                labelTotal.Text = $"Total de usuarios: {lista.Count}";
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Error al cargar los datos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void GuardarDatos()
        {
            try
            {
                DTOUsuario usuario = new DTOUsuario(Program._cadenaConexion);
                MUsuario mu = new MUsuario();
                UHash hash = new UHash();

                if (isNuevo)
                {
                    mu.Nombre = textBoxNombre.Text;
                    mu.Apellidos = textBoxApellidos.Text;
                    mu.Telefono = textBoxTelefono.Text;
                    mu.Email = string.IsNullOrWhiteSpace(textBoxEmail.Text) ? null : textBoxEmail.Text.Trim();
                    mu.Horario = textBoxHorario.Text;
                    mu.Usuario = textBoxUsuario.Text;
                    mu.Contraseña = hash.GenerarHash(textBoxContraseña.Text);
                    mu.Rol = comboBoxRol.Text;

                    if (usuario.InsertarUsuario(mu))
                    {
                        MessageBox.Show(
                            "Datos guardados correctamente",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else if (isEditar)
                {
                    mu.Id = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);
                    mu.Nombre = textBoxNombre.Text;
                    mu.Apellidos = textBoxApellidos.Text;
                    mu.Telefono = textBoxTelefono.Text;
                    mu.Email = string.IsNullOrWhiteSpace(textBoxEmail.Text) ? null : textBoxEmail.Text.Trim();
                    mu.Horario = textBoxHorario.Text;
                    mu.Rol = comboBoxRol.Text;

                    if (usuario.ActualizarUsuario(mu))
                    {
                        MessageBox.Show(
                            "Datos actualizados correctamente",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else if (isContraseña)
                {
                    mu.Id = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);
                    mu.Usuario = textBoxUsuario.Text;
                    mu.Contraseña = hash.GenerarHash(textBoxContraseña.Text);

                    if (usuario.ActualizarCredenciales(mu))
                    {
                        MessageBox.Show(
                            "Credenciales actualizados correctamente",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show(
                    "Error al guardar los datos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void EliminarDatos()
        {
            try
            {
                if (dataGridViewLista.CurrentRow == null) return;

                DTOUsuario usuario = new DTOUsuario(Program._cadenaConexion);
                MUsuario mu = new MUsuario();
                int idSelecionado = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);

                DialogResult result = MessageBox.Show(
                    "¿Está seguro de dar de baja al usuario?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (usuario.BajaUsuario(idSelecionado))
                    {
                        MessageBox.Show(
                            "Usuario dado de baja correctamente",
                            "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }

                dataGridViewLista.ClearSelection();
            }
            catch
            {
                MessageBox.Show(
                    "Error al eliminar/baja al usuario",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        #endregion

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            isNuevo = true;
            isEditar = false;
            isContraseña = false;
            HabilitarControles();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            CargarDatos();
            dataGridViewLista.ClearSelection();

            isNuevo = false;
            isEditar = false;
            isContraseña = false;
            HabilitarControles();
            LimpiarCampos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            isNuevo = false;
            isEditar = false;
            isContraseña = false;
            HabilitarControles();
            LimpiarCampos();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
            CargarDatos();
        }

        private void buttonActualizarUC_Click(object sender, EventArgs e)
        {
            isNuevo = false;
            isEditar = false;
            isContraseña = true;
            HabilitarControles();
            LimpiarCampos();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            CargarDatos();
            HabilitarControles();
        }

        private void dataGridViewLista_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewLista.CurrentRow == null) return;

            isEditar = true;
            HabilitarControles();

            var datos = (MUsuario)dataGridViewLista.CurrentRow.DataBoundItem;

            textBoxNombre.Text = datos.Nombre;
            textBoxApellidos.Text = datos.Apellidos;
            textBoxTelefono.Text = datos.Telefono;
            textBoxEmail.Text = datos.Email ?? string.Empty;
            textBoxHorario.Text = datos.Horario;
            comboBoxRol.SelectedItem = datos.Rol;
        }
    }
}
