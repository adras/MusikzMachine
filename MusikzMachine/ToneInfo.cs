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
        public double octave = 2 / 1;
        public double sixth = 8 / 5;
        public double quint = 3 / 2;
        public double quart = 4 / 3;
        public double third = 5 / 4;
        public double unision = 1 / 1;
    }
}
