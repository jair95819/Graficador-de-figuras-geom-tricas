using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Graficador_de_figuras_geométricas
{
    internal class Triangulo
    {
        public int Base;
        public int Altura;

        public Triangulo(int Base, int Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public void GraficarTriangulo(Graphics g, Color color)
        {
            Pen p = new Pen(color, 2);

            g.DrawLine(p, 50, 150, Base, 150); //Base triangulo
            g.DrawLine(p, 50, 150, 90, Altura); //Arista Izquierda
            g.DrawLine(p, 90, Altura, Base, 150); //Arista Derecha
        }
    }
}
