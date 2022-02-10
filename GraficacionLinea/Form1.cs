using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficacionLinea
{
    public partial class Form1 : Form
    {
        Bitmap area_dibujar = new Bitmap(360, 360);
        double xa, xb, ya, yb, m, y, x, pointx, pointy;
        Color color0 = Color.Green;

        public Form1()
        {
            InitializeComponent();
            TrazarPlano(area_dibujar);
        }

        private void Btn_Trazar_Click(object sender, EventArgs e)
        {
            //operaciones basicas para tener las coordenadas y la pendiente
            xa = Convert.ToDouble(Txt_Xa.Text);
            ya = Convert.ToDouble(Txt_Ya.Text);
            xb = Convert.ToDouble(Txt_Xb.Text);
            yb = Convert.ToDouble(Txt_Yb.Text);
            m = (yb - ya) / (xb - xa);
            //llamamos la funcion para llenar la tabla de los datos
            LlenarTabla(Dgv_Coordenadas, xa, ya, xb, yb, m);
            //mostrar en pantalla el valor de la pendiente
            Txt_Pendiente.Text = Convert.ToString(m);
            //Llamamos la funcion que dibuja la linea
            DibujarLinea(Pb_Mapa, area_dibujar, xa, ya, xb, yb, m);
        }

        public void TrazarPlano(Bitmap mapa)
        {
            //creamos el color del plano
            Color color1 = Color.Red;
            //indicamos los puntos iniciales
            int X = 0, Y = 0;

            //hacemos un for que va ir desde el punto 0 del plano
            //hasta el 360 que es el ancho de nuestro plano
            for (int i = 0; i < 360; i++)
            {
                //dentro del plano dibujamos una la linea que ira sobre la altura 180 que es
                //el tamaño medio en la altura
                mapa.SetPixel(X, 180, color1);
                //x toma el valor de i que se itera
                X = i;
                //dibujamos una linea dentro del plano que ira a la mitad del ancho de nuestro plano
                mapa.SetPixel(180, Y, color1);
                //y toma el valor que itera
                Y = i;

            }
            //dibujamos en el picture box los trazoz echos en el bitmap
            Pb_Mapa.Image = mapa;
        }

        public void LlenarTabla(DataGridView Dgv_Tabla, double xa, double ya, double xb, double yb, double m)
        {
            //hacemos un for que nos ayudara a iterar desde el punto inical
            //hasta el punto final para saber que puntos debe tocar la linea
            for (double i = xa; i <= xb; i++)
            {
                //dentro del datagridview vamos colocando los valores que se optiene de la operacion
                Dgv_Tabla.Rows.Add(Convert.ToString(xa), Convert.ToString(ya));
                //actualizamos valores en cada iteracion
                xa++;
                ya = ya + m;
            }
        }

        public void DibujarLinea(PictureBox Pb_mapa, Bitmap Bm_mapa, double xa, double ya, double xb, double yb, double m)
        {
            //definimos las coordenadas iniciales equivalentes a 0,0 en nuestro plano
            pointx = 180;
            pointy = 180;

            //comparamos si es el primer caso de la linea
            if(xa < xb || ya < yb)
            {
                //declaramos puntos iniciales y finales para las coordenadas
                double inix = 0, iniy = 0, finx = 0, finy = 0;
                bool band = false;
                //damos las nuevas coordenadas de los puntos introducidos más la posicion inicial
                inix = pointx + xa;
                //if para comparar si estamos hablando de un valor positivo en y para poder colocar
                //correctamente la operacion y pueda moverse de forma correcta en el plano
                if(ya > 0 || ya < 180)
                {
                    iniy = pointy - ya;
                }
                finx = pointx + xb;
                if (ya > 0 || ya < 180)
                {
                    finy = pointy - yb;
                }

                //for para comenzar a dibujar los pixeles de la linea,
                //comenzando desde nuestro nuevo punto inicial
                for(double i = inix; i <= finx; i++)
                {
                    //usamos setpixel para enviar la posicion en la que deseamos
                    //colocar cada uno de los pixeles y el color
                    Bm_mapa.SetPixel(Convert.ToInt32(i), Convert.ToInt32(iniy), color0);
                    //actualizamos la coordenada y con la pendiente
                    iniy = iniy - m;
                }
                //dibujamos en el picturebox los trazos echos en el bitmap
                Pb_mapa.Image = Bm_mapa;
                //colocamos que direccion tendra nuestra linea
                Lbl_Indicacion.Text = "Linea de Izquierda a Derecha y de Abajo para Arriba";
            }
        }

    }
}
