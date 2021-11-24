using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Practica5
{
    public partial class Form1 : Form
    {
        Thread hiloSecundario;
        private delegate void delegado(string estilo, string tama);
        private delegate void dato();
        public Form1()
        {
          
            InitializeComponent();
            hiloSecundario = new Thread(new ThreadStart(initDel));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hiloSecundario.Start();
        }
        string almc_lineas = " ",almc_caracteres = " ";
        int almc;
        private void initDel()
        {
            while (true)
            {
                init_dato();
                Hilo_status_strip(almc_lineas, almc_caracteres);
                Thread.Sleep(1);
            }
        }
        private void init_dato()
        {
            if (textoPantalla.InvokeRequired)
            {
                dato instan_dele = new dato(init_dato);
                textoPantalla.Invoke(instan_dele);
            }
            else
            {
                almc_lineas = textoPantalla.Lines.Length.ToString();
                almc_caracteres = textoPantalla.TextLength.ToString();
            }
        }
        private void Hilo_status_strip(string rows,string chars)
        {
            try
            {
                if (statusStrip1.InvokeRequired)
                {
                    delegado instan_dele = new delegado(Hilo_status_strip);
                    statusStrip1.Invoke(instan_dele, new object[] { rows, chars });
                }
                else{
                    Caracteres.Text = "Caracteres: " + chars;

                    Filas.Text = "Filas: " + rows; 
                }
            }catch (Exception)
            {
                hiloSecundario.Abort();
            }
        }
        private void WideLatin_Click(object sender, EventArgs e)
        {
            almc = Convert.ToInt32(tamFont.SelectedItem);
            tipoLetra.Text = WideLatin.Text;
            cambioFuente(WideLatin.Text, almc);
        }

        private void Arial_Click(object sender, EventArgs e)
        {
            almc = Convert.ToInt32(tamFont.SelectedItem);
            tipoLetra.Text = Arial.Text;
            cambioFuente(Arial.Text, almc);
        }

        private void textoPantalla_TextChanged(object sender, EventArgs e)
        {
            Caracteres.Text = "Caracteres: "+Convert.ToString(textoPantalla.Text.Length);
            
            Filas.Text ="Filas: "+(textoPantalla.GetLineFromCharIndex(textoPantalla.TextLength)+1).ToString();
        }
   
        private void tamFont_SelectedIndexChanged(object sender, EventArgs e)
        { 
            almc = Convert.ToInt32(tamFont.SelectedItem);
            cambioFuente(tipoLetra.Text, almc);
            
        }

        private void cambioFuente(string estilo, int tamanyo)
        {
            Font fuente = new Font(estilo, tamanyo);
            textoPantalla.SelectionFont = fuente;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            hiloSecundario.Abort();
            Application.Exit();
        }

        
        
    }
}
