using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignInteraction : MonoBehaviour
{
    public Dialog dialog;
    public float usableDistance = 4f;
    public static bool usable;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void FixedUpdate()
    {
        direction = this.transform.position - Player.Instance.transform.position;
        usable = direction.magnitude < usableDistance;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && direction.sqrMagnitude < usableDistance) 
        {
            Speak();
        }
    }

    void Speak() 
    {
        FindObjectOfType<DialogManager>().StartDialog(this.dialog);
    }
}
