using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public double a;//первая сторона
        public double b;//вторая сторона
        public double c;//третья сторона
    }
    public Triangle(double A, double B, double C)//конструктор
    {
        a = A;//создаем с заданными длинами сторон соглсано заданию
        b = B;
        c = C;
    }
    public string outputA()//выводим сторону a, данный метод возвращает строковое значение

}
