using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWF
{
    public partial class Form2 : Form
    {
        private List<string> operaciones = new List<string>();
        private int indiceActual = 0;
        private string nombreArchivo = "Historial.dat";

        public Form2()
        {
            InitializeComponent();
            CargarHistorial();
            ConfigurarEventos();
        }

        public Form2(string nombreArchivo)
        {
            InitializeComponent();
            this.nombreArchivo = nombreArchivo;
            CargarHistorial();
            ConfigurarEventos();
        }

        private void CargarHistorial()
        {
            operaciones = Archivo.ObtenerOperaciones(nombreArchivo);
            indiceActual = 0;

            if (operaciones.Count > 0)
            {
                MostrarOperacion();
            }
            else
            {
                lbl_Mostrar.Text = "Sin historial";
            }
        }

        private void ConfigurarEventos()
        {
            bt_anterior.Click += Bt_anterior_Click;
            bt_siguiente.Click += Bt_siguiente_Click;
        }

        private void Bt_anterior_Click(object? sender, EventArgs e)
        {
            if (operaciones.Count == 0) return;

            indiceActual--;
            if (indiceActual < 0)
                indiceActual = operaciones.Count - 1;

            MostrarOperacion();
        }

        private void Bt_siguiente_Click(object? sender, EventArgs e)
        {
            if (operaciones.Count == 0) return;

            indiceActual++;
            if (indiceActual >= operaciones.Count)
                indiceActual = 0;

            MostrarOperacion();
        }

        private void MostrarOperacion()
        {
            lbl_Mostrar.Text = $"{indiceActual + 1}/{operaciones.Count} - {operaciones[indiceActual]}";
        }
    }
}
