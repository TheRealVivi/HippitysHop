using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUnlock : MonoBehaviour
{
    MeshCollider meshCollider;
    MeshRenderer mesh;
    public int orbsRequired;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        meshCollider = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.Instance.orbsInPossession >= orbsRequired)
        {
            meshCollider.enabled = false;
            mesh.enabled = false;
        }
    }
}
