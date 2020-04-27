using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public Text orbCount;
    public Text hudText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        orbCount.text = Player.Instance.orbsInPossession.ToString() + " / 10";
        if (SignInteraction.usable)
            hudText.text = "PRESS E TO INTERACT";
        else
            hudText.text = " ";
    }
}
