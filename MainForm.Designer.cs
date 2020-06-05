namespace AudioTranscriber
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.browseWavBtn = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.transcribeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseWavBtn
            // 
            this.browseWavBtn.Location = new System.Drawing.Point(12, 12);
            this.browseWavBtn.Name = "browseWavBtn";
            this.browseWavBtn.Size = new System.Drawing.Size(123, 23);
            this.browseWavBtn.TabIndex = 0;
            this.browseWavBtn.Text = "Select .WAV File";
            this.browseWavBtn.UseVisualStyleBackColor = true;
            this.browseWavBtn.Click += new System.EventHandler(this.browseWavBtn_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.outputTextBox.Location = new System.Drawing.Point(310, 0);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(345, 354);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.Text = "";
            // 
            // transcribeBtn
            // 
            this.transcribeBtn.Enabled = false;
            this.transcribeBtn.Location = new System.Drawing.Point(12, 41);
            this.transcribeBtn.Name = "transcribeBtn";
            this.transcribeBtn.Size = new System.Drawing.Size(123, 23);
            this.transcribeBtn.TabIndex = 2;
            this.transcribeBtn.Text = "Transcribe";
            this.transcribeBtn.UseVisualStyleBackColor = true;
            this.transcribeBtn.Click += new System.EventHandler(this.transcribeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Enabled = false;
            this.clearBtn.Location = new System.Drawing.Point(229, 12);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Enabled = false;
            this.copyBtn.Location = new System.Drawing.Point(229, 41);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(75, 23);
            this.copyBtn.TabIndex = 4;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 354);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.transcribeBtn);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.browseWavBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Audio Transcriber";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browseWavBtn;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Button transcribeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button copyBtn;
    }
}

