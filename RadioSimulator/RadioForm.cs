using RadioSimulator.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadioSimulator
{
    public partial class RadioForm : Form
    {
        #region Constructor

        public RadioForm()
        {
            InitializeComponent();
            _radioStations = new List<RadioFile>();
        }

        #endregion

        #region Private Fields

        private List<RadioFile> _radioStations;

        #endregion

        #region Events

        private void AddFilesButton_Click(object sender, EventArgs e)
        {
            var radioFileLoader = new RadioFileLoader();
            _radioStations.AddRange(radioFileLoader.Load());

            foreach (var file in _radioStations)
                this.RadioFilesListBox.Items.Add(file.Name);
        }

        private void StartSimulationButton_Click(object sender, EventArgs e)
        {
            var simulationManager = new SimulationManager();
            simulationManager.Start(_radioStations);
        }

        #endregion
    }
}
