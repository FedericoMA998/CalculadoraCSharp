using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        #region inicializar variables globales

        decimal numero1 = 0;
        decimal numero2 = 0;
        char signo = 'n';

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) /* txtVisualisar */
        {

        }

        #region Seccion de los numeros
        private void btnNum0_Click(object sender, EventArgs e)
        {
            try
            {
                txtVisualisar.Text = txtVisualisar.Text + "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            try
            {
                txtVisualisar.Text = txtVisualisar.Text + "1";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            try
            {
                txtVisualisar.Text = txtVisualisar.Text + "2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            try
            {
                txtVisualisar.Text = txtVisualisar.Text + "3";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            try
            {
                txtVisualisar.Text = txtVisualisar.Text + "4";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            try
            {
                txtVisualisar.Text = txtVisualisar.Text + "5";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            try
            {
                txtVisualisar.Text = txtVisualisar.Text + "6";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            try
            {
                txtVisualisar.Text = txtVisualisar.Text + "7";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            try
            {
                txtVisualisar.Text = txtVisualisar.Text + "8";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            try
            {
                txtVisualisar.Text = txtVisualisar.Text + "9";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
        #endregion


        #region Seccion de los operadores
        private void btnPunto_Click(object sender, EventArgs e)
        {
            try
            {
                txtVisualisar.Text = txtVisualisar.Text + ".";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = Convert.ToDecimal(txtVisualisar.Text);
                txtVisualisar.Text = "";
                signo = '-';
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = Convert.ToDecimal(txtVisualisar.Text);
                txtVisualisar.Text = "";
                signo = '+';
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = Convert.ToDecimal(txtVisualisar.Text);
                txtVisualisar.Text = "";
                signo = '*';
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = Convert.ToDecimal(txtVisualisar.Text);
                txtVisualisar.Text = "";
                signo = '/';
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
        #endregion


        #region Seccion botones especiales
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtVisualisar.Text = "";
                numero1 = 0;
                numero2 = 0;
                signo = 'n';
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                numero2 = Convert.ToDecimal(txtVisualisar.Text);
                decimal suma = 0;
                char caso = signo;
                switch(caso){
                    case '-':
                        suma = numero1 - numero2;
                        break;
                    case '+':
                        suma = numero1 + numero2;
                        break;
                    case '*':
                        suma = numero1 * numero2;
                        break;
                    case '/':
                        suma = numero1 / numero2;
                        break;
                }
                txtVisualisar.Text = Convert.ToString(suma);
            }
            catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            
            
        }
        #endregion

    }
}

