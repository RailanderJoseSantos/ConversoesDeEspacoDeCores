using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConversorEspacoCores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_vermelho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//verifica se é qlq coisa diferente de nmrs
            {
                e.Handled = true;
            }
        }

        private void TextBox_verde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//verifica se é qlq coisa diferente de nmrs
            {
                e.Handled = true;
            }
        }

        private void TextBox_azul_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//verifica se é qlq coisa diferente de nmrs
            {
                e.Handled = true;
            }
        }

        private void TextBox_X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//verifica se é qlq coisa diferente de nmrs
            {
                e.Handled = true;
            }
        }

        private void TextBox_Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//verifica se é qlq coisa diferente de nmrs
            {
                e.Handled = true;
            }
        }

        private void TextBox_Z_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//verifica se é qlq coisa diferente de nmrs
            {
                e.Handled = true;
            }
        }
        private void Button_limpa_Click(object sender, EventArgs e)
        {
            LimpaExceto("");
        }

        private void Button_rgbParaTodos_Click(object sender, EventArgs e)
        {
            LimpaExceto("rgb");
            ConversorEntreEspacos converte = new ConversorEntreEspacos();
            String re = textBox_vermelho.Text;
            String gr = textBox_verde.Text;
            String bl = textBox_azul.Text;
            if ((re.Trim() != "") && (gr.Trim() != "") && (bl.Trim() != ""))
            {
                double r = Convert.ToDouble(re);
                double g = Convert.ToDouble(gr);
                double b = Convert.ToDouble(bl);
                converte.RgbParaXyz(r, g, b);
                converte.RgbParaCinzaMedia(r, g, b);
                converte.RgbParaCinzaCoeficiente(r, g, b);
                converte.RgbParaCmyk(r, g, b);
                converte.RgbParaHsv(r, g, b);

                textBox_X.Text = Convert.ToString(converte.GetX_yz());
                textBox_Y.Text = Convert.ToString(converte.GetY_xyz());
                textBox_Z.Text = Convert.ToString(converte.GetZ_xyz());

                txt_cinzaMedia.Text = Convert.ToString(converte.GetCinzaMed());

                txt_cinzaCoef.Text = Convert.ToString(converte.GetCizaCoe());

                textBox_C_CMYK.Text = Convert.ToString(converte.GetC() +" %");
                textBox_M_cmyk.Text = Convert.ToString(converte.GetM() +" %");
                textBox_Y_cmyk.Text = Convert.ToString(converte.GetY() +" %");
                textBox_K_cmyk.Text = Convert.ToString(converte.GetK() +" %");

                textBox_H_HSV.Text = Convert.ToString(converte.GetH()+" °");
                textBox_S_HSV.Text = Convert.ToString(converte.GetS() +" %");
                textBox_V_HSV.Text = Convert.ToString(converte.GetV() +" %");
            }
            else
            {
                MessageBox.Show("Preecha todos os campos de RGB", "RGB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TextBox_verde_MouseClick(object sender, MouseEventArgs e)
        {
            LimpaExceto("rgb");
        }

        private void TextBox_azul_MouseClick(object sender, MouseEventArgs e)
        {
            LimpaExceto("rgb");
        }

        private void TextBox_X_MouseClick(object sender, MouseEventArgs e)
        {
            LimpaExceto("xyz");
        }

        private void TextBox_Y_MouseClick(object sender, MouseEventArgs e)
        {
            LimpaExceto("xyz");
        }

        private void TextBox_Z_MouseClick(object sender, MouseEventArgs e)
        {
            LimpaExceto("xyz");
        }

        private void Button_xyzParaRgb_Click(object sender, EventArgs e)
        {
            ConversorEntreEspacos converte = new ConversorEntreEspacos();
            LimpaExceto("xyz");
            String xAux = textBox_X.Text;
            String yAux = textBox_Y.Text;
            String zAux = textBox_Z.Text;

            if ((xAux.Trim() != "") && (yAux.Trim() != "") && (zAux.Trim() != ""))
            {
                double x = Convert.ToDouble(xAux);
                double y = Convert.ToDouble(yAux);
                double z = Convert.ToDouble(zAux);
                converte.XyzParaRgb(x, y, z);

                textBox_vermelho.Text = Convert.ToString(converte.GetR());
                textBox_verde.Text = Convert.ToString(converte.GetG());
                textBox_azul.Text = Convert.ToString(converte.GetB());
            }
            else
            {
                MessageBox.Show("Preecha todos os campos de XYZ", "XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LimpaExceto(String valor)
        {
            if (valor == "xyz")
            {
                textBox_vermelho.Clear();
                textBox_verde.Clear();
                textBox_azul.Clear();
                textBox_H_HSV.Clear();
                textBox_S_HSV.Clear();
                textBox_V_HSV.Clear();
                textBox_C_CMYK.Clear();
                textBox_M_cmyk.Clear();
                textBox_Y_cmyk.Clear();
                textBox_K_cmyk.Clear();
                txt_cinzaCoef.Clear();
                txt_cinzaMedia.Clear();
            }
            else if (valor == "rgb")
            {
                textBox_X.Clear();
                textBox_Y.Clear();
                textBox_Z.Clear();
                textBox_H_HSV.Clear();
                textBox_S_HSV.Clear();
                textBox_V_HSV.Clear();
                textBox_C_CMYK.Clear();
                textBox_M_cmyk.Clear();
                textBox_Y_cmyk.Clear();
                textBox_K_cmyk.Clear();
                txt_cinzaCoef.Clear();
                txt_cinzaMedia.Clear();
            }
            else
            {
                textBox_vermelho.Clear();
                textBox_verde.Clear();
                textBox_azul.Clear();
                textBox_X.Clear();
                textBox_Y.Clear();
                textBox_Z.Clear();
                textBox_H_HSV.Clear();
                textBox_S_HSV.Clear();
                textBox_V_HSV.Clear();
                textBox_C_CMYK.Clear();
                textBox_M_cmyk.Clear();
                textBox_Y_cmyk.Clear();
                textBox_K_cmyk.Clear();
                txt_cinzaCoef.Clear();
                txt_cinzaMedia.Clear();
            }
        }

        private void TextBox_vermelho_MouseClick(object sender, MouseEventArgs e)
        {
            LimpaExceto("rgb");
        }


    }
}     


    


