using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignManager : MonoBehaviour
{
    GameObject[] signs;
    public float usableDistance;
    // Start is called before the first frame update
    void Start()
    {
        signs = GameObject.FindGameObjectsWithTag("sign");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Player.Instance.transform.position), out hit, 500))
        {
            foreach (GameObject a in signs)
            {
                if ((Player.Instance.transform.position - a.transform.position).sqrMagnitude < usableDistance && Input.GetKeyDown(KeyCode.E))
                {
                    a.GetComponent<SignInteraction>().Speak();
                }
            }
        }
    }
}
