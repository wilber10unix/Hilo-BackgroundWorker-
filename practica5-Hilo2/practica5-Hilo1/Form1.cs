using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica5_Hilo1
{
    public partial class Form1 : Form
    {
        //
        //Objeto para el acceso a los controles desde un hilo secundario
        MethodInvoker delegado;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Poner controles por defecto
            Controles_default();

            // delegado del = new delegado();
            
            /* Inicia el hilo secundario encapsulado por el objeto BackgroundWorker */

            hiloTrabajador.RunWorkerAsync();
        }


        private void Controles_default()
        {
            tstamañoletra.SelectedIndex = 2;
            ncaracteres.Text = "0";
            nfilas.Text = "0";
            Wide();
        }
        private void wideeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wide();
        }

        private void Wide()
        {
            int tam = int.Parse(tstamañoletra.SelectedItem.ToString());
            if (text.SelectionFont != null)
            {
                System.Drawing.Font currentFont = text.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (text.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }

                text.SelectionFont = new Font(
                   "wide latin",
                   tam,
                   newFontStyle
                );
                tsdtipoletra.Text = "Wide Lite";
            }
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // text.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            Arial();
        }

        private void Arial()
        {
            int tam = int.Parse(tstamañoletra.SelectedItem.ToString());
            if (text.SelectionFont != null)
            {
                System.Drawing.Font currentFont = text.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (text.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }

                text.SelectionFont = new Font(
                   "Arial",
                   tam,
                   newFontStyle
                );
                tsdtipoletra.Text = "Arial";
            }
        }

        private void Validaciones_tamaño_de_letra()
        {
            if (tstamañoletra.SelectedIndex == 0 )
            {
                if (tsdtipoletra.Text == "Wide Latin")
                {
                    Wide();
                }
                if ( tsdtipoletra.Text == "Arial")
                {
                    Arial();
                }
            }
            
            if (tstamañoletra.SelectedIndex == 1)
            {

                if (tsdtipoletra.Text == "Wide Latin")
                {
                    Wide();
                }
                if (tsdtipoletra.Text == "Arial")
                {
                    Arial();
                }
            }
            if (tstamañoletra.SelectedIndex == 2)
            {
                if (tsdtipoletra.Text == "Wide Latin")
                {
                    Wide();
                }
                if (tsdtipoletra.Text == "Arial")
                {
                    Arial();
                }
            }
            if (tstamañoletra.SelectedIndex == 3)
            {
                if (tsdtipoletra.Text == "Wide Latin")
                {
                    Wide();
                }
                if (tsdtipoletra.Text == "Arial")
                {
                    Arial();
                }
            }
            if (tstamañoletra.SelectedIndex == 4)
            {
                if (tsdtipoletra.Text == "Wide Latin")
                {
                    Wide();
                }
                if (tsdtipoletra.Text == "Arial")
                {
                    Arial();
                }
            }
            if (tstamañoletra.SelectedIndex == 5)
            {
                if (tsdtipoletra.Text == "Wide Latin")
                {
                    Wide();
                }
                if (tsdtipoletra.Text == "Arial")
                {
                    Arial();
                }
            }
            if (tstamañoletra.SelectedIndex == 6)
            {
                if (tsdtipoletra.Text == "Wide Latin")
                {
                    Wide();
                }
                if (tsdtipoletra.Text == "Arial")
                {
                    Arial();
                }
            }
            if (tstamañoletra.SelectedIndex == 7)
            {
                if (tsdtipoletra.Text == "Wide Latin")
                {
                    Wide();
                }
                if (tsdtipoletra.Text == "Arial")
                {
                    Arial();
                }
            }
            if (tstamañoletra.SelectedIndex == 8)
            {
                if (tsdtipoletra.Text == "Wide Latin")
                {
                Wide();
                 }
                 if (tsdtipoletra.Text == "Arial")
                 {
                      Arial();
                 }
            }
            if (tstamañoletra.SelectedIndex == 9)
            {
                if (tsdtipoletra.Text == "Wide Latin")
                {
                Wide();
                 }
                 if (tsdtipoletra.Text == "Arial")
                 {
                      Arial();
                 }
            }
            if (tstamañoletra.SelectedIndex == 10)
            {
                if (tsdtipoletra.Text == "Wide Latin")
                {
                Wide();
                
                 }
                 if (tsdtipoletra.Text == "Arial")
                 {
                      Arial();
                 }
            }
            if (tstamañoletra.SelectedIndex == 11)
            {
                if (tsdtipoletra.Text == "Wide Latin")
                {
                Wide();
                 }
                 if (tsdtipoletra.Text == "Arial")
                 {
                      Arial();
                 }
            }
        }

        private void tstamañoletra_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validaciones_tamaño_de_letra();
        }

        ///////////////////////////////////////////////
        ///
        /* Metodo que se ejecuta al llamar al método RunWorkerAsync del objeto BackgroundWorker */
        

        /// 

        /// 
        ///
        private void TareaSecundaria(BackgroundWorker hiloTr, DoWorkEventArgs e)
        {
            int hecho = 0, tpHecho = 0;
            while (true)
            {
               // tpHecho = text.Text.Length;
                 hecho += 1;
                // tpHecho = (int)(hecho / numCargaUCP.Value * 100);
                // if (text.Text==null)
                //{
                
                    Thread.Sleep(100);
                    /* Llamada al método ReportProgress del BackgroundWorker lo que genera el evento ProgressChanged */
                    hiloTr.ReportProgress(tpHecho);
                //}
                /*Se consulta si se ha solicitado la cancelación de la tarea por parte del hilo principal*/
                if (hiloTr.CancellationPending)
                {
                    /* Aunque no es necesaria colocar Cancel a true para que la cancelación ocurra esto permite diferenciar desde el
                    * método RunWorkerCompleted cual fue la razón de la terminación del hilo */
                    e.Cancel = true;
                    break;
                }
            }




        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /** Indicamos que deseamos cancelar la ejecución del hilo secundario **/
            hiloTrabajador.CancelAsync();
        }




        /// <summary>
        /// evento Text change 
        /// </summary>
        /// 
        private void text_TextChanged(object sender, EventArgs e)
        {
         //   TareaSecundaria();
        }

        private void hiloTrabajador_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //ncaracteres.Text = Convert.ToString(e.);
            ncaracteres.Text = Convert.ToString(text.Text.Length);
            nfilas.Text = Convert.ToString(text.Lines.Count());

        }

        private void hiloTrabajador_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            /* Consulta si se produjo un error */
            if (e.Error != null)
                MessageBox.Show(e.Error.Message);
            /* Consulta si la terminación se llevo a cabo porque la operación fue cancelada */
            else if (e.Cancelled)
                MessageBox.Show("Operación cancelada");
            /* Si no es un error o una cancelación, la tarea termino correctamente */
            else
            {
                MessageBox.Show("Fin");
                //btCalcular.Enabled = true;
                //numCargaUCP.Enabled = true;
            }

        }

        private void hiloTrabajador_DoWork(object sender, DoWorkEventArgs e)
        {
            /* Aunque podriamos colocar aqui el código q tenemos en Tarea secundaria, no lo hacemos
            * por si tenemos varios BackgroundWorker que tengan asociado el mismo método al llamar a
            * RunWorkerAsync. De esta manera al obtener primero la referencia podríamos por ejemplo
            * diferenciar entre los diferentes BackgroundWorker antes de ejecutar el código correspondiente
            * */
            BackgroundWorker hiloTr = (BackgroundWorker)sender;

            /* En nuestro caso esta comparación esta demás por que solo tenemos un BackgroundWorker pero
            * se deja para ejemplificar como se llevaría a cabo la comprobación */
            if (hiloTr == hiloTrabajador)
                TareaSecundaria(hiloTr, e);
        }
    }
}
