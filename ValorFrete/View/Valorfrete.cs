using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valorfrete.View
{
    public partial class Valorfrete : Form
    {
        public Valorfrete()
        {
            InitializeComponent();
        }

        private void Valorfrete_Load(object sender, EventArgs e)
        {
            comboBoxuf.SelectedIndex = 0;
        }

        private void Calcularfrete()
        {
            decimal valor = 0;



            decimal frete = 0;

            valor = Convert.ToDecimal(textBoxval.Text);

            switch(comboBoxuf.Text.ToUpper())
            {
     
                case "AM":    
                frete = 0.6m;
                break;

                case "MG":
                    frete = 0.35m;
                        break;

                case "RJ":
                    frete = 0.30m;
                    break;

                case "SP":
                    frete = 0.20m;
                    break;
                default:
                    frete = 0.70m;
                    break;



            }
            textBoxfrete.Text = frete.ToString("P0");
            
        }

        private void LimparTela()
        {
            textBoxcli.Text = string.Empty;
            textBoxval.Text = string.Empty;
            comboBoxuf.SelectedIndex = 1;
            textBoxfrete.Text = string.Empty;
            lblfrete.Text = string.Empty;

        }

        private void btn_Click(object sender, EventArgs e)


        {
            decimal valor = 0;
            decimal valorcomfrete = 0;

            if (textBoxval.Text == "")
            {
                MessageBox.Show("Insira os valores");
            }
            else
            {
                valor = Convert.ToDecimal(textBoxfrete.Text);
                valorcomfrete = Convert.ToDecimal(textBoxval.Text);

                richTextBox1.Text = (valor * (valorcomfrete + 1)).ToString();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxuf_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calcularfrete();
        }

        private void lblfrete_Click(object sender, EventArgs e)
        {

        }

        private void textBoxfrete_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
