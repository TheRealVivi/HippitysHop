using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastRoomController : MonoBehaviour
{
    public GameObject tenOrbCollection;
    public GameObject threeOrbCollection;
    public GameObject firstOrb;
    public GameObject secondOrb;
    public GameObject thirdOrb;
    public float usableDistance = 9f;
    public float currentDistance;
    bool tenOrbUsed;
    bool threeOrbUsed;

    // Start is called before the first frame update
    void Start()
    {
        tenOrbCollection.SetActive(false);
        firstOrb.SetActive(false);
        secondOrb.SetActive(false);
        thirdOrb.SetActive(false);
        tenOrbUsed = false;
        threeOrbUsed = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tenorbdirection = tenOrbCollection.transform.position - Player.Instance.transform.position;
        Vector3 threeorbdirection = threeOrbCollection.transform.position - Player.Instance.transform.position;

        if (Input.GetKeyDown(KeyCode.E) && (currentDistance = tenorbdirection.sqrMagnitude) < usableDistance && !tenOrbUsed) 
        {
            tenOrbCollection.SetActive(true);
            Player.Instance.orbsInPossession -= 10;
            tenOrbUsed = true;
        }

        if (Input.GetKeyDown(KeyCode.E) && threeorbdirection.sqrMagnitude < usableDistance && tenOrbUsed && !threeOrbUsed) 
        {
            firstOrb.SetActive(Player.Instance.orbsInPossession >= 1);
            secondOrb.SetActive(Player.Instance.orbsInPossession >= 2);
            thirdOrb.SetActive(Player.Instance.orbsInPossession >= 3);
            Player.Instance.orbsInPossession = 0;
            threeOrbUsed = true;
        }
    }
}
