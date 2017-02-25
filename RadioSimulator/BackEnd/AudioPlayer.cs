using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadioSimulator.BackEnd
{
    public class AudioPlayer
    {
        #region Private Fields

        private static IWavePlayer _waveOutDevice;
        private static AudioFileReader _audioFileReader;

        private static AudioPlayer _instance;

        #endregion

        #region Static Methods

        public static AudioPlayer GetInstance()
        {
            if (_instance == null)
                _instance = new AudioPlayer();

            return _instance;
        }

        public void Play(string filePath)
        {
            this.Stop();

            _waveOutDevice = new WaveOut();
            _audioFileReader = new AudioFileReader(filePath);
            _waveOutDevice.Init(_audioFileReader);
            _waveOutDevice.Play();
        }

        public void Stop()
        {
            if (_waveOutDevice != null)
            {
                _waveOutDevice.Stop();
                _waveOutDevice.Dispose();
                _waveOutDevice = null;
            }
        }

        public void Pause()
        {
            _waveOutDevice.Pause();
        }

        #endregion
    }
}
