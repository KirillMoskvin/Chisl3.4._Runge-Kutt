using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisl3._4._Runge_Kutt
{
    class RungeKutta
    {
        /// <summary>
        /// Сигнатура передваваемой функции, зависимой от х и у
        /// </summary>
        public delegate double function(double x, double y);
        
        public static double Solve(function func, double x0, double y0, double h, double b)
        {
            double res = y0;
            double x = x0;
            do
            {
                double k1 = koeff1(func, x, res);
                double k2 = koeff2(func, x, res, k1, h);
                double k3 = koeff3(func, x, res, k2, h);
                double k4 = koeff4(func, x, res, k3, h);
                double deltaY0 = h / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
                res += deltaY0;
                x += h;
            }
            while (x < b);//по всем значениям x до b с шагом h
            return res;
        }

        /// <summary>
        /// Вычисление коэффициента k1
        /// </summary>
        static double koeff1(function f, double x, double y)
        {
            return f(x , y);
        }

        /// <summary>
        /// Вычисление коэффициента k2
        /// </summary>
        static double koeff2(function f, double x, double y, double k1, double h)
        {
            return f(x + h / 2 , y + h * k1 / 2);
        }

        /// <summary>
        /// Вычисление коэффициента k3
        /// </summary>
        static double koeff3(function f, double x, double y, double k2, double h)
        {
            return f(x + h / 2 , y + h * k2 / 2);
        }

        /// <summary>
        /// Вычисление коэффициента k4
        /// </summary>
        static double koeff4(function f, double x, double y, double k3, double h)
        {
            return f(x + h , y + h * k3);
        }

    }
}
