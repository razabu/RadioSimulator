using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadioSimulator.BackEnd
{
    public class WavRadioFile : RadioFile
    {
        public WavRadioFile(string path, string name)
            : base(path, name)
        { }

        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void Pause()
        {
            throw new NotImplementedException();
        }
    }
}
