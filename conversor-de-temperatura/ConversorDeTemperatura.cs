using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class ConversorDeTemperatura : Form
    {
        public ConversorDeTemperatura()
        {
            InitializeComponent();
        }

        private void radInputCelsius_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radInputFahrenheit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int key = 0;
            double decimalNumber = 0.0;
            try
            {
                decimalNumber = Convert.ToDouble(txtValue.Text.Replace(",","."));
            }
            catch (Exception exception)
            {
                key = -1;
                exception.GetBaseException();
            }


            if(key == -1)
            {
                MessageBox.Show("Número não identificado!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radInputCelsius.Checked)
                {
                    if (radOutputFahrenheit.Checked)
                    {
                        txtResult.Text = Convert.ToString(((decimalNumber * 9/5) + 32) + " °F");

                    }else if (radOutputKelvin.Checked)
                    {
                        txtResult.Text = Convert.ToString((decimalNumber + 273.15) + " K");

                    }
                    else
                    {
                        txtResult.Text = Convert.ToString(decimalNumber + " °C");
                    }

                }else if (radInputFahrenheit.Checked)
                {
                    if (radOutputCelsius.Checked)
                    {
                        txtResult.Text = Convert.ToString(((decimalNumber - 32) * 5/9) + " °C");

                    }else if (radOutputKelvin.Checked)
                    {
                        txtResult.Text = Convert.ToString(((decimalNumber - 32) * 5/9 + 273.15) + " K");

                    }
                    else
                    {
                        txtResult.Text = Convert.ToString(decimalNumber + " °F");
                    }

                }else if (radInputKelvin.Checked)
                {
                    if (radOutputCelsius.Checked)
                    {
                        txtResult.Text = Convert.ToString((decimalNumber - 273.15) + " °C");

                    }else if (radOutputFahrenheit.Checked)
                    {
                        txtResult.Text = Convert.ToString(((decimalNumber - 273.15) * 9/5 + 32) + " °F");

                    }
                    else
                    {
                        txtResult.Text = Convert.ToString(decimalNumber + " K");
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Clear();
            txtResult.Clear();

            radInputCelsius.Checked = true;
            radOutputCelsius.Checked = true;
        }
    }
}
