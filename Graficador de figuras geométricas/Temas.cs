using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficador_de_figuras_geométricas
{
    internal class Temas //Aún falta mejorar!!
    {
        public static Color Labels;
        public static Color Buttons;
        public static Color Txtbx_Cambios;
        public static Color MenustripGeneral;
        public static Color Fondo;

        public void ElegirTema(string tema)
        {
            if(tema == "Default")
            {
                Default();
            }
            else if(tema == "Claro")
            {
                Claro();
            }
            else if(tema == "Oscuro")
            {
                Oscuro();
            }
        }

        public static void Default()
        {
            Labels = Color.FromArgb(255, 255, 255);
            Buttons = Color.FromArgb(171, 158, 234);
            MenustripGeneral = Color.FromArgb(133, 128, 158);
            Txtbx_Cambios = Color.FromArgb(102, 95, 133);
            Fondo = Color.FromArgb(84, 79, 103);
        }

        public static void Claro()
        {
            Labels = Control.DefaultForeColor;
            Buttons = Control.DefaultBackColor;
            MenustripGeneral = Control.DefaultBackColor;
            Txtbx_Cambios = Control.DefaultBackColor;
            Fondo = Control.DefaultBackColor;
        }

        public static void Oscuro()
        {

        }
    }
}
