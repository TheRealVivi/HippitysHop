using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDoor : MonoBehaviour
{
    public AudioClip notEnoughOrbs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            if (Player.Instance.orbsInPossession >= 10)
            {
                SceneManager.LoadScene("SampleScene");
            }
            else 
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = notEnoughOrbs;
                audio.Play();
            }
        }
    }
}
