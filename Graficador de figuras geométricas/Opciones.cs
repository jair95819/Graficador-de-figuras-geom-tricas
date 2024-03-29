﻿using System;
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
        string[] colores_grafico = { "Yellow", "Blue", "Red", "Green", "Orange" }; 
        string color_grafico;
        int c;

        public Opciones(Color color_actual)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            foreach(var c in colores_grafico)
            {
                cmbx_Colores.Items.Add(c);
            }
            cmbx_Colores.SelectedItem = colores_grafico.First(color => color == color_actual.Name);
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(c == 0)
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
            try
            {
                color_grafico = cmbx_Colores.SelectedItem.ToString();

                if (color_grafico != string.Empty)
                {
                    MessageBox.Show("Cambio guardado.");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            c++;
        }
    }
}
