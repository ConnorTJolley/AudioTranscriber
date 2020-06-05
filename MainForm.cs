using System;
using System.Globalization;
using System.Speech.Recognition;
using System.Windows.Forms;
using AudioTranscriber.Classes;
using AudioTranscriber.Helpers;

namespace AudioTranscriber
{
    public partial class MainForm : Form
    {
        private bool _completed;
        private AudioFile _audioFile;
        private SpeechRecognitionEngine _recognizer;
        private DictationGrammar _grammar;

        public MainForm()
        {
            this.InitializeComponent();
            this.CreateRecognizer();
        }

        private void CreateRecognizer()
        {
            this._recognizer = new SpeechRecognitionEngine(new CultureInfo("en-US"));
            this._grammar = new DictationGrammar
            {
                Name = "Dictation Grammar"
            };

            this._recognizer.LoadGrammar(this._grammar);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.outputTextBox.Clear();
            this.copyBtn.Enabled = false;
            this.clearBtn.Enabled = false;
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            this.outputTextBox.SelectionStart = 0;
            this.outputTextBox.SelectionLength = this.outputTextBox.TextLength;
            this.outputTextBox.Copy();
            this.outputTextBox.SelectionLength = 0;

            MessageBox.Show(@"Copied Text to Clipboard!");
        }

        private void browseWavBtn_Click(object sender, EventArgs e)
        {
            this._audioFile = ValueRetriever.SelectFile();
            this.transcribeBtn.Enabled = !string.IsNullOrWhiteSpace(this._audioFile.FileName);
            if (!this.transcribeBtn.Enabled)
            {
                return;
            }

            this.CreateRecognizer(); //// Just to be sure
            this.SetFileLocation();
            this._completed = false;
        }

        private void SetFileLocation()
        {
            this._recognizer.SetInputToWaveFile(this._audioFile.FileName);
            this._recognizer.SpeechRecognized += this.recognizer_SpeechRecognized;
            this._recognizer.RecognizeCompleted += this.recognizer_RecognizeCompleted;
        }

        private void recognizer_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show($@"Error encountered, {e.Error.GetType().Name}: {e.Error.Message}");
            }
            else if (e.Cancelled)
            {
                MessageBox.Show(@"  Operation cancelled.");
            }

            this._completed = true;
            this.SetComplete(true);
        }

        private void SetComplete(bool state)
        {
            this.copyBtn.Enabled = state;
            this.clearBtn.Enabled = state;
            this.browseWavBtn.Enabled = state;
            this.transcribeBtn.Enabled = state;
        }

        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result != null)
            {
                this.WriteToUi(e.Result.Text);
            }
            else
            {
                MessageBox.Show(@"Recognized text not available.");
            }
        }

        private void WriteToUi(string resultText)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => this.WriteText(resultText)));
                return;
            }

            this.WriteText(resultText);
        }

        private void WriteText(string resultText)
        {
            this.outputTextBox.AppendText(resultText + " ");
            this.outputTextBox.SelectionStart = this.outputTextBox.TextLength;
            this.outputTextBox.ScrollToCaret();
        }

        private void transcribeBtn_Click(object sender, EventArgs e)
        {
            if (this._completed || string.IsNullOrWhiteSpace(this._audioFile.FileName))
            {
                return;
            }

            this.SetComplete(false);
            this._recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }
    }
}
