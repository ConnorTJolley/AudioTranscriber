using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioTranscriber.Classes;

namespace AudioTranscriber.Helpers
{
    public static class ValueRetriever
    {
        public static AudioFile SelectFile()
        {
            var audioFile = new AudioFile();

            try
            {
                using (var fileDialog = new OpenFileDialog
                {
                    Filter = @"WAV File (*.wav)|*.wav"
                })
                {
                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        audioFile.FileName = fileDialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return audioFile;
        }
    }
}