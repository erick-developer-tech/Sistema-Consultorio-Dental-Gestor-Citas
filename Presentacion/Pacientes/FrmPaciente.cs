using AccesoDatos.DTOs;
using AccesoDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Pacientes
{
    public partial class FrmPaciente : Form
    {
        private bool isNuevo = false;
        private bool isEditar = false;
        public FrmPaciente()
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
            textBoxAlergias.Clear();
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
                textBoxAlergias.Enabled = true;

                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
                buttonEliminar.Enabled = false;
            }
            else if (isEditar)
            {
                textBoxNombre.Enabled = true;
                textBoxApellidos.Enabled = true;
                textBoxTelefono.Enabled = true;
                textBoxEmail.Enabled = true;
                textBoxAlergias.Enabled = true;

                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
                buttonEliminar.Enabled = false;
            }
            else
            {
                textBoxNombre.Enabled = false;
                textBoxApellidos.Enabled = false;
                textBoxTelefono.Enabled = false;
                textBoxEmail.Enabled = false;
                textBoxAlergias.Enabled = false;

                buttonNuevo.Enabled = true;
                buttonGuardar.Enabled = false;
                buttonCancelar.Enabled = false;
                buttonEliminar.Enabled = true;
            }
        }

        private void CargarDatos()
        {
            try
            {
                dataGridViewLista.DataSource = null;

                DTOPaciente paciente = new DTOPaciente(Program._cadenaConexion);
                var lista = paciente.ObtenerPacientes().ToList();
                dataGridViewLista.DataSource = lista;

                if (dataGridViewLista.Columns["InfoPaciente"] != null) 
                {
                    dataGridViewLista.Columns["InfoPaciente"].Visible = false;
                }
                labelTotal.Text = $"Total de pacientes: {lista.Count}";
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

                DTOPaciente paciente = new DTOPaciente(Program._cadenaConexion);
                var lista = paciente.BuscarPacientes(textBoxBuscar.Text.Trim()).ToList();
                dataGridViewLista.DataSource = lista;

                labelTotal.Text = $"Total de pacientes: {lista.Count}";
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
                DTOPaciente paciente = new DTOPaciente(Program._cadenaConexion);
                MPaciente mp = new MPaciente();

                if (isNuevo)
                {
                    mp.Nombre = textBoxNombre.Text;
                    mp.Apellidos = textBoxApellidos.Text;
                    mp.Telefono = textBoxTelefono.Text;
                    mp.Email = string.IsNullOrEmpty(textBoxEmail.Text) ? null : textBoxEmail.Text;
                    mp.Alergias = string.IsNullOrEmpty(textBoxAlergias.Text) ? null : textBoxAlergias.Text;

                    if (paciente.InsertarPaciente(mp))
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
                    mp.Id = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);
                    mp.Nombre = textBoxNombre.Text;
                    mp.Apellidos = textBoxApellidos.Text;
                    mp.Telefono = textBoxTelefono.Text;
                    mp.Email = string.IsNullOrEmpty(textBoxEmail.Text) ? null : textBoxEmail.Text;
                    mp.Alergias = string.IsNullOrEmpty(textBoxAlergias.Text) ? null : textBoxAlergias.Text;

                    if (paciente.ActualizarPaciente(mp))
                    {
                        MessageBox.Show(
                            "Datos actualizados correctamente",
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

                DTOPaciente paciente = new DTOPaciente(Program._cadenaConexion);
                MPaciente mp = new MPaciente();
                int idSelecionado = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);

                DialogResult result = MessageBox.Show(
                    "¿Está seguro de eliminar el registro?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (paciente.EliminarPaciente(idSelecionado))
                    {
                        MessageBox.Show(
                            "Datos eliminados correctamente",
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
                    "Error al eliminar los datos",
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
            HabilitarControles();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            CargarDatos();
            dataGridViewLista.ClearSelection();

            isNuevo = false;
            isEditar = false;
            HabilitarControles();
            LimpiarCampos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            isNuevo = false;
            isEditar = false;
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

        private void FrmPaciente_Load(object sender, EventArgs e)
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

            var datos = (MPaciente)dataGridViewLista.CurrentRow.DataBoundItem;

            textBoxNombre.Text = datos.Nombre;
            textBoxApellidos.Text = datos.Apellidos;
            textBoxTelefono.Text = datos.Telefono;
            textBoxEmail.Text = datos.Email;
            textBoxAlergias.Text = datos.Alergias;
        }
    }
}
