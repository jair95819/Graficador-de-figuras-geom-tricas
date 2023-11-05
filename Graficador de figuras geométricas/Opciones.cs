using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficador_de_figuras_geométricas
{
    public partial class Opciones : Form
    {
        string[] temas = new string[] { "Claro", "Oscuro", "Default" };
        string color_grafico;

        public Opciones()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            foreach (string t in temas)
            {
                cmbbx_temas.Items.Add(t);
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(color_grafico == string.Empty)
            {
                Inicio ventana_nueva = new Inicio();
                ventana_nueva.Show();
                this.Close();
            }
            else
            {
                Inicio ventana_nueva_cambiada = new Inicio(color_grafico);
                ventana_nueva_cambiada.Show();
                this.Close();
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if(txtbx_colorGrafico.Text.Length < 0 && cmbbx_temas.Text.Length < 0)
            {
                MessageBox.Show("No hubo ningún cambio!");
            }
            else if(txtbx_colorGrafico.Text.Length > 0)
            {
                color_grafico = txtbx_colorGrafico.Text;
                MessageBox.Show("Has cambiado el color predeterminado del gráficador!");
            }
        }
    }
}
