using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInputBPM : MonoBehaviour
{
    InputField inputField;
    Metronome metronome;
    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<InputField>();
        metronome = GameObject.FindGameObjectWithTag("Metronome").GetComponent<Metronome>();
    }

    public void SetBPMFromInputField(){
        metronome.SetBpm(float.Parse(inputField.text));
        inputField.text = "";
    }
}
