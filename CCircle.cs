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
    class CCircle : CFigure
    {
        public static double Radius { get; set; }

        public CCircle(double _Radius)
        {
            Radius = _Radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius; //calculus Early Transcendental eighth edition James Stewart
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius; //calculus Early Transcendental eighth edition James Stewart
        }
    }
}
