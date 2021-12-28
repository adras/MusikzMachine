using NAudio.Wave;

namespace MusikzMachine
{
    public class SignalGenWaveOut : ICustomWaveOut
    {
        public WaveOut WaveOut { get; set; }

        public SignalGenWaveOut(WaveOut waveOut)
        {
            this.WaveOut = waveOut;
        }
    }
}
