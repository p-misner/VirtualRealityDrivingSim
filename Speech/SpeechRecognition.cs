using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
//https://github.com/LightBuzz/Speech-Recognition-Unity/blob/master/SpeechRecognitionUnity/Assets/Scripts/SpeechRecognitionEngine.cs


public class SpeechRecognition : MonoBehaviour
{
    //Global Variables and Initial Declarations
    public string[] keywords = { "up", "down", "left", "right" };
    public ConfidenceLevel confidence = ConfidenceLevel.Medium;
    public float speed = 1;

    public Text results;
    public Image target;
    protected PhraseRecognizer recognizer;
    protected string word = "right";

    // Start is called before the first frame update
    private void Start()
    {
        if (keywords != null)
        {
            recognizer = new KeywordRecognizer(keywords, confidence);
            recognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
            recognizer.Start();
        }
    }

    private void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        word = args.text;
        results.text = "You said: <b>" + word + "</b>";
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        if (recognizer != null && recognizer.IsRunning)
        {
            recognizer.OnPhraseRecognized -= Recognizer_OnPhraseRecognized;
            recognizer.Stop();
        }
    }
}
