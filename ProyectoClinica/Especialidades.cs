using ProyectoClinica.Business.Services;
using ProyectoClinica.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClinica
{
    public partial class Especialidades : Form
    {
        private readonly EspecialidadServices servicioEspecialidad = new EspecialidadServices();
        private int idSeleccionado = 0;
        public Especialidades()
        {
            InitializeComponent();
            CargarEspecialidades();
        }
        private void CargarEspecialidades()
        {
            dgvEspecialidad.DataSource = servicioEspecialidad.Listar();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string carrera = txtEspecialidad.Text.Trim();
            if (carrera == "")
            {
                MessageBox.Show("Ingrese el nombre de la especialidad.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Especialidad nueva = new Especialidad()
            {
                carrera = carrera
            };
            bool respuesta = servicioEspecialidad.Registrar(nueva);
            if (respuesta)
            {
                MessageBox.Show("Especialidad registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEspecialidad.Clear();
                CargarEspecialidades();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la especialidad.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidad.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una especialidad para eliminar.");
                return;
            }
            int id = Convert.ToInt32(dgvEspecialidad.SelectedRows[0].Cells["Id_Especialidad"].Value);

            if (servicioEspecialidad.EspecialidadEnUso(id))
            {
                MessageBox.Show("No se puede eliminar. La especialidad está asignada a uno o más doctores.");
                return;
            }
            if (servicioEspecialidad.Eliminar(id))
            {
                MessageBox.Show("Especialidad eliminada correctamente.");
                CargarEspecialidades();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la especialidad.");
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una especialidad para actualizar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string carreraNueva = txtEspecialidad.Text.Trim();

            if (carreraNueva == "")
            {
                MessageBox.Show("Ingrese el nombre de la especialidad.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Especialidad esp = new Especialidad()
            {
                Id_Especialidad = idSeleccionado,
                carrera = carreraNueva
            };

            try
            {
                bool actualizado = servicioEspecialidad.Actualizar(esp);

                if (actualizado)
                {
                    MessageBox.Show("Especialidad actualizada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtEspecialidad.Clear();
                    idSeleccionado = 0;
                    CargarEspecialidades();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la especialidad.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvEspecialidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(
                    dgvEspecialidad.Rows[e.RowIndex].Cells["Id_Especialidad"].Value
                );
                txtEspecialidad.Text =
                    dgvEspecialidad.Rows[e.RowIndex].Cells["carrera"].Value.ToString();
            }
        }
        private void dgvEspecialidad_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvEspecialidad.ClearSelection();
        }
    }
}
