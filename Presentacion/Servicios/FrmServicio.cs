using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.DTOs;
using AccesoDatos.Models;
using Microsoft.IdentityModel.Protocols.Configuration;

namespace Presentacion.Servicios
{
    public partial class FrmServicio : Form
    {
        private bool isNuevo = false;
        private bool isEditar = false;

        public FrmServicio()
        {
            InitializeComponent();
        }

        #region MÉTODOS INTERNOS
        private void LimpiarCampos()
        {
            textBoxServicio.Clear();
            textBoxCosto.Clear();
            textBoxBuscar.Clear();
        }

        private void HabilitarControles()
        {
            if (isNuevo)
            {
                textBoxServicio.Enabled = true;
                textBoxCosto.Enabled = true;

                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
                buttonEliminar.Enabled = false;
            }
            else if (isEditar)
            {
                textBoxServicio.Enabled = true;
                textBoxCosto.Enabled = true;

                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
                buttonEliminar.Enabled = false;
            }
            else
            {
                textBoxServicio.Enabled = false;
                textBoxCosto.Enabled = false;

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

                DTOServicio servicio = new DTOServicio(Program._cadenaConexion);
                var lista = servicio.ObtenerServicios().ToList();
                dataGridViewLista.DataSource = lista;

                labelTotal.Text = $"Total de registros: {lista.Count}";
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

                DTOServicio servicio = new DTOServicio(Program._cadenaConexion);
                var lista = servicio.BuscarServicios(textBoxBuscar.Text).ToList();
                dataGridViewLista.DataSource = lista;

                labelTotal.Text = $"Total de registros: {lista.Count}";
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
                DTOServicio servicio = new DTOServicio(Program._cadenaConexion);
                MServicio ms = new MServicio();

                if (isNuevo)
                {
                    ms.Servicio = textBoxServicio.Text;
                    ms.Costo = decimal.Parse(textBoxCosto.Text);

                    if (servicio.InsertarServicio(ms)) 
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
                    ms.Id = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);
                    ms.Servicio = textBoxServicio.Text;
                    ms.Costo = decimal.Parse(textBoxCosto.Text);
                    if (servicio.ActualizarServicio(ms)) 
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

                DTOServicio servicio = new DTOServicio(Program._cadenaConexion);
                MServicio ms = new MServicio();
                int idSelecionado = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);

                DialogResult result = MessageBox.Show(
                    "¿Está seguro de eliminar el registro?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (servicio.EliminarServicio(idSelecionado))
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

        private void FrmServicio_Load(object sender, EventArgs e)
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

            var datos = (MServicio)dataGridViewLista.CurrentRow.DataBoundItem;

            textBoxServicio.Text = datos.Servicio;
            textBoxCosto.Text = datos.Costo.ToString();
        }
    }
}
