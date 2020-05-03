using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public float seeableDistance;
    GameObject[] agents;
    // Start is called before the first frame update
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Player.Instance.transform.position), out hit, 500))
        {
            foreach (GameObject a in agents)
            {
                if ((Player.Instance.transform.position - a.transform.position).sqrMagnitude < seeableDistance)
                {
                    a.GetComponent<Enemy>().agent.SetDestination(hit.point);
                }
            }
        }
    }
}
