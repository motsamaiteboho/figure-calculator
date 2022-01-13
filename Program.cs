/*
 * Student Name: 2016206381
 * Student Surname: Motsamai
 * Student No: 2016206381
 * UFS copyight
 * */
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016206381P4
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tC. Circle");
            Console.WriteLine("\tR. Rectangle");
            Console.WriteLine("\tX. Exit");
            Console.WriteLine();
            Console.Write("\tEnter option: ");
            char option = Console.ReadKey().KeyChar.ToString().ToUpper()[0];

            switch (option) //classroom examples
            {
                case 'C': Circle(); Main(); break;
                case 'R': Rectangle(); Main(); break;
                case 'X': Console.WriteLine("\n\n\tPress any key to exit.......");Console.ReadKey(); break;
                default: Console.WriteLine("\n\n\tYou entered invalid option, please press any key to try again"); Console.ReadKey(); Main();break;
            }

        }
        private static void Circle()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tCircle");
            Console.Write("\tRadius : ");
            double radius = Parse<double>(Console.ReadLine());
            Console.WriteLine();
            // Instantiate circle with the given radius and display the area and perimeter as in the screen print below
            CFigure cFigure = new CCircle(radius);
            Console.Clear();

            bool isValidRadius = false;
            if (CCircle.Radius <= 0)
                isValidRadius = true;

            Console.WriteLine("\tCircle");
            Console.WriteLine("\tRadius        : " + (isValidRadius ? "Invalid": CCircle.Radius.ToString()));
            Console.WriteLine("\n\tArea          : " + cFigure.Area().Round(3));
            Console.WriteLine("\tPerimeter     : " + cFigure.Perimeter().Round(4));
            Console.WriteLine();
            Console.Write("\tPress any key to return to the menu ..."); Console.ReadKey();
        } //Circle
        private static void Rectangle()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tRectangle");
            Console.Write("\tWidth : ");
            double width = Parse<double>(Console.ReadLine());
            Console.Write("\tHeight : ");
            double height = Parse<double>(Console.ReadLine());
            Console.WriteLine();
            //Instantiate rectangle with the given width and height and display the area and perimeter as in the screen print below
            CFigure cFigure = new CRectangle(height, width);
            Console.Clear();

            bool isValidWidth = false;
            if (CRectangle.Width <= 0)
                isValidWidth = true;

            bool isValidLength = false;
            if (CRectangle.Length <= 0)
                isValidLength = true;

            Console.WriteLine("\tRectangle");
            Console.WriteLine("\tWidth      : " + (isValidWidth? "Invalid" :CRectangle.Width.ToString()));
            Console.WriteLine("\tLength     : " + (isValidLength ? "Invalid": CRectangle.Length.ToString()));
            Console.WriteLine("\n\tArea       : " + cFigure.Area().Round(3));
            Console.WriteLine("\tPerimeter  : " + cFigure.Perimeter().Round());
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\tPress any key to return to the menu ..."); Console.ReadKey();
        } //Rectangle

        private static T Parse<T>(string value)
        {
            T ReturnValue;
            try
            {
                ReturnValue = (T)Convert.ChangeType(value, typeof(T));      //classroom examples
            }
            catch (Exception)
            {
                ReturnValue = default(T);

            }
            return ReturnValue;
        }
    }
}
