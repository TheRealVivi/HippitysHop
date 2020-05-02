using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDoor : MonoBehaviour
{
    public AudioClip notEnoughOrbs;
    public int goingToIndex;

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
            if (Player.Instance.orbsInPossession >= 10 || LastRoomController.threeOrbUsed)
            {
                Door door = gameObject.AddComponent<Door>() as Door;
                door.goingToIndex = goingToIndex;
                door.Open(other, door.scenes[door.goingToIndex], Door.Coordinates.cooridnates[door.goingToIndex]);
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
