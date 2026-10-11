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

namespace Presentacion.Citas
{
    public partial class FrmCitas : Form
    {
        private bool isNuevo = false;
        private bool isEditar = false;
        public FrmCitas()
        {
            InitializeComponent();
        }

        #region MÉTODOS INTERNOS
        private void LimpiarCampos()
        {
            comboBoxUsuario.SelectedIndex = -1;
            comboBoxPaciente.SelectedIndex = -1;
            comboBoxServicio.SelectedIndex = -1;
            textBoxCosto.Clear();
            textBoxNotas.Clear();
            comboBoxEstado.SelectedIndex = -1;
        }

        private void HabilitarControles()
        {
            if (isNuevo)
            {
                comboBoxUsuario.Enabled = true;
                comboBoxPaciente.Enabled = true;
                comboBoxServicio.Enabled = true;
                dateTimePickerFechaHora.Enabled = true;
                comboBoxEstado.Enabled = false;
                textBoxNotas.Enabled = true;

                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
                buttonEliminar.Enabled = false;
            }
            else if (isEditar)
            {
                comboBoxUsuario.Enabled = true;
                comboBoxPaciente.Enabled = true;
                comboBoxServicio.Enabled = true;
                dateTimePickerFechaHora.Enabled = true;
                comboBoxEstado.Enabled = true;
                textBoxNotas.Enabled = true;

                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
                buttonEliminar.Enabled = false;
            }
            else
            {
                comboBoxUsuario.Enabled = false;
                comboBoxPaciente.Enabled = false;
                comboBoxServicio.Enabled = false;
                dateTimePickerFechaHora.Enabled = false;
                comboBoxEstado.Enabled = false;
                textBoxNotas.Enabled = false;

                buttonNuevo.Enabled = true;
                buttonGuardar.Enabled = false;
                buttonCancelar.Enabled = false;
                buttonEliminar.Enabled = true;
            }
        }

