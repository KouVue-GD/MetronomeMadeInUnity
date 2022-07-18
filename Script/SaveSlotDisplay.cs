using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSlotDisplay : MonoBehaviour
{
    SaveSlot slot;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        slot = GetComponentInParent<SaveSlot>();
        text = GetComponent<Text>();
    }

    
    void FixedUpdate()
    {
        text.text = "" + slot.GetSavedBpm();
    }
}
