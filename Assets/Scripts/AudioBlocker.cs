using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBlocker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioListener audio = GetComponent<AudioListener>();
        if (Player.Instance != null)
            audio.enabled = false;
        else
            audio.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
