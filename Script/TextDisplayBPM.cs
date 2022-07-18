using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplayBPM : MonoBehaviour
{
    Text text;
    Metronome metronome;
    public string textBeforeBpm;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        metronome = GameObject.FindGameObjectWithTag("Metronome").GetComponent<Metronome>();
    }

    void FixedUpdate()
    {
        text.text = textBeforeBpm + metronome.GetBpm();
    }
}
