﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun.Cache;
using DATOS.Conexion;
using DOMINIO.Models;
using PRESENTACION.Proyecto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PRESENTACION
{
    public partial class FormProyectos : Form
    {
        public FormProyectos()
        {
            InitializeComponent();
            btn_icon_hover.AplicarFormaRedonda(btn_agregar);
            btn_icon_hover.AplicarFormaRedonda(btn_editar);
            btn_icon_hover.AplicarFormaRedonda(btn_eliminar);
        }
        private void FormProyectos_Load(object sender, EventArgs e)
        {
            CargarProyectos();
        }
        public void CargarProyectos()
        {
            Proyectos cargar = new Proyectos();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = cargar.GetProyectos();
        }

        private void AbrirFormulario<MiForm>(MiForm form) where MiForm : Form, new()
        {
            Form formulario;
            formulario = Application.OpenForms.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = form; // Utiliza la instancia del formulario como argumento
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.ShowDialog(); // Mostrar el formulario de manera modal
            }
            else
            {
                formulario.BringToFront();
            }
        }
        public void CargarEstadoProyecto(Frm_NuevoProyecto form)
        {
            Proyectos cargar = new Proyectos();

            // Configura el ComboBox en el formulario pasado como argumento
            form.cmbEstadoProyecto.DataSource = cargar.GetProyectosEstado();
            form.cmbEstadoProyecto.DisplayMember = "Estado";
            form.cmbEstadoProyecto.ValueMember = "EstadoProyectoid";
        }

        #region botones
        private void btn_editar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var form = new Frm_NuevoProyecto(); // Crear una instancia del formulario FrmNuevoProyecto
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                DataRow selectedRow = dataTable.Rows[dataGridView1.SelectedRows[0].Index];
                form.OperacionTipo = "Editar";
                form.LblEquipoProyecto.Visible = true;
                form.btnEquipoProyecto.Visible = true;
                int idProyecto = (int)selectedRow["IdProyecto"];

                // Configura los campos en el formulario
                form.IdProyecto.Text = idProyecto.ToString();
                form.txtNombreProyecto.Text = selectedRow["NombreProyecto"].ToString();
                form.txtDescripcionProyecto.Text = selectedRow["Descripcion"].ToString();
                form.dateTimePickerInicio.Value = DateTime.Parse(selectedRow["FechaInicio"].ToString());
                form.dateTimePickerEntrega.Value = DateTime.Parse(selectedRow["FechaFin"].ToString());

                // Llamar al método CargarEstadoProyecto pasando el formulario como argumento
                CargarEstadoProyecto(form);
                // Establece la propiedad FormProyectos
                form.FormProyectos = this;
                // Llamar al método AbrirFormulario con el formulario FrmNuevoProyecto
                AbrirFormulario<Frm_NuevoProyecto>(form);
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila");
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var form = new Frm_NuevoProyecto();
            form.OperacionTipo = "Insertar";

            form.FormProyectos = this; // Establece la propiedad FormProyectos

            AbrirFormulario<Frm_NuevoProyecto>(form);
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Preguntar al usuario si está seguro de eliminar el proyecto
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este Proyecto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Continuar con la eliminación si el proyecto confirma
                    Proyectos cargar = new Proyectos();
                    cargar.EliminarProyecto(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdProyecto"].Value.ToString()));
                    MessageBox.Show("Proyecto Eliminado Correctamente");
                    CargarProyectos();
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila para poder Eliminar un Proyecto");
            }
        }
        #endregion

        #region btn_hover
        private void btn_agregar_MouseEnter(object sender, EventArgs e)
        {
            btn_icon_hover.CambiarColorHover(sender, e);
        }

        private void btn_agregar_MouseLeave(object sender, EventArgs e)
        {
            btn_icon_hover.RestaurarColorOriginal(sender, e);
        }

        private void btn_editar_MouseEnter(object sender, EventArgs e)
        {
            btn_icon_hover.CambiarColorHover(sender, e);
        }

        private void btn_editar_MouseLeave(object sender, EventArgs e)
        {
            btn_icon_hover.RestaurarColorOriginal(sender, e);
        }

        private void btn_eliminar_MouseEnter(object sender, EventArgs e)
        {
            btn_icon_hover.CambiarColorHover(sender, e);
        }

        private void btn_eliminar_MouseLeave(object sender, EventArgs e)
        {
            btn_icon_hover.RestaurarColorOriginal(sender, e);
        }
        #endregion
    }
}

