using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Диаграмма_построения_качки
{
    public partial class DiagramForm : Form
    {
        public DiagramForm()
        {
            InitializeComponent();
        }

        private void DiagramForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(Fabric.Get().Phi1));
        }
        public double drawphi(double inPhi)
        {
            double outPhi = 0;
            if (inPhi <= 30)
            {
                outPhi = (0.73 * inPhi) + 30;
            }
            if (inPhi > 30 && inPhi <= 60)
            {
                outPhi = 2.57 * (inPhi - 30)+52;
            }
            if (inPhi > 60 && inPhi < 90)
            {
                outPhi = 3.33 * (inPhi - 60) + 129.5;
            }
            if (inPhi > 90 && inPhi <= 120)
            {
                outPhi = 3.33 * (inPhi - 90) + 229;
            }
            if (inPhi >120 && inPhi <= 150)
            {
                outPhi = 2.57 * (inPhi - 120) + 328;
            }
            if (inPhi > 150 && inPhi < 180)
            {
                outPhi = 0.73 * (inPhi - 150) + 406;
            }
            return outPhi;
        }
        private void DiagramForm_Paint(object sender, PaintEventArgs e)
        {
           
            //горизонтальная линия
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            e.Graphics.DrawLine(pen, 30, 250, 428, 250);
            //линии разметки углов
            e.Graphics.DrawLine(pen, 229, 250, 52, 161);//30
            e.Graphics.DrawLine(pen, 229, 250, 129, 78);//60
            e.Graphics.DrawLine(pen, 229, 250, 229, 50);//90
            e.Graphics.DrawLine(pen, 229, 250, 328, 78);//120
            e.Graphics.DrawLine(pen, 229, 250, 406, 161);//150
                                                        
            e.Graphics.DrawArc(pen, 30, 50, 398, 400, -180, 180); //полукруг
            //дуги скоростей
            e.Graphics.DrawArc(pen, 63, 83, 332, 334, -180, 180); //5
            e.Graphics.DrawArc(pen, 96, 116, 266, 268, -180, 180);//4
            e.Graphics.DrawArc(pen, 129, 149, 200, 202, -180, 180);//3
            e.Graphics.DrawArc(pen, 162, 182, 134, 136, -180, 180);//2
            e.Graphics.DrawArc(pen, 195, 215, 68, 70, -180, 180);//1
            //заливка прямоугольника
            Brush bortBrush1 = new Pen(Color.FromArgb(150, Color.Blue)).Brush;
            Brush bortBrush2 = new Pen(Color.FromArgb(150, Color.Red)).Brush;
            Brush bortBrush3 = new Pen(Color.FromArgb(150, Color.Green)).Brush;
            //Объявляем координаты X для рисования прямоугольника
            double bortR1X1=0;
            double bortR1X2=0;
            double bortR2X1=0;
            double bortR2X2=0;
            double verticalX1=0;
            double verticalX2=0;

            //расчет данных для постройки прямоугольника

            //первый прямоугольник
            //X1
            bortR1X1 = drawphi(Fabric.Get().Phi1);
            bortR1X2 = drawphi(Fabric.Get().Phi2);
            double widthR1;
            if (bortR1X1 < bortR1X2)
            {
                widthR1 = bortR1X2 - bortR1X1;
            }
            else
            {
                widthR1 = bortR1X1 - bortR1X2;
                bortR1X1 = bortR1X2;
            }
            e.Graphics.FillRectangle(bortBrush1, (float)bortR1X1, 50, (float)widthR1, 200);

            //второй прямоугольник
            bortR2X1 = drawphi(Fabric.Get().Phi3);
            bortR2X2 = drawphi(Fabric.Get().Phi4);
            double widthR2;
            if (bortR2X1 < bortR2X2)
            {
                widthR2 = bortR2X2 - bortR2X1;
                bortR2X1 = bortR2X2;
            }
            else
            {
                widthR2 = bortR2X1 - bortR2X2;
                bortR2X1 = bortR2X2;
            }
            e.Graphics.FillRectangle(bortBrush2, (float)bortR2X1, 50, (float)widthR2, 200);

            //третий прямоугольник
            verticalX1 = drawphi(Fabric.Get().Phi5);
            verticalX2 = drawphi(Fabric.Get().Phi6);
            double widthR3;
            if (verticalX1 < verticalX2)
            {
                widthR3 = verticalX2 - verticalX1;  
            }
            else
            {
                widthR3 = verticalX1 - verticalX2;
                verticalX1 = verticalX2;
            }
            
            e.Graphics.FillRectangle(bortBrush3, (float)verticalX1, 50, (float)widthR3, 200);
        }
    }
}
