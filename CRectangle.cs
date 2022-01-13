/*
 * Student Name: 2016206381
 * Student Surname: Motsamai
 * Student No: 2016206381
 * UFS copyight
 * */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016206381P4
{
    class CRectangle: CFigure
    {
        public static double Length { get; set; }
        public static double Width { get; set; }

        public CRectangle(double _Length, double _Width)
        {
            Length = _Length;
            Width = _Width;
        }
        public override double Area()
        {
            return Length * Width; //calculus Early Transcendental eighth edition James Stewart
        }
        public override double Perimeter()
        {
            return 2 * (Length + Width); //calculus Early Transcendental eighth edition James Stewart
        }
    }
}
