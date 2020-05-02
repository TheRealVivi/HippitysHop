using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour
{
    public GameObject fire1, fire2, wallFire1, wallFire2, wall;
    
    // Start is called before the first frame update
    void Start()
    {
        fire1.SetActive(false);
        fire2.SetActive(false);
        wallFire1.SetActive(false);
        wallFire2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
