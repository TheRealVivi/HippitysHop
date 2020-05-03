using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : Character
{
    public NavMeshAgent agent;
    public float coolDown;
    protected float timer;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
        agent = GetComponent<NavMeshAgent>();
    }

    public void Strike(Player player) 
    {
        player.TakeDamage(damage);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (Time.time - timer > coolDown)
        {
            Player player = collision.collider.GetComponent<Player>();

            if (player != null)
            {
                Strike(player);
                timer = Time.time;
            }
        }
    }
}
