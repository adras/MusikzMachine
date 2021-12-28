using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusikzMachine
{
    public class SignalGenWaveOutFactory
    {
        public SignalGenWaveOutFactory()
        {
        }

        public static SignalGenWaveOut Create(double frequency)
        {
            SignalGenerator generator = new SignalGenerator();
            generator.Frequency = frequency;
            generator.Type = SignalGeneratorType.Sin;

            WaveOut waveOut = new WaveOut();
            waveOut.Init(generator);

            SignalGenWaveOut result = new SignalGenWaveOut(waveOut);

            return result;
        }

    }
}
