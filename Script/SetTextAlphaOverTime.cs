using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTextAlphaOverTime : MonoBehaviour
{
    Text text;
    public float fadeTime;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.color = new Color(0, 1, 1, text.color.a - (Time.deltaTime/fadeTime));
    }
}
