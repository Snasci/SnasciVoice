using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace SnasciVoiceBox.AudioOut
{
    public class PCM
    {
        private WaveFormat waveFormat = new WaveFormat(8000, 16, 1);
        private BufferedWaveProvider bufferedWaveProvider;
        private WaveOut waveout;

        public PCM()
        {
            bufferedWaveProvider = new BufferedWaveProvider(waveFormat);
            waveout = new WaveOut();
            waveout.Init(bufferedWaveProvider);
        }

        public void PlayByteArray(byte[] pcmArray)
        {
            bufferedWaveProvider.AddSamples(pcmArray, 0, pcmArray.Length);
            waveout.Play();
        }

        public byte[] GenerateWhiteNoise(int length)
        {
            byte[] buffer = new byte[length];
            Random
        }
    }
}
