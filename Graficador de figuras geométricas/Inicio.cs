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
        Color color_grafico;        

        public Inicio()
        {
            InitializeComponent();
            rdbtn_empty.Checked = true;
            color_grafico = Color.Green;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        public Inicio(string color)
        {
            InitializeComponent();
            color_grafico = Color.FromName(color); //Color.FromName ayuda a convertir un string a Drawing.Color.
            rdbtn_empty.Checked = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void rdbtn_Circulo_CheckedChanged(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(lbl_base_radio_lado, "Solo puedes ingresar valores desde 0 hasta 195");
            lbl_base_radio_lado.Text = "Radio:";
            revision(lbl_base_radio_lado.Text);
        }

        private void rdbtn_Cuadrado_CheckedChanged(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(lbl_base_radio_lado, "Solo puedes ingresar valores desde 0 hasta 195");
            lbl_base_radio_lado.Text = "Lado:";
            revision(lbl_base_radio_lado.Text);
        }

        private void rdbtn_Rectangulo_CheckedChanged(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(lbl_base_radio_lado, "Solo puedes ingresar valores desde 0 hasta 220");
            this.toolTip2.SetToolTip(lbl_altura, "Solo puedes ingresar valores desde 0 hasta 193");
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
            Graphics g = picbx_visualizer.CreateGraphics();
            g.Clear(Color.LightGray);

            lbl_base_radio_lado.Text = "Base-Radio-Lado:";
            revision(lbl_base_radio_lado.Text);
        }

        public void revision(string text)
        {
            if (text == "Radio:" || text == "Lado:")
            {
                lbl_none.Visible = false;
                lbl_none.Dock = DockStyle.None;

                txtbx_base_radio_ladoX.ReadOnly = false;
                txtbx_alturaY.ReadOnly = true;
            }
            else if (text == "Base:")
            {
                lbl_none.Visible = false;
                lbl_none.Dock = DockStyle.None;

                txtbx_base_radio_ladoX.ReadOnly = false;
                txtbx_alturaY.ReadOnly = false;
            }
            else
            {
                lbl_none.Visible = true;
                lbl_none.Dock = DockStyle.Fill;
            }
        }

        private void btn_Graficar_Click(object sender, EventArgs e)
        {
            switch (lbl_base_radio_lado.Text)
            {
                case "Lado:":
                    DeleteEverySinglePainting();
                    picbx_visualizer.Paint += Picbx_visualizer_Paint_Cuadrado;
                    picbx_visualizer.Invalidate();
                    break;

                case "Base:":
                    if (rdbtn_Rectangulo.Checked)
                    {
                        DeleteEverySinglePainting();
                        picbx_visualizer.Paint += Picbx_visualizer_Paint_Rectangulo;
                        picbx_visualizer.Invalidate();
                    }
                    else
                    {
                        DeleteEverySinglePainting();
                        picbx_visualizer.Paint += Picbx_visualizer_Paint_Triangulo;
                        picbx_visualizer.Invalidate();
                    }
                    break;

                case "Radio:":
                    DeleteEverySinglePainting();
                    picbx_visualizer.Paint += Picbx_visualizer_Paint_Circulo;
                    picbx_visualizer.Invalidate();
                    break;

                default:
                    DeleteEverySinglePainting();
                    break;
            }
        }

        private void DeleteEverySinglePainting()
        {
            picbx_visualizer.Paint -= Picbx_visualizer_Paint_Cuadrado;
            picbx_visualizer.Paint -= Picbx_visualizer_Paint_Circulo;
            picbx_visualizer.Paint -= Picbx_visualizer_Paint_Rectangulo;
            picbx_visualizer.Paint -= Picbx_visualizer_Paint_Triangulo;

            picbx_visualizer.Invalidate();
        }

        private void Picbx_visualizer_Paint_Circulo(object sender, PaintEventArgs e)
        {
            int radio = Convert.ToInt32(txtbx_base_radio_ladoX.Text);

            if(radio <= 195)
            {
                Circulo nuevo = new Circulo(radio);
                nuevo.GraficarCirculo(e.Graphics, color_grafico);
            }
        }

        private void Picbx_visualizer_Paint_Triangulo(object sender, PaintEventArgs e)
        {
            int baseT = Convert.ToInt32(txtbx_base_radio_ladoX.Text);
            int alturaT = Convert.ToInt32(txtbx_alturaY.Text);

            Graphics g = e.Graphics;
            Pen p = new Pen(color_grafico, 2);


            g.DrawLine(p, 150, alturaT, 10, baseT); //FALTA CORREGIR
        }

        private void Picbx_visualizer_Paint_Rectangulo(object sender, PaintEventArgs e)
        {
            int largo = Convert.ToInt32(txtbx_base_radio_ladoX.Text);
            int alto = Convert.ToInt32(txtbx_alturaY.Text);

            if (largo <= 220 && alto <= 193)
            {
                Rectangulo nuevo = new Rectangulo(largo, alto);
                nuevo.GraficarRectangulo(e.Graphics, color_grafico);
            }
        }

        private void Picbx_visualizer_Paint_Cuadrado(object sender, PaintEventArgs e)
        {
            int lado = Convert.ToInt32(txtbx_base_radio_ladoX.Text);

            if(lado <= 195)
            {
                Cuadrado nuevo = new Cuadrado(lado);
                nuevo.GraficarCuadrado(e.Graphics, color_grafico);
            }
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult diag = MessageBox.Show("Se perderán todos los dibujos, ¿desea continuar?", "Aviso", buttons);
            if(diag == DialogResult.Yes)
            {
                Opciones ventana_nueva = new Opciones();
                ventana_nueva.Show();
                this.Hide();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
