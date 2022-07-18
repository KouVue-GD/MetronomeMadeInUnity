using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Metronome : MonoBehaviour
{
    //Contains all the functions that the other scripts will reference for metronome

    float bpm;
    AudioSource tickSound;

    void Save(){
        PlayerPrefs.SetFloat("bpm", bpm);
    }

    void Load(){
        bpm = PlayerPrefs.GetFloat("bpm", 0);
    }

    public float GetBpm(){
        return bpm;
    }

    public void SetBpm(float value){
        bpm = value;
    }

    public void IncrementBpm(){
        bpm += 1;
    }

    public void DecrementBpm(){
        bpm -= 1;
    }

    public void Play(){
        isPlaying = !isPlaying;
    }

    public void SetVolume(float value){
        tickSound.volume = value;
    }

    Text errorText;
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        tickSound = GetComponentInChildren<AudioSource>();
        errorText = GameObject.FindGameObjectWithTag("ErrorText").GetComponent<Text>();
        Load();
    }
    
    bool isPlaying;
    float time;
    // Update is called once per frame
    void Update()
    {
        if(bpm < 0 || bpm > float.MaxValue){
            bpm = 0;
            errorText.color = Color.cyan;
        }

        if(isPlaying == true){
            time += Time.deltaTime;
            if(bpm == 0){

            }
            else if(time%(1/(bpm/60)) <= 0 + Time.deltaTime){
                tickSound.Play();
            }

        }else{
            time = 0;
        }
        
    }

    void OnApplicationQuit()
    {
        Save();
        PlayerPrefs.Save();
    }
}
