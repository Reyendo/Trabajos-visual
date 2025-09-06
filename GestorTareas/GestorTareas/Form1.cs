using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorTareas
{
    
    public partial class Form1 : Form
    {
        List<Tarea> listaTareas = new List<Tarea>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ActualizarGrid(List<Tarea> lista)
        {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = listaTareas;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Tarea nueva = new Tarea()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = lblDescripcion.Text,
                Fecha = dtpFecha.Value,
                Lugar = txtLugar.Text,
                Estado = cmbEstado.SelectedItem.ToString()
            };

            listaTareas.Add(nueva);
            ActualizarGrid(listaTareas);
            MessageBox.Show("Tarea agregada correctamente.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Tarea nueva = new Tarea()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Fecha = dtpFecha.Value,
                Lugar = txtLugar.Text,
                Estado = cmbEstado.SelectedItem.ToString()
            };

            listaTareas.Add(nueva);
            ActualizarGrid(listaTareas);
            MessageBox.Show("Tarea agregada correctamente.");

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtLugar.Text = "";
            cmbEstado.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas[index].Codigo = txtCodigo.Text;
                listaTareas[index].Nombre = txtNombre.Text;
                listaTareas[index].Descripcion = txtDescripcion.Text;
                listaTareas[index].Fecha = dtpFecha.Value;
                listaTareas[index].Lugar = txtLugar.Text;
                listaTareas[index].Estado = cmbEstado.SelectedItem.ToString();

                ActualizarGrid(listaTareas);
                MessageBox.Show("Tarea editada correctamente.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas.RemoveAt(index);
                ActualizarGrid(listaTareas);
                MessageBox.Show("Tarea eliminada correctamente.");
            }
        }
        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvTareas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvTareas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvTareas.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpFecha.Value = (DateTime)dgvTareas.Rows[e.RowIndex].Cells[3].Value;
                txtLugar.Text = dgvTareas.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbEstado.SelectedItem = dgvTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        private void Cargar()
        {
            ActualizarGrid(listaTareas);
        }

        private void btnBCod_Click(object sender, EventArgs e)
        {
            string codigo = txtBuscarCodigo.Text.Trim();
            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Ingrese un codigo para buscar");
                Cargar();
                return;
            }
            var resul = listaTareas.Where(t => t.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase)).ToList();
            if (resul.Any())
            {
                ActualizarGrid(resul);
                MessageBox.Show($"Se encontro {resul.Count} tareas con el codigo: '{codigo}'.");

            }
            else 
            {
                ActualizarGrid(new List<Tarea>());
                MessageBox.Show("No se encontraron tareas con ese codigo.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (cmbBuscar.SelectedItem==null)
            {
                MessageBox.Show("Ingrese un estado para buscar");
                Cargar();
                return;
            }
            string lel = cmbBuscar.SelectedItem.ToString();
            var resul = listaTareas.Where(t => t.Estado.Equals(lel, StringComparison.OrdinalIgnoreCase)).ToList();
            if (resul.Any())
            {
                ActualizarGrid(resul);
                MessageBox.Show($"Se encontraron {resul.Count} tareas con el estado: '{lel}'.");

            }
            else
            {
                ActualizarGrid(new List<Tarea>());
                MessageBox.Show("No se encontraron tareas en ese estado.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fi= dateTimePicker1.Value;
            DateTime ff = dateTimePicker2.Value;
            if (fi > ff)
            {
                MessageBox.Show("La fecha final no puede pasar despues de la fecha de inicio");
                Cargar();
                return;
            }
            var resul = listaTareas.Where(t => t.Fecha.Date >= fi && t.Fecha.Date <= ff).ToList();
            if (resul.Any())
            {
                ActualizarGrid(resul);
                MessageBox.Show($"Se encontraron {resul.Count} tareas en el rango de fechas seleccionado.");

            }
            else
            {
                ActualizarGrid(new List<Tarea>());
                MessageBox.Show("No se encontraron tareas en ese rango.");
            }
        }
    }
    public class Tarea
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public string Estado { get; set; }
    }

}
