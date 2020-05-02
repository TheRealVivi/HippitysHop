using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool activated;
    public float usableDistance = 9f;
    public AudioClip activatedSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = this.transform.position - Player.Instance.transform.position;
        if (Input.GetKey(KeyCode.E) && direction.sqrMagnitude < usableDistance) 
        {
            activated = true;
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = activatedSound;
            audio.Play();
        }
    }
}
