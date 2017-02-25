using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadioSimulator.BackEnd
{
    public  class Mp3RadioFile : RadioFile
    {
        public Mp3RadioFile(string path, string name)
            : base(path, name)
        { }

        public override void Play()
        {
            
        }

        public override void Pause()
        {
            throw new NotImplementedException();
        }
    }
}
