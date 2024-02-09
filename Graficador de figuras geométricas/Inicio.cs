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
        string medidaX;

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
                    
                    picbx_visualizer.Paint += Picbx_visualizer_Paint_Cuadrado;
                    picbx_visualizer.Invalidate();
                    break;

                case "Base:":
                    if (rdbtn_Rectangulo.Checked)
                    {

                    }
                    else
                    {

                    }
                    break;

                case "Radio:":

                    break;

                default:

                    break;
            }
                
        }

        private void Picbx_visualizer_Paint_Cuadrado(object sender, PaintEventArgs e)
        {
            int lado = Convert.ToInt32(txtbx_base_radio_ladoX.Text);
            MessageBoxButtons botones = MessageBoxButtons.YesNo;

            if(lado >= 195)
            {
                DialogResult diag = MessageBox.Show("EL cuadrado podría salir de los márgenes del marco, ¿Desea continuar?", "Aviso", botones);
                if (diag.Equals(DialogResult.Yes)) //CORREGIR PROBLEMA MESSAGE BOX
                {
                    Graphics g = e.Graphics;
                    Pen p = new Pen(color_grafico, 2);

                    Rectangle cuadrado = new Rectangle(30, 5, lado, lado);
                    g.DrawRectangle(p, cuadrado);
                }
                
            } else
            {
                Graphics g = e.Graphics;
                Pen p = new Pen(color_grafico, 2);

                Rectangle cuadrado = new Rectangle(30, 5, lado, lado);
                g.DrawRectangle(p, cuadrado);
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
