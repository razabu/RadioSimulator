using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RadioSimulator.BackEnd
{
    public class RadioFileLoader
    {
        #region Constants

        private const string FILTER = "Arquivos Mp3 (*.mp3)|*.mp3|Arquivos WAV (*.wav)|*.wav";

        #endregion

        #region Public Methods

        public List<RadioFile> Load()
        {
            var fileList = this.GetFileList();

            return fileList;
        }

        #endregion

        #region Private Methods

        private List<RadioFile> GetFileList()
        {
            var result = new List<RadioFile>();
            var openFileDialog = this.GetOpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var fileName in openFileDialog.FileNames)
                {
                    var format = Path.GetExtension(fileName);
                    var name = Path.GetFileName(fileName);

                    if (format == ".mp3")
                        result.Add(new Mp3RadioFile(fileName, name));
                    else if (format == ".wav")
                        result.Add(new WavRadioFile(fileName, name));
                }
            }

            return result;
        }

        private OpenFileDialog GetOpenFileDialog()
        {
            return new OpenFileDialog()
            {
                Filter = RadioFileLoader.FILTER,
                Multiselect = true,
            };
        }

        #endregion
    }
}
