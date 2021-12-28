using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusikzMachine
{
    public class ToneInfo
    {
        public double frequency;
        public string name;
    }
    // TODO: Herausfinden, wie man Intervalle abbildet, basierend auf einer Basisfrequenz wie z.B. A=440 hz
    // Tonleiter, z.B. C-Dur davon ableiten

    public class Intervals
    {
        // https://kilchb.de/muslekt1.php
        public static double octave = 2.0 / 1;
        public static double sixth = 8.0 / 5;
        public static double quint = 3.0 / 2;
        public static double quart = 4.0 / 3;
        public static double third = 5.0 / 4;
        public static double unision = 1.0 / 1;
    }
}
