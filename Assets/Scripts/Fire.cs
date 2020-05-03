using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private void Start()
    {
    }
    private void OnTriggerEnter(Collider collision)
    {
        Player player = collision.GetComponent<Player>();
        Hippity hippity = collision.GetComponent<Hippity>();
        if (player != null) 
        {
            player.TakeDamage(5);
        }

        if (hippity != null)
        {
            hippity.TakeDamage(10);
        }
    }
}
