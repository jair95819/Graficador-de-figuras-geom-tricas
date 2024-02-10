using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador_de_figuras_geométricas
{
    internal class Circulo
    {
        public int radio;

        public Circulo(int radio)
        {
            this.radio = radio;
        }

        public void GraficarCirculo(Graphics g, Color color)
        {
            Pen p = new Pen(color, 2);

            Rectangle circulo = new Rectangle(30, 5, radio, radio);
            g.DrawEllipse(p, circulo);
        }
    }
}
