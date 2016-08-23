using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Диаграмма_построения_качки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        public void buttOk_Click(object sender, EventArgs e)
        {;
            Fabric.Get().Lambda = Convert.ToDouble(tBLambda.Text.Replace(".", ","));
            Fabric.Get().V = Convert.ToDouble(tBV.Text.Replace(".", ","));
            Fabric.Get().Phi = Convert.ToDouble(tBPhi.Text.Replace(".", ","));
            Fabric.Get().B = Convert.ToDouble(tBB.Text.Replace(".", ","));
            Fabric.Get().T = Convert.ToDouble(tBT.Text.Replace(".", ","));
            Fabric.Get().h = Convert.ToDouble(tBMH.Text.Replace(".", ","));
            //Fabric.Get().Lambda = 65;
            //Fabric.Get().V = 14;
            //Fabric.Get().Phi = 60;
            //Fabric.Get().B = 10;
            //Fabric.Get().T = 3.9;
            //Fabric.Get().h = 0.65;
            if ((Fabric.Get().Lambda <= 0) || (Fabric.Get().V <= 0) || (Fabric.Get().B <= 0) || (Fabric.Get().T <= 0) || (Fabric.Get().h <= 0))
            {
                MessageBox.Show("Введено неправильное число: Lambda, V, B, T, h должны быть положительны.");
            }
            else
            {
                Fabric.Get().Vich();
                //Вывод результата
                string StrResult = "Резонансных периодов не обнаружено.";
                if ((Fabric.Get().TauK / Fabric.Get().TauPsi > 0.8) && (Fabric.Get().TauK / Fabric.Get().TauPsi < 2.15))
                    StrResult = "Обнаружен основной резонанс килевой качки.";
                if ((Fabric.Get().TauK / Fabric.Get().TauTheta > 0.8) && (Fabric.Get().TauK / Fabric.Get().TauTheta < 1.2))
                    StrResult = "Обнаружен основной резонанс бортовой качки.";
                labelResultVar.Text = StrResult;
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiagramForm form = new DiagramForm();
            form.Owner = this;
            form.Show();
        }
    }
}
