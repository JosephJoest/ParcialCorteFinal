using ParcialCorteFinal.Entidad;
using ParcialCorteFinal.Negocio.Servicio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ParcialCorteFinal.Presentacion.Formularios
{
    public partial class FromVentas : Form
    {
        SedeServicio sedeServicio = new SedeServicio();
        VentaServicio ventaServicio = new VentaServicio(); 

        public FromVentas()
        {
            InitializeComponent();
        }

        private void ListarSedes()
        {
            try
            {
                List<Sede> sedes = sedeServicio.ListarSedes();
                comboBoxSedes.DataSource = sedes;
                comboBoxSedes.DisplayMember = "Nombre";
                comboBoxSedes.ValueMember = "Codigo"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string AbrirArchivo()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Seleccionar archivo";
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog1.FileName;
                return rutaArchivo;
            }

            return string.Empty;
        }

        private void FromVentas_Load(object sender, EventArgs e)
        {
            ListarSedes();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string rutaArchivo = AbrirArchivo();
            if (!string.IsNullOrEmpty(rutaArchivo))
            {
                string codigoSedeSeleccionada = comboBoxSedes.SelectedValue.ToString();
                List<Venta> ventas = ventaServicio.ObtenerVentasPorSede(rutaArchivo, codigoSedeSeleccionada);

                tabla.DataSource = ventas; 
            }
        }
    }
}
