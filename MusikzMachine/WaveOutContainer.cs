using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusikzMachine
{

    public class WaveOutContainer
    {
        public static Lazy<WaveOutContainer> instance = new Lazy<WaveOutContainer>();

        List<ICustomWaveOut> waveOuts;

        public WaveOutContainer()
        {
            waveOuts = new List<ICustomWaveOut>(); 
        }

        public void AddWaveOut(ICustomWaveOut waveOut)
        {
            waveOuts.Add(waveOut);
        }

        public void PlayAll()
        {
            foreach(ICustomWaveOut waveOut in waveOuts)  
                waveOut.WaveOut.Play();
        }

        public void StopAll()
        {
            foreach (ICustomWaveOut waveOut in waveOuts)
                waveOut.WaveOut.Stop();
        }
    }
}
