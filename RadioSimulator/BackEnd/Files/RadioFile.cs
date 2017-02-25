using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadioSimulator.BackEnd
{
    public abstract class RadioFile
    {
        #region Constructor

        public RadioFile(string path, string name)
        {
            this.Path = path;
            this.Name = name;
        }

        #endregion

        #region Attributes and Properties

        public string Path { get; set; }
        public string Name { get; set; }

        #endregion

        #region Abstract Methods

        public abstract void Play();
        public abstract void Pause();

        #endregion
    }
}
