﻿using System;
using System.Globalization;

namespace Curso
{
    public class Arrays1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0; i < n; ++i)
            {
                soma += vect[i];
            }

            double avg = soma / n;

            Console.WriteLine("AVERAGE HEIGHT: " + avg.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
