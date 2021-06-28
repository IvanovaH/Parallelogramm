using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ozn_prackt
{
    class parallelogram
    {
   
        public double S;
        public double P;
        public double L;
        public double D;

        public double A1;
        public double B1;



        public void Sp_PO_VIS(double A, double H)//вычисление площади параллелограмма по стороне и высоте параллелограмма, опущенной к данной стороне
        {

            S = A * H;
        }

        public void Sp_PO_DIAG(double d1, double d2, double alf)//вычисление площади параллелограмма по двум диагоналям и углу между ними
        {

            S = 0.5*d1*d2 * Math.Sin(alf);
        }
        public void Sp_PO_ULGU_STORON(double A, double B,double alf)//вычисление площади параллелограмма по двум сторонам и углу между ними
        {

            S = (A * B)*(Math.Sin(alf));
        }

        public void PP(double A, double B)//вычисление периметра параллелограмма по  двум сторонам
        {

            P = 2*(A + B);
        }



        public void P_D(double A, double D1, double D2)//вычисление периметра параллелограмма по стороне и двум диагоналям
        {
            P= 2 * A + Math.Sqrt(2 * (Math.Pow(D1, 2)) + 2 * (Math.Pow(D2, 2)) - 4 * (Math.Pow(A, 2)));
             
        }




        //определение сторон

        public void a_po_diag_alf(double d1, double d2, double alf)//вычисление стороны параллелограмма по двум диагоналям и углу между ними
        {
            A1 = (Math.Sqrt(Math.Pow(d1, 2) + Math.Pow(d2, 2) + 2 * d1 * d2 * Math.Cos(alf)))/2;

        }


        public void a_po_diag_b(double d1, double d2, double b)//вычисление стороны параллелограмма по двум диагоналям и другой стороне
        {
            A1 = (Math.Sqrt(Math.Pow(d1, 2) + Math.Pow(d2, 2) - 4* Math.Pow(b, 2))) / 2;

        }

        public void a_po_h_alf(double h, double alf)// вычисление стороны параллелограмма по высоте, проведенной к другой стороне и прилежащему углу
        {
            A1 = h / Math.Sin(alf);

        }


        public void a_po_S_H(double s, double h)// вычисление стороны параллелограмма по высоте, проведенной к данной стороне и площади
        {
            A1 = s / h;

        }

        
        public void UG(double pr_ug)//вычисление угла параллелограмма по прилежащему углу
        {

            L = 180 - pr_ug;
        }
    }
}