        private void CargarUsuariosCombo()
        {
            DTOUsuario usuario = new DTOUsuario(Program._cadenaConexion);

            var lista = usuario.ObtenerUsuarios().ToList();
            comboBoxUsuario.DataSource = lista;
            comboBoxUsuario.ValueMember = "Id";
            comboBoxUsuario.DisplayMember = "InfoUsuario";
            comboBoxUsuario.SelectedIndex = -1;
        }
        private void CargarPacientesCombo()
        {
            DTOPaciente paciente = new DTOPaciente(Program._cadenaConexion);

            var lista = paciente.ObtenerPacientes().ToList();
            comboBoxPaciente.DataSource = lista;
            comboBoxPaciente.ValueMember = "Id";
            comboBoxPaciente.DisplayMember = "InfoPaciente";
            comboBoxPaciente.SelectedIndex = -1;
        }
        private void CargarServiciosCombo()
        {
            DTOServicio servicio = new DTOServicio(Program._cadenaConexion);

            var lista = servicio.ObtenerServicios().ToList();
            comboBoxServicio.DataSource = lista;
            comboBoxServicio.ValueMember = "Id";
            comboBoxServicio.DisplayMember = "Servicio";
            comboBoxServicio.SelectedIndex = -1;
        }
        private void CargarDatos()
        {
            try
            {
                dataGridViewLista.DataSource = null;

                DTOCita cita = new DTOCita(Program._cadenaConexion);
                var lista = cita.ObtenerCitas().ToList();
                dataGridViewLista.DataSource = lista;

                if (dataGridViewLista.Columns["IdUsuario"] != null ||
                    dataGridViewLista.Columns["IdPaciente"] != null ||
                    dataGridViewLista.Columns["IdServicio"] != null ||
                    dataGridViewLista.Columns["InfoCita"] != null)
                {
                    dataGridViewLista.Columns["IdUsuario"].Visible = false;
                    dataGridViewLista.Columns["IdPaciente"].Visible = false;
                    dataGridViewLista.Columns["IdServicio"].Visible = false;
                    dataGridViewLista.Columns["InfoCita"].Visible = false;
                }

                labelTotal.Text = $"Total de citas: {lista.Count}";
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

                DTOCita cita = new DTOCita(Program._cadenaConexion);
                DateTime fechaInicio = dateTimePickerFechaInicio.Value;
                DateTime fechaFin = dateTimePickerFechaFin.Value;

                var lista = cita.BuscarCitas(fechaInicio, fechaFin).ToList();
                dataGridViewLista.DataSource = lista;

                if (dataGridViewLista.Columns["IdUsuario"] != null ||
                    dataGridViewLista.Columns["IdPaciente"] != null ||
                    dataGridViewLista.Columns["IdServicio"] != null ||
                    dataGridViewLista.Columns["InfoCita"] != null)
                {
                    dataGridViewLista.Columns["IdUsuario"].Visible = false;
                    dataGridViewLista.Columns["IdPaciente"].Visible = false;
                    dataGridViewLista.Columns["IdServicio"].Visible = false;
                    dataGridViewLista.Columns["InfoCita"].Visible = false;
                }

                labelTotal.Text = $"Total de citas: {lista.Count}";
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
                DTOCita cita = new DTOCita(Program._cadenaConexion);
                MCita mc = new MCita();

                if (isNuevo)
                {
                    mc.IdUsuario = Convert.ToInt32(comboBoxUsuario.SelectedValue);
                    mc.IdPaciente = Convert.ToInt32(comboBoxPaciente.SelectedValue);
                    mc.IdServicio = Convert.ToInt32(comboBoxServicio.SelectedValue);
                    mc.FechaHora = dateTimePickerFechaHora.Value;
                    mc.Notas = string.IsNullOrEmpty(textBoxNotas.Text) ? null : textBoxNotas.Text;

                    if (cita.InsertarCita(mc))
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
                    mc.Id = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);
                    mc.IdUsuario = Convert.ToInt32(comboBoxUsuario.SelectedValue);
                    mc.IdPaciente = Convert.ToInt32(comboBoxPaciente.SelectedValue);
                    mc.IdServicio = Convert.ToInt32(comboBoxServicio.SelectedValue);
                    mc.FechaHora = dateTimePickerFechaHora.Value;
                    mc.Estado = comboBoxEstado.Text;
                    mc.Notas = string.IsNullOrEmpty(textBoxNotas.Text) ? null : textBoxNotas.Text;

                    if (cita.ActualizarCita(mc))
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

                DTOCita cita = new DTOCita(Program._cadenaConexion);

                int idSelecionado = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);

                DialogResult result = MessageBox.Show(
                    "¿Está seguro de eliminar el registro?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (cita.EliminarCita(idSelecionado))
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

        private void MarcarPagado() 
        {
            try
            {
                if (dataGridViewLista.CurrentRow == null) return;

                DTOCita cita = new DTOCita(Program._cadenaConexion);
                int idSelecionado = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);

                DialogResult dialog = MessageBox.Show(
                    $"¿Estas seguro de marcar como pagado este registro \nId: {idSelecionado}?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    if (cita.PagarCita(idSelecionado))
                    {
                        MessageBox.Show(
                                "Cita pagada con éxito.",
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
                    "Error al actualizar la cita seleccionada.",
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

        private void buttonPagado_Click(object sender, EventArgs e)
        {
            MarcarPagado();
            CargarDatos();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
            CargarDatos();
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            CargarDatos();
            CargarUsuariosCombo();
            CargarPacientesCombo();
            CargarServiciosCombo();
            HabilitarControles();
        }

        private void dataGridViewLista_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewLista.CurrentRow == null) return;

            isEditar = true;
            HabilitarControles();

            var datos = (MCita)dataGridViewLista.CurrentRow.DataBoundItem;

            comboBoxUsuario.SelectedValue = datos.IdUsuario;
            comboBoxPaciente.SelectedValue = datos.IdPaciente;
            comboBoxServicio.SelectedValue = datos.IdServicio;
            dateTimePickerFechaHora.Value = datos.FechaHora;
            comboBoxEstado.Text = datos.Estado;
            textBoxNotas.Text = datos.Notas;
        }

        private void comboBoxServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxServicio.SelectedIndex != -1 && comboBoxServicio.SelectedItem is MServicio servicioSeleccionado)
            {
                textBoxCosto.Text = servicioSeleccionado.Costo.ToString("N2");
            }
            else
            {
                textBoxCosto.Clear();
            }
        }
    }
}
