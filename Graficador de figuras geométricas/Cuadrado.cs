using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador_de_figuras_geométricas
{
    public class Cuadrado
    {
        public int lado;

        public Cuadrado(int lado)
        {
            this.lado = lado;
        }

        public void GraficarCuadrado(Graphics g, Color color)
        {
            Pen p = new Pen(color, 2);

            Rectangle cuadrado = new Rectangle(30, 5, lado, lado);
            g.DrawRectangle(p, cuadrado);
        }
    }
}
