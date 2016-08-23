using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Диаграмма_построения_качки
{
    class Manager
    {
        public double Lambda;
        public double V;
        public double Phi;
        public double B;
        public double T;
        public double h;
        public double Cw;
        public double TauK;
        public double C = 0.8;
        public double TauTheta;
        public double TauPsi;
        //Данные для построения диаграммы
        public double Phi1;
        public double Phi2;
        public double Phi3;
        public double Phi4;
        public double Phi5;
        public double Phi6;
        double CosPhi1;
        double CosPhi2;
        double CosPhi3;
        double CosPhi4;
        double CosPhi5;
        double CosPhi6;
        //double Cos;
        double TauKRasch1;
        double TauKRasch2;
        double TauKRasch3;
        double TauKRasch4;
        double TauKRasch5;
        double TauKRasch6;
        double Vrasch;


        public void Vich()
        {
            V = V * 0.514;
            Vrasch = V/0.514;
            //Вычисление скорости волны
            Cw = 1.25 * Math.Sqrt(Lambda);
            //Вычисление кажущегося периода
            TauK = Lambda / (Cw - V * Math.Cos(Phi * Math.PI / 180));
            //Вычисление собственного периода бортовой качки
            TauTheta = C * B / Math.Sqrt(h);
            //Вычисление собственного периода килевой качки
            TauPsi = 2.5 * Math.Sqrt(T);
            
            //Бортовая качка 0,8-1,2
            TauKRasch1 = 0.8 * TauTheta;
            TauKRasch2 = 1.2 * TauTheta;
            //Бортовая качка 1,85-2,15
            TauKRasch3 = 1.85 * TauTheta;
            TauKRasch4 = 2.15 * TauTheta;
            //Килевая качка 0.8-1.2
            TauKRasch5 = 0.8 * TauPsi;
            TauKRasch6 = 1.2 * TauPsi;

            //Вычисления для постройки диаграммы
            //0.8
            CosPhi1 = ((Cw - (Lambda / TauKRasch1)))/Vrasch;
            //находим угол
            Phi1 = Math.Acos(CosPhi1)* (180 / Math.PI);
            //1.2
            CosPhi2 = (Cw - (Lambda / TauKRasch2))/Vrasch;
            Phi2 = Math.Acos(CosPhi2) * (180 / Math.PI);
            //1.85
            CosPhi3 = (Cw - (Lambda / TauKRasch3)) / Vrasch;
            Phi3 = Math.Acos(CosPhi3) * (180 / Math.PI);
            //2.15
            CosPhi4 = (Cw - (Lambda / TauKRasch4)) / Vrasch;
            Phi4 = Math.Acos(CosPhi4) * (180 / Math.PI);

            //Килевая качка
            CosPhi5 = (Cw - (Lambda / TauKRasch5)) / Vrasch;
            Phi5 = Math.Acos(CosPhi5) * (180 / Math.PI);
            CosPhi6 = (Cw - (Lambda / TauKRasch6)) / Vrasch;
            Phi6 = Math.Acos(CosPhi6) * (180 / Math.PI);
        }
            
    }
}