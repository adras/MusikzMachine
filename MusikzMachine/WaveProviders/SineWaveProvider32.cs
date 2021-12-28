using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusikzMachine.WaveProviders
{
    public class SineWaveProvider32
    {
        //int sample;

        //public SineWaveProvider32(double frequency)
        //{
        //    Frequency = frequency;
        //    Amplitude = 0.25f; // Let's not hurt our ears
        //}

        //public double Frequency { get; set; }
        //public double Amplitude { get; set; }

        //public override int Read(double[] buffer, int offset, int sampleCount)
        //{
        //    int sampleRate = WaveFormat.SampleRate;
        //    for (int n = 0; n < sampleCount; n++)
        //    {
        //        buffer[n + offset] = (float)(Amplitude * Math.Sin((2 * Math.PI * sample * Frequency) / sampleRate));
        //        sample++;
        //        if (sample >= sampleRate)
        //            sample = 0;
        //    }
        //}
    }
}
