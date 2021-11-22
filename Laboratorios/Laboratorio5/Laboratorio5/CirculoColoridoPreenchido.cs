using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Laboratorio5
{
    public class CirculoColoridoPreenchido : CirculoColorido
    {
        private Color corAdicional;

        public CirculoColoridoPreenchido()
        {
             corAdicional = Color.FromArgb(210,102,103);

        }

        public Color Cor2
        {
            get { return corAdicional; }
            set { corAdicional = value; }
        }

        public CirculoColoridoPreenchido(double x, double y, double r, string c, Color d) : base(x, y, r,c)
        {
            corAdicional = d;
        }

        public override string ToString()
        {
            return base.ToString() + " cor=" + corAdicional;
        }

    }
}
