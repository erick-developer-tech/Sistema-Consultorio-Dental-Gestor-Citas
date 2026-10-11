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

namespace Presentacion.Recetas
{
    public partial class FrmRecetas : Form
    {
        private bool isNuevo = false;
        private bool isEditar = false;
        public FrmRecetas()
        {
            InitializeComponent();
        }

        #region MÉTODOS INTERNOS
        private void LimpiarCampos()
        {
            comboBoxCita.SelectedIndex = -1;
            textBoxDiagnostico.Clear();
            textBoxTratamiento.Clear();
            textBoxBuscar.Clear();
        }

        private void HabilitarControles()
        {
            if (isNuevo)
            {
                comboBoxCita.Enabled = true;
                textBoxDiagnostico.Enabled = true;
                textBoxTratamiento.Enabled = true;

                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
                buttonEliminar.Enabled = false;
            }
            else if (isEditar)
            {
                comboBoxCita.Enabled = true;
                textBoxDiagnostico.Enabled = true;
                textBoxTratamiento.Enabled = true;

                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
                buttonEliminar.Enabled = false;
            }
            else
            {
                comboBoxCita.Enabled = false;
                textBoxDiagnostico.Enabled = false;
                textBoxTratamiento.Enabled = false;

                buttonNuevo.Enabled = true;
                buttonGuardar.Enabled = false;
                buttonCancelar.Enabled = false;
                buttonEliminar.Enabled = true;
            }
        }

        private void CargarCitasCombo() 
        {
            DTOCita dto = new DTOCita(Program._cadenaConexion);
            var lista = dto.ObtenerCitas().ToList();

            comboBoxCita.DataSource = lista;
            comboBoxCita.DisplayMember = "InfoCita";
            comboBoxCita.ValueMember = "Id";
            comboBoxCita.SelectedIndex = -1;
        }
        private void CargarDatos()
        {
            try
            {
                dataGridViewLista.DataSource = null;

                DTOReceta receta = new DTOReceta(Program._cadenaConexion);
                var lista = receta.ObtenerRecetas().ToList();
                dataGridViewLista.DataSource = lista;

                labelTotal.Text = $"Total de recetas: {lista.Count}";
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

                DTOReceta receta = new DTOReceta(Program._cadenaConexion);
                var lista = receta.BuscarRecetas(textBoxBuscar.Text.Trim()).ToList();
                dataGridViewLista.DataSource = lista;

                labelTotal.Text = $"Total de recetas: {lista.Count}";
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
                DTOReceta receta = new DTOReceta(Program._cadenaConexion);
                MReceta mr = new MReceta();

                if (isNuevo)
                {
                    mr.IdCita = Convert.ToInt32(comboBoxCita.SelectedValue);
                    mr.Diagnostico = textBoxDiagnostico.Text;
                    mr.Tratamiento = textBoxTratamiento.Text;

                    if (receta.InsertarReceta(mr))
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
                    mr.Id = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);
                    mr.IdCita = Convert.ToInt32(comboBoxCita.SelectedValue);
                    mr.Diagnostico = textBoxDiagnostico.Text;
                    mr.Tratamiento = textBoxTratamiento.Text;

                    if (receta.ActualizarReceta(mr))
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

                DTOReceta receta = new DTOReceta(Program._cadenaConexion);
                MReceta mr = new MReceta();
                int idSelecionado = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);

                DialogResult result = MessageBox.Show(
                    "¿Está seguro de eliminar el registro?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (receta.EliminarReceta(idSelecionado))
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

        private void FrmRecetas_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            CargarDatos();
            CargarCitasCombo();
            HabilitarControles();
        }

        private void dataGridViewLista_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewLista.CurrentRow == null) return;

            isEditar = true;
            HabilitarControles();

            var datos = (MReceta)dataGridViewLista.CurrentRow.DataBoundItem;

            comboBoxCita.SelectedValue = datos.IdCita;
            textBoxDiagnostico.Text = datos.Diagnostico;
            textBoxTratamiento.Text = datos.Tratamiento;
        }
    }
}
