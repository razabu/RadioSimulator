using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadioSimulator.BackEnd
{
    public class SimulationManager
    {
        #region Private Fields

        private IWavePlayer _waveOutDevice;
        private AudioFileReader _audioFileReader;

        #endregion

        #region Public Methods

        public void Start(IEnumerable<RadioFile> radioStations)
        {
            var teste = radioStations.First();

            foreach (var item in radioStations)
            {
                AudioPlayer.GetInstance().Play(item.Path);
            }
            
        }

        #endregion
    }
}
