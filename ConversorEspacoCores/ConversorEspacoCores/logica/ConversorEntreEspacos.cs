using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConversorEspacoCores
{
    class ConversorEntreEspacos
    {
        Form1 janela = new Form1();
        private double r, g, b, h, s, v, c, m, y, k, cinzaCoe;
        private double x_xyz, y_xyz, z_xyz, cinzaMed;
        public void SetRGB(double red, double gre, double blu)
        {
            r = red;
            g = gre;
            b = blu;
        }
        public double GetR()
        {
            return r;
        }
        public double GetG()
        {
            return g;
        }
        public double GetB()
        {
            return b;
        }
        public void SetHSV(double hue, double sat, double val)
        {
            h = hue;
            s = sat;
            v = val;
        }
        public double GetH()
        {
            return h;
        }
        public double GetS()
        {
            return s;
        }
        public double GetV()
        {
            return v;
        }
        public void SetCMYK(double cy, double ma, double ye, double ke)
        {
            c = cy;
            m = ma;
            y = ye;
            k = ke;
        }
        public double GetC()
        {
            return c;
        }
        public double GetM()
        {
            return m;
        }
        public double GetY()
        {
            return y;
        }
        public double GetK()
        {
            return k;
        }
        public void SetXYZ(double xi, double ip, double ze)
        {
            x_xyz = xi;
            y_xyz = ip;
            z_xyz = ze;
        }
        public double GetX_yz()
        {
            return x_xyz;
        }
        public double GetY_xyz()
        {
            return y_xyz;
        }
        public double GetZ_xyz()
        {
            return z_xyz;
        }
        public void SetCinzaCoeficiente(double cc)
        {
            cinzaCoe = cc;
        }
        public double GetCizaCoe()
        {
            return cinzaCoe;
        }
        public void SetCinzaMedia(double cm)
        {
            cinzaMed = cm;
        }
        public double GetCinzaMed()
        {
            return cinzaMed;
        }

        public void RgbParaCinzaMedia(double r, double g, double b)
        {
            if ((r == 0) && (g == 0) && (b == 0))//se preto:
            {
                SetCinzaMedia(0);

            }
            else
            {
                double cinzaM = ((r + g + b) / 3);
                
                SetCinzaMedia(Math.Round(cinzaM, 2));
            }
        }
        public void RgbParaCinzaCoeficiente(double r, double g, double b)
        {

            if ((r == 0) && (g == 0) && (b == 0))//se preto:
            {
                SetCinzaCoeficiente(0);
            }
            else
            {
                double cinzaC = (0.2989 * r) + (0.5870 * g) + (0.1140 * b);
               
                SetCinzaCoeficiente(Math.Round(cinzaC, 2));
            }
        }
        public void XyzParaRgb(double x, double y, double z)
        {

            double lin0Col0, lin0Col1, lin0Col2;
            double lin1Col0, lin1Col1, lin1Col2;
            double lin2Col0, lin2Col1, lin2Col2;

            // valores pre-definidos (vetor da cor)
            lin0Col0 = 0.4868870; lin0Col1 = 0.3062984; lin0Col2 = 0.1710347;
            lin1Col0 = 0.1746583; lin1Col1 = 0.8247541; lin1Col2 = 0.0005877;
            lin2Col0 = -0.0012563; lin2Col1 = 0.0169832; lin2Col2 = 0.8094831;

            double r = ((lin0Col0 * x) + (lin0Col1 * y) + (lin0Col2 * z));
            double g = ((lin1Col0 * x) + (lin1Col1 * y) + (lin1Col2 * z));
            double b = ((lin2Col0 * x) + (lin2Col1 * y) + (lin2Col2 * z));

            SetRGB(Math.Round(r, 2), Math.Round(g, 2), Math.Round(b, 2));
        }
        public void RgbParaXyz(double r, double g, double b)
        {
            double lin0Col0, lin0Col1, lin0Col2;
            double lin1Col0, lin1Col1, lin1Col2;
            double lin2Col0, lin2Col1, lin2Col2;

            // valores pre-definidos (vetor da cor)
            lin0Col0 = 2.3646138; lin0Col1 = -0.8965405; lin0Col2 = -0.4680732;
            lin1Col0 = -0.5151662; lin1Col1 = 1.4264081; lin1Col2 = 0.0887581;
            lin2Col0 = 0.0052036; lin2Col1 = -0.0144081; lin2Col2 = 1.0092044;

            double x = ((lin0Col0 * r) + (lin0Col1 * g) + (lin0Col2 * b));
            double y = ((lin1Col0 * r) + (lin1Col1 * g) + (lin1Col2 * b));
            double z = ((lin2Col0 * r) + (lin2Col1 * g) + (lin2Col2 * b));
            SetXYZ(Math.Round(x, 2), Math.Round(y, 2), Math.Round(z, 2));
        }

        internal void RgbParaCmyk(double r, double g, double b)
        {
            r = r / 255;
            g = g / 255;
            b = b / 255;
            double k = 1 - Math.Max(r, Math.Max(g, b));
            double c = ((1 - r - k) / (1 - k));
            double m = ((1 - g - k) / (1 - k));
            double y = ((1 - b - k) / (1 - k));
            SetCMYK(Math.Round(c * 100, 2), Math.Round(m * 100, 2), Math.Round(y * 100, 2), Math.Round(k * 100, 2));
        }

        internal void RgbParaHsv(double r, double g, double b)
        {
            double delta, min;
            double h = 0, s, v;
            r = r / 255;
            g = g / 255;
            b = b / 255;

            min = Math.Min(Math.Min(r, g), b);
            v = Math.Max(Math.Max(r, g), b);
            delta = v - min;

            if (v != 0)
            {
                s = (delta / v);
            }
            else
            {
                s = 0;
            }
            if (v == r && g >= b)
            {
                if (r == g && g ==b)
                {
                    h = 0;
                }
                else
                {
                    h = 60 * (g - b) / delta + 0;
                }
            }            
            else if (v == r && g < b)
            {
                h = 60 * ((g - b) / delta) + 360;
            }
            else if (v == g)
            {
                h = 60 * ((b - r) / delta) + 120;
            }
            else if( v == b)
            {
                h = 60 * ((r - g) / delta) + 240;
            }

            SetHSV(Math.Round(h,2), Math.Round(s * 100, 2), Math.Round(v * 100, 2));
        }
    }
}
