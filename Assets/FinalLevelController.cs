using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLevelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.Instance.transform.position.y < -5f)
            Player.Instance.hp = 0;
    }
}
