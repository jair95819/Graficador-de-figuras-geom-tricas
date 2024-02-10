using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador_de_figuras_geométricas
{
    internal class Rectangulo
    {
        public int Base;
        public int Altura;

        public Rectangulo(int Base, int Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public void GraficarRectangulo(Graphics g, Color color)
        {
            Pen p = new Pen(color, 2);

            Rectangle rectangulo = new Rectangle(30, 5, Base, Altura);
            g.DrawRectangle(p, rectangulo);
        }
    }
}
