using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();

        }
        Font fuente;
        int almc;
        private void WideLatin_Click(object sender, EventArgs e)
        {
            almc = Convert.ToInt32(tamFont.SelectedItem);
            fuente = new Font("Dubai",almc );
            tipoLetra.Text = WideLatin.Text;
            textoPantalla.Font = fuente;
        }

        private void Arial_Click(object sender, EventArgs e)
        {
            fuente = new Font("Arial",almc);
            tipoLetra.Text = Arial.Text;
            textoPantalla.Font = fuente;
        }

        private void textoPantalla_TextChanged(object sender, EventArgs e)
        {
            Caracteres.Text = "Caracteres: "+Convert.ToString(textoPantalla.Text.Length);
            
            Filas.Text ="Filas: "+(textoPantalla.GetLineFromCharIndex(textoPantalla.TextLength)+1).ToString();
        }

        private void tamFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string letra;
            almc = Convert.ToInt32(tamFont.SelectedItem);
            letra = tipoLetra.Text;
            fuente = new Font(letra, almc);
            textoPantalla.Font = fuente;
        }

   
    }
}
