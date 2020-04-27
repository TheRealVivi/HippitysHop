using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignInteraction : MonoBehaviour
{
    public Dialog dialog;
    public float usableDistance = 2f;
    public static bool usable;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        direction = this.transform.position - Player.Instance.transform.position;
        usable = direction.magnitude < usableDistance;
        if (Input.GetKeyDown(KeyCode.E) && direction.magnitude < usableDistance) 
        {
            Speak();
        }
    }

    void Speak() 
    {
        FindObjectOfType<DialogManager>().StartDialog(this.dialog);
    }
}
