using ProyectoClinica.Business.Services;
using ProyectoClinica.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClinica
{
    public partial class FormDoctores : Form
    {
        
        private DoctoresServices servicio = new DoctoresServices();
        private EspecialidadServices especialidadService = new EspecialidadServices();
        public FormDoctores()
        {
            InitializeComponent();
            CargarEspecialidades();
            CargarDoctores();
        }
        private void FormDoctores_Load(object sender, EventArgs e)
        {
        }
        private void CargarDoctores()
        {
            List<Doctores> listaDoctores = servicio.ObtenerDoctores();
            dgvDoctores.DataSource = listaDoctores;
        }
        private void CargarEspecialidades()
        {
            var lista = especialidadService.Listar();

            if (lista.Count == 0)
            {
                MessageBox.Show("No hay especialidades registradas en la base de datos.");
                return;
            }
            cboEspecialidad.DataSource = lista;
            cboEspecialidad.DisplayMember = "carrera";
            cboEspecialidad.ValueMember = "Id_Especialidad";
            cboEspecialidad.SelectedIndex = -1;
            
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            cboEspecialidad.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Especialidad esp = cboEspecialidad.SelectedItem as Especialidad;
            if (esp == null)
            {
                MessageBox.Show("Debe seleccionar una especialidad");
                return;
            }
            try
            {
                Doctores doc = new Doctores
                {
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    dni = txtDni.Text,
                    telefono = txtTelefono.Text,
                    correo = txtCorreo.Text,
                    Especialidad = new Especialidad
                    {
                        Id_Especialidad = esp.Id_Especialidad
                    }
                };
                bool ok = servicio.Agregar(doc);
                if (ok)
                {
                    MessageBox.Show("Doctor agregado correctamente");
                    LimpiarFormulario();
                    CargarDoctores();
                }
                else
                {
                    MessageBox.Show("Error al agregar el doctor");
                }
            }
                catch (Exception ex)
                {
                    // MUY IMPORTANTE: aquí caen las validaciones del Service
                    MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        
        private void dgvDoctores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDoctores.Rows[e.RowIndex];
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtApellido.Text = fila.Cells["apellido"].Value.ToString();
                txtDni.Text = fila.Cells["dni"].Value.ToString();
                txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
                txtCorreo.Text = fila.Cells["correo"].Value.ToString();
                cboEspecialidad.Text = fila.Cells["NombreEspecialidad"].Value.ToString();
            }
        }
        private void mostrarDoc_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDoctores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un doctor de la lista.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Obtener el ID del doctor seleccionado
            int idDoctor = Convert.ToInt32(dgvDoctores.CurrentRow.Cells["Id_doctor"].Value);
            // Confirmación
            var respuesta = MessageBox.Show("¿Está seguro que desea eliminar este doctor?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
                return;
            // Intentar eliminar
            bool eliminado = servicio.Eliminar(idDoctor);

            if (eliminado)
            {
                MessageBox.Show("Doctor eliminado correctamente.");
                CargarDoctores();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el doctor.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvDoctores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un doctor para actualizar.");
                return;
            }
            try
            {
                DataGridViewRow fila = dgvDoctores.SelectedRows[0];
                int idDoctor = Convert.ToInt32(fila.Cells["Id_doctor"].Value);

                Doctores doc = new Doctores
                {
                    Id_doctor = idDoctor,
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    dni = txtDni.Text,
                    telefono = txtTelefono.Text,
                    correo = txtCorreo.Text,
                    Especialidad = new Especialidad
                    {
                        Id_Especialidad = Convert.ToInt32(cboEspecialidad.SelectedValue)
                    }
                };
                bool actualizado = servicio.Actualizar(doc);
                if (actualizado)
                {
                    MessageBox.Show("Doctor actualizado correctamente.");
                    CargarDoctores();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar.");
                }
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        
        private void txtBuscarDni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita el sonido "beep"
                string dni = txtBuscarDni.Text.Trim();

                if (dni == "")
                {
                    MessageBox.Show("Ingrese un DNI para buscar.");
                    return;
                }

                Doctores doctor = servicio.BuscarPorDni(dni);
                if (doctor == null)
                {
                    MessageBox.Show("No se encontró un doctor con ese DNI.");
                    return;
                }
                txtNombre.Text = doctor.nombre;
                txtApellido.Text = doctor.apellido;
                txtDni.Text = doctor.dni;
                txtTelefono.Text = doctor.telefono;
                txtCorreo.Text = doctor.correo;
                cboEspecialidad.SelectedValue = doctor.Especialidad.Id_Especialidad;
                dgvDoctores.DataSource = new List<Doctores> { doctor };
            }
        }

        private void dgvDoctores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDoctores.ClearSelection();
        }
    }
}
