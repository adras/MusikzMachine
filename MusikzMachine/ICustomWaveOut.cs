using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusikzMachine
{
    public interface ICustomWaveOut
    {
        public WaveOut WaveOut { get; set; }
    }
}
