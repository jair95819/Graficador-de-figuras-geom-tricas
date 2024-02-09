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
    public partial class Inicio : Form
    {
        string color_grafico;

        public Inicio()
        {
            InitializeComponent();
            rdbtn_empty.Checked = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        public Inicio(string color)
        {
            InitializeComponent();
            color_grafico = color;
            rdbtn_empty.Checked = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void rdbtn_Circulo_CheckedChanged(object sender, EventArgs e)
        {
            lbl_base_radio_lado.Text = "Radio:";
            revision(lbl_base_radio_lado.Text);
        }

        private void rdbtn_Cuadrado_CheckedChanged(object sender, EventArgs e)
        {
            lbl_base_radio_lado.Text = "Lado:";
            revision(lbl_base_radio_lado.Text);
        }

        private void rdbtn_Rectangulo_CheckedChanged(object sender, EventArgs e)
        {
            lbl_base_radio_lado.Text = "Base:";
            revision(lbl_base_radio_lado.Text);
        }

        private void rdbtn_Triangulo_CheckedChanged(object sender, EventArgs e)
        {
            lbl_base_radio_lado.Text = "Base:";
            revision(lbl_base_radio_lado.Text);
        }

        private void rdbtn_empty_CheckedChanged(object sender, EventArgs e)
        {
            lbl_base_radio_lado.Text = "Base-Radio-Lado:";
            revision(lbl_base_radio_lado.Text);
        }

        public void revision(string text)
        {
            if (text == "Radio:" || text == "Lado:")
            {
                lbl_none.Visible = false;
                lbl_none.Dock = DockStyle.None;
                pctbx_visualizer.Size = new Size(200, 200);

                txtbx_base_radio_ladoX.ReadOnly = false;
                txtbx_alturaY.ReadOnly = true;
            }
            else if (text == "Base:")
            {
                lbl_none.Visible = false;
                lbl_none.Dock = DockStyle.None;
                pctbx_visualizer.Size = new Size(250, 200);

                txtbx_base_radio_ladoX.ReadOnly = false;
                txtbx_alturaY.ReadOnly = false;
            }
            else
            {
                lbl_none.Visible = true;
                lbl_none.Dock = DockStyle.Fill;
                pctbx_visualizer.Size = new Size(250, 200);
            }
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opciones ventana_nueva = new Opciones();
            ventana_nueva.Show();
            this.Hide();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
