using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Polar A, B, C;
        double XMax, XMin, YMax, YMin;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            draw();
        }

       

        Graphics gr;
       
        float ToScreenX(double val)
        {
            var WScale = panel1.Width / (Math.Abs(XMin) + (Math.Abs(XMax)));
            return (float) (WScale * (val + Math.Abs(XMin)));
        }
        float ToScreenY(double val)
        {
            var HScale = panel1.Height / (Math.Abs(YMax - YMin));
            return (float) (HScale * (YMax - val));
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            gr = panel1.CreateGraphics();
            gr.Clear(Color.White);
            A = new Polar(Aradius.Value, Aangle.Value);
            B = new Polar(Bradius.Value, Bangle.Value);
            C = new Polar(Cradius.Value, Cangle.Value);
            label1.Text = A.area_triangle(B, C).ToString();
            if (checkBox1.Checked)
            {
                draw();
            }
        }
        
        void draw()
        {
            //Рисование
            double[] matrX = { A.GetX(), B.GetX(), C.GetX() };
            double[] matrY = { A.GetY(), B.GetY(), C.GetY() };

            XMax = matrX.Max();
            XMin = matrX.Min();
            YMax = matrY.Max();
            YMin = matrY.Min();

            try
            {
                Pen p = new Pen(Color.Blue, 5);// цвет линии и ширина
                gr.DrawLine(p, ToScreenX(0), ToScreenY(0), ToScreenX(4), ToScreenY(0));
                p.Color = Color.Black;
                gr.DrawLine(p, ToScreenX(A.GetX()), ToScreenY(A.GetY()), ToScreenX(B.GetX()), ToScreenY(B.GetY()));
                gr.DrawLine(p, ToScreenX(A.GetX()), ToScreenY(A.GetY()), ToScreenX(C.GetX()), ToScreenY(C.GetY()));
                gr.DrawLine(p, ToScreenX(C.GetX()), ToScreenY(C.GetY()), ToScreenX(B.GetX()), ToScreenY(B.GetY()));
                gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            }
            catch
            {
                label2.Text = "Не удолось визуализировать";
            }
            finally
            {
                
            }
        }


       
    }
}
