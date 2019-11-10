using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class speechToText : MonoBehaviour
{
    [SerializeField]
    private Text m_Hypotheses;

    [SerializeField]
    private Text m_Recognitions;

    private DictationRecognizer m_DictationRecognizer;
    private float timer = 0.0f;
    void Start()
    {
        m_DictationRecognizer = new DictationRecognizer();
        string[] array = {"blue", "red", "white", "bomb", "wire", "cut", "first", "keypad", "button", "yellow", "green", "venting", "gas", "simon", "says", "manual", "time", "timer", "black", "first", "fourth", "third", "second", "fifth", "sixth"};
        m_DictationRecognizer.DictationResult += (text, confidence) =>
        {
            string test = text;
            for (int i = 0; i < array.Length; i++)
            {
                if(test.IndexOf(array[i])>=0)
                {
                    Debug.LogFormat("Dictation result: {0}", text);
                    m_Recognitions.text = text + "\n";
                    Debug.Log(timer);
                    break;
                }
            }
        };

        m_DictationRecognizer.DictationHypothesis += (text) =>
        {
            Debug.LogFormat("Dictation hypothesis: {0}", text);
            m_Hypotheses.text = text;
            Debug.Log(timer);
        };

        m_DictationRecognizer.DictationComplete += (completionCause) =>
        {
            if (completionCause != DictationCompletionCause.Complete)
                Debug.LogErrorFormat("Dictation completed unsuccessfully: {0}.", completionCause);
        };

        m_DictationRecognizer.DictationError += (error, hresult) =>
        {
            Debug.LogErrorFormat("Dictation error: {0}; HResult = {1}.", error, hresult);
        };

        m_DictationRecognizer.Start();
    }
    private void Update()
    {
        timer += Time.deltaTime;
    }
}
