using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace SpeakIt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speech = new SpeechSynthesizer();
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            selectGender();
            speech.Volume = 100;
            speech.Speak(text);
        }

        public void selectGender()
        {
            if (radioButton1.Checked == true)
                speech.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
            else
                speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
        }
    }
}
