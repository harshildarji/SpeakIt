using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakIt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
            speech.Volume = 100;
            speech.Speak(text);
        }
    }
}
