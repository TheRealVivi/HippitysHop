using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignInteraction : MonoBehaviour
{
    public Dialog dialog;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Speak() 
    {
        FindObjectOfType<DialogManager>().StartDialog(this.dialog);
    }
}
