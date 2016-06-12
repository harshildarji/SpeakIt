# SpeakIt
Simple windows form application that speaks whatever user enters into given textbox.

#### Code behind:

- Basic idea behind this is similar to my previous repository: <a href="https://github.com/H-Darji/KeySound">KeySound</a>
- I included a **`textbox`**, **`groupbox`** with **`two radio buttons`** and a **`button`** as shown in below image:

<img src="https://f4e7137fefea07b0fae4c8ffd7320e68e7aa0823-www.googledrive.com/host/0B9svjAuZEeT4YVM3M1hzdGVxUzQ/si.jpg">

- User enters data/message into textbox provided, which then will be passed to a string variable as:
```C#
string text = textBox1.Text;
```
- Now, We will create object of **`SpeechSynthesizer`** as:
```C#
SpeechSynthesizer speech = new SpeechSynthesizer();
```
- Now, When user clicks on **`Speak`** button, we will call **`selectGender()`** function to select the gender of output voice based on option selected by the user.
- This **`selectGender()`** is as follows:
```C#
public void selectGender()
{
    if (radioButton1.Checked == true)
        speech.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
    else
        speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
}
```
- Now, We will set **`speech volume`** as:
```C#
speech.Volume = 100;
```
- At the end, We will call **`Speak`** method using object of **`SpeechSynthesizer`** with **`text`** as argument:
```C#
speech.Speak(text);
```

###### Thank you for visit.
