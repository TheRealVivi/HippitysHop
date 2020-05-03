using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLevelController : MonoBehaviour
{
    public Dialog tutorial;
    public GameObject firstMob;
    public GameObject mazeMob;
    bool firstTriggered;
    bool mazeTriggered;
    bool beginningTriggered;
    private void Start()
    {
        beginningTriggered = false;
        firstTriggered = false;
        mazeTriggered = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (!beginningTriggered) 
        {
            beginningTriggered = true;
            Speak();
        }
        if (Player.Instance.orbsInPossession >= 4 && !firstTriggered) 
        {
            firstTriggered = true;
            firstMob.SetActive(false);
        }
        if (Player.Instance.orbsInPossession >= 8 && !mazeTriggered) 
        {
            mazeTriggered = true;
            mazeMob.SetActive(false);
        }
    }

    public void Speak()
    {
        FindObjectOfType<DialogManager>().StartDialog(this.tutorial);
    }
}
