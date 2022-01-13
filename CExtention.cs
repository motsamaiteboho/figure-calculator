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
    public static class Extensions
    {
        public static string Round(this double n)
        {
            return n.ToString("0.00");
        } 
        public static string Round(this double n, int m)
        {
            string decimals = "0. ";
            int[] decii = new int[m];
            for (int i = 0; i < decii.Length; i++)
                decimals += "0";

            return n.ToString(decimals);
        } 

    } 
}
