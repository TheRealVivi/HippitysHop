using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastRoomController : MonoBehaviour
{
    public GameObject tenOrbCollection;
    public float usableDistance = 9f;

    // Start is called before the first frame update
    void Start()
    {
        tenOrbCollection.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = this.transform.position - Player.Instance.transform.position;

        if (Input.GetKeyDown(KeyCode.E) && direction.sqrMagnitude < usableDistance) 
        {
            tenOrbCollection.SetActive(true);
            Player.Instance.orbsInPossession -= 10;
        }
    }
}
