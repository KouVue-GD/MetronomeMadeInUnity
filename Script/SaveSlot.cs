using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSlot : MonoBehaviour
{
    float savedBPM;
    Metronome metronome;

    void Save(){
        PlayerPrefs.SetFloat(name, savedBPM);
    }

    void Load(){
        savedBPM = PlayerPrefs.GetFloat(name, 0);
    }

    public void LoadIntoMetronome(){
        metronome.SetBpm(savedBPM);
    }

    public void SaveInSlot(){
        savedBPM = metronome.GetBpm();
    }

    public float GetSavedBpm(){
        return savedBPM;
    }

    public void SetSavedBpm(float value){
        savedBPM = value;
    }

    void Start()
    {
        metronome = GameObject.FindGameObjectWithTag("Metronome").GetComponent<Metronome>();
        Load();
    }

    void OnApplicationQuit()
    {
        Save();
    }
}
